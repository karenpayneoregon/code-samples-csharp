using System;
using System.Threading;
using System.Windows.Forms;
using MockupAsyncDataOperations.Classes;

namespace MockupAsyncDataOperations
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }
        /// <summary>
        /// Subscribe to the event which is raised if an exception happens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            DataOperations.OnErrorHandler += DataOperations_OnErrorHandler;
        }
        /// <summary>
        /// Raised from the catch in ProcessData
        /// </summary>
        /// <param name="sender"></param>
        private void DataOperations_OnErrorHandler(Exception sender)
        {
            MessageBox.Show($"Failed with\n{sender.Message}");
        }
        /// <summary>
        /// Run the process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RunProcessButton_Click(object sender, EventArgs e)
        {
            RunProcessButton.Enabled = false;

            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }
            
            try
            {
                await DataOperations.ProcessData(_cancellationTokenSource.Token);

            }
            catch (OperationCanceledException oce)
            {
                // land here if there was a cancellation request
                MessageBox.Show(@"Operation cancelled");
            }
            finally
            {
                RunProcessButton.Enabled = true;
            }
        }
        /// <summary>
        /// Cancel the process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelProcessButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            RunProcessButton.Enabled = true;
        }
    }
}
