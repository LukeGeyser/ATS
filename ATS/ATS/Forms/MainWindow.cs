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

        public double BAP = 0.0;

        public double BCP = 0.0;

        public double CM = 0.0;

        public double HM = 0.0;

        bool canMonitor = false;

        public MainWindow()
        {
            InitializeComponent();
            lblBTIError.Visible = false;
            btn_ActivateMonitoring.Enabled = canMonitor;
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

                //VBP = Validator.CalcVBP(AskBid.Bids, 5);

                if (!string.IsNullOrEmpty(VBP.ToString()))
                    txtVALRBidPrice.Text = VBP.ToString();

            }

            var BitStampResult = await BitStampService.Get("x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "neyy1424");

            var orderbook = Newtonsoft.Json.JsonConvert.DeserializeObject<BitstampOrderBook>(BitStampResult);

            //BAP = Validator.CalcBAP(orderbook.asks, Convert.ToDouble(txtBTI.Text));

            BAP = Validator.CalcBAP(new List<List<string>>
            {
                new List<string> { "12179.49", "0.2" },
                new List<string> { "12180.85", "0.45740213" },
                new List<string> { "12180.86", "2" },
                new List<string> { "12182.76", "0.025" },
                new List<string> { "12182.81", "0.39920598" },
                new List<string> { "12182.82", "2" },
                new List<string> { "12184.68", "0.2063" },
                new List<string> { "12185", "0.07" },
                new List<string> { "12185.29", "0.08" },
            }, 5);

            // TODO: RUN THIS TEST FOR PROOF (CHECK THIS OUT WITH NICOL)

            //BAP = Validator.CalcBAP(new List<List<string>>
            //{
            //    new List<string> { "171149", "11.00650027" },
            //    new List<string> { "170500", "0.00052312" },
            //    new List<string> { "170181", "0.99" },
            //    new List<string> { "170180", "0.27486756" },
            //    new List<string> { "170178", "0.1" },
            //    new List<string> { "170170", "0.1" },
            //    new List<string> { "170007", "0.32" },
            //    new List<string> { "170000", "0.11764706" },
            //    new List<string> { "169355", "0.1" },
            //}, 5);

            if (!string.IsNullOrEmpty(BAP.ToString()))
                txtBitstampAskPrice.Text = BAP.ToString();

            if (!string.IsNullOrEmpty(txtER.Text))
            {
                BCP = BAP * Convert.ToDouble(txtER.Text);

                CM = ((BCP - VBP) / VBP) * 100;

                if (CM > HM || HM == 0)
                    HM = CM;
            }

            txtHighestMargin.Text = HM.ToString();
            txtCurrentMargin.Text = CM.ToString();
            txtBitstampConvertedPrice.Text = BCP.ToString();
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
                        lblBTIError.Visible = false;
                    }
                    else
                    {
                        canMonitor = false;
                        lblBTIError.Text = "Please check your BTI value";
                        lblBTIError.Visible = true;
                    }
                }
                else
                {
                    if (BTI > 0.0001)
                    {
                        canMonitor = true;
                        lblBTIError.Visible = false;
                    }
                    else
                    {
                        canMonitor = false;
                        lblBTIError.Text = "Please check your BTI value";
                        lblBTIError.Visible = true;
                    }
                }
                btn_ActivateMonitoring.Enabled = canMonitor;
            }
            catch (Exception)
            {
                canMonitor = false;
                lblBTIError.Text = "Please check your BTI value";
                lblBTIError.Visible = true;
                btn_ActivateMonitoring.Enabled = canMonitor;
            }
            
        }
    }
}
