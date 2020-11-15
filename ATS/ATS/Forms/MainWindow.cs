using ATS.Models.Bitstamp;
using ATS.Models.VALR;
using ATS.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    public partial class MainWindow : Form
    {

        public double VBP = 0.0;

        bool canMonitor = false;

        public MainWindow()
        {
            InitializeComponent();
            lblBTIError.Visible = false;
        }

        private void lblSecret_Click(object sender, EventArgs e)
        {

        }

        private async void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            IRestResponse response = await ValrService.Get("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", "/v1/marketdata/BTCZAR/orderbook");

            if (!response.IsSuccessful)
                Debug.WriteLine($"ERROR: {response.Content}");
            else
            {
                Debug.WriteLine(response.Content);
                var AskBid = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBookVALR>(response.Content);
                VBP = Validator.CalcVBP(new List<AskBid> {
                    new AskBid() { Price = "171149", Quantity = "11.00650027" },
                    new AskBid() { Price = "170500", Quantity = "0.00052312" },
                    new AskBid() { Price = "170181", Quantity = "0.99" },
                    new AskBid() { Price = "170180", Quantity = "0.27486756" },
                    new AskBid() { Price = "170178", Quantity = "0.1" },
                    new AskBid() { Price = "170170", Quantity = "0.1" },
                    new AskBid() { Price = "170007", Quantity = "0.32" },
                    new AskBid() { Price = "170000", Quantity = "0.11764706" },
                    new AskBid() { Price = "169355", Quantity = "0.1" },}, 5);
                int d = 3;
                Debug.WriteLine(VBP);
            }

            var BitStampResult = await BitStampService.Get("x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "neyy1424");

            var orderbook = Newtonsoft.Json.JsonConvert.DeserializeObject<BitstampOrderBook>(BitStampResult);
            int a = 2; 
        }

        private void lbl_Lunoheader_Click(object sender, EventArgs e)
        {

        }

        private void txtBTI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var BTI = Convert.ToDouble(txtBTI.Text);
                if (!string.IsNullOrEmpty(txtBitstampAskPrice.Text))
                {
                    
                    var BAP = Convert.ToDouble(txtBitstampAskPrice.Text);
                    if (BTI > 0.0001 && BTI > (25 / BAP))
                    {
                        canMonitor = true;
                    }
                    else
                        canMonitor = false;
                }
                else
                {
                    if (BTI > 0.0001)
                    {
                        canMonitor = true;
                    }
                    else
                        canMonitor = false;
                }
            }
            catch (Exception)
            {
                lblBTIError.Text = "Please check your BTI value";
            }
            
        }
    }
}
