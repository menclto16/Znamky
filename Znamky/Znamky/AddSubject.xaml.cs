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
	public partial class AddSubject : ContentPage
	{
        MarkHandler MarkHandlerClass = new MarkHandler();
        public AddSubject ()
		{
			InitializeComponent ();
		}
        public void AddSubjectInputCompleted(object sender, EventArgs e)
        {
            MarkHandlerClass.InsertSubject(SubjectEntry.Text);
        }
    }
}