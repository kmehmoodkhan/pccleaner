﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCleaner.Controls
{
    public partial class UCAbout : UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
            this.labelDescription.Text = "PCOptimizer is a premium PC cleaning tool, it keeps your PC smooth and light and secure."+Environment.NewLine+"It's a useful tool to remove unncecessary files from your sytem and keep registry clean.";

            this.labelCopyRights.Text = "Copyright © 2018 ComputerSolutionsLab.com Inc." + Environment.NewLine + "All rights reserved.";
        }
    }
}
