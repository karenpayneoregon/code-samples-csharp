using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CancellationToken
{
    public partial class ControlDemo : UserControl
    {
        public System.Threading.CancellationToken _cancellationToken;
        Bitmap shadowBmp = null;



        public ControlDemo()
        {
            InitializeComponent();

            
        }


        public async void DoSomething()
        {
            try
            {
                for (int index = 0; index < 5000; index++)
                {
                    Console.WriteLine(index);
                    await Task.Delay(1000, _cancellationToken);

                    if (_cancellationToken.IsCancellationRequested)
                        _cancellationToken.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException oce)
            {
                Console.WriteLine("User cancelled");
            }
            catch (Exception ex)
            {
                // TODO
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            //DoSomething();
        }



    }
}
