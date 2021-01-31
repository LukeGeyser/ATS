using ATS.Enumerators;
using ATS.Forms.Components;
using ATS.Helpers;
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
using System.Globalization;
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
            if (txtVALRApiKey.InvokeRequired)
            {
                SetVALRKeyIdCallback d = new SetVALRKeyIdCallback(SetVALRKeyIdText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtVALRApiKey.Text = text;
            }
        }


        delegate void SetVALRSecretCallback(string text);

        private void SetVALRSecretText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtVALRApiKeySecret.InvokeRequired)
            {
                SetVALRSecretCallback d = new SetVALRSecretCallback(SetVALRSecretText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtVALRApiKeySecret.Text = text;
            }
        }


        delegate void SetBitmapCustIDCallback(string text);

        private void SetBitmapCustIDText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitstampClientID.InvokeRequired)
            {
                SetBitmapCustIDCallback d = new SetBitmapCustIDCallback(SetBitmapCustIDText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitstampClientID.Text = text;
            }
        }


        delegate void SetBitmapKeyCallback(string text);

        private void SetBitmapKeyText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBitstampApiKey.InvokeRequired)
            {
                SetBitmapKeyCallback d = new SetBitmapKeyCallback(SetBitmapKeyText);
                Invoke(d, new object[] { text });
            }
            else
            {
                txtBitstampApiKey.Text = text;
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

                FileHandler.WriteError(error);

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
                totalSellBTI = 0.0;
                totalBuyBTI = 0.0;
                SetSellTotal(totalSellBTI.ToString());
                SetBuyTotal(totalBuyBTI.ToString());
            }
        }


        delegate void SetActiveMonitoringBtnCallback(bool enabled);

        private void SetActiveMonitoring(bool enabled)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (btn_ActivateMonitoring.InvokeRequired)
            {
                SetActiveMonitoringBtnCallback d = new SetActiveMonitoringBtnCallback(SetActiveMonitoring);
                Invoke(d, new object[] { enabled });
            }
            else
            {
                btn_ActivateMonitoring.Enabled = true;
            }
        }


        delegate void StopAllCallback();

        private void StopAll()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (btn_ActivateMonitoring.InvokeRequired)
            {
                StopAllCallback d = new StopAllCallback(StopAll);
                Invoke(d, new object[] {  });
            }
            else
            {
                btn_StopAll.PerformClick();
            }
        }


        delegate void SetNotificationCallback(string message, NotificationType type, string exchange, string otherParam = "");

        private void SetNotification(string message, NotificationType type, string exchange, string otherParam = "")
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (btn_ActivateTrading.InvokeRequired)
            {
                SetNotificationCallback d = new SetNotificationCallback(SetNotification);
                Invoke(d, new object[] { message, type, exchange, otherParam });
            }
            else
            {
                NotificationForm form = new NotificationForm();
                form.showNotification(message, exchange, type);

                if (type == NotificationType.ERROR)
                {
                    AddErrorText(new ErrorModel(DateTime.Now.ToString(), message, otherParam, exchange));
                }
            }
        }

        delegate void SetBuyTotalCallback(string text);

        private void SetBuyTotal(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtBuyTotal.InvokeRequired)
            {
                SetBuyTotalCallback d = new SetBuyTotalCallback(SetBuyTotal);
                Invoke(d, new object[] { });
            }
            else
            {
                txtBuyTotal.Text = text;
            }
        }

        delegate void SetSellTotalCallback(string text);

        private void SetSellTotal(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (txtSellTotal.InvokeRequired)
            {
                SetSellTotalCallback d = new SetSellTotalCallback(SetSellTotal);
                Invoke(d, new object[] { });
            }
            else
            {
                txtSellTotal.Text = text;
            }
        }

        #endregion

        #region Properties

        public double VBP = 0.0;

        public double BAP = 0.0;

        public double BCP = 0.0;

        public double BTL = 0.0;

        public double CM = 0.0;

        public double HM = 0.0;

        public double totalSellBTI = 0.0;

        public double totalBuyBTI = 0.0;

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

            errors = new BindingList<ErrorModel>(FileHandler.GetErrors());

            errorBindingSource = new BindingSource(errors, null);

            dgv_errorLog.DataSource = errorBindingSource;

            txtVALRApiKey.Text = Properties.Settings.Default.VALRApiKey;
            txtVALRApiKeySecret.Text = Properties.Settings.Default.VALRKeySecret;
            txtBitstampClientID.Text = Properties.Settings.Default.BITSTAMPClientID;
            txtBitstampApiKey.Text = Properties.Settings.Default.BITSTAMPApiKey;
            txtBitstampApiKeySecret.Text = Properties.Settings.Default.BITSTAMPKeySecret;
        }

        #endregion

        #region UI Events

        private void lblSecret_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtVALRApiKey.Text) ||
                    string.IsNullOrEmpty(txtVALRApiKeySecret.Text) ||
                    string.IsNullOrEmpty(txtBitstampApiKey.Text) ||
                    string.IsNullOrEmpty(txtBitstampApiKeySecret.Text) ||
                    string.IsNullOrEmpty(txtBitstampClientID.Text))
                {
                    SetNotification("Please fill in all the Exchange Details before Trading / Monitoring", NotificationType.ERROR, "APPLICATION", "Missing Exchange Details");
                    return;
                }

                if (monitorThread == null)
                    monitorThread = new Thread(new ThreadStart(Monitor));

                monitorThread.Start();

                isMonitoring = true;

                btn_ActivateMonitoring.Enabled = false;

                btn_ActivateTrading.Enabled = true;
            }
            catch (Exception ex)
            {
                SetNotification(ex.Message, NotificationType.ERROR, "APPLICATION", ex.Source);
            }
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
                SetNotification(ex.Message, NotificationType.ERROR, "APPLICATION", ex.Source);
            }
        }

        private void lbl_Lunoheader_Click(object sender, EventArgs e)
        {

        }

        private void txtBTI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var BTI = Convert.ToDouble(txtBTI.Text, CultureInfo.InvariantCulture);
                if (!string.IsNullOrEmpty(txtBitstampAskPrice.Text))
                {

                    var BAP = Convert.ToDouble(txtBitstampAskPrice.Text, CultureInfo.InvariantCulture);
                    if (BTI > 0.001 && BTI > (25 / BAP))
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
                    if (BTI >= 0.001)
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
                if (!isMonitoring)
                    btn_ActivateMonitoring.Enabled = canMonitor;
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
                btn_ActivateTrading.Enabled = false;
            }
            catch (Exception ex)
            {
                SetNotification(ex.Message, NotificationType.ERROR, "APPLICATION", ex.Source);
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

        private void btnClearErrors_Click(object sender, EventArgs e)
        {
            if (errors != null)
                errors.Clear();
        }

        private void txtVALRApiKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VALRApiKey = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        private void txtVALRApiKeySecret_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VALRKeySecret = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        private void txtBitstampClientID_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BITSTAMPClientID = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        private void txtBitstampApiKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BITSTAMPApiKey = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        private void txtBitstampApiKeySecret_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BITSTAMPKeySecret = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Helpers

        private async void Monitor()
        {
            while (isMonitoring)
            {
                try
                {
                    IRestResponse response = await ValrService.Get(txtVALRApiKey.Text, txtVALRApiKeySecret.Text, "GET", "/v1/marketdata/BTCZAR/orderbook");

                    if (!response.IsSuccessful)
                    {
                        StopAll();
                        SetNotification(response.Content, NotificationType.ERROR, "VALR");
                    }
                    else
                    {
                        var AskBid = Newtonsoft.Json.JsonConvert.DeserializeObject<OrderBookVALR>(response.Content);

                        VBP = Validator.CalcVBP(AskBid.Bids, Convert.ToDouble(txtBTI.Text, CultureInfo.InvariantCulture));
                    }

                    try
                    {
                        var BitStampResult = await BitStampService.Get(txtBitstampApiKey.Text, txtBitstampClientID.Text);

                        var orderbook = Newtonsoft.Json.JsonConvert.DeserializeObject<BitstampOrderBook>(BitStampResult);

                        BAP = Validator.CalcBAP(orderbook.asks, Convert.ToDouble(txtBTI.Text, CultureInfo.InvariantCulture));
                    }
                    catch (Exception bitstampEx)
                    {
                        StopAll();
                        SetNotification(bitstampEx.Message, NotificationType.ERROR, "BITSTAMP", bitstampEx.Source);
                    }

                    if (!string.IsNullOrEmpty(txtER.Text))
                    {
                        BCP = BAP * Convert.ToDouble(txtER.Text, CultureInfo.InvariantCulture);

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
                    SetNotification(ex.Message, NotificationType.ERROR, "APPLICATION", ex.Source);

                    monitorThread = null;
                    isMonitoring = false;
                    SetActiveMonitoring(true);

                    StopAll();
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
                    if (totalBuyBTI >= Convert.ToDouble(txtBTL.Text, CultureInfo.InvariantCulture) || totalSellBTI >= Convert.ToDouble(txtBTL.Text, CultureInfo.InvariantCulture))
                    {
                        // STOP ALL TRADING
                        buyAndSellThread = null;
                        isTrading = false;
                        SetActiveTradingBtn(false);
                        break;
                    }

                    if (string.IsNullOrEmpty(txtRM.Text))
                        return;

                    if (CM > Convert.ToDouble(txtRM.Text, CultureInfo.InvariantCulture))
                    {
                        string jsonString = JsonConvert.SerializeObject(new MarketOrderVALR() { side = "SELL", baseAmount = txtBTI.Text, pair = "BTCZAR" });

                        IRestResponse responseVALR = await ValrService.PostMarketOrder(txtVALRApiKey.Text, txtVALRApiKeySecret.Text, "POST", "/v1/orders/market", jsonString);

                        if (!responseVALR.IsSuccessful)
                        {
                            SetNotification(responseVALR.Content, NotificationType.ERROR, "VALR");

                            // STOP ALL TRADING
                            buyAndSellThread = null;
                            isTrading = false;
                            SetActiveTradingBtn(false);
                            return;
                        }
                        else
                        {
                            try
                            {
                                MarketOrderResponseVALR marketOrderResponseVALR = JsonConvert.DeserializeObject<MarketOrderResponseVALR>(responseVALR.Content);

                                // Check to see the status of the Order
                                IRestResponse orderResponseVALR = await ValrService.GetOrderStatus(txtVALRApiKey.Text, txtVALRApiKeySecret.Text, "GET", $"/v1/orders/BTCZAR/orderid/{marketOrderResponseVALR.id}");

                                MarketOrderStatusVALR orderStatusVALR = JsonConvert.DeserializeObject<MarketOrderStatusVALR>(orderResponseVALR.Content);

                                if (string.IsNullOrEmpty(orderStatusVALR.failedReason) && responseVALR.StatusCode == System.Net.HttpStatusCode.Accepted)
                                {
                                    // TODO: Notify on Status
                                    SetNotification("Order Status: " + orderStatusVALR.orderStatusType, NotificationType.SUCCESS, "VALR", orderStatusVALR.orderType);
                                    totalSellBTI += Convert.ToDouble(txtBTL.Text, CultureInfo.InvariantCulture);
                                    SetSellTotal(totalSellBTI.ToString());
                                }
                                else
                                {
                                    // Create Error Based on Failed Reason
                                    SetNotification(orderStatusVALR.failedReason, NotificationType.ERROR, "VALR", $"{orderStatusVALR.orderSide}: {orderStatusVALR.orderStatusType}");

                                    // STOP ALL TRADING
                                    buyAndSellThread = null;
                                    isTrading = false;
                                    SetActiveTradingBtn(false);
                                    return;
                                }
                            }
                            catch (Exception valrEx)
                            {
                                SetNotification(valrEx.Message, NotificationType.ERROR, "VALR", valrEx.Source);

                                // STOP ALL TRADING
                                buyAndSellThread = null;
                                isTrading = false;
                                SetActiveTradingBtn(false);
                                return;
                            }
                        }

                        // Buy Market Order on Bitstamp
                        IRestResponse BitStampResult = await BitStampService.PostMarketOrder(txtBitstampApiKeySecret.Text, txtBitstampApiKey.Text, txtBTI.Text);

                        BitstampOrderError bitstampOrderError = JsonConvert.DeserializeObject<BitstampOrderError>(BitStampResult.Content);

                        if (!BitStampResult.IsSuccessful || bitstampOrderError != null ? bitstampOrderError.status == "error" : bitstampOrderError == null)
                        {
                            SetNotification(bitstampOrderError != null ? bitstampOrderError.reason.__all__[0] : BitStampResult.Content,
                                NotificationType.ERROR, "BITSTAMP",
                                bitstampOrderError != null && bitstampOrderError.reason.__all__.Count > 1 ? bitstampOrderError.reason.__all__[1] : "null");

                            // STOP ALL TRADING
                            buyAndSellThread = null;
                            isTrading = false;
                            SetActiveTradingBtn(false);
                            return;
                        }
                        else
                        {
                            try
                            {
                                BitstampMarketOrderResponse bitstampMarketOrderResponse = JsonConvert.DeserializeObject<BitstampMarketOrderResponse>(BitStampResult.Content);

                                IRestResponse bitstampOrderStatus = await BitStampService.GetOrderStatus(txtBitstampApiKeySecret.Text, txtBitstampApiKey.Text, bitstampMarketOrderResponse.id);

                                BitstampMarketOrderStatus bitstampMarketOrderStatus = JsonConvert.DeserializeObject<BitstampMarketOrderStatus>(bitstampOrderStatus.Content);

                                if (bitstampMarketOrderStatus.status != "Canceled" && BitStampResult.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    // TODO: Notify on Status
                                    SetNotification("Order Status: " + bitstampMarketOrderStatus.status, NotificationType.SUCCESS, "BITSTAMP", "Amount Remaining: " + bitstampMarketOrderStatus.amount_remaining);

                                    totalBuyBTI += Convert.ToDouble(txtBTL.Text, CultureInfo.InvariantCulture);
                                    SetBuyTotal(totalBuyBTI.ToString());
                                }
                                else
                                {
                                    // Create Error Based on Failed Reason
                                    SetNotification(bitstampMarketOrderStatus.status, NotificationType.ERROR, "BITSTAMP", "Amount Remaining: " + bitstampMarketOrderStatus.amount_remaining);

                                    // STOP ALL TRADING
                                    buyAndSellThread = null;
                                    isTrading = false;
                                    SetActiveTradingBtn(false);
                                    return;
                                }
                            }
                            catch (Exception bitstampEx)
                            {
                                SetNotification(bitstampEx.Message, NotificationType.ERROR, "BITSTAMP", bitstampEx.Source);

                                // STOP ALL TRADING
                                buyAndSellThread = null;
                                isTrading = false;
                                SetActiveTradingBtn(false);
                                return;
                            }
                        }

                        Thread.Sleep(2000);
                    }
                }
                catch (Exception ex)
                {
                    SetNotification(ex.Message, NotificationType.ERROR, "APPLICATION", ex.Source);

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
        }

        #endregion

    }
}
