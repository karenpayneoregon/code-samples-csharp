using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CopyFileWhenDone.Classes;

namespace CopyFileWhenDone
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private string _inputFileName = "File1.txt";
        private string _outputFileName = "File2.txt";
        private int _currentLineNumber = 0;
        public Form1()
        {
            InitializeComponent();
            FileOperations.OnIterateEvent += FileOperations_OnIterateEvent;
        }

        private void FileOperations_OnIterateEvent(int sender)
        {
            _currentLineNumber = sender;
            Text = $"Current line: {sender}";
        }

        private async void CopyFileNoDelayButton_Click(object sender, EventArgs e)
        {
            ResetTokenSource();
            CheckFileExists();

            timer1.Enabled = true;
            listBox1.Items.Clear();

            try
            {
                await FileOperations.CopyFileTask(_inputFileName, _outputFileName, 0, _cancellationTokenSource.Token);
            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show("Operation cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            listBox1.Items.Add("Done");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            timer1.Enabled = false;
            Text = "Code sample";
        }

        private void CheckFileExists()
        {
            if (File.Exists(_outputFileName))
            {
                File.Delete(_outputFileName);
            }
        }

        private void ResetTokenSource()
        {
            if (!_cancellationTokenSource.IsCancellationRequested) return;
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = new CancellationTokenSource();
        }

        private async void CopyFileWithDelayButton_Click(object sender, EventArgs e)
        {
            ResetTokenSource();
            CheckFileExists();

            timer1.Enabled = true;
            listBox1.Items.Clear();

            try
            {
                await FileOperations.CopyFileTask(_inputFileName, _outputFileName, numericTextBox1.AsInt, _cancellationTokenSource.Token);
                listBox1.Items.Add($"Done with {_currentLineNumber} processed");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                timer1.Enabled = false;
            }
            catch (OperationCanceledException oce)
            {
                timer1.Enabled = false;
                listBox1.Items.Add($"Operation cancelled with {_currentLineNumber} processed");
                
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
                timer1.Enabled = false;
            }

            Text = "Code sample";

        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(_outputFileName))
            {
                try
                {
                    var result = await FileHelper.CanReadFile(_outputFileName) ? "Yes" : "No";
                    listBox1.Items.Add($"Ready: {result}");
                }
                catch (Exception exception)
                {
                    listBox1.Items.Add(exception.Message);
                }
            }
            else
            {
                listBox1.Items.Add("Not found");
            }

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
