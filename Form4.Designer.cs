namespace FormAppYUO
{
    partial class Form4
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
            this.Hangisinden = new System.Windows.Forms.ComboBox();
            this.Hangisine = new System.Windows.Forms.ComboBox();
            this.Girilen = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hangisinden
            // 
            this.Hangisinden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hangisinden.FormattingEnabled = true;
            this.Hangisinden.Items.AddRange(new object[] {
            "C",
            "F",
            "K",
            "R"});
            this.Hangisinden.Location = new System.Drawing.Point(54, 198);
            this.Hangisinden.Name = "Hangisinden";
            this.Hangisinden.Size = new System.Drawing.Size(151, 28);
            this.Hangisinden.TabIndex = 1;
            this.Hangisinden.SelectedIndexChanged += new System.EventHandler(this.Hangisinden_SelectedIndexChanged);
            // 
            // Hangisine
            // 
            this.Hangisine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hangisine.FormattingEnabled = true;
            this.Hangisine.Items.AddRange(new object[] {
            "C",
            "F",
            "K",
            "R"});
            this.Hangisine.Location = new System.Drawing.Point(54, 266);
            this.Hangisine.Name = "Hangisine";
            this.Hangisine.Size = new System.Drawing.Size(151, 28);
            this.Hangisine.TabIndex = 2;
            this.Hangisine.SelectedIndexChanged += new System.EventHandler(this.Hangisine_SelectedIndexChanged);
            // 
            // Girilen
            // 
            this.Girilen.Location = new System.Drawing.Point(54, 130);
            this.Girilen.Name = "Girilen";
            this.Girilen.Size = new System.Drawing.Size(151, 27);
            this.Girilen.TabIndex = 0;
            this.Girilen.Text = "0";
            this.Girilen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Girilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Girilen_KeyDown);
            this.Girilen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Girilen_KeyPress);
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(59, 324);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(56, 20);
            this.Sonuc.TabIndex = 3;
            this.Sonuc.Text = "Sonuç: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Değer Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hangisinden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hangisine";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.Girilen);
            this.Controls.Add(this.Hangisine);
            this.Controls.Add(this.Hangisinden);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Hangisinden;
        private ComboBox Hangisine;
        private TextBox Girilen;
        private Label Sonuc;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}