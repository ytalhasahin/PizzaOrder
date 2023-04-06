namespace _6_FrmApp6
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.gbMalzeme = new System.Windows.Forms.GroupBox();
            this.checkKasar = new System.Windows.Forms.CheckBox();
            this.checkZeytin = new System.Windows.Forms.CheckBox();
            this.checkMantar = new System.Windows.Forms.CheckBox();
            this.gbSoğanlı = new System.Windows.Forms.GroupBox();
            this.rbSogansiz = new System.Windows.Forms.RadioButton();
            this.rbSoganli = new System.Windows.Forms.RadioButton();
            this.rich = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbMalzeme.SuspendLayout();
            this.gbSoğanlı.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZA SİPARİŞİ";
            // 
            // cbPizza
            // 
            this.cbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Küçük Boy Pizza",
            "Orta Boy Pizza",
            "Büyük Boy Pizza"});
            this.cbPizza.Location = new System.Drawing.Point(19, 64);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(127, 21);
            this.cbPizza.TabIndex = 1;
            // 
            // gbMalzeme
            // 
            this.gbMalzeme.Controls.Add(this.checkKasar);
            this.gbMalzeme.Controls.Add(this.checkZeytin);
            this.gbMalzeme.Controls.Add(this.checkMantar);
            this.gbMalzeme.Location = new System.Drawing.Point(21, 105);
            this.gbMalzeme.Name = "gbMalzeme";
            this.gbMalzeme.Size = new System.Drawing.Size(156, 126);
            this.gbMalzeme.TabIndex = 2;
            this.gbMalzeme.TabStop = false;
            this.gbMalzeme.Text = "Malzemeler";
            // 
            // checkKasar
            // 
            this.checkKasar.AutoSize = true;
            this.checkKasar.Location = new System.Drawing.Point(14, 71);
            this.checkKasar.Name = "checkKasar";
            this.checkKasar.Size = new System.Drawing.Size(87, 17);
            this.checkKasar.TabIndex = 0;
            this.checkKasar.Text = "Kaşar Peyniri";
            this.checkKasar.UseVisualStyleBackColor = true;
            // 
            // checkZeytin
            // 
            this.checkZeytin.AutoSize = true;
            this.checkZeytin.Location = new System.Drawing.Point(14, 48);
            this.checkZeytin.Name = "checkZeytin";
            this.checkZeytin.Size = new System.Drawing.Size(55, 17);
            this.checkZeytin.TabIndex = 0;
            this.checkZeytin.Text = "Zeytin";
            this.checkZeytin.UseVisualStyleBackColor = true;
            // 
            // checkMantar
            // 
            this.checkMantar.AutoSize = true;
            this.checkMantar.Location = new System.Drawing.Point(14, 25);
            this.checkMantar.Name = "checkMantar";
            this.checkMantar.Size = new System.Drawing.Size(59, 17);
            this.checkMantar.TabIndex = 0;
            this.checkMantar.Text = "Mantar";
            this.checkMantar.UseVisualStyleBackColor = true;
            // 
            // gbSoğanlı
            // 
            this.gbSoğanlı.Controls.Add(this.rbSogansiz);
            this.gbSoğanlı.Controls.Add(this.rbSoganli);
            this.gbSoğanlı.Location = new System.Drawing.Point(183, 105);
            this.gbSoğanlı.Name = "gbSoğanlı";
            this.gbSoğanlı.Size = new System.Drawing.Size(156, 126);
            this.gbSoğanlı.TabIndex = 2;
            this.gbSoğanlı.TabStop = false;
            this.gbSoğanlı.Text = "Soğan Durumu";
            // 
            // rbSogansiz
            // 
            this.rbSogansiz.AutoSize = true;
            this.rbSogansiz.Location = new System.Drawing.Point(15, 47);
            this.rbSogansiz.Name = "rbSogansiz";
            this.rbSogansiz.Size = new System.Drawing.Size(68, 17);
            this.rbSogansiz.TabIndex = 0;
            this.rbSogansiz.TabStop = true;
            this.rbSogansiz.Text = "Soğansız";
            this.rbSogansiz.UseVisualStyleBackColor = true;
            // 
            // rbSoganli
            // 
            this.rbSoganli.AutoSize = true;
            this.rbSoganli.Location = new System.Drawing.Point(15, 25);
            this.rbSoganli.Name = "rbSoganli";
            this.rbSoganli.Size = new System.Drawing.Size(60, 17);
            this.rbSoganli.TabIndex = 0;
            this.rbSoganli.TabStop = true;
            this.rbSoganli.Text = "Soğanlı";
            this.rbSoganli.UseVisualStyleBackColor = true;
            // 
            // rich
            // 
            this.rich.Location = new System.Drawing.Point(19, 281);
            this.rich.Name = "rich";
            this.rich.Size = new System.Drawing.Size(320, 135);
            this.rich.TabIndex = 3;
            this.rich.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rich);
            this.Controls.Add(this.gbSoğanlı);
            this.Controls.Add(this.gbMalzeme);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Sipariş";
            this.gbMalzeme.ResumeLayout(false);
            this.gbMalzeme.PerformLayout();
            this.gbSoğanlı.ResumeLayout(false);
            this.gbSoğanlı.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.GroupBox gbMalzeme;
        private System.Windows.Forms.CheckBox checkKasar;
        private System.Windows.Forms.CheckBox checkZeytin;
        private System.Windows.Forms.CheckBox checkMantar;
        private System.Windows.Forms.GroupBox gbSoğanlı;
        private System.Windows.Forms.RadioButton rbSogansiz;
        private System.Windows.Forms.RadioButton rbSoganli;
        private System.Windows.Forms.RichTextBox rich;
        private System.Windows.Forms.Button btnSave;
    }
}

