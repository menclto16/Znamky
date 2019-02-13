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
	public partial class MarkList : ContentPage
	{
        MarkHandler MarkHandlerClass = new MarkHandler();
        List<Mark> Marks = new List<Mark>();
        public MarkList()
		{
			InitializeComponent();

            Marks = MarkHandlerClass.GetMarks();

            MarkListView.ItemsSource = Marks;
        }
	}
}