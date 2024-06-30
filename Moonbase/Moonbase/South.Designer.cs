namespace Moonbase
{
    partial class South
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(South));
            this.NVgroupBox = new System.Windows.Forms.GroupBox();
            this.HMbuttonS = new System.Windows.Forms.Button();
            this.NTHbuttonS = new System.Windows.Forms.Button();
            this.ESTbuttonS = new System.Windows.Forms.Button();
            this.WSTButtonS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NVgroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NVgroupBox
            // 
            this.NVgroupBox.BackColor = System.Drawing.Color.Blue;
            this.NVgroupBox.Controls.Add(this.WSTButtonS);
            this.NVgroupBox.Controls.Add(this.ESTbuttonS);
            this.NVgroupBox.Controls.Add(this.NTHbuttonS);
            this.NVgroupBox.Controls.Add(this.HMbuttonS);
            this.NVgroupBox.Location = new System.Drawing.Point(53, 34);
            this.NVgroupBox.Name = "NVgroupBox";
            this.NVgroupBox.Size = new System.Drawing.Size(219, 230);
            this.NVgroupBox.TabIndex = 0;
            this.NVgroupBox.TabStop = false;
            this.NVgroupBox.Text = "Navigator";
            // 
            // HMbuttonS
            // 
            this.HMbuttonS.Location = new System.Drawing.Point(79, 90);
            this.HMbuttonS.Name = "HMbuttonS";
            this.HMbuttonS.Size = new System.Drawing.Size(60, 60);
            this.HMbuttonS.TabIndex = 0;
            this.HMbuttonS.Text = "Home";
            this.HMbuttonS.UseVisualStyleBackColor = true;
            this.HMbuttonS.Click += new System.EventHandler(this.HMbuttonS_Click);
            // 
            // NTHbuttonS
            // 
            this.NTHbuttonS.Location = new System.Drawing.Point(79, 15);
            this.NTHbuttonS.Name = "NTHbuttonS";
            this.NTHbuttonS.Size = new System.Drawing.Size(60, 60);
            this.NTHbuttonS.TabIndex = 1;
            this.NTHbuttonS.Text = "North";
            this.NTHbuttonS.UseVisualStyleBackColor = true;
            this.NTHbuttonS.Click += new System.EventHandler(this.NTHbuttonS_Click);
            // 
            // ESTbuttonS
            // 
            this.ESTbuttonS.Location = new System.Drawing.Point(153, 90);
            this.ESTbuttonS.Name = "ESTbuttonS";
            this.ESTbuttonS.Size = new System.Drawing.Size(60, 60);
            this.ESTbuttonS.TabIndex = 2;
            this.ESTbuttonS.Text = "East";
            this.ESTbuttonS.UseVisualStyleBackColor = true;
            this.ESTbuttonS.Click += new System.EventHandler(this.ESTbuttonS_Click);
            // 
            // WSTButtonS
            // 
            this.WSTButtonS.Location = new System.Drawing.Point(7, 90);
            this.WSTButtonS.Name = "WSTButtonS";
            this.WSTButtonS.Size = new System.Drawing.Size(60, 60);
            this.WSTButtonS.TabIndex = 3;
            this.WSTButtonS.Text = "West";
            this.WSTButtonS.UseVisualStyleBackColor = true;
            this.WSTButtonS.Click += new System.EventHandler(this.WSTButtonS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpaceX Moonbase Store Area";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(919, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "South Site Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(222, 98);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "This is the South site of SpaceX Moonbase. This site is where\r\npeople who are col" +
    "onozing the moon and mars will be able\r\nto come and buy important goods from foo" +
    "d, drinks, electronics,\r\nand many more.";
            // 
            // South
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NVgroupBox);
            this.Name = "South";
            this.Text = "South Site";
            this.Load += new System.EventHandler(this.South_Load);
            this.NVgroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NVgroupBox;
        private System.Windows.Forms.Button HMbuttonS;
        private System.Windows.Forms.Button NTHbuttonS;
        private System.Windows.Forms.Button ESTbuttonS;
        private System.Windows.Forms.Button WSTButtonS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}