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
	public partial class MarkList : ContentPage
	{
        MarkHandler MarkHandlerClass = new MarkHandler();
        ObservableCollection<Mark> Marks = new ObservableCollection<Mark>();
        public MarkList()
		{
			InitializeComponent();

            Marks = new ObservableCollection<Mark>(MarkHandlerClass.GetMarks());

            MarkListView.ItemsSource = Marks;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Marks.Clear();
            List<Mark> marksList = MarkHandlerClass.GetMarks();
            foreach (var mark in marksList) Marks.Add(mark);
        }
	}
}