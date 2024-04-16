using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class OknoZamestnanci : Form
{
	Database? database;
	public OknoZamestnanci()
	{
		InitializeComponent();
	}

	public OknoZamestnanci(object? _)
	{
		InitializeComponent();

		string connectionString = "Server=localhost;Integrated security=True";
		database = new Database(connectionString);
		if (!database.ExistujeDatabaze())
		{
			database.VytvoritDatabazi();
		}
		database.ZmenitPripojovaciRetezec("Initial Catalog=EvidenceKlicu;Integrated Security=True;Encrypt=False");
		if (database.ZjistitStavTabulkyKlice() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZamestnanci() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZaznamyVypujceni() != StavTabulky.Vporadku)
		{
			database.OpravitTabulky();
		}
		FormClosing += HlavniOkno_FormClosing;

		ObnovitTabulkuZamestnanci();
		ObnovitTabulkuKlice();
		tabulkaZamestnanci.CellContentClick += TabulkaZamestnanci_CellContentClick;
		tabulkaKlice.CellContentClick += TabulkaKlice_CellContentClick;

		toolStripMenuItemNovyZamestnanec.Click += ToolStripMenuItemNovyZamestnanec_Click;
		toolStripMenuItemNovyKlic.Click += ToolStripMenuItemNovyKlic_Click;

		Text = "Evidence klíčů zapůjčených zaměstnancům";
	}

	private void TabulkaKlice_CellContentClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.RowIndex >= tabulkaKlice.RowCount - 1 || e.ColumnIndex < 6) return;

		DataGridViewRow selectedRow = tabulkaKlice.Rows[e.RowIndex];
		int id = (int)selectedRow.Cells[indexId].Value;
		Klic? klic = database!.ZiskatKlic(id);
		if (klic is null) return;

		if (e.ColumnIndex == tabulkaKlice.Columns["AkceUpravitKlic"].Index)
		{
			var okno = new OknoUpravitKlic(database, klic);
			okno.ItemsChanged += ZmenaKlicu;
			okno.ShowDialog();
		}
		else if (e.ColumnIndex == tabulkaKlice.Columns["AkceOdstranitKlic"].Index)
		{
			DialogResult vysledek = MessageBox.Show(
				$"Opravdu si přejete smazat klíč {klic}?",
				"Jste si jistí?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question
				);
			if (vysledek == DialogResult.OK)
			{
				database.OdstranitKlic(klic);
				ObnovitTabulkuKlice();
			}
		}
	}

	private void ZmenaKlicu(object sender, EventArgs e)
	{
		ObnovitTabulkuKlice();
		ObnovitTabulkuZamestnanci();
	}

	private void ToolStripMenuItemNovyKlic_Click(object? sender, EventArgs e)
	{
		var okno = new OknoPridatKlic(database!);
		okno.ItemsChanged += ZmenaKlicu;
		okno.Show();
	}

	private void ToolStripMenuItemNovyZamestnanec_Click(object? sender, EventArgs e)
	{
		var okno = new OknoPridatZamestnance(database!);
		okno.ItemsChanged += ZmenaZamestnancu;
		okno.Show();
	}

	private void ZmenaZamestnancu(object sender, EventArgs e)
	{
		ObnovitTabulkuZamestnanci();
		ObnovitTabulkuKlice();
	}

	const int indexId = 0;
	private void ObnovitTabulkuZamestnanci()
	{
		tabulkaZamestnanci.Rows.Clear();
		IEnumerable<Zamestnanec> zamestnanci = database!.ZiskatVsechnyZamestnance();
		foreach (Zamestnanec item in zamestnanci)
		{
			DataGridViewRow radek = new DataGridViewRow();
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = item.Jmeno });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = item.Prijmeni });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = item.Zkratka });

			DataGridViewButtonCell tlacitkoUpravit = new DataGridViewButtonCell()
			{
				Value = "Upravit"
			};
			DataGridViewButtonCell tlacitkoSmazat = new DataGridViewButtonCell()
			{
				Value = "Odstranit"
			};
			radek.Cells.Add(tlacitkoUpravit);
			radek.Cells.Add(tlacitkoSmazat);

			tabulkaZamestnanci.Rows.Add(radek);
		}
	}

	private void TabulkaZamestnanci_CellContentClick(object? sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.RowIndex >= tabulkaZamestnanci.RowCount - 1) return;

		DataGridViewRow selectedRow = tabulkaZamestnanci.Rows[e.RowIndex];
		int id = (int)selectedRow.Cells[indexId].Value;
		Zamestnanec? zamestnanec = database!.ZiskatZamestnance(id);
		if (zamestnanec is null) return;

		if (e.ColumnIndex == tabulkaZamestnanci.Columns["AkceUpravitZamestnance"].Index)
		{
			var okno = new OknoUpravitZamestnance(database, zamestnanec);
			okno.ItemsChanged += ZmenaZamestnancu;
			okno.ShowDialog();
		}
		else if (e.ColumnIndex == tabulkaZamestnanci.Columns["AkceOdstranitZamestnance"].Index)
		{
			DialogResult vysledek = MessageBox.Show(
				$"Opravdu si přejete smazat zaměstnance {zamestnanec}?",
				"Jste si jistí?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question
				);
			if (vysledek == DialogResult.OK)
			{
				database.OdstranitZamestnance(zamestnanec);
				ObnovitTabulkuZamestnanci();
			}
		}
	}

	private void ObnovitTabulkuKlice()
	{
		tabulkaKlice.Rows.Clear();
		IEnumerable<Klic> klice = database!.ZiskatVsechnyKlice();
		foreach (Klic klic in klice)
		{
			DataGridViewRow radek = new DataGridViewRow();
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.Id });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.Cislo });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.NazevMistnosti });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.OznaceniDveri });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.PocetVyrobenychKusu });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = $"{klic.PocetVyrobenychKusu - klic.PocetPujcenychKusu} z {klic.PocetVyrobenychKusu}" });
			DataGridViewButtonCell tlacitkoUpravit = new DataGridViewButtonCell()
			{
				Value = "Upravit"
			};
			DataGridViewButtonCell tlacitkoSmazat = new DataGridViewButtonCell()
			{
				Value = "Odstranit"
			};
			radek.Cells.Add(tlacitkoUpravit);
			radek.Cells.Add(tlacitkoSmazat);

			tabulkaKlice.Rows.Add(radek);
		}
	}

	private void HlavniOkno_FormClosing(object? sender, FormClosingEventArgs e)
	{
		database?.UzavritPripojeni();
	}
}
