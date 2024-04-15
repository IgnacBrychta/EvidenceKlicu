using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class OknoPridatZamestnance : VychoziOknoZamestnanec
{
	public OknoPridatZamestnance()
	{
		InitializeComponent();
	}

	public OknoPridatZamestnance(Database database) : base(database)
	{
		InitializeComponent();
		tabulkaKlice.Hide();
		Text = "Upravit zaměstnance";
	}

	protected override void ButtonOk_Click(object? sender, EventArgs e)
	{
		if (!Zamestnanec.JsouUdajeSpravne(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text, database.dbOmezeni))
		{
#warning chyba
			SpatneUdaje();
			return;
		}

		
		database.PridatNovehoZamestnance(new Zamestnanec(
			textBoxJmeno.Text,
			textBoxPrijmeni.Text,
			textBoxZkratka.Text
			)
			);
		SpravneUdaje();
		OnItemsChanged(e);
		Close();
	}

	protected override void ButtonZavrit_Click(object? sender, EventArgs e)
	{
		Close();
	}
}