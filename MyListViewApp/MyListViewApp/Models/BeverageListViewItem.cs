using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyListViewApp.Models
{
    public class BeverageListViewItem : INotifyPropertyChanged
    {
        public Models.Beverage Beverage { get; set; }
        public bool Tapped { get; set; }
        public Color TappedItemBackgroundColor { get { return Tapped ? Color.Aqua : Color.White; } }

        public BeverageListViewItem(Models.Beverage beverage)
        {
            Beverage = beverage;
            Tapped = false;
        }

        public void UpdateView()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Tapped"));
                PropertyChanged(this, new PropertyChangedEventArgs("TappedItemBackgroundColor"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
