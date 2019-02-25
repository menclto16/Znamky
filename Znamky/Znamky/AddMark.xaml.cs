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

            MarkPicker.Items.Add("1");
            MarkPicker.Items.Add("2");
            MarkPicker.Items.Add("3");
            MarkPicker.Items.Add("4");
            MarkPicker.Items.Add("5");

            WeightPicker.Items.Add("5");
            WeightPicker.Items.Add("10");
            WeightPicker.Items.Add("15");
            WeightPicker.Items.Add("20");
            WeightPicker.Items.Add("25");
            WeightPicker.Items.Add("30");
            WeightPicker.Items.Add("35");
            WeightPicker.Items.Add("40");
            WeightPicker.Items.Add("45");
            WeightPicker.Items.Add("50");
            WeightPicker.Items.Add("55");
            WeightPicker.Items.Add("60");
            WeightPicker.Items.Add("65");
            WeightPicker.Items.Add("70");
            WeightPicker.Items.Add("75");
            WeightPicker.Items.Add("80");
            WeightPicker.Items.Add("85");
            WeightPicker.Items.Add("90");
            WeightPicker.Items.Add("95");
            WeightPicker.Items.Add("100");
        }
        public void InsertMark(object sender, EventArgs e)
        {
            if (SubjectPicker.SelectedIndex != -1 & MarkPicker.SelectedIndex != -1 & WeightPicker.SelectedIndex != -1)
            {
                MarkHandlerClass.InsertMark(SubjectPicker.SelectedItem.ToString(), Int32.Parse(MarkPicker.SelectedItem.ToString()), Int32.Parse(WeightPicker.SelectedItem.ToString()), Comment.Text);
            }
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