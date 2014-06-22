﻿using System;
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

namespace RenderingGraphicaalDataUsingShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private enum SelectedShape
        { Circle, Rectangle, Line }

        private SelectedShape currentShape;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void circleOption_Click(object sender, RoutedEventArgs e)
        {
            currentShape = SelectedShape.Circle;
        }

        private void canvasDrawingArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shapeToRender = null;

            switch (currentShape)
            { 
                case SelectedShape.Circle:
                    shapeToRender = new Ellipse() { Fill = Brushes.Green, Height = 35, Width = 35 };
                    break;
                case SelectedShape.Rectangle:
                    shapeToRender = new Rectangle() { Fill = Brushes.Red, Height = 35, Width = 35 ,RadiusX = 10, RadiusY = 10};
                    break;
                case SelectedShape.Line:
                    shapeToRender = new Line()
                    {
                        Stroke = Brushes.Blue,
                        StrokeThickness = 10,
                        X1 = 0,
                        X2 = 50,
                        Y1 = 0,
                        Y2 = 50,
                        StrokeStartLineCap = PenLineCap.Triangle,
                        StrokeEndLineCap = PenLineCap.Round
                    };
                    break;
                default:
                    return;
            }

            Canvas.SetLeft(shapeToRender, e.GetPosition(canvasDrawingArea).X);
            Canvas.SetTop(shapeToRender, e.GetPosition(canvasDrawingArea).Y);

            canvasDrawingArea.Children.Add(shapeToRender);
        }

        private void canvasDrawingArea_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        { 
            Point pt = e.GetPosition((Canvas)sender);

            HitTestResult result = VisualTreeHelper.HitTest(canvasDrawingArea, pt);

            if (result != null)
            {
                canvasDrawingArea.Children.Remove(result.VisualHit as Shape);
            }
        }
    }
}
