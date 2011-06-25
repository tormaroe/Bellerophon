using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Sesma.Application.UserControls
{
    public partial class StateGrid : UserControl
    {

        private ShapeContainer shapeContainer1;
        private RectangleShape[] _lightbulbs;
        private const int BULB_SIZE = 5;
        private const int PADDING = 3;

        public static Color COLOR_OFF = Color.Black;

        public StateGrid()
        {
            InitializeComponent();
        }

        public void InitializeLightbulbs(int rows, int columns)
        {
            this.shapeContainer1 = new ShapeContainer();
            this.SuspendLayout();

            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";            

            int numberOfBulbs = rows * columns;
            _lightbulbs = new RectangleShape[numberOfBulbs];
            int index = 0;
            for (int rowNumber = 0; rowNumber < rows; rowNumber++)
            {
                for (int columNumber = 0; columNumber < columns; columNumber++)
                {
                    int left = (columNumber * PADDING) + (columNumber * BULB_SIZE);
                    int top = (rowNumber * PADDING) + (rowNumber * BULB_SIZE);
                    var bulb = new RectangleShape(left, top, BULB_SIZE, BULB_SIZE)
                    {
                        BackStyle = BackStyle.Opaque,
                        BackColor = COLOR_OFF,
                    };
                    _lightbulbs[index++] = bulb;                    
                    this.shapeContainer1.Shapes.Add(bulb);
                }
            }

            this.shapeContainer1.Size = new System.Drawing.Size(64, 73);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;

            this.Controls.Add(this.shapeContainer1);

            int totalWidth = (columns * PADDING) + (columns * BULB_SIZE);
            int totalHeight = (rows * PADDING) + (rows * BULB_SIZE);
            this.Size = new System.Drawing.Size(totalWidth, totalHeight);

            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
