
namespace LineDrawing
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btn_dda = new System.Windows.Forms.Button();
            this.btn_bresenham = new System.Windows.Forms.Button();
            this.txt_start_x = new System.Windows.Forms.TextBox();
            this.txt_start_y = new System.Windows.Forms.TextBox();
            this.txt_end_x = new System.Windows.Forms.TextBox();
            this.txt_end_y = new System.Windows.Forms.TextBox();
            this.lbl_start_point = new System.Windows.Forms.Label();
            this.lbl_ending_point = new System.Windows.Forms.Label();
            this.lbl_width_holder = new System.Windows.Forms.Label();
            this.lbl_height_holder = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(525, 506);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // btn_dda
            // 
            this.btn_dda.Location = new System.Drawing.Point(545, 136);
            this.btn_dda.Name = "btn_dda";
            this.btn_dda.Size = new System.Drawing.Size(85, 23);
            this.btn_dda.TabIndex = 1;
            this.btn_dda.Text = "DDA";
            this.btn_dda.UseVisualStyleBackColor = true;
            this.btn_dda.Click += new System.EventHandler(this.btn_dda_Click);
            // 
            // btn_bresenham
            // 
            this.btn_bresenham.Location = new System.Drawing.Point(636, 136);
            this.btn_bresenham.Name = "btn_bresenham";
            this.btn_bresenham.Size = new System.Drawing.Size(86, 23);
            this.btn_bresenham.TabIndex = 2;
            this.btn_bresenham.Text = "Bresenham";
            this.btn_bresenham.UseVisualStyleBackColor = true;
            this.btn_bresenham.Click += new System.EventHandler(this.btn_bresenham_Click);
            // 
            // txt_start_x
            // 
            this.txt_start_x.Location = new System.Drawing.Point(544, 36);
            this.txt_start_x.Name = "txt_start_x";
            this.txt_start_x.Size = new System.Drawing.Size(86, 23);
            this.txt_start_x.TabIndex = 3;
            // 
            // txt_start_y
            // 
            this.txt_start_y.Location = new System.Drawing.Point(636, 36);
            this.txt_start_y.Name = "txt_start_y";
            this.txt_start_y.Size = new System.Drawing.Size(86, 23);
            this.txt_start_y.TabIndex = 4;
            // 
            // txt_end_x
            // 
            this.txt_end_x.Location = new System.Drawing.Point(545, 89);
            this.txt_end_x.Name = "txt_end_x";
            this.txt_end_x.Size = new System.Drawing.Size(86, 23);
            this.txt_end_x.TabIndex = 5;
            // 
            // txt_end_y
            // 
            this.txt_end_y.Location = new System.Drawing.Point(637, 89);
            this.txt_end_y.Name = "txt_end_y";
            this.txt_end_y.Size = new System.Drawing.Size(86, 23);
            this.txt_end_y.TabIndex = 6;
            // 
            // lbl_start_point
            // 
            this.lbl_start_point.AutoSize = true;
            this.lbl_start_point.Location = new System.Drawing.Point(545, 15);
            this.lbl_start_point.Name = "lbl_start_point";
            this.lbl_start_point.Size = new System.Drawing.Size(79, 15);
            this.lbl_start_point.TabIndex = 7;
            this.lbl_start_point.Text = "Starting Point";
            // 
            // lbl_ending_point
            // 
            this.lbl_ending_point.AutoSize = true;
            this.lbl_ending_point.Location = new System.Drawing.Point(544, 71);
            this.lbl_ending_point.Name = "lbl_ending_point";
            this.lbl_ending_point.Size = new System.Drawing.Size(75, 15);
            this.lbl_ending_point.TabIndex = 8;
            this.lbl_ending_point.Text = "Ending Point";
            // 
            // lbl_width_holder
            // 
            this.lbl_width_holder.AutoSize = true;
            this.lbl_width_holder.Location = new System.Drawing.Point(549, 185);
            this.lbl_width_holder.Name = "lbl_width_holder";
            this.lbl_width_holder.Size = new System.Drawing.Size(45, 15);
            this.lbl_width_holder.TabIndex = 9;
            this.lbl_width_holder.Text = "Width :";
            this.lbl_width_holder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_height_holder
            // 
            this.lbl_height_holder.AutoSize = true;
            this.lbl_height_holder.Location = new System.Drawing.Point(545, 212);
            this.lbl_height_holder.Name = "lbl_height_holder";
            this.lbl_height_holder.Size = new System.Drawing.Size(49, 15);
            this.lbl_height_holder.TabIndex = 10;
            this.lbl_height_holder.Text = "Height :";
            this.lbl_height_holder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(600, 185);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(45, 15);
            this.lbl_width.TabIndex = 11;
            this.lbl_width.Text = "Not set";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(600, 212);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(45, 15);
            this.lbl_height.TabIndex = 12;
            this.lbl_height.Text = "Not set";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 531);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.lbl_height_holder);
            this.Controls.Add(this.lbl_width_holder);
            this.Controls.Add(this.lbl_ending_point);
            this.Controls.Add(this.lbl_start_point);
            this.Controls.Add(this.txt_end_y);
            this.Controls.Add(this.txt_end_x);
            this.Controls.Add(this.txt_start_y);
            this.Controls.Add(this.txt_start_x);
            this.Controls.Add(this.btn_bresenham);
            this.Controls.Add(this.btn_dda);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btn_dda;
        private System.Windows.Forms.Button btn_bresenham;
        private System.Windows.Forms.TextBox txt_start_x;
        private System.Windows.Forms.TextBox txt_start_y;
        private System.Windows.Forms.TextBox txt_end_x;
        private System.Windows.Forms.TextBox txt_end_y;
        private System.Windows.Forms.Label lbl_start_point;
        private System.Windows.Forms.Label lbl_ending_point;
        private System.Windows.Forms.Label lbl_width_holder;
        private System.Windows.Forms.Label lbl_height_holder;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_height;
    }
}

