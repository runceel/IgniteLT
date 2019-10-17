using System.Windows;
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
    }
}
