namespace PcPartFinder
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
            this.button1 = new System.Windows.Forms.Button();
            this.mb_textBox = new System.Windows.Forms.TextBox();
            this.mb_label = new System.Windows.Forms.Label();
            this.gpu_label = new System.Windows.Forms.Label();
            this.gpu_textBox = new System.Windows.Forms.TextBox();
            this.ram_label = new System.Windows.Forms.Label();
            this.ram_textBox = new System.Windows.Forms.TextBox();
            this.cpu_label = new System.Windows.Forms.Label();
            this.cpu_textBox = new System.Windows.Forms.TextBox();
            this.wil_label = new System.Windows.Forms.Label();
            this.wil_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get The Parts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mb_textBox
            // 
            this.mb_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.mb_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mb_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mb_textBox.ForeColor = System.Drawing.Color.White;
            this.mb_textBox.Location = new System.Drawing.Point(12, 160);
            this.mb_textBox.Name = "mb_textBox";
            this.mb_textBox.ReadOnly = true;
            this.mb_textBox.Size = new System.Drawing.Size(457, 27);
            this.mb_textBox.TabIndex = 1;
            // 
            // mb_label
            // 
            this.mb_label.AutoSize = true;
            this.mb_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mb_label.ForeColor = System.Drawing.Color.White;
            this.mb_label.Location = new System.Drawing.Point(12, 136);
            this.mb_label.Name = "mb_label";
            this.mb_label.Size = new System.Drawing.Size(102, 21);
            this.mb_label.TabIndex = 2;
            this.mb_label.Text = "Motherboard";
            // 
            // gpu_label
            // 
            this.gpu_label.AutoSize = true;
            this.gpu_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_label.ForeColor = System.Drawing.Color.White;
            this.gpu_label.Location = new System.Drawing.Point(12, 195);
            this.gpu_label.Name = "gpu_label";
            this.gpu_label.Size = new System.Drawing.Size(108, 21);
            this.gpu_label.TabIndex = 4;
            this.gpu_label.Text = "Graphics Card";
            // 
            // gpu_textBox
            // 
            this.gpu_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.gpu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpu_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_textBox.ForeColor = System.Drawing.Color.White;
            this.gpu_textBox.Location = new System.Drawing.Point(12, 219);
            this.gpu_textBox.Name = "gpu_textBox";
            this.gpu_textBox.ReadOnly = true;
            this.gpu_textBox.Size = new System.Drawing.Size(457, 27);
            this.gpu_textBox.TabIndex = 3;
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ram_label.ForeColor = System.Drawing.Color.White;
            this.ram_label.Location = new System.Drawing.Point(12, 254);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(230, 21);
            this.ram_label.TabIndex = 6;
            this.ram_label.Text = "Random Access Memory (RAM)";
            // 
            // ram_textBox
            // 
            this.ram_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.ram_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ram_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ram_textBox.ForeColor = System.Drawing.Color.White;
            this.ram_textBox.Location = new System.Drawing.Point(12, 278);
            this.ram_textBox.Name = "ram_textBox";
            this.ram_textBox.ReadOnly = true;
            this.ram_textBox.Size = new System.Drawing.Size(457, 27);
            this.ram_textBox.TabIndex = 5;
            // 
            // cpu_label
            // 
            this.cpu_label.AutoSize = true;
            this.cpu_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_label.ForeColor = System.Drawing.Color.White;
            this.cpu_label.Location = new System.Drawing.Point(12, 77);
            this.cpu_label.Name = "cpu_label";
            this.cpu_label.Size = new System.Drawing.Size(40, 21);
            this.cpu_label.TabIndex = 8;
            this.cpu_label.Text = "CPU";
            // 
            // cpu_textBox
            // 
            this.cpu_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.cpu_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpu_textBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_textBox.ForeColor = System.Drawing.Color.White;
            this.cpu_textBox.Location = new System.Drawing.Point(12, 101);
            this.cpu_textBox.Name = "cpu_textBox";
            this.cpu_textBox.ReadOnly = true;
            this.cpu_textBox.Size = new System.Drawing.Size(457, 27);
            this.cpu_textBox.TabIndex = 7;
            // 
            // wil_label
            // 
            this.wil_label.AutoSize = true;
            this.wil_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wil_label.ForeColor = System.Drawing.Color.White;
            this.wil_label.Location = new System.Drawing.Point(12, 313);
            this.wil_label.Name = "wil_label";
            this.wil_label.Size = new System.Drawing.Size(183, 21);
            this.wil_label.TabIndex = 10;
            this.wil_label.Text = "Windows Install Location";
            // 
            // wil_textbox
            // 
            this.wil_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.wil_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wil_textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wil_textbox.ForeColor = System.Drawing.Color.White;
            this.wil_textbox.Location = new System.Drawing.Point(12, 338);
            this.wil_textbox.Name = "wil_textbox";
            this.wil_textbox.ReadOnly = true;
            this.wil_textbox.Size = new System.Drawing.Size(457, 27);
            this.wil_textbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(481, 380);
            this.Controls.Add(this.wil_label);
            this.Controls.Add(this.wil_textbox);
            this.Controls.Add(this.cpu_label);
            this.Controls.Add(this.cpu_textBox);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.ram_textBox);
            this.Controls.Add(this.gpu_label);
            this.Controls.Add(this.gpu_textBox);
            this.Controls.Add(this.mb_label);
            this.Controls.Add(this.mb_textBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PcPartFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox mb_textBox;
        private Label mb_label;
        private Label gpu_label;
        private TextBox gpu_textBox;
        private Label ram_label;
        private TextBox ram_textBox;
        private Label cpu_label;
        private TextBox cpu_textBox;
        private Label wil_label;
        private TextBox wil_textbox;
    }
}