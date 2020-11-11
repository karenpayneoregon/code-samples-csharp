using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfCommandBinding
{
    public partial class MainWindow : Window
    {
        public static RoutedCommand ColorCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ExecutedRoutedEventHandler for toggling fore and background colors
        /// along 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (!(e.Source is Button target)) return;

            if (target.Background == Brushes.Brown)
            {
                target.Background = Brushes.Red;
                target.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                target.Background = Brushes.Brown;
                target.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        /// <summary>
        /// CanExecuteRoutedEventHandler for the custom color command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e != null)
            {
                e.CanExecute = true;
            }
        }
    }
}
