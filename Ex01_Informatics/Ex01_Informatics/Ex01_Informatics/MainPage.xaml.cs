using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Ex01_Informatics.Model;
using System.Diagnostics;

namespace Ex01_Informatics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ShowQuote();
        }

        private void ShowQuote()
        {
            Random rand = new Random();

            Debug.WriteLine("Hello");
            Quote q = Quote.GetQuotes()[0];

            lblContent.Text = q.Content;
            lblAuthor.Text = q.Author;
            lblSubject.Text = q.Subject;       
        }
}
}
