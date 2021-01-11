using ATS.Enumerators;
using ATS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS.Forms.Components
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private NotificationAction notificationAction;

        private int x, y;

        private void btnDisposeNotification_Click(object sender, EventArgs e)
        {
            tmrNotification.Interval = 1;
            notificationAction = NotificationAction.CLOSE;
        }

        private void tmrNotification_Tick(object sender, EventArgs e)
        {
            switch (this.notificationAction)
            {
                case NotificationAction.WAIT:
                    tmrNotification.Interval = 1500;
                    notificationAction = NotificationAction.CLOSE;
                    break;
                case NotificationAction.START:
                    tmrNotification.Interval = 1;
                    this.Opacity += 0.1;

                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            notificationAction = NotificationAction.WAIT;
                        }
                    }
                    break;
                case NotificationAction.CLOSE:
                    tmrNotification.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;

                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        public void showNotification(string message, string exchange, NotificationType notificationType)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            string formName;

            for (int i = 1; i < 10; i++)
            {
                formName = "alert" + i.ToString();
                NotificationForm notificationForm = (NotificationForm)Application.OpenForms[formName];

                if (notificationForm == null)
                {
                    this.Name = formName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (notificationType)
            {
                case NotificationType.SUCCESS:
                    pctNotificationType.Image = Resources.Success;
                    this.BackColor = Color.FromArgb(26, 171, 83);
                    this.btnDisposeNotification.BackColor = Color.FromArgb(26, 171, 83);
                    this.btnDisposeNotification.FlatAppearance.BorderColor = Color.FromArgb(26, 171, 83);
                    break;
                case NotificationType.ERROR:
                    pctNotificationType.Image = Resources.Error;
                    this.BackColor = Color.FromArgb(244, 67, 54);
                    this.btnDisposeNotification.BackColor = Color.FromArgb(244, 67, 54);
                    this.btnDisposeNotification.FlatAppearance.BorderColor = Color.FromArgb(244, 67, 54);
                    break;
                case NotificationType.INFORMATION:
                    pctNotificationType.Image = Resources.Information;
                    this.BackColor = Color.FromArgb(63, 101, 226);
                    this.btnDisposeNotification.BackColor = Color.FromArgb(63, 101, 226);
                    this.btnDisposeNotification.FlatAppearance.BorderColor = Color.FromArgb(63, 101, 226);
                    break;
                default:
                    break;
            }

            this.lblExchange.ForeColor = Color.White;
            this.lblMessage.ForeColor = Color.White;
            this.lblMessage.Text = message;
            this.lblExchange.Text = exchange;

            this.Show();
            this.notificationAction = NotificationAction.START;

            this.tmrNotification.Interval = 1;
            tmrNotification.Start();
        }

    }
}
