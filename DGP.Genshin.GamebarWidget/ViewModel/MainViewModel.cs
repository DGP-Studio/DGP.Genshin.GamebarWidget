using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DGP.Genshin.GamebarWidget.Helper;
using DGP.Genshin.GamebarWidget.Model;
using DGP.Genshin.GamebarWidget.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace DGP.Genshin.GamebarWidget.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private ObservableCollection<Cookie> cookies;
        private Cookie selectedCookie;

        public ObservableCollection<Cookie> Cookies { get => cookies; set => SetProperty(ref cookies, value); }
        public Cookie SelectedCookie { get => selectedCookie; set => SetProperty(ref selectedCookie, value); }
        public ICommand AddCookieCommand { get; }
        public ICommand RemoveCookieCommand { get; }

        public MainViewModel()
        {
            Cookies = new ObservableCollection<Cookie>(Setting.Cookies);
            SelectedCookie = Cookies.FirstOrDefault();

            AddCookieCommand = new AsyncRelayCommand(AddCookieAsync);
            RemoveCookieCommand = new AsyncRelayCommand(RemoveCookieAsync);
        }

        private async Task AddCookieAsync()
        {
            (ContentDialogResult dialog, string cookie) = await new CookieDialog().GetInputCookieAsync();

            if (dialog == ContentDialogResult.Primary)
            {
                Cookies.Add(new Cookie(cookie));
                Setting.Cookies = Cookies.ToList();
            }
        }

        private async Task RemoveCookieAsync()
        {
            if(SelectedCookie != null)
            {
                ContentDialogResult result = await new ContentDialog()
                {
                    Title = "确认删除该Cookie?",
                    PrimaryButtonText = "是",
                    CloseButtonText = "否",
                    DefaultButton = ContentDialogButton.Close
                }.ShowAsync();

                if (result == ContentDialogResult.Primary)
                {
                    Cookies.Remove(SelectedCookie);
                    SelectedCookie = Cookies.FirstOrDefault();
                    Setting.Cookies = Cookies.ToList();
                }
            }
        }
    }
}
