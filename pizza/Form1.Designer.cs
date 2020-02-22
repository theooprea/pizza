namespace pizza
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
            this.button2 = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.TextBox();
            this.pretcurent = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ofertazilei = new System.Windows.Forms.TextBox();
            this.pretredus = new System.Windows.Forms.TextBox();
            this.testbox = new System.Windows.Forms.TextBox();
            this.testbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pizzas
            // 
            this.pizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzas.FormattingEnabled = true;
            this.pizzas.ItemHeight = 31;
            this.pizzas.Items.AddRange(new object[] {
            "Quatro Stagionni",
            "Quatro Formaggi",
            "Afluente",
            "Diavola",
            "Suprema",
            "Colosseum"});
            this.pizzas.Location = new System.Drawing.Point(77, 35);
            this.pizzas.Name = "pizzas";
            this.pizzas.Size = new System.Drawing.Size(278, 221);
            this.pizzas.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(526, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afiseaza detalii";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pizzacurenta
            // 
            this.pizzacurenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzacurenta.Location = new System.Drawing.Point(840, 35);
            this.pizzacurenta.Multiline = true;
            this.pizzacurenta.Name = "pizzacurenta";
            this.pizzacurenta.Size = new System.Drawing.Size(384, 221);
            this.pizzacurenta.TabIndex = 2;
            this.pizzacurenta.Text = "Detalii";
            this.pizzacurenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(526, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Adauga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(77, 317);
            this.order.Multiline = true;
            this.order.Name = "order";
            this.order.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.order.Size = new System.Drawing.Size(278, 164);
            this.order.TabIndex = 4;
            // 
            // pretcurent
            // 
            this.pretcurent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretcurent.Location = new System.Drawing.Point(480, 317);
            this.pretcurent.Name = "pretcurent";
            this.pretcurent.Size = new System.Drawing.Size(290, 34);
            this.pretcurent.TabIndex = 5;
            this.pretcurent.Text = "Pret neredus: 0 lei";
            this.pretcurent.TextChanged += new System.EventHandler(this.pretcurent_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(526, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 74);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sterge comanda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ofertazilei
            // 
            this.ofertazilei.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ofertazilei.Location = new System.Drawing.Point(480, 397);
            this.ofertazilei.Multiline = true;
            this.ofertazilei.Name = "ofertazilei";
            this.ofertazilei.Size = new System.Drawing.Size(290, 84);
            this.ofertazilei.TabIndex = 7;
            this.ofertazilei.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pretredus
            // 
            this.pretredus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretredus.Location = new System.Drawing.Point(480, 357);
            this.pretredus.Name = "pretredus";
            this.pretredus.Size = new System.Drawing.Size(290, 34);
            this.pretredus.TabIndex = 8;
            this.pretredus.Text = "Pret redus: 0 lei";
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(840, 317);
            this.testbox.Multiline = true;
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(384, 74);
            this.testbox.TabIndex = 9;
            // 
            // testbox2
            // 
            this.testbox2.Location = new System.Drawing.Point(840, 407);
            this.testbox2.Multiline = true;
            this.testbox2.Name = "testbox2";
            this.testbox2.Size = new System.Drawing.Size(384, 74);
            this.testbox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 626);
            this.Controls.Add(this.testbox2);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.pretredus);
            this.Controls.Add(this.ofertazilei);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pretcurent);
            this.Controls.Add(this.order);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox order;
        private System.Windows.Forms.TextBox pretcurent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ofertazilei;
        private System.Windows.Forms.TextBox pretredus;
        private System.Windows.Forms.TextBox testbox;
        private System.Windows.Forms.TextBox testbox2;
    }
}

