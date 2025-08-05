using System.Windows.Controls;

namespace FilterTreeView.Extensions
{
    internal static class TreeViewItemExtensions
    {
        internal static void Collapse(this TreeViewItem treeViewItem) => treeViewItem.Height = 0;
        internal static void Expand(this TreeViewItem treeViewItem)
        {
            treeViewItem.Height = Double.NaN;
            treeViewItem.IsExpanded = true;
        }
    }
}
