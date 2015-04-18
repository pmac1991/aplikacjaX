using Facebook;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.Security.Authentication.Web;
using Windows.UI.Xaml.Controls;
using ZUMOAPPNAME;

namespace aplikacjax
{
    public sealed partial class MainPage : Page, IWebAuthenticationContinuable
    {

        //private async Task fbLogin()
        //{
        //    //Facebook app id
        //    var clientId = "1531845183735056";
        //    //Facebook permissions
        //    var scope = "public_profile, email";

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

        //    //Avvio l'operazione di autenticazione
        //    WebAuthenticationBroker.AuthenticateAndContinue(startUri, endUri, null, WebAuthenticationOptions.None);
        //}
        
    }

}
