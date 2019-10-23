using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WpfApp.Models;

namespace UWPApp.Controls
{
    public class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ItemTemplate { get; set; } = default!;
        public DataTemplate CategoryTemplate { get; set; } = default!;

        protected override DataTemplate SelectTemplateCore(object item)
        {
            return item switch
            {
                Category _ => CategoryTemplate,
                Item _ => ItemTemplate,
                _ => throw new InvalidOperationException(),
            };
        }
    }
}
