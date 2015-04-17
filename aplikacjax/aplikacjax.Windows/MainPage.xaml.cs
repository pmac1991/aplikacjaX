using Windows.UI.Xaml.Controls;
using Facebook.Client.Controls;
namespace aplikacjax
{
    public sealed partial class MainPage : Page
    {
        private void OnSessionStateChanged(object sender, Facebook.Client.Controls.SessionStateChangedEventArgs e)
        {
            this.ContentPanel.Visibility = (e.SessionState == Facebook.Client.Controls.FacebookSessionState.Opened) ? Windows.UI.Xaml.Visibility.Visible : Windows.UI.Xaml.Visibility.Collapsed;           
        }
    }
}
