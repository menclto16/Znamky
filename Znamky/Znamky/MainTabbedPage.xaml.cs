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
    public partial class MainTabbedPage : TabbedPage
    {
        ContentPage MarkListPage = new MarkListPage();
        ContentPage AddMarkPage = new AddMark();
        ContentPage AddSubjectPage = new AddSubject();
        public MainTabbedPage()
        {
            InitializeComponent();
            MarkListPage.Title = "Marks";
            AddMarkPage.Title = "Add Mark";
            AddSubjectPage.Title = "Add subject";
            Children.Add(MarkListPage);
            Children.Add(AddMarkPage);
            Children.Add(AddSubjectPage);
        }
    }
}