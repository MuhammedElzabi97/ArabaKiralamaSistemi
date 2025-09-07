namespace ArabaKiralamaSistemi
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnEkle = new Button();
            txtAracId = new TextBox();
            txtMarka = new TextBox();
            label2 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtYil = new TextBox();
            label4 = new Label();
            txtKilometre = new TextBox();
            label5 = new Label();
            txtGunlukKira = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtSirketID = new TextBox();
            label8 = new Label();
            txtYakiTipiId = new TextBox();
            label9 = new Label();
            btnSil = new Button();
            btnAra = new Button();
            button1 = new Button();
            txtYakitTipi = new TextBox();
            btnGuncelleme = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(895, 341);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1073, 30);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Arac ID:";
            label1.Click += label1_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(33, 468);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(175, 45);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAracId
            // 
            txtAracId.Location = new Point(1153, 30);
            txtAracId.Name = "txtAracId";
            txtAracId.Size = new Size(175, 31);
            txtAracId.TabIndex = 3;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(1153, 67);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(175, 31);
            txtMarka.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1077, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 4;
            label2.Text = "Marka :";
            label2.Click += label2_Click;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(1153, 104);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(175, 31);
            txtModel.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1075, 104);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 6;
            label3.Text = "Model :";
            // 
            // txtYil
            // 
            txtYil.Location = new Point(1153, 141);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(175, 31);
            txtYil.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1103, 141);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 8;
            label4.Text = "Yil : ";
            // 
            // txtKilometre
            // 
            txtKilometre.Location = new Point(1153, 178);
            txtKilometre.Name = "txtKilometre";
            txtKilometre.Size = new Size(175, 31);
            txtKilometre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1046, 178);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 10;
            label5.Text = "Kilometre : ";
            // 
            // txtGunlukKira
            // 
            txtGunlukKira.Location = new Point(1153, 215);
            txtGunlukKira.Name = "txtGunlukKira";
            txtGunlukKira.Size = new Size(175, 31);
            txtGunlukKira.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1037, 215);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 12;
            label6.Text = "Gunluk Kira :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1057, 252);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 14;
            label7.Text = "Yakit Tipi :";
            // 
            // txtSirketID
            // 
            txtSirketID.Location = new Point(1153, 289);
            txtSirketID.Name = "txtSirketID";
            txtSirketID.Size = new Size(175, 31);
            txtSirketID.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1059, 289);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 16;
            label8.Text = "Sirket ID :";
            label8.Click += label8_Click;
            // 
            // txtYakiTipiId
            // 
            txtYakiTipiId.Location = new Point(1153, 326);
            txtYakiTipiId.Name = "txtYakiTipiId";
            txtYakiTipiId.Size = new Size(175, 31);
            txtYakiTipiId.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1034, 326);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 18;
            label9.Text = "Yakit Tipi ID :";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(256, 468);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(175, 45);
            btnSil.TabIndex = 20;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += button2_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(492, 468);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(175, 45);
            btnAra.TabIndex = 21;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // button1
            // 
            button1.Location = new Point(935, 468);
            button1.Name = "button1";
            button1.Size = new Size(175, 45);
            button1.TabIndex = 22;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtYakitTipi
            // 
            txtYakitTipi.Location = new Point(1153, 252);
            txtYakitTipi.Name = "txtYakitTipi";
            txtYakitTipi.Size = new Size(175, 31);
            txtYakitTipi.TabIndex = 23;
            // 
            // btnGuncelleme
            // 
            btnGuncelleme.Location = new Point(717, 468);
            btnGuncelleme.Name = "btnGuncelleme";
            btnGuncelleme.Size = new Size(175, 45);
            btnGuncelleme.TabIndex = 24;
            btnGuncelleme.Text = "Guncelleme";
            btnGuncelleme.UseVisualStyleBackColor = true;
            btnGuncelleme.Click += btnGuncelleme_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1153, 468);
            button2.Name = "button2";
            button2.Size = new Size(175, 45);
            button2.TabIndex = 25;
            button2.Text = "Cikis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 557);
            Controls.Add(button2);
            Controls.Add(btnGuncelleme);
            Controls.Add(txtYakitTipi);
            Controls.Add(button1);
            Controls.Add(btnAra);
            Controls.Add(btnSil);
            Controls.Add(txtYakiTipiId);
            Controls.Add(label9);
            Controls.Add(txtSirketID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtGunlukKira);
            Controls.Add(label6);
            Controls.Add(txtKilometre);
            Controls.Add(label5);
            Controls.Add(txtYil);
            Controls.Add(label4);
            Controls.Add(txtModel);
            Controls.Add(label3);
            Controls.Add(txtMarka);
            Controls.Add(label2);
            Controls.Add(txtAracId);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "-";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEkle;
        private TextBox txtAracId;
        private TextBox txtMarka;
        private Label label2;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtYil;
        private Label label4;
        private TextBox txtKilometre;
        private Label label5;
        private TextBox txtGunlukKira;
        private Label label6;
        private Label label7;
        private TextBox txtSirketID;
        private Label label8;
        private TextBox txtYakiTipiId;
        private Label label9;
        private Button btnSil;
        private Button btnAra;
        private Button button1;
        private TextBox txtYakitTipi;
        private Button btnGuncelleme;
        private Button button2;
    }
}