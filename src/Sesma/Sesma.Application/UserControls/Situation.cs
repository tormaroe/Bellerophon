using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sesma.Application
{
    public partial class Situation : UserControl
    {
        public Situation()
        {
            InitializeComponent();

               
            powerMeter.MaxLevel = 100;
            powerMeter.CurrentLevel = 50;

            powerOutputMeter.SetLabel("Output");
            powerConsumptionMeter.SetLabel("Usage");

            stateGrid.InitializeLightbulbs(5, 53);
        }
    }
}
