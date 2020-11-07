using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ExceptionHandling;
using WpfControlExtensions.Classes;
using static WpfControlExtensions.Classes.CommonDialogs;

namespace WpfControlExtensions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand ClearLabelsRoutedCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(
                ClearLabelsRoutedCommand, 
                ClearLabelsCommandOnExecute, 
                ClearLabelsCanExecute));
        }

        private void ClearLabelsCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ClearLabelsCommandOnExecute(object sender, ExecutedRoutedEventArgs e)
        {

            var thread = new Thread(delegate()
            {
                Thread.Sleep(100);

                try
                {
                    Dispatcher.BeginInvoke(DispatcherPriority.Send, new Action(this.ResetLabels<Label>));
                }
                catch (Exception exception)
                {
                    Exceptions.Write(exception);
                }
            }) {Name = "thread-clearing-demo"};

            thread.Start();


        }
    }
}
