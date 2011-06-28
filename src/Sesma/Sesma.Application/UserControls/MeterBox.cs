using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesma.Application.UserControls
{
    public partial class MeterBox : UserControl
    {
        public MeterBox()
        {
            InitializeComponent();
        }
        public void SetLabel(string text)
        {
            label.Text = text;
        }
    }
}
