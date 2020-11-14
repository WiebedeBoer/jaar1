using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Samplesocket
{
    [Activity(Label = "Coffeetime")]
    public class Coffeetime : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        public abstract class Coffee
        {
            protected int caffeineAmount;
            protected string drinkName;
            protected int temperature;
            public abstract void CoolDown();
            public abstract bool IsDrinkable();

        }

        class Cappuchino : Coffee
        {
            public Cappuchino(int caffeine, string name, int temperature)
            {
                this.caffeineAmount = caffeine;

            }

            override public void CoolDown()
            {
                this.temperature -= 5;
            }
            override public bool IsDrinkable()
            {
                if (this.temperature > 30)
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}