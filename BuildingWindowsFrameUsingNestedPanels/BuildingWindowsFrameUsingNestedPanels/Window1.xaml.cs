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
using System.Windows.Shapes;

namespace BuildingWindowsFrameUsingNestedPanels
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void FileExit_Click(object sender, RoutedEventArgs args)
        {
            this.Close();
        }

        private void ToolsSpellingHints_Click(object sender, RoutedEventArgs args)
        {

        }

        protected void MouseEnterExitArea(object sender, RoutedEventArgs args)
        {
            statBarExit.Text = "Exit the application";
        }

        protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs args)
        {
            statBarExit.Text = "Show spelling Suggestions";
        }

        protected void MouseLeaveArea(object sender, RoutedEventArgs args)
        {
            statBarExit.Text = "Ready";
        }
    }
}
