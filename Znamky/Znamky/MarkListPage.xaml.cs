using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZnamkyLibrary;

namespace Znamky
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MarkListPage : ContentPage
	{
        MarkHandler MarkHandlerClass = new MarkHandler();
        private ObservableCollection<MarkGroup> groupedMarks { get; set; }
        public MarkListPage()
		{
			InitializeComponent();

            groupedMarks = new ObservableCollection<MarkGroup>(MarkHandlerClass.GetGroupedMarks());

            MarkListView.ItemsSource = groupedMarks;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            groupedMarks.Clear();
            foreach (var item in MarkHandlerClass.GetGroupedMarks())
            {
                groupedMarks.Add(item);
            }
        }
	}
}