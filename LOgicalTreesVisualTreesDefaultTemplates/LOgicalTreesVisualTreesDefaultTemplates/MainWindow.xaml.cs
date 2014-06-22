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

namespace LOgicalTreesVisualTreesDefaultTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string dataToShow;
        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        private void btnShowLogicalTree_Click(object sender, RoutedEventArgs e)
        {
            dataToShow = "";
            BuildLogicalTree(0, this);
            this.txtDisplayArea.Text = dataToShow;
        }

        void BuildLogicalTree(int depth, object obj)
        {
            dataToShow += new string(' ', depth) + obj.GetType().Name + "\n";

            if (!(obj is DependencyObject))
                return;

            foreach (object child in LogicalTreeHelper.GetChildren(
                obj as DependencyObject))
                BuildLogicalTree(depth + 5, child);
        }

        private void btnShowVisualTree_Click(object sender, RoutedEventArgs e)
        {
            dataToShow = "";
            BuildVisualTree(0, this);
            this.txtDisplayArea.Text = dataToShow;
        }

        void BuildVisualTree(int depth, object obj)
        {
            dataToShow += new string(' ', depth) + obj.GetType().Name + "\n";

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                BuildVisualTree(depth + 1, VisualTreeHelper.GetChild(obj, i));
        }
    }
}
