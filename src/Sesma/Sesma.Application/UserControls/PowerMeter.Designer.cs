namespace Sesma.Application.UserControls
{
    partial class PowerMeter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.level6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.level5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.level4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.level3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.level2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.level1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.level1,
            this.level2,
            this.level3,
            this.level4,
            this.level5,
            this.level6});
            this.shapeContainer1.Size = new System.Drawing.Size(64, 73);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // level6
            // 
            this.level6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level6.Location = new System.Drawing.Point(6, 16);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(50, 8);
            // 
            // level5
            // 
            this.level5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level5.Location = new System.Drawing.Point(6, 24);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(50, 8);
            // 
            // level4
            // 
            this.level4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level4.Location = new System.Drawing.Point(6, 32);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(50, 8);
            // 
            // level3
            // 
            this.level3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level3.Location = new System.Drawing.Point(6, 40);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(50, 8);
            // 
            // level2
            // 
            this.level2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level2.Location = new System.Drawing.Point(6, 48);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(50, 8);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.SystemColors.Control;
            this.level1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.level1.Location = new System.Drawing.Point(6, 56);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(50, 8);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Power";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "PowerMeter";
            this.Size = new System.Drawing.Size(64, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape level5;
        private System.Windows.Forms.Label label1;
    }
}
