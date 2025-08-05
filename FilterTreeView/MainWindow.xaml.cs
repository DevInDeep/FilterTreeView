using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;

namespace FilterTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void MainWindow_Loaded(object sender, RoutedEventArgs e) => treeView.ItemsSource = Data.FetchTestData();
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e) => Debug.WriteLine(txtSearch.Text);
    }
}