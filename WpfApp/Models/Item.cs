using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Text;

namespace WpfApp.Models
{
    public class Item : BindableBase
    {
        public Item(string name, string emoji) => (_name, _emoji) = (name, emoji);
        public string Id { get; } = Guid.NewGuid().ToString();

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _emoji;
        public string Emoji
        {
            get { return _emoji; }
            set { SetProperty(ref _emoji, value); }
        }
    }
}
