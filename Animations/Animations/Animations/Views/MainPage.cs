using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Animations.Views
{
    public class MainPage : ContentPage
    {
        BoxView redRect;
        BoxView blueRect;
        public MainPage()
        {
            AbsoluteLayout layout = new AbsoluteLayout()
            {
                BackgroundColor = Color.White
            };

            redRect = new BoxView()
            {
                BackgroundColor = Color.Red,
                WidthRequest = 100,
                HeightRequest = 100,
                AnchorX = 200,
                AnchorY = 0,
                Opacity = 0,
            };
            layout.Children.Add(redRect);
            blueRect = new BoxView()
            {
                BackgroundColor = Color.Blue,
                WidthRequest = 100,
                HeightRequest = 100,
                AnchorX = 200,
                AnchorY = 0,
                Opacity = 0
            };
            layout.Children.Add(blueRect);

            Content = layout;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            blueRect.TranslateTo(0, 470, 5000, Easing.BounceOut);
            redRect.TranslateTo(0, 470, 5000, Easing.BounceOut);
            do
            {
                await blueRect.FadeTo(1, 2000, Easing.Linear);
                redRect.FadeTo(1, 1000, Easing.Linear);
                await blueRect.FadeTo(0, 2000, Easing.Linear);
            } while (true);
        }
    }
}
