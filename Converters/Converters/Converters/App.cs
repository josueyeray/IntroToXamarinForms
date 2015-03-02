namespace Converters
{
    using Converters.View;
    using Converters.ViewModels.Base;
    using Xamarin.Forms;

    public class App : Application
    {
        public App()
        {
            // The root page of your application
            Current.Resources = new ResourceDictionary();
            var locator = new ViewModelLocator();
            Current.Resources.Add("Locator", locator);

            MainPage = new MainView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
