namespace Sesma.Application
{
    partial class Situation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.powerConsumptionMeter = new Sesma.Application.UserControls.MeterBox();
            this.powerOutputMeter = new Sesma.Application.UserControls.MeterBox();
            this.powerMeter = new Sesma.Application.UserControls.PowerMeter();
            this.stateGrid = new Sesma.Application.UserControls.StateGrid();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.powerConsumptionMeter);
            this.groupBox1.Controls.Add(this.powerOutputMeter);
            this.groupBox1.Controls.Add(this.powerMeter);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power";
            // 
            // powerConsumptionMeter
            // 
            this.powerConsumptionMeter.Location = new System.Drawing.Point(84, 13);
            this.powerConsumptionMeter.Name = "powerConsumptionMeter";
            this.powerConsumptionMeter.Size = new System.Drawing.Size(73, 75);
            this.powerConsumptionMeter.TabIndex = 3;
            // 
            // powerOutputMeter
            // 
            this.powerOutputMeter.Location = new System.Drawing.Point(4, 13);
            this.powerOutputMeter.Name = "powerOutputMeter";
            this.powerOutputMeter.Size = new System.Drawing.Size(73, 75);
            this.powerOutputMeter.TabIndex = 2;
            // 
            // powerMeter
            // 
            this.powerMeter.CurrentLevel = 0;
            this.powerMeter.Location = new System.Drawing.Point(163, 12);
            this.powerMeter.MaxLevel = 0;
            this.powerMeter.Name = "powerMeter";
            this.powerMeter.Size = new System.Drawing.Size(64, 73);
            this.powerMeter.TabIndex = 1;
            // 
            // stateGrid
            // 
            this.stateGrid.BackColor = System.Drawing.SystemColors.Control;
            this.stateGrid.Location = new System.Drawing.Point(6, 222);
            this.stateGrid.Name = "stateGrid";
            this.stateGrid.Size = new System.Drawing.Size(126, 23);
            this.stateGrid.TabIndex = 1;
            // 
            // Situation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stateGrid);
            this.Name = "Situation";
            this.Size = new System.Drawing.Size(435, 264);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.StateGrid stateGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.PowerMeter powerMeter;
        private UserControls.MeterBox powerConsumptionMeter;
        private UserControls.MeterBox powerOutputMeter;
    }
}
