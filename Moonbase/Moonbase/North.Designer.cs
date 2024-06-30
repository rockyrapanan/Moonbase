namespace Moonbase
{
    partial class North
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(North));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ESTbuttonN = new System.Windows.Forms.Button();
            this.HMbuttonN = new System.Windows.Forms.Button();
            this.WSTbuttonN = new System.Windows.Forms.Button();
            this.STHbuttonN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.STHbuttonN);
            this.groupBox1.Controls.Add(this.WSTbuttonN);
            this.groupBox1.Controls.Add(this.HMbuttonN);
            this.groupBox1.Controls.Add(this.ESTbuttonN);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigator";
            // 
            // ESTbuttonN
            // 
            this.ESTbuttonN.ForeColor = System.Drawing.Color.Black;
            this.ESTbuttonN.Location = new System.Drawing.Point(6, 89);
            this.ESTbuttonN.Name = "ESTbuttonN";
            this.ESTbuttonN.Size = new System.Drawing.Size(60, 60);
            this.ESTbuttonN.TabIndex = 0;
            this.ESTbuttonN.Text = "East";
            this.ESTbuttonN.UseVisualStyleBackColor = true;
            this.ESTbuttonN.Click += new System.EventHandler(this.ESTbuttonN_Click);
            // 
            // HMbuttonN
            // 
            this.HMbuttonN.ForeColor = System.Drawing.Color.Black;
            this.HMbuttonN.Location = new System.Drawing.Point(78, 89);
            this.HMbuttonN.Name = "HMbuttonN";
            this.HMbuttonN.Size = new System.Drawing.Size(60, 60);
            this.HMbuttonN.TabIndex = 1;
            this.HMbuttonN.Text = "Home";
            this.HMbuttonN.UseVisualStyleBackColor = true;
            this.HMbuttonN.Click += new System.EventHandler(this.HMbuttonN_Click);
            // 
            // WSTbuttonN
            // 
            this.WSTbuttonN.ForeColor = System.Drawing.Color.Black;
            this.WSTbuttonN.Location = new System.Drawing.Point(153, 89);
            this.WSTbuttonN.Name = "WSTbuttonN";
            this.WSTbuttonN.Size = new System.Drawing.Size(60, 60);
            this.WSTbuttonN.TabIndex = 2;
            this.WSTbuttonN.Text = "West";
            this.WSTbuttonN.UseVisualStyleBackColor = true;
            this.WSTbuttonN.Click += new System.EventHandler(this.WSTbuttonN_Click);
            // 
            // STHbuttonN
            // 
            this.STHbuttonN.ForeColor = System.Drawing.Color.Black;
            this.STHbuttonN.Location = new System.Drawing.Point(78, 164);
            this.STHbuttonN.Name = "STHbuttonN";
            this.STHbuttonN.Size = new System.Drawing.Size(60, 60);
            this.STHbuttonN.TabIndex = 3;
            this.STHbuttonN.Text = "South";
            this.STHbuttonN.UseVisualStyleBackColor = true;
            this.STHbuttonN.Click += new System.EventHandler(this.STHbuttonN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1053, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "North Site Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SpaceX Housing on the moon";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 106);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // North
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "North";
            this.Text = "North Site";
            this.Load += new System.EventHandler(this.North_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HMbuttonN;
        private System.Windows.Forms.Button ESTbuttonN;
        private System.Windows.Forms.Button WSTbuttonN;
        private System.Windows.Forms.Button STHbuttonN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}