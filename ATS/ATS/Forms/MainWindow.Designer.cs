namespace ATS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Inputs = new System.Windows.Forms.Label();
            this.pnl_Inputs = new System.Windows.Forms.Panel();
            this.lbl_ExhcangeRate = new System.Windows.Forms.Label();
            this.cmb_exchangerate = new System.Windows.Forms.ComboBox();
            this.lbl_tradeIncre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_requiredmargin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Lunoheader = new System.Windows.Forms.Label();
            this.lbl_keyID = new System.Windows.Forms.Label();
            this.lblSecret = new System.Windows.Forms.Label();
            this.lbl_bitmapauth = new System.Windows.Forms.Label();
            this.lbl_APIKey = new System.Windows.Forms.Label();
            this.lbl_cust_id = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnl_monitor = new System.Windows.Forms.Panel();
            this.txt_currentmargin = new System.Windows.Forms.TextBox();
            this.lbl_currentmargin = new System.Windows.Forms.Label();
            this.cmb_BitmapAskPrice = new System.Windows.Forms.ComboBox();
            this.lbl_bitmapask = new System.Windows.Forms.Label();
            this.cmb_VALRBidPrice = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_valrbidprice = new System.Windows.Forms.Label();
            this.lbl_bitmapconverted = new System.Windows.Forms.Label();
            this.cmb_bitmapConverted = new System.Windows.Forms.ComboBox();
            this.txtHighestMargin = new System.Windows.Forms.TextBox();
            this.lbl_highestmargin = new System.Windows.Forms.Label();
            this.btn_ResetHighestMargin = new System.Windows.Forms.Button();
            this.pnl_activations = new System.Windows.Forms.Panel();
            this.btn_ActivateMonitoring = new System.Windows.Forms.Button();
            this.lbl_Activations = new System.Windows.Forms.Label();
            this.btn_ActivateTrading = new System.Windows.Forms.Button();
            this.btn_StopAll = new System.Windows.Forms.Button();
            this.pnl_ErrorLog = new System.Windows.Forms.Panel();
            this.lbl_errorLog = new System.Windows.Forms.Label();
            this.dgv_errorLog = new System.Windows.Forms.DataGridView();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Inputs.SuspendLayout();
            this.pnl_monitor.SuspendLayout();
            this.pnl_activations.SuspendLayout();
            this.pnl_ErrorLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_errorLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Inputs
            // 
            this.lbl_Inputs.AutoSize = true;
            this.lbl_Inputs.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inputs.Location = new System.Drawing.Point(14, 9);
            this.lbl_Inputs.Name = "lbl_Inputs";
            this.lbl_Inputs.Size = new System.Drawing.Size(72, 24);
            this.lbl_Inputs.TabIndex = 0;
            this.lbl_Inputs.Text = "Inputs:";
            // 
            // pnl_Inputs
            // 
            this.pnl_Inputs.Controls.Add(this.textBox5);
            this.pnl_Inputs.Controls.Add(this.textBox4);
            this.pnl_Inputs.Controls.Add(this.textBox3);
            this.pnl_Inputs.Controls.Add(this.textBox2);
            this.pnl_Inputs.Controls.Add(this.lbl_APIKey);
            this.pnl_Inputs.Controls.Add(this.lbl_cust_id);
            this.pnl_Inputs.Controls.Add(this.lbl_bitmapauth);
            this.pnl_Inputs.Controls.Add(this.lblSecret);
            this.pnl_Inputs.Controls.Add(this.lbl_keyID);
            this.pnl_Inputs.Controls.Add(this.lbl_Lunoheader);
            this.pnl_Inputs.Controls.Add(this.textBox1);
            this.pnl_Inputs.Controls.Add(this.lbl_requiredmargin);
            this.pnl_Inputs.Controls.Add(this.comboBox1);
            this.pnl_Inputs.Controls.Add(this.lbl_tradeIncre);
            this.pnl_Inputs.Controls.Add(this.cmb_exchangerate);
            this.pnl_Inputs.Controls.Add(this.lbl_Inputs);
            this.pnl_Inputs.Controls.Add(this.lbl_ExhcangeRate);
            this.pnl_Inputs.Location = new System.Drawing.Point(12, 3);
            this.pnl_Inputs.Name = "pnl_Inputs";
            this.pnl_Inputs.Size = new System.Drawing.Size(989, 189);
            this.pnl_Inputs.TabIndex = 1;
            // 
            // lbl_ExhcangeRate
            // 
            this.lbl_ExhcangeRate.AutoSize = true;
            this.lbl_ExhcangeRate.Location = new System.Drawing.Point(15, 61);
            this.lbl_ExhcangeRate.Name = "lbl_ExhcangeRate";
            this.lbl_ExhcangeRate.Size = new System.Drawing.Size(81, 13);
            this.lbl_ExhcangeRate.TabIndex = 2;
            this.lbl_ExhcangeRate.Text = "Exchange Rate";
            // 
            // cmb_exchangerate
            // 
            this.cmb_exchangerate.FormattingEnabled = true;
            this.cmb_exchangerate.Location = new System.Drawing.Point(141, 58);
            this.cmb_exchangerate.Name = "cmb_exchangerate";
            this.cmb_exchangerate.Size = new System.Drawing.Size(121, 21);
            this.cmb_exchangerate.TabIndex = 3;
            // 
            // lbl_tradeIncre
            // 
            this.lbl_tradeIncre.AutoSize = true;
            this.lbl_tradeIncre.Location = new System.Drawing.Point(15, 112);
            this.lbl_tradeIncre.Name = "lbl_tradeIncre";
            this.lbl_tradeIncre.Size = new System.Drawing.Size(120, 13);
            this.lbl_tradeIncre.TabIndex = 4;
            this.lbl_tradeIncre.Text = "Bitcoin Trade Increment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lbl_requiredmargin
            // 
            this.lbl_requiredmargin.AutoSize = true;
            this.lbl_requiredmargin.Location = new System.Drawing.Point(15, 165);
            this.lbl_requiredmargin.Name = "lbl_requiredmargin";
            this.lbl_requiredmargin.Size = new System.Drawing.Size(85, 13);
            this.lbl_requiredmargin.TabIndex = 6;
            this.lbl_requiredmargin.Text = "Required Margin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lbl_Lunoheader
            // 
            this.lbl_Lunoheader.AutoSize = true;
            this.lbl_Lunoheader.Location = new System.Drawing.Point(510, 42);
            this.lbl_Lunoheader.Name = "lbl_Lunoheader";
            this.lbl_Lunoheader.Size = new System.Drawing.Size(102, 13);
            this.lbl_Lunoheader.TabIndex = 8;
            this.lbl_Lunoheader.Text = "Luno Authentication";
            // 
            // lbl_keyID
            // 
            this.lbl_keyID.AutoSize = true;
            this.lbl_keyID.Location = new System.Drawing.Point(510, 66);
            this.lbl_keyID.Name = "lbl_keyID";
            this.lbl_keyID.Size = new System.Drawing.Size(42, 13);
            this.lbl_keyID.TabIndex = 9;
            this.lbl_keyID.Text = "Key ID:";
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(510, 92);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(41, 13);
            this.lblSecret.TabIndex = 10;
            this.lblSecret.Text = "Secret:";
            this.lblSecret.Click += new System.EventHandler(this.lblSecret_Click);
            // 
            // lbl_bitmapauth
            // 
            this.lbl_bitmapauth.AutoSize = true;
            this.lbl_bitmapauth.Location = new System.Drawing.Point(510, 117);
            this.lbl_bitmapauth.Name = "lbl_bitmapauth";
            this.lbl_bitmapauth.Size = new System.Drawing.Size(110, 13);
            this.lbl_bitmapauth.TabIndex = 11;
            this.lbl_bitmapauth.Text = "Bitmap Authentication";
            // 
            // lbl_APIKey
            // 
            this.lbl_APIKey.AutoSize = true;
            this.lbl_APIKey.Location = new System.Drawing.Point(510, 165);
            this.lbl_APIKey.Name = "lbl_APIKey";
            this.lbl_APIKey.Size = new System.Drawing.Size(48, 13);
            this.lbl_APIKey.TabIndex = 13;
            this.lbl_APIKey.Text = "API Key:";
            // 
            // lbl_cust_id
            // 
            this.lbl_cust_id.AutoSize = true;
            this.lbl_cust_id.Location = new System.Drawing.Point(509, 140);
            this.lbl_cust_id.Name = "lbl_cust_id";
            this.lbl_cust_id.Size = new System.Drawing.Size(68, 13);
            this.lbl_cust_id.TabIndex = 12;
            this.lbl_cust_id.Text = "Customer ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(623, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(623, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(623, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(623, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 20);
            this.textBox5.TabIndex = 17;
            // 
            // pnl_monitor
            // 
            this.pnl_monitor.Controls.Add(this.btn_ResetHighestMargin);
            this.pnl_monitor.Controls.Add(this.txtHighestMargin);
            this.pnl_monitor.Controls.Add(this.lbl_highestmargin);
            this.pnl_monitor.Controls.Add(this.cmb_bitmapConverted);
            this.pnl_monitor.Controls.Add(this.lbl_bitmapconverted);
            this.pnl_monitor.Controls.Add(this.txt_currentmargin);
            this.pnl_monitor.Controls.Add(this.lbl_currentmargin);
            this.pnl_monitor.Controls.Add(this.cmb_BitmapAskPrice);
            this.pnl_monitor.Controls.Add(this.lbl_bitmapask);
            this.pnl_monitor.Controls.Add(this.cmb_VALRBidPrice);
            this.pnl_monitor.Controls.Add(this.label9);
            this.pnl_monitor.Controls.Add(this.lbl_valrbidprice);
            this.pnl_monitor.Location = new System.Drawing.Point(12, 191);
            this.pnl_monitor.Name = "pnl_monitor";
            this.pnl_monitor.Size = new System.Drawing.Size(989, 170);
            this.pnl_monitor.TabIndex = 18;
            // 
            // txt_currentmargin
            // 
            this.txt_currentmargin.Location = new System.Drawing.Point(141, 140);
            this.txt_currentmargin.Name = "txt_currentmargin";
            this.txt_currentmargin.Size = new System.Drawing.Size(74, 20);
            this.txt_currentmargin.TabIndex = 7;
            // 
            // lbl_currentmargin
            // 
            this.lbl_currentmargin.AutoSize = true;
            this.lbl_currentmargin.Location = new System.Drawing.Point(15, 147);
            this.lbl_currentmargin.Name = "lbl_currentmargin";
            this.lbl_currentmargin.Size = new System.Drawing.Size(76, 13);
            this.lbl_currentmargin.TabIndex = 6;
            this.lbl_currentmargin.Text = "Current Margin";
            // 
            // cmb_BitmapAskPrice
            // 
            this.cmb_BitmapAskPrice.FormattingEnabled = true;
            this.cmb_BitmapAskPrice.Location = new System.Drawing.Point(141, 76);
            this.cmb_BitmapAskPrice.Name = "cmb_BitmapAskPrice";
            this.cmb_BitmapAskPrice.Size = new System.Drawing.Size(74, 21);
            this.cmb_BitmapAskPrice.TabIndex = 5;
            // 
            // lbl_bitmapask
            // 
            this.lbl_bitmapask.AutoSize = true;
            this.lbl_bitmapask.Location = new System.Drawing.Point(15, 79);
            this.lbl_bitmapask.Name = "lbl_bitmapask";
            this.lbl_bitmapask.Size = new System.Drawing.Size(87, 13);
            this.lbl_bitmapask.TabIndex = 4;
            this.lbl_bitmapask.Text = "Bitmap Ask Price";
            // 
            // cmb_VALRBidPrice
            // 
            this.cmb_VALRBidPrice.FormattingEnabled = true;
            this.cmb_VALRBidPrice.Location = new System.Drawing.Point(141, 40);
            this.cmb_VALRBidPrice.Name = "cmb_VALRBidPrice";
            this.cmb_VALRBidPrice.Size = new System.Drawing.Size(74, 21);
            this.cmb_VALRBidPrice.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monitor";
            // 
            // lbl_valrbidprice
            // 
            this.lbl_valrbidprice.AutoSize = true;
            this.lbl_valrbidprice.Location = new System.Drawing.Point(15, 43);
            this.lbl_valrbidprice.Name = "lbl_valrbidprice";
            this.lbl_valrbidprice.Size = new System.Drawing.Size(80, 13);
            this.lbl_valrbidprice.TabIndex = 2;
            this.lbl_valrbidprice.Text = "VALR Bid Price";
            // 
            // lbl_bitmapconverted
            // 
            this.lbl_bitmapconverted.AutoSize = true;
            this.lbl_bitmapconverted.Location = new System.Drawing.Point(15, 113);
            this.lbl_bitmapconverted.Name = "lbl_bitmapconverted";
            this.lbl_bitmapconverted.Size = new System.Drawing.Size(118, 13);
            this.lbl_bitmapconverted.TabIndex = 8;
            this.lbl_bitmapconverted.Text = "Bitmap Converted Price";
            // 
            // cmb_bitmapConverted
            // 
            this.cmb_bitmapConverted.FormattingEnabled = true;
            this.cmb_bitmapConverted.Location = new System.Drawing.Point(141, 110);
            this.cmb_bitmapConverted.Name = "cmb_bitmapConverted";
            this.cmb_bitmapConverted.Size = new System.Drawing.Size(74, 21);
            this.cmb_bitmapConverted.TabIndex = 9;
            // 
            // txtHighestMargin
            // 
            this.txtHighestMargin.Location = new System.Drawing.Point(404, 83);
            this.txtHighestMargin.Name = "txtHighestMargin";
            this.txtHighestMargin.Size = new System.Drawing.Size(74, 20);
            this.txtHighestMargin.TabIndex = 11;
            // 
            // lbl_highestmargin
            // 
            this.lbl_highestmargin.AutoSize = true;
            this.lbl_highestmargin.Location = new System.Drawing.Point(322, 86);
            this.lbl_highestmargin.Name = "lbl_highestmargin";
            this.lbl_highestmargin.Size = new System.Drawing.Size(78, 13);
            this.lbl_highestmargin.TabIndex = 10;
            this.lbl_highestmargin.Text = "Highest Margin";
            // 
            // btn_ResetHighestMargin
            // 
            this.btn_ResetHighestMargin.Location = new System.Drawing.Point(496, 71);
            this.btn_ResetHighestMargin.Name = "btn_ResetHighestMargin";
            this.btn_ResetHighestMargin.Size = new System.Drawing.Size(99, 43);
            this.btn_ResetHighestMargin.TabIndex = 12;
            this.btn_ResetHighestMargin.Text = "Reset Highest Margin";
            this.btn_ResetHighestMargin.UseVisualStyleBackColor = true;
            // 
            // pnl_activations
            // 
            this.pnl_activations.Controls.Add(this.btn_StopAll);
            this.pnl_activations.Controls.Add(this.btn_ActivateTrading);
            this.pnl_activations.Controls.Add(this.btn_ActivateMonitoring);
            this.pnl_activations.Controls.Add(this.lbl_Activations);
            this.pnl_activations.Location = new System.Drawing.Point(12, 367);
            this.pnl_activations.Name = "pnl_activations";
            this.pnl_activations.Size = new System.Drawing.Size(989, 83);
            this.pnl_activations.TabIndex = 19;
            // 
            // btn_ActivateMonitoring
            // 
            this.btn_ActivateMonitoring.Location = new System.Drawing.Point(235, 31);
            this.btn_ActivateMonitoring.Name = "btn_ActivateMonitoring";
            this.btn_ActivateMonitoring.Size = new System.Drawing.Size(99, 43);
            this.btn_ActivateMonitoring.TabIndex = 12;
            this.btn_ActivateMonitoring.Text = "Activate Monitoring";
            this.btn_ActivateMonitoring.UseVisualStyleBackColor = true;
            this.btn_ActivateMonitoring.Click += new System.EventHandler(this.btn_ActivateMonitoring_Click);
            // 
            // lbl_Activations
            // 
            this.lbl_Activations.AutoSize = true;
            this.lbl_Activations.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Activations.Location = new System.Drawing.Point(14, 9);
            this.lbl_Activations.Name = "lbl_Activations";
            this.lbl_Activations.Size = new System.Drawing.Size(108, 24);
            this.lbl_Activations.TabIndex = 0;
            this.lbl_Activations.Text = "Activatons";
            // 
            // btn_ActivateTrading
            // 
            this.btn_ActivateTrading.Location = new System.Drawing.Point(435, 31);
            this.btn_ActivateTrading.Name = "btn_ActivateTrading";
            this.btn_ActivateTrading.Size = new System.Drawing.Size(99, 43);
            this.btn_ActivateTrading.TabIndex = 13;
            this.btn_ActivateTrading.Text = "Activate Trading";
            this.btn_ActivateTrading.UseVisualStyleBackColor = true;
            // 
            // btn_StopAll
            // 
            this.btn_StopAll.Location = new System.Drawing.Point(623, 31);
            this.btn_StopAll.Name = "btn_StopAll";
            this.btn_StopAll.Size = new System.Drawing.Size(99, 43);
            this.btn_StopAll.TabIndex = 14;
            this.btn_StopAll.Text = "Stop All";
            this.btn_StopAll.UseVisualStyleBackColor = true;
            // 
            // pnl_ErrorLog
            // 
            this.pnl_ErrorLog.Controls.Add(this.dgv_errorLog);
            this.pnl_ErrorLog.Controls.Add(this.lbl_errorLog);
            this.pnl_ErrorLog.Location = new System.Drawing.Point(12, 456);
            this.pnl_ErrorLog.Name = "pnl_ErrorLog";
            this.pnl_ErrorLog.Size = new System.Drawing.Size(989, 210);
            this.pnl_ErrorLog.TabIndex = 20;
            // 
            // lbl_errorLog
            // 
            this.lbl_errorLog.AutoSize = true;
            this.lbl_errorLog.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorLog.Location = new System.Drawing.Point(14, 9);
            this.lbl_errorLog.Name = "lbl_errorLog";
            this.lbl_errorLog.Size = new System.Drawing.Size(98, 24);
            this.lbl_errorLog.TabIndex = 0;
            this.lbl_errorLog.Text = "Error Log";
            // 
            // dgv_errorLog
            // 
            this.dgv_errorLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_errorLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestamp,
            this.error,
            this.Other_Parameter,
            this.Exchange});
            this.dgv_errorLog.Location = new System.Drawing.Point(3, 36);
            this.dgv_errorLog.Name = "dgv_errorLog";
            this.dgv_errorLog.Size = new System.Drawing.Size(983, 150);
            this.dgv_errorLog.TabIndex = 1;
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "Time & Date";
            this.timestamp.Name = "timestamp";
            // 
            // error
            // 
            this.error.HeaderText = "Error";
            this.error.Name = "error";
            // 
            // Other_Parameter
            // 
            this.Other_Parameter.HeaderText = "Other Parameter";
            this.Other_Parameter.Name = "Other_Parameter";
            // 
            // Exchange
            // 
            this.Exchange.HeaderText = "Exchange";
            this.Exchange.Name = "Exchange";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 649);
            this.Controls.Add(this.pnl_ErrorLog);
            this.Controls.Add(this.pnl_activations);
            this.Controls.Add(this.pnl_monitor);
            this.Controls.Add(this.pnl_Inputs);
            this.Name = "MainWindow";
            this.Text = "Arbitrade Trading Software";
            this.pnl_Inputs.ResumeLayout(false);
            this.pnl_Inputs.PerformLayout();
            this.pnl_monitor.ResumeLayout(false);
            this.pnl_monitor.PerformLayout();
            this.pnl_activations.ResumeLayout(false);
            this.pnl_activations.PerformLayout();
            this.pnl_ErrorLog.ResumeLayout(false);
            this.pnl_ErrorLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_errorLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Inputs;
        private System.Windows.Forms.Panel pnl_Inputs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_requiredmargin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_tradeIncre;
        private System.Windows.Forms.ComboBox cmb_exchangerate;
        private System.Windows.Forms.Label lbl_ExhcangeRate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_APIKey;
        private System.Windows.Forms.Label lbl_cust_id;
        private System.Windows.Forms.Label lbl_bitmapauth;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.Label lbl_keyID;
        private System.Windows.Forms.Label lbl_Lunoheader;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel pnl_monitor;
        private System.Windows.Forms.Button btn_ResetHighestMargin;
        private System.Windows.Forms.TextBox txtHighestMargin;
        private System.Windows.Forms.Label lbl_highestmargin;
        private System.Windows.Forms.ComboBox cmb_bitmapConverted;
        private System.Windows.Forms.Label lbl_bitmapconverted;
        private System.Windows.Forms.TextBox txt_currentmargin;
        private System.Windows.Forms.Label lbl_currentmargin;
        private System.Windows.Forms.ComboBox cmb_BitmapAskPrice;
        private System.Windows.Forms.Label lbl_bitmapask;
        private System.Windows.Forms.ComboBox cmb_VALRBidPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_valrbidprice;
        private System.Windows.Forms.Panel pnl_activations;
        private System.Windows.Forms.Button btn_StopAll;
        private System.Windows.Forms.Button btn_ActivateTrading;
        private System.Windows.Forms.Button btn_ActivateMonitoring;
        private System.Windows.Forms.Label lbl_Activations;
        private System.Windows.Forms.Panel pnl_ErrorLog;
        private System.Windows.Forms.DataGridView dgv_errorLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exchange;
        private System.Windows.Forms.Label lbl_errorLog;
    }
}

