using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZnamkyLibrary;

namespace Znamky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        ContentPage AddMarkPage = new AddMark();
        ContentPage MarkListPage = new MarkList();
        public TabbedPage1 ()
        {
            InitializeComponent();
            AddMarkPage.Title = "Add Mark";
            MarkListPage.Title = "Marks";
            this.Children.Add(MarkListPage);
            this.Children.Add(AddMarkPage);
        }

        public void RefreshPage(object sender, EventArgs e) {
        }
    }
}