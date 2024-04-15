namespace EvidenceKlicu.Okna;

partial class VychoziOknoZamestnanec
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
		textBoxJmeno = new TextBox();
		textBoxPrijmeni = new TextBox();
		textBoxZkratka = new TextBox();
		buttonZavrit = new Button();
		buttonOk = new Button();
		tabulkaKlice = new DataGridView();
		IdKlice = new DataGridViewTextBoxColumn();
		NazevMistnosti = new DataGridViewTextBoxColumn();
		OznaceniDveri = new DataGridViewTextBoxColumn();
		Stav = new DataGridViewTextBoxColumn();
		Zapujcit = new DataGridViewTextBoxColumn();
		Vratit = new DataGridViewTextBoxColumn();
		groupBox1 = new GroupBox();
		groupBox7 = new GroupBox();
		groupBox6 = new GroupBox();
		groupBox5 = new GroupBox();
		textBoxId = new TextBox();
		groupBox4 = new GroupBox();
		groupBox3 = new GroupBox();
		groupBox2 = new GroupBox();
		((System.ComponentModel.ISupportInitialize)tabulkaKlice).BeginInit();
		groupBox1.SuspendLayout();
		groupBox7.SuspendLayout();
		groupBox6.SuspendLayout();
		groupBox5.SuspendLayout();
		groupBox4.SuspendLayout();
		groupBox3.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// textBoxJmeno
		// 
		textBoxJmeno.Location = new Point(7, 22);
		textBoxJmeno.Margin = new Padding(4, 3, 4, 3);
		textBoxJmeno.Name = "textBoxJmeno";
		textBoxJmeno.Size = new Size(257, 23);
		textBoxJmeno.TabIndex = 1;
		// 
		// textBoxPrijmeni
		// 
		textBoxPrijmeni.Location = new Point(7, 22);
		textBoxPrijmeni.Margin = new Padding(4, 3, 4, 3);
		textBoxPrijmeni.Name = "textBoxPrijmeni";
		textBoxPrijmeni.Size = new Size(257, 23);
		textBoxPrijmeni.TabIndex = 3;
		// 
		// textBoxZkratka
		// 
		textBoxZkratka.Location = new Point(7, 22);
		textBoxZkratka.Margin = new Padding(4, 3, 4, 3);
		textBoxZkratka.Name = "textBoxZkratka";
		textBoxZkratka.Size = new Size(112, 23);
		textBoxZkratka.TabIndex = 5;
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
		// tabulkaKlice
		// 
		tabulkaKlice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		tabulkaKlice.Columns.AddRange(new DataGridViewColumn[] { IdKlice, NazevMistnosti, OznaceniDveri, Stav, Zapujcit, Vratit });
		tabulkaKlice.Location = new Point(6, 22);
		tabulkaKlice.Name = "tabulkaKlice";
		tabulkaKlice.RowTemplate.Height = 25;
		tabulkaKlice.Size = new Size(658, 239);
		tabulkaKlice.TabIndex = 8;
		// 
		// IdKlice
		// 
		IdKlice.HeaderText = "Id";
		IdKlice.Name = "IdKlice";
		IdKlice.ReadOnly = true;
		// 
		// NazevMistnosti
		// 
		NazevMistnosti.HeaderText = "Název místnosti";
		NazevMistnosti.Name = "NazevMistnosti";
		NazevMistnosti.ReadOnly = true;
		// 
		// OznaceniDveri
		// 
		OznaceniDveri.HeaderText = "OznaceniDveri";
		OznaceniDveri.Name = "OznaceniDveri";
		OznaceniDveri.ReadOnly = true;
		// 
		// Stav
		// 
		Stav.HeaderText = "Stav";
		Stav.Name = "Stav";
		Stav.ReadOnly = true;
		// 
		// Zapujcit
		// 
		Zapujcit.HeaderText = "Zapůjčit";
		Zapujcit.Name = "Zapujcit";
		// 
		// Vratit
		// 
		Vratit.HeaderText = "Vrátit";
		Vratit.Name = "Vratit";
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(groupBox7);
		groupBox1.Controls.Add(groupBox6);
		groupBox1.Controls.Add(groupBox5);
		groupBox1.Controls.Add(groupBox4);
		groupBox1.Controls.Add(groupBox3);
		groupBox1.Controls.Add(groupBox2);
		groupBox1.Location = new Point(12, 12);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(962, 297);
		groupBox1.TabIndex = 9;
		groupBox1.TabStop = false;
		groupBox1.Text = "Zaměstnanec";
		// 
		// groupBox7
		// 
		groupBox7.Controls.Add(tabulkaKlice);
		groupBox7.Location = new Point(287, 22);
		groupBox7.Name = "groupBox7";
		groupBox7.Size = new Size(669, 267);
		groupBox7.TabIndex = 7;
		groupBox7.TabStop = false;
		groupBox7.Text = "Zapůjčené klíče";
		// 
		// groupBox6
		// 
		groupBox6.Controls.Add(buttonOk);
		groupBox6.Controls.Add(buttonZavrit);
		groupBox6.Location = new Point(6, 208);
		groupBox6.Name = "groupBox6";
		groupBox6.Size = new Size(275, 81);
		groupBox6.TabIndex = 6;
		groupBox6.TabStop = false;
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
		textBoxId.Size = new Size(112, 23);
		textBoxId.TabIndex = 6;
		// 
		// groupBox4
		// 
		groupBox4.Controls.Add(textBoxZkratka);
		groupBox4.Location = new Point(151, 22);
		groupBox4.Name = "groupBox4";
		groupBox4.Size = new Size(130, 56);
		groupBox4.TabIndex = 4;
		groupBox4.TabStop = false;
		groupBox4.Text = "Zkratka";
		// 
		// groupBox3
		// 
		groupBox3.Controls.Add(textBoxPrijmeni);
		groupBox3.Location = new Point(6, 84);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new Size(275, 56);
		groupBox3.TabIndex = 2;
		groupBox3.TabStop = false;
		groupBox3.Text = "Příjmení";
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(textBoxJmeno);
		groupBox2.Location = new Point(6, 146);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(275, 56);
		groupBox2.TabIndex = 0;
		groupBox2.TabStop = false;
		groupBox2.Text = "Jméno";
		// 
		// VychoziOknoZamestnanec
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(979, 311);
		Controls.Add(groupBox1);
		Margin = new Padding(4, 3, 4, 3);
		MaximumSize = new Size(2000, 2000);
		Name = "VychoziOknoZamestnanec";
		Text = "OknoVychoziZamestnanec";
		((System.ComponentModel.ISupportInitialize)tabulkaKlice).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox7.ResumeLayout(false);
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
	protected TextBox textBoxJmeno;
    protected TextBox textBoxPrijmeni;
    protected TextBox textBoxZkratka;
    protected Button buttonZavrit;
    protected Button buttonOk;
	private GroupBox groupBox1;
	private GroupBox groupBox7;
	private GroupBox groupBox6;
	private GroupBox groupBox5;
	protected TextBox textBoxId;
	private GroupBox groupBox4;
	private GroupBox groupBox3;
	private GroupBox groupBox2;
	private DataGridViewTextBoxColumn IdKlice;
	private DataGridViewTextBoxColumn NazevMistnosti;
	private DataGridViewTextBoxColumn OznaceniDveri;
	private DataGridViewTextBoxColumn Stav;
	private DataGridViewTextBoxColumn Zapujcit;
	private DataGridViewTextBoxColumn Vratit;
	protected DataGridView tabulkaKlice;
}