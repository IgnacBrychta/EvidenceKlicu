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
		if(!database.ExistujeDatabaze())
		{
			database.VytvoritDatabazi();
		}
        database.ZmenitPripojovaciRetezec("Initial Catalog=EvidenceKlicu;Integrated Security=True;Encrypt=False");
		if(database.ZjistitStavTabulkyKlice() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZamestnanci() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZaznamyVypujceni() != StavTabulky.Vporadku)
		{
			database.OpravitTabulky();
		}
		FormClosing += HlavniOkno_FormClosing;

        ObnovitTabulkuZamestnanci();
		tabulkaZamestnanci.CellContentClick += TabulkaZamestnanci_CellContentClick;
		toolStripMenuItemNovyZamestnanec.Click += ToolStripMenuItemNovyZamestnanec_Click;

#if DEBUG
        new OknoUpravitZamestnance(database, database!.ZiskatZamestnance(133)).Show();
#endif
    }

	private void ToolStripMenuItemNovyZamestnanec_Click(object? sender, EventArgs e)
	{
        var okno = new OknoPridatZamestnance(database!);
		okno.ItemsChanged += ItemsChanged;
        okno.Show();
	}

	private void ItemsChanged(object sender, EventArgs e)
	{
		ObnovitTabulkuZamestnanci();
	}

	const int indexIdUpravitZamestnance = 0;

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
		int id = (int)selectedRow.Cells[indexIdUpravitZamestnance].Value;
        Zamestnanec? zamestnanec = database!.ZiskatZamestnance(id);
        if (zamestnanec is null) return;

		if (e.ColumnIndex == tabulkaZamestnanci.Columns["AkceUpravitZamestnance"].Index)
		{
			var okno = new OknoUpravitZamestnance(database, zamestnanec);
			okno.ItemsChanged += ItemsChanged;
			okno.Show();
		}
		else if (e.ColumnIndex == tabulkaZamestnanci.Columns["AkceOdstranitZamestnance"].Index)
		{

            // Perform actions based on the clicked row data
            DialogResult vysledek = MessageBox.Show(
                $"Opravdu si přejete smazat zaměstnance {zamestnanec}?",
                "Jste si jistí?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
            if(vysledek == DialogResult.OK)
            {
                database.OdstranitZamestnance(zamestnanec);
                ObnovitTabulkuZamestnanci();
            }
		}
	}

	private void Button_Click(object? sender, EventArgs e)
    {
       
    }

    private void pridatZamestnance_Click(object sender, EventArgs e)
    {

    }

    private void upravitZamestnance_Click(object sender, EventArgs e)
    {
        /*DialogResult result = MessageBox.Show("Chcete opravdu odstranit zaměstnance?", "Odstranění zaměstnance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            database.OdstranitZamestnance(zamestnanec); // nevím, jakým způsobem zjišťujeme vybraného zaměstnance
        }*/
    }

    private void odstranitZamestnance_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void HlavniOkno_FormClosing(object? sender, FormClosingEventArgs e)
    {
        database?.UzavritPripojeni();
    }
}
