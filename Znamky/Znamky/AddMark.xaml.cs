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
	public partial class AddMark : ContentPage
	{
        MarkHandler MarkHandlerClass = new MarkHandler();
        List<Mark> Marks = new List<Mark>();
        public AddMark()
		{
			InitializeComponent();
		}
        public void InsertMark(object sender, EventArgs e)
        {
            MarkHandlerClass.InsertMark(Subject.Text, Int32.Parse(Mark.Text), Int32.Parse(Weight.Text), Comment.Text);
            
            Marks = MarkHandlerClass.GetMarks();
        }
    }
}