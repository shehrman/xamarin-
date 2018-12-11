using DemoXamarinSQLite.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXamarinSQLite.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
		public EditPage ()
		{
			InitializeComponent ();
		}
        public EditPage(Student student, SQLiteConnection conn)
        {
            InitializeComponent();

            EditName.Text = student.Name;
            EditAddress.Text = student.Address;

            Updatedata.Clicked += async delegate
             {
                 Student student1 = new Student()
                 {
                     ID=student.ID,
                     Name = EditName.Text,
                      Address= EditAddress.Text

                 };

                  conn.Update(student1);
                var response = await DisplayActionSheet("Update","OK","", "Have be updated");
                 if (response == "OK")
                 {
                     await Navigation.PushAsync(new HomePage());
                 }
             };



        }

       

    }
}