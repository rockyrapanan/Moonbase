namespace Moonbase
{
    partial class East
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(East));
            this.NVgroupBox = new System.Windows.Forms.GroupBox();
            this.HMbuttonE = new System.Windows.Forms.Button();
            this.NRTHbuttonE = new System.Windows.Forms.Button();
            this.WSTbuttonE = new System.Windows.Forms.Button();
            this.STHbuttonE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NVgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NVgroupBox
            // 
            this.NVgroupBox.BackColor = System.Drawing.Color.Blue;
            this.NVgroupBox.Controls.Add(this.STHbuttonE);
            this.NVgroupBox.Controls.Add(this.WSTbuttonE);
            this.NVgroupBox.Controls.Add(this.NRTHbuttonE);
            this.NVgroupBox.Controls.Add(this.HMbuttonE);
            this.NVgroupBox.ForeColor = System.Drawing.Color.White;
            this.NVgroupBox.Location = new System.Drawing.Point(55, 37);
            this.NVgroupBox.Name = "NVgroupBox";
            this.NVgroupBox.Size = new System.Drawing.Size(219, 230);
            this.NVgroupBox.TabIndex = 0;
            this.NVgroupBox.TabStop = false;
            this.NVgroupBox.Text = "Navigator";
            // 
            // HMbuttonE
            // 
            this.HMbuttonE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HMbuttonE.Location = new System.Drawing.Point(80, 88);
            this.HMbuttonE.Name = "HMbuttonE";
            this.HMbuttonE.Size = new System.Drawing.Size(60, 60);
            this.HMbuttonE.TabIndex = 0;
            this.HMbuttonE.Text = "Home";
            this.HMbuttonE.UseVisualStyleBackColor = true;
            this.HMbuttonE.Click += new System.EventHandler(this.HMbuttonE_Click);
            // 
            // NRTHbuttonE
            // 
            this.NRTHbuttonE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NRTHbuttonE.Location = new System.Drawing.Point(80, 10);
            this.NRTHbuttonE.Name = "NRTHbuttonE";
            this.NRTHbuttonE.Size = new System.Drawing.Size(60, 60);
            this.NRTHbuttonE.TabIndex = 1;
            this.NRTHbuttonE.Text = "North";
            this.NRTHbuttonE.UseVisualStyleBackColor = true;
            this.NRTHbuttonE.Click += new System.EventHandler(this.NRTHbuttonE_Click);
            // 
            // WSTbuttonE
            // 
            this.WSTbuttonE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WSTbuttonE.Location = new System.Drawing.Point(6, 88);
            this.WSTbuttonE.Name = "WSTbuttonE";
            this.WSTbuttonE.Size = new System.Drawing.Size(60, 60);
            this.WSTbuttonE.TabIndex = 2;
            this.WSTbuttonE.Text = "West";
            this.WSTbuttonE.UseVisualStyleBackColor = true;
            this.WSTbuttonE.Click += new System.EventHandler(this.WSTbuttonE_Click);
            // 
            // STHbuttonE
            // 
            this.STHbuttonE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.STHbuttonE.Location = new System.Drawing.Point(80, 164);
            this.STHbuttonE.Name = "STHbuttonE";
            this.STHbuttonE.Size = new System.Drawing.Size(60, 60);
            this.STHbuttonE.TabIndex = 3;
            this.STHbuttonE.Text = "South";
            this.STHbuttonE.UseVisualStyleBackColor = true;
            this.STHbuttonE.Click += new System.EventHandler(this.STHbuttonE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1006, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "East Site Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpaceX Moonbase Entertainment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(253, 136);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // East
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NVgroupBox);
            this.Name = "East";
            this.Text = "East  Site";
            this.Load += new System.EventHandler(this.East_Load);
            this.NVgroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NVgroupBox;
        private System.Windows.Forms.Button HMbuttonE;
        private System.Windows.Forms.Button STHbuttonE;
        private System.Windows.Forms.Button WSTbuttonE;
        private System.Windows.Forms.Button NRTHbuttonE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}