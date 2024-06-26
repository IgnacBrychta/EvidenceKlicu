﻿namespace EvidenceKlicu.Okna;

partial class OknoZamestnanci
{
	/// <summary>
	/// Vyžaduje se proměnná návrháře.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Uvolněte všechny používané prostředky.
	/// </summary>
	/// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Kód generovaný Návrhářem Windows Form

	/// <summary>
	/// Metoda vyžadovaná pro podporu Návrháře - neupravovat
	/// obsah této metody v editoru kódu.
	/// </summary>
	private void InitializeComponent()
	{
		tabulkaZamestnanci = new DataGridView();
		Id = new DataGridViewTextBoxColumn();
		Jmeno = new DataGridViewTextBoxColumn();
		Prijmeni = new DataGridViewTextBoxColumn();
		Zkratka = new DataGridViewTextBoxColumn();
		AkceUpravitZamestnance = new DataGridViewButtonColumn();
		AkceOdstranitZamestnance = new DataGridViewButtonColumn();
		menuStrip1 = new MenuStrip();
		pridatZamestnance = new ToolStripMenuItem();
		toolStripMenuItemNovyZamestnanec = new ToolStripMenuItem();
		toolStripMenuItemNovyKlic = new ToolStripMenuItem();
		tabulkaKlice = new DataGridView();
		groupBox1 = new GroupBox();
		groupBox2 = new GroupBox();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		Cislo = new DataGridViewTextBoxColumn();
		NazevMistnosti = new DataGridViewTextBoxColumn();
		OznaceniMistnosti = new DataGridViewTextBoxColumn();
		PocetKusu = new DataGridViewTextBoxColumn();
		PocetDostupnych = new DataGridViewTextBoxColumn();
		AkceUpravitKlic = new DataGridViewButtonColumn();
		AkceOdstranitKlic = new DataGridViewButtonColumn();
		((System.ComponentModel.ISupportInitialize)tabulkaZamestnanci).BeginInit();
		menuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)tabulkaKlice).BeginInit();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// tabulkaZamestnanci
		// 
		tabulkaZamestnanci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		tabulkaZamestnanci.Columns.AddRange(new DataGridViewColumn[] { Id, Jmeno, Prijmeni, Zkratka, AkceUpravitZamestnance, AkceOdstranitZamestnance });
		tabulkaZamestnanci.Location = new Point(7, 22);
		tabulkaZamestnanci.Margin = new Padding(4, 3, 4, 3);
		tabulkaZamestnanci.Name = "tabulkaZamestnanci";
		tabulkaZamestnanci.Size = new Size(644, 540);
		tabulkaZamestnanci.TabIndex = 0;
		// 
		// Id
		// 
		Id.HeaderText = "Id";
		Id.Name = "Id";
		Id.ReadOnly = true;
		// 
		// Jmeno
		// 
		Jmeno.HeaderText = "Jméno";
		Jmeno.Name = "Jmeno";
		Jmeno.ReadOnly = true;
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
		// AkceUpravitZamestnance
		// 
		AkceUpravitZamestnance.HeaderText = "Upravit";
		AkceUpravitZamestnance.Name = "AkceUpravitZamestnance";
		AkceUpravitZamestnance.ReadOnly = true;
		AkceUpravitZamestnance.Resizable = DataGridViewTriState.True;
		AkceUpravitZamestnance.SortMode = DataGridViewColumnSortMode.Automatic;
		AkceUpravitZamestnance.Text = "";
		// 
		// AkceOdstranitZamestnance
		// 
		AkceOdstranitZamestnance.HeaderText = " Odstranit";
		AkceOdstranitZamestnance.Name = "AkceOdstranitZamestnance";
		AkceOdstranitZamestnance.ReadOnly = true;
		AkceOdstranitZamestnance.Resizable = DataGridViewTriState.True;
		AkceOdstranitZamestnance.SortMode = DataGridViewColumnSortMode.Automatic;
		AkceOdstranitZamestnance.Text = "";
		// 
		// menuStrip1
		// 
		menuStrip1.Items.AddRange(new ToolStripItem[] { pridatZamestnance });
		menuStrip1.Location = new Point(0, 0);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.Padding = new Padding(7, 2, 0, 2);
		menuStrip1.Size = new Size(1561, 24);
		menuStrip1.TabIndex = 2;
		menuStrip1.Text = "menuStrip1";
		// 
		// pridatZamestnance
		// 
		pridatZamestnance.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNovyZamestnanec, toolStripMenuItemNovyKlic });
		pridatZamestnance.Name = "pridatZamestnance";
		pridatZamestnance.Size = new Size(59, 20);
		pridatZamestnance.Text = "Přidat...";
		// 
		// toolStripMenuItemNovyZamestnanec
		// 
		toolStripMenuItemNovyZamestnanec.Name = "toolStripMenuItemNovyZamestnanec";
		toolStripMenuItemNovyZamestnanec.Size = new Size(174, 22);
		toolStripMenuItemNovyZamestnanec.Text = "Nový zaměstnanec";
		// 
		// toolStripMenuItemNovyKlic
		// 
		toolStripMenuItemNovyKlic.Name = "toolStripMenuItemNovyKlic";
		toolStripMenuItemNovyKlic.Size = new Size(174, 22);
		toolStripMenuItemNovyKlic.Text = "Nový klíč";
		// 
		// tabulkaKlice
		// 
		tabulkaKlice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		tabulkaKlice.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Cislo, NazevMistnosti, OznaceniMistnosti, PocetKusu, PocetDostupnych, AkceUpravitKlic, AkceOdstranitKlic });
		tabulkaKlice.Location = new Point(7, 22);
		tabulkaKlice.Margin = new Padding(4, 3, 4, 3);
		tabulkaKlice.Name = "tabulkaKlice";
		tabulkaKlice.Size = new Size(853, 540);
		tabulkaKlice.TabIndex = 3;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(tabulkaZamestnanci);
		groupBox1.Location = new Point(12, 27);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(659, 564);
		groupBox1.TabIndex = 4;
		groupBox1.TabStop = false;
		groupBox1.Text = "Zaměstnanci";
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(tabulkaKlice);
		groupBox2.Location = new Point(677, 27);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(872, 545);
		groupBox2.TabIndex = 5;
		groupBox2.TabStop = false;
		groupBox2.Text = "Klíče";
		// 
		// dataGridViewTextBoxColumn1
		// 
		dataGridViewTextBoxColumn1.HeaderText = "Id";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.ReadOnly = true;
		// 
		// Cislo
		// 
		Cislo.HeaderText = "Cislo";
		Cislo.Name = "Cislo";
		Cislo.ReadOnly = true;
		// 
		// NazevMistnosti
		// 
		NazevMistnosti.HeaderText = "Název místnosti";
		NazevMistnosti.Name = "NazevMistnosti";
		NazevMistnosti.ReadOnly = true;
		// 
		// OznaceniMistnosti
		// 
		OznaceniMistnosti.HeaderText = "Označení místnosti";
		OznaceniMistnosti.Name = "OznaceniMistnosti";
		OznaceniMistnosti.ReadOnly = true;
		// 
		// PocetKusu
		// 
		PocetKusu.HeaderText = "Počet kusů";
		PocetKusu.Name = "PocetKusu";
		PocetKusu.ReadOnly = true;
		// 
		// PocetDostupnych
		// 
		PocetDostupnych.HeaderText = "Počet dostupných";
		PocetDostupnych.Name = "PocetDostupnych";
		PocetDostupnych.ReadOnly = true;
		// 
		// AkceUpravitKlic
		// 
		AkceUpravitKlic.HeaderText = "Upravit";
		AkceUpravitKlic.Name = "AkceUpravitKlic";
		AkceUpravitKlic.ReadOnly = true;
		AkceUpravitKlic.Resizable = DataGridViewTriState.True;
		AkceUpravitKlic.SortMode = DataGridViewColumnSortMode.Automatic;
		AkceUpravitKlic.Text = "";
		// 
		// AkceOdstranitKlic
		// 
		AkceOdstranitKlic.HeaderText = "Odstranit";
		AkceOdstranitKlic.Name = "AkceOdstranitKlic";
		AkceOdstranitKlic.ReadOnly = true;
		AkceOdstranitKlic.Resizable = DataGridViewTriState.True;
		AkceOdstranitKlic.SortMode = DataGridViewColumnSortMode.Automatic;
		AkceOdstranitKlic.Text = "";
		// 
		// OknoZamestnanci
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1561, 615);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Controls.Add(menuStrip1);
		MainMenuStrip = menuStrip1;
		Margin = new Padding(4, 3, 4, 3);
		Name = "OknoZamestnanci";
		Text = "Form1";
		((System.ComponentModel.ISupportInitialize)tabulkaZamestnanci).EndInit();
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)tabulkaKlice).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DataGridView tabulkaZamestnanci;
	private MenuStrip menuStrip1;
	private ToolStripMenuItem pridatZamestnance;
	private DataGridView tabulkaKlice;
	private GroupBox groupBox1;
	private GroupBox groupBox2;
	private DataGridViewTextBoxColumn Id;
	private DataGridViewTextBoxColumn Jmeno;
	private DataGridViewTextBoxColumn Prijmeni;
	private DataGridViewTextBoxColumn Zkratka;
	private DataGridViewButtonColumn AkceUpravitZamestnance;
	private DataGridViewButtonColumn AkceOdstranitZamestnance;
	private ToolStripMenuItem toolStripMenuItemNovyZamestnanec;
	private ToolStripMenuItem toolStripMenuItemNovyKlic;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	private DataGridViewTextBoxColumn Cislo;
	private DataGridViewTextBoxColumn NazevMistnosti;
	private DataGridViewTextBoxColumn OznaceniMistnosti;
	private DataGridViewTextBoxColumn PocetKusu;
	private DataGridViewTextBoxColumn PocetDostupnych;
	private DataGridViewButtonColumn AkceUpravitKlic;
	private DataGridViewButtonColumn AkceOdstranitKlic;
}

