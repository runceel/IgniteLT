using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApp.Models
{
    public class Category : BindableBase
    {
        public Category(string name) => _name = name;

        public string Id { get; } = Guid.NewGuid().ToString();

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        public Item? FindFoodById(string id) => Items.FirstOrDefault(x => x.Id == id);
    }
}
