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

        private void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            IRestResponse response = ValrService.Get("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", "/v1/marketdata/BTCZAR/orderbook");

            if (!response.IsSuccessful)
                Debug.WriteLine($"ERROR: {response.Content}");
            else
            {
                Debug.WriteLine(response.Content);
                var AskBid = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBookVALR>(response.Content);
                VBP = Validator.CalcVBP(new List<AskBid> { 
                    new AskBid() { Price = "5", Quantity = "75" },
                    new AskBid() { Price = "50", Quantity = "75" },
                    new AskBid() { Price = "80", Quantity = "50" }}, 199);
                int d = 3;
            }

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
