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
	public partial class IndexPage : ContentPage
    {
        public IndexPage()
        {
            InitializeComponent();
        }
        
       
     
        public IndexPage (IEnumerable<Student> data, SQLiteConnection conn)
        {
            InitializeComponent();

            Detils.ItemsSource = data;
            Detils.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (Student)e.SelectedItem;

                // now you can reference item.Name, item.Location, etc

                var response = await DisplayActionSheet("Delete Or Edite","Delete","Edite");

                if (response == "Delete")
                {
                  conn.Delete<Student>(item.ID);
                    await Navigation.PushAsync(new HomePage());
                    await Navigation.PushAsync(new IndexPage(data, conn));
                }
                else if (response == "Edite")
                {
                    //EditeItem(item.ID);

                    await Navigation.PushAsync(new EditPage(item, conn));
                }

               
            };
        }



        //public  void DeleteItemAsync(int Id)
        //{
        //    _Db.Delete<Student>(_student);
        //}




      

    }
}