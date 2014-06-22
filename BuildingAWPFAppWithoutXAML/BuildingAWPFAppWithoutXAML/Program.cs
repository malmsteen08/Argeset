using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace BuildingAWPFAppWithoutXAML
{
    class Program : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            Program app = new Program();
            app.Startup += new StartupEventHandler(AppStartUp);
            app.Exit += new ExitEventHandler(AppExit);
            app.Run();
        }

        static void AppExit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("App has exited");
        }

        static void AppStartUp(object sender, StartupEventArgs e)
        { 
            //Create a window object and set some basic properties
            //Window mainWindow = new Window();
            //mainWindow.Title = "My First WPF App!";
            //mainWindow.Height = 200;
            //mainWindow.Width = 300;
            //mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //mainWindow.Show();

            Application.Current.Properties["GodMode"] = false;
            foreach (string arg in e.Args)
            {
                if (arg.ToLower() == "/godmode")
                {
                    Application.Current.Properties["GodMode"] = true;
                    break;
                }
            }

            MainWindow wnd = new MainWindow("My Better WPF App!", 200, 300);
        }
    }

    class MainWindow : Window
    {
        //our UI element
        private Button btnExitApp = new Button();
        
        public MainWindow(string windowTitle, int height, int width)
        {

            //configure Button and set the child control
            btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
            btnExitApp.Content = "Exit Application";
            btnExitApp.Height = 25;
            btnExitApp.Width = 100;

            //Set the content of this windowto a single button
            this.Content = btnExitApp;

            //configure the window
            this.Title = windowTitle;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Height = height;
            this.Width = width;

            this.Closing += MainWindow_Closing;
            this.Closed += MainWindow_Closed;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("See You");
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //see if the user really wants to quit
            string msg = "Do you want to qüit?";
                MessageBoxResult result = MessageBox.Show(msg, "MyApp", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if(result == MessageBoxResult.No)
            {
                //if user doesnt want continue
                e.Cancel = true;
            }
        }

        private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            if ((bool)Application.Current.Properties["GodMode"])
                MessageBox.Show("Cheater");

            this.Close();
        }
    }
}
