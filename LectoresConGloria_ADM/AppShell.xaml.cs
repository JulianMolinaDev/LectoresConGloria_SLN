using LectoresConGloria_ADM.MVVM.Navigation;
using LectoresConGloria_ADM.MVVM.Settings;

namespace LectoresConGloria_ADM
{
    public partial class AppShell : Shell
    {
        INavigationService _navigationService;
        public AppShell(INavigationService navigationService)
        {
            InitializeComponent();

            _navigationService = navigationService;
        }

        protected override async void OnParentSet()
        {
            base.OnParentSet();
            if (Parent is not null)
            {
                await _navigationService.InitializeAsync();
            }
        }

    }
}