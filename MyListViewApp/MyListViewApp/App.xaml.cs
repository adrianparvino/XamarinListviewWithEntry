using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyListViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new Views.MainPage());
            MainPage = nav;
        }

        public static List<Models.Beverage> generateData()
        {
            List<Models.Beverage> beverageList = new List<Models.Beverage>();

            Models.Store store = new Models.Store("JOE'S Bar");
            beverageList.Add(new Models.Beverage("Budweiser bottle", 20, store));
            beverageList.Add(new Models.Beverage("Heineken bottle", 50, store));
            beverageList.Add(new Models.Beverage("Guiness can", 0, store));

            store = new Models.Store("Good Cafe");
            beverageList.Add(new Models.Beverage("Milk box", 0, store));
            beverageList.Add(new Models.Beverage("Coffee", 150, store));

            store = new Models.Store("Rock Grocery");
            beverageList.Add(new Models.Beverage("Sprite can", 0, store));
            beverageList.Add(new Models.Beverage("Nestea bottle", 25, store));
            beverageList.Add(new Models.Beverage("Coke bottle", 80, store));

            return beverageList;
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
