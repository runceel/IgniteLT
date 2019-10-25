using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWPApp.Controls
{
    public sealed partial class UwpItemsTreeView : UserControl
    {
        public event EventHandler<TreeViewSelectionChangedEventArgs>? SelectionChanged;
        public UwpItemsTreeView()
        {
            InitializeComponent();
        }

        private void treeView_ItemInvoked(Microsoft.UI.Xaml.Controls.TreeView sender, Microsoft.UI.Xaml.Controls.TreeViewItemInvokedEventArgs args)
        {
            SelectionChanged?.Invoke(this, new TreeViewSelectionChangedEventArgs(args.InvokedItem));
        }
    }

    public class TreeViewSelectionChangedEventArgs : EventArgs
    {
        public TreeViewSelectionChangedEventArgs(object selectedItem)
        {
            SelectedItem = selectedItem;
        }

        public object SelectedItem { get; }
    }
}
