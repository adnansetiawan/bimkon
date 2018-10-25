using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BimKon.Core.Models
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }
        public BaseViewModel(INavigation navigation = null)
        {
            Navigation = navigation;
        }
        public bool IsInitialized { get; set; }
        public async Task PushModalAsync(Page page)
        {
            if (Navigation != null)
                await Navigation.PushModalAsync(page);
        }
        public async Task PopModalAsync()
        {
            if (Navigation != null)
                await Navigation.PopModalAsync();
        }
        public async Task PushAsync(Page page)
        {
            if (Navigation != null)
                await Navigation.PushAsync(page);
        }
        public async Task PopAsync()
        {
            if (Navigation != null)
                await Navigation.PopAsync();
        }
        string title = string.Empty;
        public const string TitlePropertyName = "Title";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value, TitlePropertyName); }
        }
        string subTitle = string.Empty;
        /// <summary>
        /// Gets or sets the "Subtitle" property
        /// </summary>
        public const string SubtitlePropertyName = "Subtitle";
        public string Subtitle
        {
            get { return subTitle; }
            set { SetProperty(ref subTitle, value, SubtitlePropertyName); }
        }
        string icon = null;
        /// <summary>
        /// Gets or sets the "Icon" of the viewmodel
        /// </summary>
        public const string IconPropertyName = "Icon";
        public string Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value, IconPropertyName); }
        }
        protected void SetProperty<U>(
            ref U backingStore, U value,
            string propertyName,
            Action onChanged = null,
            Action<U> onChanging = null)
        {
            if (EqualityComparer<U>.Default.Equals(backingStore, value))
                return;
            if (onChanging != null)
                onChanging(value);
            OnPropertyChanging(propertyName);
            backingStore = value;
            if (onChanged != null)
                onChanged();
            OnPropertyChanged(propertyName);
        }
        #region INotifyPropertyChanging implementation

        public event Xamarin.Forms.PropertyChangingEventHandler PropertyChanging;

        #endregion
        public void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging == null)
                return;
            PropertyChanging(this, new Xamarin.Forms.PropertyChangingEventArgs(propertyName));
        }
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private ICommand _onPageBackCommand;
        public ICommand OnPageBackCommand
        {
            get
            {
                _onPageBackCommand = _onPageBackCommand ?? new Command(async () =>
                {
                    await PopAsync();
                });

                return _onPageBackCommand;
            }
        }
    }
}
