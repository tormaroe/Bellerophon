﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesma.Application
{
    public partial class Help : UserControl
    {
        public Help()
        {
            InitializeComponent();
        }

        public void Load(string page)
        {
            this.webBrowser1.Navigate("http://127.0.0.1:8123/" + page);
        }
    }
}
