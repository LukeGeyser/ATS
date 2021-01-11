namespace ATS.Forms.Components
{
    partial class NotificationForm
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDisposeNotification = new System.Windows.Forms.Button();
            this.pctNotificationType = new System.Windows.Forms.PictureBox();
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.lblExchange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctNotificationType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(96, 31);
            this.lblMessage.MaximumSize = new System.Drawing.Size(325, 0);
            this.lblMessage.MinimumSize = new System.Drawing.Size(325, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(325, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "base_message";
            // 
            // btnDisposeNotification
            // 
            this.btnDisposeNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnDisposeNotification.FlatAppearance.BorderSize = 0;
            this.btnDisposeNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisposeNotification.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisposeNotification.Image = global::ATS.Properties.Resources.Cancel;
            this.btnDisposeNotification.Location = new System.Drawing.Point(428, 14);
            this.btnDisposeNotification.Name = "btnDisposeNotification";
            this.btnDisposeNotification.Size = new System.Drawing.Size(68, 49);
            this.btnDisposeNotification.TabIndex = 1;
            this.btnDisposeNotification.UseVisualStyleBackColor = false;
            this.btnDisposeNotification.Click += new System.EventHandler(this.btnDisposeNotification_Click);
            // 
            // pctNotificationType
            // 
            this.pctNotificationType.Image = global::ATS.Properties.Resources.Success;
            this.pctNotificationType.Location = new System.Drawing.Point(14, 14);
            this.pctNotificationType.Name = "pctNotificationType";
            this.pctNotificationType.Size = new System.Drawing.Size(64, 49);
            this.pctNotificationType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctNotificationType.TabIndex = 2;
            this.pctNotificationType.TabStop = false;
            // 
            // tmrNotification
            // 
            this.tmrNotification.Interval = 10;
            this.tmrNotification.Tick += new System.EventHandler(this.tmrNotification_Tick);
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchange.Location = new System.Drawing.Point(95, 6);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(165, 25);
            this.lblExchange.TabIndex = 3;
            this.lblExchange.Text = "base_exchange";
            // 
            // NotificationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(508, 79);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.pctNotificationType);
            this.Controls.Add(this.btnDisposeNotification);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctNotificationType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDisposeNotification;
        private System.Windows.Forms.PictureBox pctNotificationType;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.Timer tmrNotification;
    }
}