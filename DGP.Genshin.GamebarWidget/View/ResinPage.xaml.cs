using DGP.Genshin.GamebarWidget.ViewModel;
using Windows.UI.Xaml.Controls;

namespace DGP.Genshin.GamebarWidget.View
{
    public sealed partial class ResinPage : Page
    {
        public ResinPage()
        {
            DataContext = new ResinViewModel() { View = this };
            this.InitializeComponent();
        }
    }
}
