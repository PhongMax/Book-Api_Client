﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookApiClient
{
    public partial class frmBook : DevExpress.XtraEditors.XtraForm
    {
        public frmBook()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a JsonDataSource asynchronously
            jsonDataSource1.FillAsync();
           
        }
    }
}