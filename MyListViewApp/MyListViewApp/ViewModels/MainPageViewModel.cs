using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListViewApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public List<Models.Beverage> BeverageList { get; set; }
        public ObservableCollection<Models.BeverageCollection> beverageListViewItemCollection { get; set; }
        private List<Models.BeverageListViewItem> beverageListViewItemList = new List<Models.BeverageListViewItem>();
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel(List<Models.Beverage> beverageList)
        {
            BeverageList = beverageList;
            convertBeverageListToBeverageListViewItem();
            setupBeverageListViewItemCollection();
        }

        public void convertBeverageListToBeverageListViewItem()
        {
            Models.BeverageListViewItem beverageListViewItem;
            foreach (Models.Beverage beverage in BeverageList)
            {
                beverageListViewItem = new Models.BeverageListViewItem(beverage);
                beverageListViewItemList.Add(beverageListViewItem);
            }
        }

        public void setupBeverageListViewItemCollection()
        {
            beverageListViewItemCollection = new ObservableCollection<Models.BeverageCollection>();

            foreach (Models.BeverageListViewItem b in beverageListViewItemList)
            {
                var listItemGroup = beverageListViewItemCollection.FirstOrDefault(t => t.StoreName == b.Beverage.Store.Name);
                if (listItemGroup == null)
                {
                    listItemGroup = new Models.BeverageCollection(b.Beverage.Store.Name);
                    listItemGroup.Add(b);
                    beverageListViewItemCollection.Add(listItemGroup);
                }
                else
                {
                    listItemGroup.Add(b);
                }
            }
        }
    }
}
