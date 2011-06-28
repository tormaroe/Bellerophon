namespace Sesma.Application
{
    partial class ScriptsList
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scriptControl7 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl6 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl5 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl4 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl3 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl2 = new Sesma.Application.UserControls.ScriptControl();
            this.scriptControl1 = new Sesma.Application.UserControls.ScriptControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Sesma.Application.Icons.add;
            this.button1.Location = new System.Drawing.Point(329, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Script";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Sesma.Application.Icons.folder;
            this.button2.Location = new System.Drawing.Point(223, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open Scripts";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // scriptControl7
            // 
            this.scriptControl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl7.Enabled = false;
            this.scriptControl7.Location = new System.Drawing.Point(3, 235);
            this.scriptControl7.Name = "scriptControl7";
            this.scriptControl7.Size = new System.Drawing.Size(428, 30);
            this.scriptControl7.TabIndex = 8;
            // 
            // scriptControl6
            // 
            this.scriptControl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl6.Enabled = false;
            this.scriptControl6.Location = new System.Drawing.Point(3, 202);
            this.scriptControl6.Name = "scriptControl6";
            this.scriptControl6.Size = new System.Drawing.Size(428, 30);
            this.scriptControl6.TabIndex = 7;
            // 
            // scriptControl5
            // 
            this.scriptControl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl5.Enabled = false;
            this.scriptControl5.Location = new System.Drawing.Point(3, 169);
            this.scriptControl5.Name = "scriptControl5";
            this.scriptControl5.Size = new System.Drawing.Size(428, 30);
            this.scriptControl5.TabIndex = 6;
            // 
            // scriptControl4
            // 
            this.scriptControl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl4.Enabled = false;
            this.scriptControl4.Location = new System.Drawing.Point(3, 136);
            this.scriptControl4.Name = "scriptControl4";
            this.scriptControl4.Size = new System.Drawing.Size(428, 30);
            this.scriptControl4.TabIndex = 5;
            // 
            // scriptControl3
            // 
            this.scriptControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl3.Enabled = false;
            this.scriptControl3.Location = new System.Drawing.Point(3, 103);
            this.scriptControl3.Name = "scriptControl3";
            this.scriptControl3.Size = new System.Drawing.Size(428, 30);
            this.scriptControl3.TabIndex = 4;
            // 
            // scriptControl2
            // 
            this.scriptControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl2.Enabled = false;
            this.scriptControl2.Location = new System.Drawing.Point(3, 70);
            this.scriptControl2.Name = "scriptControl2";
            this.scriptControl2.Size = new System.Drawing.Size(428, 30);
            this.scriptControl2.TabIndex = 1;
            // 
            // scriptControl1
            // 
            this.scriptControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scriptControl1.Enabled = false;
            this.scriptControl1.Location = new System.Drawing.Point(3, 37);
            this.scriptControl1.Name = "scriptControl1";
            this.scriptControl1.Size = new System.Drawing.Size(428, 30);
            this.scriptControl1.TabIndex = 0;
            // 
            // ScriptsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.scriptControl7);
            this.Controls.Add(this.scriptControl6);
            this.Controls.Add(this.scriptControl5);
            this.Controls.Add(this.scriptControl4);
            this.Controls.Add(this.scriptControl3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scriptControl2);
            this.Controls.Add(this.scriptControl1);
            this.Name = "ScriptsList";
            this.Size = new System.Drawing.Size(435, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ScriptControl scriptControl1;
        private UserControls.ScriptControl scriptControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControls.ScriptControl scriptControl3;
        private UserControls.ScriptControl scriptControl4;
        private UserControls.ScriptControl scriptControl5;
        private UserControls.ScriptControl scriptControl6;
        private UserControls.ScriptControl scriptControl7;

    }
}
