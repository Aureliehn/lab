using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace leLab
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Count_Button_Clicked(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
            Console.WriteLine("click add ok");
        }

        private void Decremente_Button_Clicked(object sender, EventArgs e)
        {
            count--;
            countLabel.Text = count.ToString();
            Console.WriteLine("click ok");
        }
    }
}
