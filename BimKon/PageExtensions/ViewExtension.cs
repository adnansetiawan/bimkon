using System;

using Xamarin.Forms;

namespace BimKon.Core.PageExtensions
{
    public static class ViewExtension
    {
        public static void AddShadow(this View view)
        {
            //view.Effects.Add(new SquareShadowEffect());
        }
        public static void StartAnimate(this View view)
        {
            var animation = new Animation(v => view.Scale = v, 0.1, 1);
            animation.Commit(view, "SpringInAnimation", 16, 200, Easing.SpringIn, (v, c) => view.Scale = 1, () => false);
        }
    }
}

