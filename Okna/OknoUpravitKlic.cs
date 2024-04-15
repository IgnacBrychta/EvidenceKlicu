using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;
using System.Configuration;

namespace EvidenceKlicu.Okna;

public partial class OknoUpravitKlic : VychoziOknoKlice
{
	Klic klic;
	int pocetPujcenychKusu;
	public OknoUpravitKlic()
	{
		InitializeComponent();
	}

	public OknoUpravitKlic(Database database, Klic klic) : base(database)
	{
		InitializeComponent();
		this.klic = klic;
		textBoxId.Text = klic.Id.ToString();
		textBoxCislo.Text = klic.Cislo.ToString("0000");
		textBoxNazevMistnosti.Text = klic.NazevMistnosti;
		textBoxOznaceniDveri.Text = klic.OznaceniDveri;
		textBoxPocetKusu.Text = klic.PocetVyrobenychKusu.ToString();
		pocetPujcenychKusu = database.ZiskatVsechnyKlice().First(k => k.Id == klic.Id).PocetPujcenychKusu;
		textBoxPocetDostupnych.Text = $"{klic.PocetVyrobenychKusu - pocetPujcenychKusu} z {klic.PocetVyrobenychKusu}";

		ObnovitTabulku(klic);
		Text = "Upravit klíč";
	}

	protected override void ButtonOk_Click(object? sender, EventArgs e)
	{
		if (!int.TryParse(textBoxPocetKusu.Text, out int pocetKusu) ||
			!Klic.JsouUdajeSpravne(textBoxCislo.Text, textBoxNazevMistnosti.Text, textBoxOznaceniDveri.Text, pocetKusu, database.dbOmezeni) ||
			pocetKusu < pocetPujcenychKusu
			)
		{
			SpatneUdaje();
			return;
		}
		klic.NazevMistnosti = textBoxNazevMistnosti.Text;
		klic.OznaceniDveri = textBoxOznaceniDveri.Text;
		klic.PocetVyrobenychKusu = pocetKusu;
		database.UpravitKlic(klic);
		OnItemsChanged(e);
		SpravneUdaje();

		textBoxPocetDostupnych.Text = $"{klic.PocetVyrobenychKusu - pocetPujcenychKusu} z {klic.PocetVyrobenychKusu}";
	}

	protected override void ButtonZavrit_Click(object? sender, EventArgs e)
	{
		textBoxNazevMistnosti.Text = klic.NazevMistnosti;
		textBoxOznaceniDveri.Text = klic.OznaceniDveri;
		textBoxPocetKusu.Text = klic.PocetVyrobenychKusu.ToString();
	}
}
