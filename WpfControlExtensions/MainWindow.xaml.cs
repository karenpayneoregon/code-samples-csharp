using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using ExceptionHandling;
using WpfControlExtensions.Classes;

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
