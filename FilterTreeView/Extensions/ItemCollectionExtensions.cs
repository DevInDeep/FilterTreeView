using System.Windows.Controls;

namespace FilterTreeView.Extensions
{
    internal static class ItemCollectionExtensions
    {
        internal static void Do<T>(this ItemCollection collection, Action<T> onItem) where T : class
        {
            foreach (var item in collection)
            {
                if (item is T castItem)
                    onItem(castItem);
            }
        }

        internal static IEnumerable<T> Where<T>(this ItemCollection collection, Func<T, bool> predicate) where T : class
        {
            foreach (var item in collection)
            {
                if (item is T)
                {
                    if (item is T castItem && predicate(castItem))
                        yield return castItem;
                }
            }
        }

        internal static void FilterBy(this ItemCollection collection, Func<TreeViewItem, bool> filter)
        {
            collection.Do<TreeViewItem>(item => item.Collapse());
            collection.Where<TreeViewItem>(filter).Do(item => item.Expand());
        }
    }
}
