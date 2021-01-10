using ATS.Models;
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


        delegate void AddErrorCallback(ErrorModel error);

        private void AddErrorText(ErrorModel error)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dgv_errorLog.InvokeRequired)
            {
                AddErrorCallback d = new AddErrorCallback(AddErrorText);
                Invoke(d, new object[] { error });
            }
            else
            {
                errors.Add(error);

                if (errors.Count >= 5)
                    errors.RemoveAt(0);
            }
        }


        delegate void SetActiveTradingBtnCallback(bool enabled);

        private void SetActiveTradingBtn(bool enabled)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (btn_ActivateTrading.InvokeRequired)
            {
                SetActiveTradingBtnCallback d = new SetActiveTradingBtnCallback(SetActiveTradingBtn);
                Invoke(d, new object[] { enabled });
            }
            else
            {
                btn_ActivateTrading.Enabled = true;
            }
        }

        #endregion

        #region Properties

        public double VBP = 0.0;

        public double BAP = 0.0;

        public double BCP = 0.0;

        public double CM = 0.0;

        public double HM = 0.0;

        bool canMonitor = false;

        bool isMonitoring = false;

        bool isTrading = false;

        Thread monitorThread;

        Thread buyAndSellThread;

        BindingSource errorBindingSource;

        BindingList<ErrorModel> errors = new BindingList<ErrorModel>();

        #endregion

        #region MAIN_ENTRY_TO_APPLICATION

        public MainWindow()
        {
            InitializeComponent();
            lblBTIError.Visible = false;
            btn_ActivateMonitoring.Enabled = canMonitor;
            btn_ActivateTrading.Enabled = canMonitor;

            txtER.Text = "18.7";
            txtBTI.Text = "0.0001";
            txtRM.Text = "3.2";

            errorBindingSource = new BindingSource(errors, null);

            dgv_errorLog.DataSource = errorBindingSource;
        }

        #endregion

        #region UI Events

        private void lblSecret_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            if (monitorThread == null)
                monitorThread = new Thread(new ThreadStart(Monitor));

            monitorThread.Start();

            isMonitoring = true;

            btn_ActivateMonitoring.Enabled = false;
        }

        private void btn_ActivateTrading_Click(object sender, EventArgs e)
        {
            try
            {
                if (buyAndSellThread == null)
                    buyAndSellThread = new Thread(new ThreadStart(BuyAndSellMarket));

                buyAndSellThread.Start();

                isTrading = true;

                btn_ActivateTrading.Enabled = false;
            }
            catch (Exception ex)
            {
                AddError(ex.Message, ex.Source, "APPLICATION");
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
                    if (BTI >= 0.0001)
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
            try
            {
                if (monitorThread != null)
                {
                    if (monitorThread.ThreadState == System.Threading.ThreadState.Running || monitorThread.ThreadState == System.Threading.ThreadState.Stopped)
                        monitorThread.Abort();
                }

                monitorThread = null;
                isMonitoring = false;
                btn_ActivateMonitoring.Enabled = true;

                if (buyAndSellThread != null)
                {
                    if (buyAndSellThread.ThreadState == System.Threading.ThreadState.Running || buyAndSellThread.ThreadState == System.Threading.ThreadState.Stopped)
                        buyAndSellThread.Abort();
                }

                buyAndSellThread = null;
                isTrading = false;
                btn_ActivateTrading.Enabled = true;
            }
            catch (Exception ex)
            {
                AddError(ex.Message, ex.Source, "APPLICATION");
            }
        }

        private void dgv_errorLog_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_errorLog.Rows)
            {
                try
                {
                    string Exchange = row.Cells["Exchange"].Value.ToString();

                    if (Exchange == "VALR")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(63, 101, 226);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (Exchange == "BITSTAMP")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(26, 171, 83);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
                catch (Exception) { }
            }
        }

        #endregion

        #region Helpers

        private async void Monitor()
        {
            while (isMonitoring)
            {
                try
                {
                    IRestResponse response = await ValrService.Get("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", "/v1/marketdata/BTCZAR/orderbook");

                    if (!response.IsSuccessful)
                        AddError(response.Content, "null", "VALR");
                    else
                    {
                        Debug.WriteLine(response.Content);

                        var AskBid = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBookVALR>(response.Content);

                        VBP = Validator.CalcVBP(AskBid.Bids, Convert.ToDouble(txtBTI.Text));
                    }

                    var BitStampResult = await BitStampService.Get("e2VEXCaeW1ExIwHTOE3qIBHaIW2BS490", "neyy1424");

                    var orderbook = Newtonsoft.Json.JsonConvert.DeserializeObject<BitstampOrderBook>(BitStampResult);

                    BAP = Validator.CalcBAP(orderbook.asks, Convert.ToDouble(txtBTI.Text));

                    if (!string.IsNullOrEmpty(txtER.Text))
                    {
                        BCP = BAP * Convert.ToDouble(txtER.Text);

                        CM = ((VBP - BCP) / BCP) * 100;

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
                catch (Exception ex)
                {
                    // TODO: Create Custom Exceptions Here
                    AddError(ex.Message, ex.Source, "APPLICATION");
                }

                Thread.Sleep(2000);
            }
        }

        private async void BuyAndSellMarket()
        {
            while (isTrading)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtRM.Text))
                        return;

                    if (CM > Convert.ToDouble(txtRM.Text))
                    {
                        //string jsonString = JsonConvert.SerializeObject(new MarketOrderVALR() { side = "SELL", baseAmount = txtBTI.Text, pair = "BTCZAR" });

                        //IRestResponse responseVALR = await ValrService.PostMarketOrder("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "POST", "/v1/orders/market", jsonString);

                        //if (!responseVALR.IsSuccessful)
                        //    AddError(responseVALR.Content, "null", "VALR");
                        //else
                        //{
                        //    try
                        //    {
                        //        MarketOrderResponseVALR marketOrderResponseVALR = JsonConvert.DeserializeObject<MarketOrderResponseVALR>(responseVALR.Content);

                        //        // Check to see the status of the Order
                        //        IRestResponse orderResponseVALR = await ValrService.GetOrderStatus("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", $"/v1/orders/BTCZAR/orderid/{marketOrderResponseVALR.id}");

                        //        MarketOrderStatusVALR orderStatusVALR = JsonConvert.DeserializeObject<MarketOrderStatusVALR>(orderResponseVALR.Content);

                        //        if (string.IsNullOrEmpty(orderStatusVALR.failedReason) && responseVALR.StatusCode == System.Net.HttpStatusCode.Accepted)
                        //        {
                        //            // TODO: Notify on Status
                        //        }
                        //        else
                        //        {
                        //            // Create Error Based on Failed Reason
                        //            AddError(orderStatusVALR.failedReason, orderStatusVALR.orderStatusType, "VALR");
                        //        }
                        //    }
                        //    catch (Exception valrEx)
                        //    {
                        //        AddError(valrEx.Message, valrEx.Source, "VALR");
                        //    }
                        //}

                        // Buy Market Order on Bitstamp
                        IRestResponse BitStampResult = await BitStampService.PostMarketOrder("2pMX7tjPlZe6sMX18GKoTYf2Axr5kExv", "e2VEXCaeW1ExIwHTOE3qIBHaIW2BS490", txtBTI.Text);

                        BitstampOrderError bitstampOrderError = JsonConvert.DeserializeObject<BitstampOrderError>(BitStampResult.Content);

                        if (!BitStampResult.IsSuccessful || bitstampOrderError != null ? bitstampOrderError.status == "error" : bitstampOrderError == null)
                            AddError(
                                bitstampOrderError != null ? bitstampOrderError.reason.__all__[0] : BitStampResult.Content,
                                bitstampOrderError != null && bitstampOrderError.reason.__all__.Count > 1 ? bitstampOrderError.reason.__all__[1] : "null",
                                "BITSTAMP");
                        else
                        {
                            try
                            {
                                BitstampMarketOrderResponse bitstampMarketOrderResponse = JsonConvert.DeserializeObject<BitstampMarketOrderResponse>(BitStampResult.Content);

                                IRestResponse bitstampOrderStatus = await BitStampService.GetOrderStatus("2pMX7tjPlZe6sMX18GKoTYf2Axr5kExv", "e2VEXCaeW1ExIwHTOE3qIBHaIW2BS490", bitstampMarketOrderResponse.id);

                                BitstampMarketOrderStatus bitstampMarketOrderStatus = JsonConvert.DeserializeObject<BitstampMarketOrderStatus>(bitstampOrderStatus.Content);

                                if (bitstampMarketOrderStatus.status != "Canceled" && BitStampResult.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    // TODO: Notify on Status
                                }
                                else
                                {
                                    // Create Error Based on Failed Reason
                                    AddError(bitstampMarketOrderStatus.status, "Amount Remaining: " + bitstampMarketOrderStatus.amount_remaining, "BITSTAMP");
                                }
                            }
                            catch (Exception bitstampEx)
                            {
                                AddError(bitstampEx.Message, bitstampEx.Source, "BITSTAMP");
                            }
                        }

                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    AddError(ex.Message, ex.Source, "APPLICATION");

                    // STOP ALL TRADING
                    buyAndSellThread = null;
                    isTrading = false;
                    SetActiveTradingBtn(false);
                }

            }
        }

        private void AddError(string error, string otherParam, string exchange)
        {
            AddErrorText(new ErrorModel(DateTime.Now.ToString(), error, otherParam, exchange));

            // TODO: Add error to .txt File

        }

        #endregion
    }
}
