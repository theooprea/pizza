﻿namespace pizza
{
    partial class Form1
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
            this.pizzas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pizzacurenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pizzas
            // 
            this.pizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzas.FormattingEnabled = true;
            this.pizzas.ItemHeight = 38;
            this.pizzas.Items.AddRange(new object[] {
            "Quatro Stagionni",
            "Quatro Formaggi",
            "Hawaii",
            "Diavola"});
            this.pizzas.Location = new System.Drawing.Point(77, 35);
            this.pizzas.Name = "pizzas";
            this.pizzas.Size = new System.Drawing.Size(278, 156);
            this.pizzas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afiseaza detalii";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pizzacurenta
            // 
            this.pizzacurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzacurenta.Location = new System.Drawing.Point(840, 35);
            this.pizzacurenta.Multiline = true;
            this.pizzacurenta.Name = "pizzacurenta";
            this.pizzacurenta.Size = new System.Drawing.Size(384, 156);
            this.pizzacurenta.TabIndex = 2;
            this.pizzacurenta.Text = "Detalii";
            this.pizzacurenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 626);
            this.Controls.Add(this.pizzacurenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pizzas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pizzas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pizzacurenta;
    }
}

