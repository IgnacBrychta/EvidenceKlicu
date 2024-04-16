using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class VychoziOknoKlice : Form
{
	protected Database database;
	public VychoziOknoKlice(Database database)
	{
		InitializeComponent();
		this.database = database;
		buttonOk.Click += ButtonOk_Click;
		buttonZavrit.Click += ButtonZavrit_Click;
		try { Icon = new Icon(OknoZamestnanci.iconPath); } catch (Exception) { }
	}

	public VychoziOknoKlice()
	{
		InitializeComponent();
	}

	public delegate void ItemsChangedEventHandler(object sender, EventArgs e);
	public event ItemsChangedEventHandler ItemsChanged;
	protected virtual void OnItemsChanged(EventArgs e)
	{
		ItemsChanged?.Invoke(this, e);
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

	protected void ObnovitTabulku(Klic klic)
	{
		tabulkaKlice.Rows.Clear();
		IEnumerable<Zamestnanec> zamestnanci = database!.ZiskatZamestnanceDluziciKlic(klic);
		foreach (Zamestnanec zamestnanec in zamestnanci)
		{
			DataGridViewRow radek = new DataGridViewRow();
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.Id });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.Jmeno });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.Prijmeni });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.Zkratka });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.DatumVypujceni?.ToString() ?? "N/A" });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = zamestnanec.DatumVraceni?.ToString() ?? "N/A" });

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
