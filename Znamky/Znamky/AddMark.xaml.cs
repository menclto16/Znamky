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
        List<Subject> Subjects = new List<Subject>();
        public AddMark()
		{
			InitializeComponent();
		}
        public void InsertMark(object sender, EventArgs e)
        {
            MarkHandlerClass.InsertMark(SubjectPicker.SelectedItem.ToString(), Int32.Parse(Mark.Text), Int32.Parse(Weight.Text), Comment.Text);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            SubjectPicker.Items.Clear();
            Subjects = MarkHandlerClass.GetSubjects();
            foreach (var subject in Subjects) SubjectPicker.Items.Add(subject.Name);
        }
    }
}