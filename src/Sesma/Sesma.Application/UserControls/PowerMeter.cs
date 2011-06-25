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
    public partial class PowerMeter : UserControl
    {
        public PowerMeter()
        {
            InitializeComponent();
            MaxLevel = Int32.MaxValue;
        }

        public int MaxLevel { get; set; }
        
        private int _CurrentLevel;
        public int CurrentLevel
        {
            get
            {
                return _CurrentLevel;
            }
            set
            {
                _CurrentLevel = value;
                int levelSize = MaxLevel / 6;
                int currentSize = _CurrentLevel / levelSize;
                DisplayLevels(currentSize);
            }
        }
        private void DisplayLevels(int n)
        {
            Color activeColor = Color.LightGreen;

            if (n > 0) level1.BackColor = activeColor;
            if (n > 1) level2.BackColor = activeColor;
            if (n > 2) level3.BackColor = activeColor;
            if (n > 3) level4.BackColor = activeColor;
            if (n > 4) level5.BackColor = activeColor;
            if (n > 5) level6.BackColor = activeColor;
        }
    }
}
