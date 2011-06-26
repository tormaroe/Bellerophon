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
            this.stateGrid = new Sesma.Application.UserControls.StateGrid();
            this.powerMeter = new Sesma.Application.UserControls.PowerMeter();
            this.SuspendLayout();
            // 
            // stateGrid
            // 
            this.stateGrid.BackColor = System.Drawing.SystemColors.Control;
            this.stateGrid.Location = new System.Drawing.Point(6, 222);
            this.stateGrid.Name = "stateGrid";
            this.stateGrid.Size = new System.Drawing.Size(126, 23);
            this.stateGrid.TabIndex = 1;
            // 
            // powerMeter
            // 
            this.powerMeter.CurrentLevel = 0;
            this.powerMeter.Location = new System.Drawing.Point(3, 3);
            this.powerMeter.MaxLevel = 0;
            this.powerMeter.Name = "powerMeter";
            this.powerMeter.Size = new System.Drawing.Size(64, 73);
            this.powerMeter.TabIndex = 0;
            // 
            // Situation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.stateGrid);
            this.Controls.Add(this.powerMeter);
            this.Name = "Situation";
            this.Size = new System.Drawing.Size(293, 251);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.PowerMeter powerMeter;
        private UserControls.StateGrid stateGrid;
    }
}
