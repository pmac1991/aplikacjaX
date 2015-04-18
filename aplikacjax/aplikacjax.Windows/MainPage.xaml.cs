using Facebook;
using System;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web;
using Windows.UI.Xaml.Controls;

namespace aplikacjax
{
    public sealed partial class MainPage : Page
    {
        //private async Task fbLogin()
        //{
        //    //Facebook app id
        //    var clientId = "452835904891461";
        //    //Facebook permissions
        //    var scope = "email";

        //    var redirectUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();
        //    var fb = new FacebookClient();
        //    var loginUrl = fb.GetLoginUrl(new
        //    {
        //        client_id = clientId,
        //        redirect_uri = redirectUri,
        //        response_type = "token",
        //        scope = scope
        //    });

        //    Uri startUri = loginUrl;
        //    Uri endUri = new Uri(redirectUri, UriKind.Absolute);

        //    WebAuthenticationResult result = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, startUri, endUri);
        //    //await ParseAuthenticationResult(result);
        //}

        private async void fb_Login_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            await Login();
        }
    }
}
