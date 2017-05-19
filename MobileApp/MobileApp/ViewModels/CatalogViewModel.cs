using MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileApp.View
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        private List<Product> products;
        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Products"));
            }
        }

        public CatalogViewModel()
        {
            Title = "Catalog";
            GetData();
        }

        
        public async void GetData()
        {
            var productTable = App.MobileService.GetTable<Product>();
            Products = await productTable.ToListAsync();
        }
    }
}
