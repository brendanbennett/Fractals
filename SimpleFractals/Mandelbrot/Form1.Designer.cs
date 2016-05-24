namespace Mandelbrot
{
    partial class Mandelbrot
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Iterations = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zoomLevelIn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.xPanIn = new System.Windows.Forms.TextBox();
            this.yPanIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Iterations
            // 
            this.Iterations.AcceptsReturn = true;
            this.Iterations.Location = new System.Drawing.Point(14, 451);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(48, 20);
            this.Iterations.TabIndex = 2;
            this.Iterations.Text = "10";
            this.Iterations.Enter += new System.EventHandler(this.Iterations_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iterations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zoom";
            // 
            // zoomLevelIn
            // 
            this.zoomLevelIn.Location = new System.Drawing.Point(72, 451);
            this.zoomLevelIn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.zoomLevelIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoomLevelIn.Name = "zoomLevelIn";
            this.zoomLevelIn.Size = new System.Drawing.Size(64, 20);
            this.zoomLevelIn.TabIndex = 6;
            this.zoomLevelIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X Pan";
            // 
            // xPanIn
            // 
            this.xPanIn.Location = new System.Drawing.Point(143, 451);
            this.xPanIn.Name = "xPanIn";
            this.xPanIn.Size = new System.Drawing.Size(61, 20);
            this.xPanIn.TabIndex = 8;
            this.xPanIn.Text = "0";
            // 
            // yPanIn
            // 
            this.yPanIn.Location = new System.Drawing.Point(210, 451);
            this.yPanIn.Name = "yPanIn";
            this.yPanIn.Size = new System.Drawing.Size(61, 20);
            this.yPanIn.TabIndex = 9;
            this.yPanIn.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y Pan";
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yPanIn);
            this.Controls.Add(this.xPanIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zoomLevelIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mandelbrot";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Iterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown zoomLevelIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xPanIn;
        private System.Windows.Forms.TextBox yPanIn;
        private System.Windows.Forms.Label label4;
    }
}

