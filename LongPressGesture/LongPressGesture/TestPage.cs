using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LongPressGesture
{
    public class TestPage : ContentPage
    {
        public TestPage()
        {
            Label l = new Label
            {
                Text = "Gesture test/n/n/nTest here",
            };

            GesturesContentView g = new GesturesContentView
            {
                Content = l,
            };
            GestureInterest gi1 = new GestureInterest
            {
                GestureType = GestureType.LongPress
            };
            GestureInterest gi2 = new GestureInterest
            {
                GestureType = GestureType.DoubleTap
            };
            List<GestureInterest> gilist = new List<GestureInterest>();
            gilist.Add(gi1);
            gilist.Add(gi2);
            IEnumerable<GestureInterest> gintrest = gilist;
            g.RegisterInterests(l, gintrest);
            g.GestureRecognized += G_GestureRecognized1;
            Content = g;
        }

        private void G_GestureRecognized1(object sender, GestureResult e)
        {
            if (e.GestureType == GestureType.DoubleTap)
            {
                DisplayAlert("Gesture", "DoubleTap", "OK");
            }
            else if (e.GestureType == GestureType.Down)
            {
                DisplayAlert("Gesture", "Down", "OK");
            }
            else if (e.GestureType == GestureType.LongPress)
            {
                DisplayAlert("Gesture", "LongPress", "OK");
            }
            else if (e.GestureType == GestureType.Move)
            {
                DisplayAlert("Gesture", "Move", "OK");
            }
            else if (e.GestureType == GestureType.Pinch)
            {
                DisplayAlert("Gesture", "Pinch", "OK");
            }
            else if (e.GestureType == GestureType.SingleTap)
            {
                DisplayAlert("Gesture", "SingleTap", "OK");
            }
            else if (e.GestureType == GestureType.Swipe)
            {
                DisplayAlert("Gesture", "Swipe", "OK");
            }
            else if (e.GestureType == GestureType.Unknown)
            {
                DisplayAlert("Gesture", "Unknown", "OK");
            }
            else if (e.GestureType == GestureType.Up)
            {
                DisplayAlert("Gesture", "Up", "OK");
            }
        }
    }
}
