using System;

using Xamarin.Forms;

namespace BimKon.Core.PageExtensions
{
    public class BottomBarPage : TabbedPage
    {
        public enum BarThemeTypes { Light, DarkWithAlpha, DarkWithoutAlpha }
        public bool FixedMode { get; set; }
        public BarThemeTypes BarTheme { get; set; }
        public void RaiseCurrentPageChanged()
        {

            OnCurrentPageChanged();
        }

        protected override void OnCurrentPageChanged()
        {

            base.OnCurrentPageChanged();
        }
    }
}

