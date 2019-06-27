using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppObject.Views
{
    public class UzmanERP
    {
        public int ID { get; set; }
        public string Name{ get; set; }

        public string ImageURl { get; set; }

    }


	public partial class ListViewÖrnek : ContentPage
	{
      

        public ListViewÖrnek()
        {
            InitializeComponent();

            List<UzmanERP> uzman = new List<UzmanERP>();
            uzman.Add(new UzmanERP { ID = 1, Name = "Bora", ImageURl = "xamagon.png" });
            uzman.Add(new UzmanERP { ID = 2, Name = "Emre", ImageURl = "xamagon.png" });
            uzman.Add(new UzmanERP { ID = 3, Name = "Yavuz", ImageURl = "xamagon.png" });

            lstView.ItemsSource = uzman;


        }
        private void onselected(object sender,SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            UzmanERP selected = (UzmanERP)e.SelectedItem;
            DisplayAlert("UzmanERP", selected.Name, "ok");
        }

        private void OnClicked(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            DisplayAlert("Button",btn.CommandParameter.ToString(),"OK"); //buton olayında ıdyi yazdırdık mesajbox a


        }
    }
}