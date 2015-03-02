using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BehaviorsTriggers.Triggers
{
    public class ButtonTrigger : TriggerAction<Button>
    {
        protected override async void Invoke(Button sender)
        {
            await sender.FadeTo(0, 2000, Easing.CubicIn);
            await sender.FadeTo(1, 2000, Easing.CubicOut);
        }
    }
}
