using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesma.Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            helpControl.LoadPage("index.md");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Program.Stop();
        }
    }
}
