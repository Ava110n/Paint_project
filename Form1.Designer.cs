namespace Paint_3._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfill = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnrect = new System.Windows.Forms.Button();
            this.btnellipse = new System.Windows.Forms.Button();
            this.btneraser = new System.Windows.Forms.Button();
            this.btnpen = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.btncolor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btncolor);
            this.panel1.Controls.Add(this.btnfill);
            this.panel1.Controls.Add(this.btnline);
            this.panel1.Controls.Add(this.btnrect);
            this.panel1.Controls.Add(this.btnellipse);
            this.panel1.Controls.Add(this.btneraser);
            this.panel1.Controls.Add(this.btnpen);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnfill
            // 
            this.btnfill.Location = new System.Drawing.Point(427, 12);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(75, 46);
            this.btnfill.TabIndex = 5;
            this.btnfill.Text = "подливка";
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // btnline
            // 
            this.btnline.Location = new System.Drawing.Point(343, 12);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(57, 46);
            this.btnline.TabIndex = 4;
            this.btnline.Text = "лизочко";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnrect
            // 
            this.btnrect.Location = new System.Drawing.Point(256, 12);
            this.btnrect.Name = "btnrect";
            this.btnrect.Size = new System.Drawing.Size(57, 46);
            this.btnrect.TabIndex = 3;
            this.btnrect.Text = "ректальный";
            this.btnrect.UseVisualStyleBackColor = true;
            this.btnrect.Click += new System.EventHandler(this.btnrect_Click);
            // 
            // btnellipse
            // 
            this.btnellipse.Location = new System.Drawing.Point(176, 14);
            this.btnellipse.Name = "btnellipse";
            this.btnellipse.Size = new System.Drawing.Size(49, 46);
            this.btnellipse.TabIndex = 2;
            this.btnellipse.Text = "козлина";
            this.btnellipse.UseVisualStyleBackColor = true;
            this.btnellipse.Click += new System.EventHandler(this.btnellipse_Click);
            // 
            // btneraser
            // 
            this.btneraser.Location = new System.Drawing.Point(99, 14);
            this.btneraser.Name = "btneraser";
            this.btneraser.Size = new System.Drawing.Size(49, 46);
            this.btneraser.TabIndex = 1;
            this.btneraser.Text = "jopa";
            this.btneraser.UseVisualStyleBackColor = true;
            this.btneraser.Click += new System.EventHandler(this.btneraser_Click);
            // 
            // btnpen
            // 
            this.btnpen.Location = new System.Drawing.Point(27, 12);
            this.btnpen.Name = "btnpen";
            this.btnpen.Size = new System.Drawing.Size(49, 46);
            this.btnpen.TabIndex = 0;
            this.btnpen.Text = "penis";
            this.btnpen.UseVisualStyleBackColor = true;
            this.btnpen.Click += new System.EventHandler(this.btnpen_Click);
            // 
            // Pic
            // 
            this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic.Location = new System.Drawing.Point(0, 79);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(798, 369);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(692, 5);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(96, 61);
            this.btncolor.TabIndex = 6;
            this.btncolor.Text = "кал";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "paint...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnpen;
        private PictureBox Pic;
        private Button btneraser;
        private Button btnellipse;
        private Button btnrect;
        private Button btnline;
        private Button btnfill;
        private Button btncolor;
    }
}