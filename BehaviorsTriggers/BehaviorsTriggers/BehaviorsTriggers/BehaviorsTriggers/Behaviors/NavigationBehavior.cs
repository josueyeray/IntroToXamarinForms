using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;

namespace BehaviorsTriggers.Behaviors
{
    public class NavigationBehavior : Behavior<Button>
    {
        private INavigation navService;

        public string TargetPage { get; set; }

        protected override void OnAttachedTo(Button bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Clicked += bindable_Clicked;
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.Clicked -= bindable_Clicked;
        }

        private async void bindable_Clicked(object sender, EventArgs e)
        {
            this.navService = App.Current.MainPage.Navigation;
            var targetPageType = Type.GetType(TargetPage);
            var targetPageInstance = (Page)Activator.CreateInstance(targetPageType);
            await this.navService.PushAsync(targetPageInstance);
        }
    }
}
