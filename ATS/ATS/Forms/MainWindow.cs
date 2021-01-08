using ATS.Models.Bitstamp;
using ATS.Models.VALR;
using ATS.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS
{
    public partial class MainWindow : Form
    {

        #region MAIN_THREAD_UI_UPDATERS

        delegate void SetERCallback(string text);

        private void SetERText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtER.InvokeRequired)
            {
                SetERCallback d = new SetERCallback(SetERText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtER.Text = text;
            }
        }


        delegate void SetBTICallback(string text);

        private void SetBTIText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBTI.InvokeRequired)
            {
                SetBTICallback d = new SetBTICallback(SetBTIText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBTI.Text = text;
            }
        }


        delegate void SetRMCallback(string text);

        private void SetRMText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtRM.InvokeRequired)
            {
                SetRMCallback d = new SetRMCallback(SetRMText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtRM.Text = text;
            }
        }


        delegate void SetVALRKeyIdCallback(string text);

        private void SetVALRKeyIdText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtVALRKeyId.InvokeRequired)
            {
                SetVALRKeyIdCallback d = new SetVALRKeyIdCallback(SetVALRKeyIdText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtVALRKeyId.Text = text;
            }
        }


        delegate void SetVALRSecretCallback(string text);

        private void SetVALRSecretText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtVALRSecret.InvokeRequired)
            {
                SetVALRSecretCallback d = new SetVALRSecretCallback(SetVALRSecretText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtVALRSecret.Text = text;
            }
        }


        delegate void SetBitmapCustIDCallback(string text);

        private void SetBitmapCustIDText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitmapCustID.InvokeRequired)
            {
                SetBitmapCustIDCallback d = new SetBitmapCustIDCallback(SetBitmapCustIDText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitmapCustID.Text = text;
            }
        }


        delegate void SetBitmapKeyCallback(string text);

        private void SetBitmapKeyText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitmapKey.InvokeRequired)
            {
                SetBitmapKeyCallback d = new SetBitmapKeyCallback(SetBitmapKeyText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitmapKey.Text = text;
            }
        }


        delegate void SetVALRBidPriceCallback(string text);

        private void SetVALRBidPriceText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtVALRBidPrice.InvokeRequired)
            {
                SetVALRBidPriceCallback d = new SetVALRBidPriceCallback(SetVALRBidPriceText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtVALRBidPrice.Text = text;
            }
        }


        delegate void SetBitstampAskPriceCallback(string text);

        private void SetBitstampAskPriceText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitstampAskPrice.InvokeRequired)
            {
                SetBitstampAskPriceCallback d = new SetBitstampAskPriceCallback(SetBitstampAskPriceText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitstampAskPrice.Text = text;
            }
        }


        delegate void SetBitstampConvertedPriceCallback(string text);

        private void SetBitstampConvertedPriceText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitstampConvertedPrice.InvokeRequired)
            {
                SetBitstampConvertedPriceCallback d = new SetBitstampConvertedPriceCallback(SetBitstampConvertedPriceText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitstampConvertedPrice.Text = text;
            }
        }


        delegate void SetCurrentMarginCallback(string text);

        private void SetCurrentMarginText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtCurrentMargin.InvokeRequired)
            {
                SetCurrentMarginCallback d = new SetCurrentMarginCallback(SetCurrentMarginText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtCurrentMargin.Text = text;
            }
        }


        delegate void SetHighestMarginCallback(string text);

        private void SetHighestMarginText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtHighestMargin.InvokeRequired)
            {
                SetHighestMarginCallback d = new SetHighestMarginCallback(SetHighestMarginText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtHighestMargin.Text = text;
            }
        }

        #endregion

        public double VBP = 0.0;

        public double BAP = 0.0;

        public double BCP = 0.0;

        public double CM = 0.0;

        public double HM = 0.0;

        bool canMonitor = false;

        Thread monitorThread;

        Thread buyAndSellThread;

        public MainWindow()
        {
            InitializeComponent();
            lblBTIError.Visible = false;
            btn_ActivateMonitoring.Enabled = canMonitor;
            btn_ActivateTrading.Enabled = canMonitor;
            monitorThread = new Thread(new ThreadStart(Monitor));
            buyAndSellThread = new Thread(new ThreadStart(BuyAndSellMarket));
        }

        private void lblSecret_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            monitorThread = new Thread(new ThreadStart(Monitor));
            monitorThread.Start();

            btn_ActivateMonitoring.Enabled = false;
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
                btn_ActivateTrading.Enabled = canMonitor;
            }
            catch (Exception)
            {
                canMonitor = false;
                lblBTIError.Text = "Please check your BTI value";
                lblBTIError.Visible = true;
                btn_ActivateMonitoring.Enabled = canMonitor;
                btn_ActivateTrading.Enabled = canMonitor;
            }
            
        }

        private void btn_ResetHighestMargin_Click(object sender, EventArgs e)
        {
            HM = 0.0;
            txtHighestMargin.Text = HM.ToString();
        }

        private void btn_StopAll_Click(object sender, EventArgs e)
        {
            if (monitorThread.ThreadState == System.Threading.ThreadState.Running || monitorThread.ThreadState == System.Threading.ThreadState.Stopped)
            {
                monitorThread.Abort();
                btn_ActivateMonitoring.Enabled = true;
            }

            if (buyAndSellThread.ThreadState == System.Threading.ThreadState.Running || buyAndSellThread.ThreadState == System.Threading.ThreadState.Stopped)
            {
                buyAndSellThread.Abort();
                btn_ActivateTrading.Enabled = true;
            }
        }

        private void btn_ActivateTrading_Click(object sender, EventArgs e)
        {
            buyAndSellThread = new Thread(new ThreadStart(BuyAndSellMarket));
            buyAndSellThread.Start();

            btn_ActivateTrading.Enabled = false;
        }

        #region Helpers

        private async void Monitor()
        {
            while (true)
            {
                IRestResponse response = await ValrService.Get("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", "/v1/marketdata/BTCZAR/orderbook");

                if (!response.IsSuccessful)
                    Debug.WriteLine($"ERROR: {response.Content}");
                else
                {
                    Debug.WriteLine(response.Content);

                    var AskBid = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBookVALR>(response.Content);

                    //VBP = Validator.CalcVBP(new List<AskBid> {
                    //    new AskBid() { Price = "171149", Quantity = "11.00650027" },
                    //    new AskBid() { Price = "170500", Quantity = "0.00052312" },
                    //    new AskBid() { Price = "170181", Quantity = "0.99" },
                    //    new AskBid() { Price = "170180", Quantity = "0.27486756" },
                    //    new AskBid() { Price = "170178", Quantity = "0.1" },
                    //    new AskBid() { Price = "170170", Quantity = "0.1" },
                    //    new AskBid() { Price = "170007", Quantity = "0.32" },
                    //    new AskBid() { Price = "170000", Quantity = "0.11764706" },
                    //    new AskBid() { Price = "169355", Quantity = "0.1" },}, 5);

                    VBP = Validator.CalcVBP(AskBid.Bids, Convert.ToDouble(txtBTI.Text));
                }

                var BitStampResult = await BitStampService.Get("x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "neyy1424");

                var orderbook = Newtonsoft.Json.JsonConvert.DeserializeObject<BitstampOrderBook>(BitStampResult);

                BAP = Validator.CalcBAP(orderbook.asks, Convert.ToDouble(txtBTI.Text));

                //BAP = Validator.CalcBAP(new List<List<string>>
                //{
                //    new List<string> { "12179.49", "0.2" },
                //    new List<string> { "12180.85", "0.45740213" },
                //    new List<string> { "12180.86", "2" },
                //    new List<string> { "12182.76", "0.025" },
                //    new List<string> { "12182.81", "0.39920598" },
                //    new List<string> { "12182.82", "2" },
                //    new List<string> { "12184.68", "0.2063" },
                //    new List<string> { "12185", "0.07" },
                //    new List<string> { "12185.29", "0.08" },
                //}, 5);

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

                if (!string.IsNullOrEmpty(txtER.Text))
                {
                    BCP = BAP * Convert.ToDouble(txtER.Text);

                    CM = ((BCP - VBP) / VBP) * 100;

                    if (CM > HM || HM == 0)
                        HM = CM;
                }

                if (!string.IsNullOrEmpty(VBP.ToString()))
                    SetVALRBidPriceText(VBP.ToString());

                if (!string.IsNullOrEmpty(BAP.ToString()))
                    SetBitstampAskPriceText(BAP.ToString());

                SetHighestMarginText(HM.ToString());
                SetCurrentMarginText(CM.ToString());
                SetBitstampConvertedPriceText(BCP.ToString());
            }
        }

        private async void BuyAndSellMarket()
        {
            while (true)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtRM.Text))
                        return;

                    if (CM > Convert.ToDouble(txtRM.Text))
                    {
                        string jsonString = JsonConvert.SerializeObject(new MarketOrderVALR() { side = "SELL", baseAmount = txtBTI.Text, pair = "BTCZAR" });

                        IRestResponse response = await ValrService.PostMarketOrder("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "POST", "/v1/orders/market", jsonString);

                        if (!response.IsSuccessful)
                            Debug.WriteLine($"ERROR: {response.Content}");
                        else
                        {
                            Debug.WriteLine(response.Content);


                            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
                            {
                                // TODO: Check to see the status of the Order
                                string orderID = "";
                                IRestResponse orderResponse = await ValrService.GetOrderStatus("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "POST", $"/v1/orders/BTCZAR/orderid/${orderID}");
                            }
                            else
                            {
                                // TODO: Create an error based on the reason
                            }
                        }

                        // Buy Market Order on Bitstamp
                        //var BitStampResult = await BitStampService.Get("x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "x4nzTgSdkuGgPzwSa5kBrKHmyyDOURdI", "neyy1424");

                    }
                }
                catch (Exception)
                {
                    Debug.WriteLine("Error");
                }
            }
        }

        #endregion

        
    }
}
