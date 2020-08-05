using FileChecker;
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static FileHandler _fileHandler = new FileHandler();

        private static ContentChecker _contentChecker = new ContentChecker(_fileHandler);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rctDrop1_Drop(object sender, DragEventArgs e)
        {
            var path = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!string.IsNullOrEmpty(path[0]))
            {
                _fileHandler.Path1 = path[0];
            }
            checkForMerge();
            var rect = sender as Rectangle;
            rect.Fill = GetHexColor("#273c75");
        }

        private void rctDrop2_Drop(object sender, DragEventArgs e)
        {
            var path = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!string.IsNullOrEmpty(path[0]))
            {
                _fileHandler.Path2 = path[0];
            }
            checkForMerge();
            var rect = sender as Rectangle;
            rect.Fill = GetHexColor("#273c75");
        }

        private void btnDiferences_Click(object sender, RoutedEventArgs e)
        {
            _contentChecker.WriteDiferences();
            clearData();
            checkForMerge();
        }

        private void btnAlikes_Click(object sender, RoutedEventArgs e)
        {
            _contentChecker.WriteAlikes();
            clearData();
            checkForMerge();
        }

        private void clearData()
        {
            _fileHandler.Path1 = "";
            _fileHandler.Path2 = "";
            rctDrop1.Fill = GetHexColor("#f5f6fa");
            rctDrop2.Fill = GetHexColor("#f5f6fa");
        }

        private Brush GetHexColor(string colorCode)
        {
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorCode));
        }

        private void checkForMerge()
        {
            var checkVis = !string.IsNullOrEmpty(_fileHandler.Path1) && !string.IsNullOrEmpty(_fileHandler.Path2);
            btnDiferences.IsEnabled = checkVis;
            btnAlikes.IsEnabled = checkVis;
        }
    }
}
