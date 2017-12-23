using CobaListView.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CobaListView.ViewModels
{
    public class ListItemViewModel : BindableObject
    {
        private List<ListItem> lsItems;

        public ListItemViewModel()
        {
            lsItems = new List<ListItem>
            {
                new ListItem { Sumber="pertama.png", Judul="Merah", Deskripsi="Merah memiliki kode warna #FF0000" },
                new ListItem { Sumber="kedua.png", Judul="Hijau", Deskripsi="Hijau memiliki kode warna #00FF00" },
                new ListItem { Sumber="ketiga.png", Judul="Biru", Deskripsi="Biru memiliki kode warna #0000FF" },
            };
        }

        public List<ListItem> ListItems
        {
            get { return lsItems; }
            set
            {
                lsItems = value;
                OnPropertyChanged("ListItems");
            }
        }
    }
}
