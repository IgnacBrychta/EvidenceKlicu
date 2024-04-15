using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class OknoPridatKlic : VychoziOknoKlice
{
	public OknoPridatKlic()
	{
		InitializeComponent();
	}

	public OknoPridatKlic(Database database) : base(database)
	{
		InitializeComponent();
		Text = "Přidat klíč";
		tabulkaKlice.Hide();
	}

	protected override void ButtonZavrit_Click(object? sender, EventArgs e)
	{
		Close();
	}

	protected override void ButtonOk_Click(object? sender, EventArgs e)
	{
		if(!int.TryParse(textBoxCislo.Text, out int cislo) || 
			!int.TryParse(textBoxPocetKusu.Text, out int pocetKusu) || 
			!Klic.JsouUdajeSpravne(textBoxCislo.Text, textBoxNazevMistnosti.Text, textBoxOznaceniDveri.Text, pocetKusu, database.dbOmezeni)
			)
		{
			SpatneUdaje();
			return;
		}

		Klic klic = new Klic(cislo, textBoxNazevMistnosti.Text, textBoxOznaceniDveri.Text, pocetKusu, StavKlice.Neznamy);
		database.PridatNovyKlic(klic);
		OnItemsChanged(e);
		SpravneUdaje();
		Close();
	}
}
