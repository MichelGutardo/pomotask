namespace PomoTask.View
{
    partial class frmRelogio
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSegs = new System.Windows.Forms.Label();
            this.lblMili = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMin.Location = new System.Drawing.Point(9, -5);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(112, 87);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "25";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSegs
            // 
            this.lblSegs.BackColor = System.Drawing.Color.Transparent;
            this.lblSegs.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegs.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSegs.Location = new System.Drawing.Point(121, -4);
            this.lblSegs.Name = "lblSegs";
            this.lblSegs.Size = new System.Drawing.Size(102, 87);
            this.lblSegs.TabIndex = 1;
            this.lblSegs.Text = "00";
            this.lblSegs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMili
            // 
            this.lblMili.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMili.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMili.Location = new System.Drawing.Point(220, 4);
            this.lblMili.Name = "lblMili";
            this.lblMili.Size = new System.Drawing.Size(54, 44);
            this.lblMili.TabIndex = 2;
            this.lblMili.Text = "00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(96, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmRelogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(308, 105);
            this.Controls.Add(this.lblSegs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMili);
            this.Controls.Add(this.lblMin);
            this.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmRelogio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSegs;
        private System.Windows.Forms.Label lblMili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}