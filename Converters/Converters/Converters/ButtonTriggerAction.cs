using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Converters
{
    public class ButtonTriggerAction : TriggerAction<Button>
    {
        protected override async void Invoke(Button sender)
        {
            await sender.FadeTo(0, 1500, Easing.CubicIn);
            await sender.FadeTo(1, 1500, Easing.CubicOut);
        }
    }
}
