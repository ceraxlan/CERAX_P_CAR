﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASKAR_CONTROL_PANEL
{
    public partial class PB_BatteryArea : UserControl
    {
        ASKAR_UI_FORM MainUI;
        public PB_BatteryArea(ASKAR_UI_FORM form)
        {
            InitializeComponent();
            MainUI = form;
        }
    }
}
