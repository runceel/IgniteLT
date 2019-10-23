using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Windows;
using System.Windows.Controls;
using UWPApp.Controls;
using WpfApp.Models;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ItemsTreeView_SelectionChanged(object sender, TreeViewSelectionChangedEventArgs e)
        {
            ((MainWindowViewModel)DataContext).SelectedItem = e.SelectedItem as Item;
        }

        private void UwpItemTreeViewHost_ChildChanged(object sender, System.EventArgs e)
        {
            var host = (WindowsXamlHost)sender;
            if (host.Child is UwpItemsTreeView treeView)
            {
                treeView.DataContext = DataContext;
                treeView.SelectionChanged += (_, args) =>
                {
                    ((MainWindowViewModel)DataContext).SelectedItem = args.SelectedItem as Item;
                };
            }
        }

        private void UwpContentItemView_ChildChanged(object sender, System.EventArgs e)
        {
            var host = (WindowsXamlHost)sender;
            if (host.Child is UwpContentItemView itemView)
            {
                itemView.DataContext = DataContext;
            }
        }
    }
}
