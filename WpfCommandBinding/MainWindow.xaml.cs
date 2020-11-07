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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        /// ExecutedRoutedEventHandler for the custom color command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is Button target)
            {
                target.Background = target.Background == Brushes.AliceBlue ? Brushes.Black : Brushes.AliceBlue;
                target.Foreground = target.Foreground == Brushes.Black ? Brushes.White : Brushes.Black;
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
