using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNotePage : ContentPage
    {
        public AddNotePage()
        {
            InitializeComponent();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {

        }
    }
}