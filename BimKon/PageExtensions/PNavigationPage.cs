using System;

using Xamarin.Forms;

namespace BimKon.Core.PageExtensions
{
    public class PNavigationPage : NavigationPage
    {
        public PNavigationPage(Page root) : base(root)
        {
            Init();
        }

        public PNavigationPage()
        {
            Init();
        }

        void Init()
        {
            //NavigationPage.SetBackButtonTitle(this.CurrentPage, string.Empty);

        }
    }
}

