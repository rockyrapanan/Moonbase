namespace Moonbase
{
    partial class West
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(West));
            this.NVgroupBox = new System.Windows.Forms.GroupBox();
            this.HMbuttonW = new System.Windows.Forms.Button();
            this.ESTbuttonW = new System.Windows.Forms.Button();
            this.NTHbuttonW = new System.Windows.Forms.Button();
            this.STHbuttonW = new System.Windows.Forms.Button();
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
            this.NVgroupBox.Controls.Add(this.STHbuttonW);
            this.NVgroupBox.Controls.Add(this.NTHbuttonW);
            this.NVgroupBox.Controls.Add(this.ESTbuttonW);
            this.NVgroupBox.Controls.Add(this.HMbuttonW);
            this.NVgroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NVgroupBox.Location = new System.Drawing.Point(48, 39);
            this.NVgroupBox.Name = "NVgroupBox";
            this.NVgroupBox.Size = new System.Drawing.Size(219, 230);
            this.NVgroupBox.TabIndex = 0;
            this.NVgroupBox.TabStop = false;
            this.NVgroupBox.Text = "Navigator";
            // 
            // HMbuttonW
            // 
            this.HMbuttonW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HMbuttonW.Location = new System.Drawing.Point(80, 92);
            this.HMbuttonW.Name = "HMbuttonW";
            this.HMbuttonW.Size = new System.Drawing.Size(60, 60);
            this.HMbuttonW.TabIndex = 0;
            this.HMbuttonW.Text = "Home Button";
            this.HMbuttonW.UseVisualStyleBackColor = true;
            this.HMbuttonW.Click += new System.EventHandler(this.HMbuttonW_Click);
            // 
            // ESTbuttonW
            // 
            this.ESTbuttonW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ESTbuttonW.Location = new System.Drawing.Point(153, 92);
            this.ESTbuttonW.Name = "ESTbuttonW";
            this.ESTbuttonW.Size = new System.Drawing.Size(60, 60);
            this.ESTbuttonW.TabIndex = 1;
            this.ESTbuttonW.Text = "East";
            this.ESTbuttonW.UseVisualStyleBackColor = true;
            this.ESTbuttonW.Click += new System.EventHandler(this.ESTbuttonW_Click);
            // 
            // NTHbuttonW
            // 
            this.NTHbuttonW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NTHbuttonW.Location = new System.Drawing.Point(80, 20);
            this.NTHbuttonW.Name = "NTHbuttonW";
            this.NTHbuttonW.Size = new System.Drawing.Size(60, 60);
            this.NTHbuttonW.TabIndex = 2;
            this.NTHbuttonW.Text = "North";
            this.NTHbuttonW.UseVisualStyleBackColor = true;
            this.NTHbuttonW.Click += new System.EventHandler(this.NTHbuttonW_Click);
            // 
            // STHbuttonW
            // 
            this.STHbuttonW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.STHbuttonW.Location = new System.Drawing.Point(80, 164);
            this.STHbuttonW.Name = "STHbuttonW";
            this.STHbuttonW.Size = new System.Drawing.Size(60, 60);
            this.STHbuttonW.TabIndex = 3;
            this.STHbuttonW.Text = "South";
            this.STHbuttonW.UseVisualStyleBackColor = true;
            this.STHbuttonW.Click += new System.EventHandler(this.STHbuttonW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(994, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "West Site Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpaceX Workplace Area";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 137);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // West
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NVgroupBox);
            this.Name = "West";
            this.Text = "West Site";
            this.Load += new System.EventHandler(this.West_Load);
            this.NVgroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NVgroupBox;
        private System.Windows.Forms.Button HMbuttonW;
        private System.Windows.Forms.Button ESTbuttonW;
        private System.Windows.Forms.Button NTHbuttonW;
        private System.Windows.Forms.Button STHbuttonW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}