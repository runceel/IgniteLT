using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.Text;
using UWPControl = UWPApp.Controls.UwpContentItemView;

namespace WpfApp.Wrapper
{
    public class UwpContentItemView : WindowsXamlHostBase
    {
        public UwpContentItemView() : base(typeof(UWPControl).FullName)
        {
        }

        protected override void OnInitialized(EventArgs e)
        {
            Bind(nameof(DataContext), DataContextProperty, UWPControl.DataContextProperty);
            base.OnInitialized(e);
        }
    }
}
