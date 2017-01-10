using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListViewApp.Models
{
    public class BeverageCollection : ObservableCollection<BeverageListViewItem>
    {
        public string StoreName { get; set; }

        public BeverageCollection(string storeName)
        {
            StoreName = storeName;
        }
    }
}
