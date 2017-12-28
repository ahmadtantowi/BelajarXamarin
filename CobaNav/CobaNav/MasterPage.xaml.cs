using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CobaNav
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

            var masterDetailItems = new List<MasterDetailItem>();
            masterDetailItems.Add(new MasterDetailItem
            {
                Title = "Kontak",
                IconSource = "pertama.png",
                TargetType = typeof(MasterDetailContact)
            });
            masterDetailItems.Add(new MasterDetailItem
            {
                Title = "Todo List",
                IconSource = "kedua.png",
                TargetType = typeof(MasterDetailTodoList)
            });
            masterDetailItems.Add(new MasterDetailItem
            {
                Title = "Pengingat",
                IconSource = "ketiga.png",
                TargetType = typeof(MasterDetailReminder)
            });
            listView.ItemsSource = masterDetailItems;
        }
	}
}