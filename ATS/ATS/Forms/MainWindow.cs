﻿using ATS.Services;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lblSecret_Click(object sender, EventArgs e)
        {

        }

        private void btn_ActivateMonitoring_Click(object sender, EventArgs e)
        {
            IRestResponse response = ValrService.Get("881c6b0beb12baa68875b2c51bc82b5cfb175bfe3492cfdbe7af045afaf765f3", "99a5c2c177959c19856546b789cdc715737c50d0a6af61abc6a88e9428f50933", "GET", "/v1/account/balances");

            if (!response.IsSuccessful)
                Debug.WriteLine($"ERROR: {response.Content}");

        }
    }
}
