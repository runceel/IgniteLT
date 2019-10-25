using Prism.Mvvm;
using System.Collections.ObjectModel;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ItemManager ItemManager { get; } = new ItemManager();

        public ObservableCollection<Category> Categories => ItemManager.Categories;

        private Item? _selectedItem;
        public Item? SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }
    }
}
