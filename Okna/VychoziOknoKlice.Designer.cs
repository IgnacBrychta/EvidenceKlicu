namespace EvidenceKlicu.Okna
{
	partial class VychoziOknoKlice
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
			groupBox1 = new GroupBox();
			groupBox9 = new GroupBox();
			textBoxPocetDostupnych = new TextBox();
			groupBox8 = new GroupBox();
			textBoxCislo = new TextBox();
			groupBox7 = new GroupBox();
			tabulkaKlice = new DataGridView();
			IdZamestnance = new DataGridViewTextBoxColumn();
			Jmeno = new DataGridViewTextBoxColumn();
			Prijmeni = new DataGridViewTextBoxColumn();
			Zkratka = new DataGridViewTextBoxColumn();
			DatumVypujceni = new DataGridViewTextBoxColumn();
			DatumVraceni = new DataGridViewTextBoxColumn();
			groupBox6 = new GroupBox();
			buttonOk = new Button();
			buttonZavrit = new Button();
			groupBox5 = new GroupBox();
			textBoxId = new TextBox();
			groupBox4 = new GroupBox();
			textBoxPocetKusu = new TextBox();
			groupBox3 = new GroupBox();
			textBoxNazevMistnosti = new TextBox();
			groupBox2 = new GroupBox();
			textBoxOznaceniDveri = new TextBox();
			groupBox1.SuspendLayout();
			groupBox9.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tabulkaKlice).BeginInit();
			groupBox6.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox9);
			groupBox1.Controls.Add(groupBox8);
			groupBox1.Controls.Add(groupBox7);
			groupBox1.Controls.Add(groupBox6);
			groupBox1.Controls.Add(groupBox5);
			groupBox1.Controls.Add(groupBox4);
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(866, 356);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Klíč";
			// 
			// groupBox9
			// 
			groupBox9.Controls.Add(textBoxPocetDostupnych);
			groupBox9.Location = new Point(151, 84);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(130, 56);
			groupBox9.TabIndex = 6;
			groupBox9.TabStop = false;
			groupBox9.Text = "Počet dostupných";
			// 
			// textBoxPocetDostupnych
			// 
			textBoxPocetDostupnych.Location = new Point(7, 22);
			textBoxPocetDostupnych.Margin = new Padding(4, 3, 4, 3);
			textBoxPocetDostupnych.Name = "textBoxPocetDostupnych";
			textBoxPocetDostupnych.Size = new Size(85, 23);
			textBoxPocetDostupnych.TabIndex = 5;
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(textBoxCislo);
			groupBox8.Location = new Point(151, 22);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(130, 56);
			groupBox8.TabIndex = 7;
			groupBox8.TabStop = false;
			groupBox8.Text = "Číslo";
			// 
			// textBoxCislo
			// 
			textBoxCislo.Location = new Point(7, 22);
			textBoxCislo.Margin = new Padding(4, 3, 4, 3);
			textBoxCislo.Name = "textBoxCislo";
			textBoxCislo.Size = new Size(65, 23);
			textBoxCislo.TabIndex = 6;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(tabulkaKlice);
			groupBox7.Location = new Point(287, 22);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(569, 329);
			groupBox7.TabIndex = 7;
			groupBox7.TabStop = false;
			groupBox7.Text = "Zapůjčené klíče";
			// 
			// tabulkaKlice
			// 
			tabulkaKlice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			tabulkaKlice.Columns.AddRange(new DataGridViewColumn[] { IdZamestnance, Jmeno, Prijmeni, Zkratka, DatumVypujceni, DatumVraceni });
			tabulkaKlice.Location = new Point(6, 22);
			tabulkaKlice.Name = "tabulkaKlice";
			tabulkaKlice.RowTemplate.Height = 25;
			tabulkaKlice.Size = new Size(557, 301);
			tabulkaKlice.TabIndex = 8;
			// 
			// IdZamestnance
			// 
			IdZamestnance.HeaderText = "Id";
			IdZamestnance.Name = "IdZamestnance";
			IdZamestnance.ReadOnly = true;
			IdZamestnance.Width = 50;
			// 
			// Jmeno
			// 
			Jmeno.HeaderText = "Jméno";
			Jmeno.Name = "Jmeno";
			Jmeno.ReadOnly = true;
			Jmeno.Width = 50;
			// 
			// Prijmeni
			// 
			Prijmeni.HeaderText = "Příjmení";
			Prijmeni.Name = "Prijmeni";
			Prijmeni.ReadOnly = true;
			// 
			// Zkratka
			// 
			Zkratka.HeaderText = "Zkratka";
			Zkratka.Name = "Zkratka";
			Zkratka.ReadOnly = true;
			// 
			// DatumVypujceni
			// 
			DatumVypujceni.HeaderText = "Datum vypůjčení";
			DatumVypujceni.Name = "DatumVypujceni";
			DatumVypujceni.ReadOnly = true;
			// 
			// DatumVraceni
			// 
			DatumVraceni.HeaderText = "Datum vrácení";
			DatumVraceni.Name = "DatumVraceni";
			DatumVraceni.ReadOnly = true;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(buttonOk);
			groupBox6.Controls.Add(buttonZavrit);
			groupBox6.Location = new Point(6, 270);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(275, 81);
			groupBox6.TabIndex = 6;
			groupBox6.TabStop = false;
			// 
			// buttonOk
			// 
			buttonOk.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			buttonOk.Location = new Point(7, 22);
			buttonOk.Margin = new Padding(4, 3, 4, 3);
			buttonOk.Name = "buttonOk";
			buttonOk.Size = new Size(123, 53);
			buttonOk.TabIndex = 7;
			buttonOk.Text = "OK";
			buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonZavrit
			// 
			buttonZavrit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
			buttonZavrit.Location = new Point(145, 22);
			buttonZavrit.Margin = new Padding(4, 3, 4, 3);
			buttonZavrit.Name = "buttonZavrit";
			buttonZavrit.Size = new Size(123, 53);
			buttonZavrit.TabIndex = 6;
			buttonZavrit.Text = "Zahodit";
			buttonZavrit.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(textBoxId);
			groupBox5.Location = new Point(6, 22);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(130, 56);
			groupBox5.TabIndex = 5;
			groupBox5.TabStop = false;
			groupBox5.Text = "Id";
			// 
			// textBoxId
			// 
			textBoxId.Location = new Point(7, 22);
			textBoxId.Margin = new Padding(4, 3, 4, 3);
			textBoxId.Name = "textBoxId";
			textBoxId.ReadOnly = true;
			textBoxId.Size = new Size(56, 23);
			textBoxId.TabIndex = 6;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(textBoxPocetKusu);
			groupBox4.Location = new Point(6, 84);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(130, 56);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			groupBox4.Text = "Počet kusů celkem";
			// 
			// textBoxPocetKusu
			// 
			textBoxPocetKusu.Location = new Point(7, 22);
			textBoxPocetKusu.Margin = new Padding(4, 3, 4, 3);
			textBoxPocetKusu.Name = "textBoxPocetKusu";
			textBoxPocetKusu.Size = new Size(85, 23);
			textBoxPocetKusu.TabIndex = 5;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(textBoxNazevMistnosti);
			groupBox3.Location = new Point(6, 146);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(275, 56);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Název místnosti";
			// 
			// textBoxNazevMistnosti
			// 
			textBoxNazevMistnosti.Location = new Point(7, 22);
			textBoxNazevMistnosti.Margin = new Padding(4, 3, 4, 3);
			textBoxNazevMistnosti.Name = "textBoxNazevMistnosti";
			textBoxNazevMistnosti.Size = new Size(257, 23);
			textBoxNazevMistnosti.TabIndex = 3;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(textBoxOznaceniDveri);
			groupBox2.Location = new Point(6, 208);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(275, 56);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Označení dveří";
			// 
			// textBoxOznaceniDveri
			// 
			textBoxOznaceniDveri.Location = new Point(7, 22);
			textBoxOznaceniDveri.Margin = new Padding(4, 3, 4, 3);
			textBoxOznaceniDveri.Name = "textBoxOznaceniDveri";
			textBoxOznaceniDveri.Size = new Size(257, 23);
			textBoxOznaceniDveri.TabIndex = 1;
			// 
			// VychoziOknoKlice
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 374);
			Controls.Add(groupBox1);
			Name = "VychoziOknoKlice";
			Text = "VychoziOknoKlice";
			groupBox1.ResumeLayout(false);
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tabulkaKlice).EndInit();
			groupBox6.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox8;
		protected TextBox textBoxCislo;
		private GroupBox groupBox7;
		protected DataGridView tabulkaKlice;
		private DataGridViewTextBoxColumn IdZamestnance;
		private DataGridViewTextBoxColumn Jmeno;
		private DataGridViewTextBoxColumn Prijmeni;
		private DataGridViewTextBoxColumn Zkratka;
		private DataGridViewTextBoxColumn DatumVypujceni;
		private DataGridViewTextBoxColumn DatumVraceni;
		private GroupBox groupBox6;
		protected Button buttonOk;
		protected Button buttonZavrit;
		private GroupBox groupBox5;
		protected TextBox textBoxId;
		private GroupBox groupBox4;
		protected TextBox textBoxPocetKusu;
		private GroupBox groupBox3;
		protected TextBox textBoxNazevMistnosti;
		private GroupBox groupBox2;
		protected TextBox textBoxOznaceniDveri;
		private GroupBox groupBox9;
		protected TextBox textBoxPocetDostupnych;
	}
}