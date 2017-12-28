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
    public partial class CobaNavPopupAlert : TabbedPage
    {
        public CobaNavPopupAlert ()
        {
            InitializeComponent();
        }
    }
}