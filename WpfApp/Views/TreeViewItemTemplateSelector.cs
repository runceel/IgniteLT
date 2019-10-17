using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WpfApp.Models;

namespace WpfApp.Views
{
    public class TreeViewItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ItemTemplate { get; set; } = default!;
        public DataTemplate CategoryTemplate { get; set; } = default!;
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
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
