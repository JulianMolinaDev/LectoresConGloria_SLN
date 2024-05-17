using LectoresConGloria_ADM.MVVM.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_ADM.MVVM.Navigation
{
    internal class NavigationService : INavigationService
    {
        public Task InitializeAsync()
        {
            return NavigateToAsync(string.IsNullOrEmpty(SettingsService.AuthAccessToken)
            ? "//Login"
            : "//MainPage");
        }

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
