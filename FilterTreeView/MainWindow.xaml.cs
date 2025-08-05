using System.Windows;
using System.Windows.Controls;
using FilterTreeView.Extensions;

namespace FilterTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void MainWindow_Loaded(object sender, RoutedEventArgs e) => treeView.ItemsSource = Data.FetchTestData().Convert();
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            treeView.Items.Do<TreeViewItem>(item => item.Collapse());
            treeView.Items.Where<TreeViewItem>(search).Do(item => item.Expand());
        }
        private bool search(TreeViewItem item) =>
            item.GetHeaderOrEmpty().StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase);
    }
}