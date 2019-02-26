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
            var qList = Quote.GetQuotesFiltered(true);
            Quote q = qList[rand.Next(0,qList.Count)];

            lblContent.Text = q.Content;
            if (q.Author.Length != 0)
            {
                lblAuthor.Text = q.Author;
            }else
            {
                lblAuthor.Text = "-Anoniem";
            }

            switch(q.Subject)
            {
                case "Programming":
                    imgSubject.Source = "http://clients.swcg-inc.net/portals/0/Images/SWCG/Programming.jpg";                  
                    break;
                case "Hardware":
                    imgSubject.Source = "https://s-media-cache-ak0.pinimg.com/736x/fa/1e/b7/fa1eb7cd0dc2a72945148603738e514a.jpg";
                    break;
                case "Windows":
                    imgSubject.Source = "http://www.logodesignlove.com/images/contentious/honest-windows-logo.jpg";
                    break;
                case "Varia":
                    imgSubject.Source = "http://ehealth4everyone.com/wp-content/uploads/2016/04/health-it-1140x450.jpg";
                    break;
                default:
                    imgSubject.Source = "http://clients.swcg-inc.net/portals/0/Images/SWCG/Programming.jpg";
                    break;
            }
            lblSubject.Text = q.Subject;
        }

        private void BtnRandom_Clicked(object sender, EventArgs e)
        {
            ShowQuote();
        }
    }
}
