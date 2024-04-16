using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class VychoziOknoZamestnanec : Form
{
	protected Database database;
	public VychoziOknoZamestnanec()
	{
		InitializeComponent();
	}

	protected VychoziOknoZamestnanec(Database database)
	{
		InitializeComponent();
		Load += VychoziOknoZamestnanec_Load;
		this.database = database;
		buttonOk.Click += ButtonOk_Click;
		buttonZavrit.Click += ButtonZavrit_Click;
		tabulkaKlice.CellContentClick += TabulkaKlice_CellContentClick;
		try { Icon = new Icon(OknoZamestnanci.iconPath); } catch (Exception) { }
	}

	public delegate void ItemsChangedEventHandler(object sender, EventArgs e);
	public event ItemsChangedEventHandler ItemsChanged;
	protected virtual void OnItemsChanged(EventArgs e)
	{
		ItemsChanged?.Invoke(this, e);
	}

	protected virtual void TabulkaKlice_CellContentClick(object? sender, DataGridViewCellEventArgs e)
	{
		throw new NotImplementedException();
	}

	protected virtual void ButtonZavrit_Click(object? sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	protected virtual void ButtonOk_Click(object? sender, EventArgs e)
	{
		throw new NotImplementedException();
	}

	private void VychoziOknoZamestnanec_Load(object? sender, EventArgs e)
	{
		MinimumSize = Size;
		MaximumSize = Size;
	}

	protected void ObnovitTabulku(Zamestnanec zamestnanec)
	{
		tabulkaKlice.Rows.Clear();
		IEnumerable<Klic> klice = database!.ZiskatZapujceneKlice(zamestnanec);
		foreach (Klic klic in klice)
		{
			DataGridViewRow radek = new DataGridViewRow();
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.Id });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.Cislo });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.NazevMistnosti });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.OznaceniDveri });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.DatumVypujceni?.ToString() ?? "N/A" });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.DatumVraceni?.ToString() ?? "N/A" });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.StavKlice.ActualRepresentation() });
			
			if(klic.StavKlice == StavKlice.Dostupny)
			{
				DataGridViewButtonCell tlacitkoZapujcit = new DataGridViewButtonCell()
				{
					Value = "Zapůjčit"
				};
				radek.Cells.Add(tlacitkoZapujcit);
			}
			else if(klic.StavKlice == StavKlice.ZapujcenZamestnanci)
			{
				DataGridViewButtonCell tlacitkoVratit = new DataGridViewButtonCell()
				{
					Value = "Vrátit"
				};
				radek.Cells.Add(tlacitkoVratit);
			}
			tabulkaKlice.Rows.Add(radek);
		}
	}

	protected static void SpatneUdaje() => MessageBox.Show(
		"Změna selhala, ověřte správnost údajů a připojení.",
		"Změna selhala",
		MessageBoxButtons.OK,
		MessageBoxIcon.Error
		);
	protected static void SpravneUdaje() => MessageBox.Show(
		"Změna provedena úspěšně.",
		"Změna provedena",
		MessageBoxButtons.OK,
		MessageBoxIcon.Information
		);
}
