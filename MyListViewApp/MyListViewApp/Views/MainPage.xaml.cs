using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyListViewApp.Views
{
    public partial class MainPage : ContentPage
    {
        private Models.BeverageListViewItem beverageListViewItemSelected;

        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModels.MainPageViewModel mainPageViewModel = new ViewModels.MainPageViewModel(App.generateData());
            BindingContext = mainPageViewModel;
            beverageList.ItemsSource = mainPageViewModel.beverageListViewItemCollection;

            //Select the first row
            changeSelectedItem(mainPageViewModel.beverageListViewItemCollection[0][0]);
        }

        private void beverageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
            var item = e.Item as Models.BeverageListViewItem;
            changeSelectedItem(item);
        }

        private void changeSelectedItem(Models.BeverageListViewItem newBeverageListViewItem)
        {
            if (beverageListViewItemSelected != null)
            {
                beverageListViewItemSelected.Tapped = !beverageListViewItemSelected.Tapped;
                beverageListViewItemSelected.UpdateView();
            }
            beverageListViewItemSelected = newBeverageListViewItem;
            beverageListViewItemSelected.Tapped = true;
            beverageListViewItemSelected.UpdateView();
        }
    }
}
