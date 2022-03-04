using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleInterest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Calculate_btn_Clicked(object sender, EventArgs e)
        {
            double total_interest = Convert.ToDouble(Principal.Text) * Convert.ToDouble(Interest.Text) * Convert.ToDouble(months.Text) / (12 * 100);
            double total_amount = Convert.ToDouble(Principal.Text) + total_interest;
            Total_amount.Text = total_amount.ToString();
            Total_interest.Text = total_interest.ToString();
            Total_int_lbl.IsVisible = true;
            Total_amt_lbl.IsVisible = true;
            Total_amount.IsVisible = true;
            Total_interest.IsVisible = true;
            Frame_amt.IsVisible = true;
            Frame_int.IsVisible = true;
        }

        private void Clear_btn_Clicked(object sender, EventArgs e)
        {
            Principal.Text = null;
            Interest.Text = null;
            months.Text = null;
            Total_amount.Text = null;
            Total_interest.Text = null;
            Total_int_lbl.IsVisible = false;
            Total_amt_lbl.IsVisible = false;
            Total_amount.IsVisible = false;
            Total_interest.IsVisible = false;
            Frame_amt.IsVisible = false;
            Frame_int.IsVisible = false;
        }
    }
}
