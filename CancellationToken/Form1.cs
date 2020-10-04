using System;
using System.Threading;
using System.Windows.Forms;
using CancellationToken.Classes;

namespace CancellationToken
{
    public partial class Form1 : Form
    {
        private int _totalIterations = 500;
        private CancellationTokenSource _cancellationTokenSource = 
            new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();

            progressBar1.Maximum = _totalIterations;
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            RunButton.Enabled = false;

            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            var ops = new Operations();
            ops.OnMonitor += OnMonitor;

            try
            {
                var resultValue = await ops.Run(_totalIterations, 
                    _cancellationTokenSource.Token);

            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show("Operation cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RunButton.Enabled = true;
            }
        }

        private void OnMonitor(MonitorArgs args)
        {
            progressBar1.Value = args.Value;
            if (args.Value == _totalIterations)
            {
                MessageBox.Show(args.Text);
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {

            _cancellationTokenSource.Cancel();
            RunButton.Enabled = true;
        }
    }
}
