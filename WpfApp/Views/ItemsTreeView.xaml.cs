using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Models;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for FoodTreeView.xaml
    /// </summary>
    public partial class ItemsTreeView : UserControl
    {
        public event EventHandler<TreeViewSelectionChangedEventArgs>? SelectionChanged;
        public ItemsTreeView()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            SelectionChanged?.Invoke(this, new TreeViewSelectionChangedEventArgs(e.NewValue));
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
