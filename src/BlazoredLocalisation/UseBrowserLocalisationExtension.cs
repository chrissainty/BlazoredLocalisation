using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.JSInterop;
using System.Globalization;
using System.Threading.Tasks;

namespace Blazored.Localisation
{
    public static class UseBrowserLocalisationExtension
    {
        public static void UseBrowserLocalisation(this IBlazorApplicationBuilder app)
        {
            var browserLocale = ((IJSInProcessRuntime)JSRuntime.Current).Invoke<string>("blazoredLocalisation.getBrowserLocale");
            var culture = new CultureInfo(browserLocale);

            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }
    }
}
