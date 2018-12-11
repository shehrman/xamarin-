using DemoXamarinSQLite.Model;
using SQLite;
using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoXamarinSQLite.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
    {

        private SQLiteConnection conn;
        public Student student;
        public HomePage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLlite>().GetConnection();
            conn.CreateTable<Student>();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            student = new Student();
            student.Name = Name.Text;
            student.Address = Address.Text;
            conn.Insert(student);
            Name.Text = "";
            Address.Text = "";


        }

        private  async void Showdata_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Student>() select stu);

           await  Navigation.PushAsync(new IndexPage(data,conn));

          
        }




      
    }
}