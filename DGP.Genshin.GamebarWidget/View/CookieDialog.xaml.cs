using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DGP.Genshin.GamebarWidget.View
{
    public sealed partial class CookieDialog : ContentDialog
    {
        public CookieDialog()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 获取输入的Cookie
        /// </summary>
        public async Task<(ContentDialogResult result, string cookie)> GetInputCookieAsync()
        {
            ContentDialogResult result = await ShowAsync();
            return (result, InputText.Text);
        }
    }
}
