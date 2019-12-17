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

namespace D20
{
 
    public class JadeSplashActivity : AppCompatActivity
        {
            protected void onCreate(Bundle savedInstanceState)
                {
                base.onCreate(savedInstanceState);
                setContentView(R.layout.activity_jade_splash);
                (new Handler() + postDelayed(new Runnable(), 3000));
                }
        }
}