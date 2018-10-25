using System;
using BimKon.Core.PageExtensions;
using Xamarin.Forms;

namespace BimKon.Core
{
    public class PMainPage : BottomBarPage
    {
        private PNavigationPage _navMANOverviewPage;
        private PNavigationPage _navSMAOverviewPage;
        private PNavigationPage _navSMKOverviewPage;
        public PMainPage()
        {
            _navSMKOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.SMK));
            _navSMKOverviewPage.Title = "SMK";

            Children.Add(_navSMKOverviewPage);

            _navSMAOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.SMA));
            _navSMAOverviewPage.Title = "SMA";
            Children.Add(_navSMAOverviewPage);

            _navMANOverviewPage = new PNavigationPage(new SekolahOverviewPage(Enums.SchoolType.MAN));
            _navMANOverviewPage.Title = "MAN";
            Children.Add(_navMANOverviewPage);
        }
    }
}

