using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using WpfApp.Views;
using UWPControl = UWPApp.Controls.UwpItemsTreeView;

namespace WpfApp.Wrapper
{
    public class UWPItemsTreeView : WindowsXamlHostBase
    {
        public event EventHandler<TreeViewSelectionChangedEventArgs>? SelectionChanged;
        public UWPItemsTreeView() : base(typeof(UWPControl).FullName)
        {
        }

        protected override void OnInitialized(EventArgs e)
        {
            Bind(nameof(DataContext), DataContextProperty, UWPControl.DataContextProperty);
            base.OnInitialized(e);
        }

        protected override void OnChildChanged()
        {
            if (ChildInternal is UWPControl c)
            {
                c.SelectionChanged += ChildInternal_SelectionChanged;
            }

            base.OnChildChanged();
        }

        private void ChildInternal_SelectionChanged(object? sender, UWPApp.Controls.TreeViewSelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, new TreeViewSelectionChangedEventArgs(e.SelectedItem));
        }
    }
}
