using AppObject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppObject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
           InitializeComponent();
            //lstMVA.BindingContext = MVUFactory.MVUdata;
            lstMVA.BindingContext = MVUFactory.BindingWithGrouping();
        }

        private void lstMVA_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lv = (ListView)sender;
            var selectedMVU = (MVUFactory.MVU)e.SelectedItem;
            DisplayAlert(selectedMVU.PublishDate.ToString("yyyy-MM-dd")
                 + " " + selectedMVU.Title, selectedMVU.Description, "Detay", "Vaçgeç");
            lv.SelectedItem = null;

        }

        private void lstMVA_Refreshing(object sender, EventArgs e)
        {
            MVUFactory.RefreshCount++;
            lstMVA.BindingContext = MVUFactory.BindingWithGrouping();
            lstMVA.IsRefreshing = false;//refresi bitir.
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue.Length>3)
            {
                lstMVA.BindingContext = MVUFactory.BindingWithGrouping(e.NewTextValue);
            }
            else if( string.IsNullOrEmpty(e.NewTextValue))
            {
                lstMVA.BindingContext = MVUFactory.BindingWithGrouping();
            }
        }
    }
       
}

   