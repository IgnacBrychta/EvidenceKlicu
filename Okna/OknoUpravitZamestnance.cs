using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceKlicu.Okna
{
	public partial class OknoUpravitZamestnance : VychoziOknoZamestnanec
	{
		Zamestnanec zamestnanec;
		public OknoUpravitZamestnance()
		{
			InitializeComponent();
		}

		public OknoUpravitZamestnance(Database database, Zamestnanec zamestnanec) : base(database)
		{
			InitializeComponent();
			this.zamestnanec = zamestnanec;
			textBoxId.Text = zamestnanec.Id.ToString();
			textBoxJmeno.Text = zamestnanec.Jmeno;
			textBoxPrijmeni.Text = zamestnanec.Prijmeni;
			textBoxZkratka.Text = zamestnanec.Zkratka;
		}

		protected override void ButtonOk_Click(object? sender, EventArgs e)
		{
			if (!Zamestnanec.JsouUdajeSpravne(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text, database.dbOmezeni))
			{
#warning chyba
				SpatneUdaje();
				return;
			}
			
			zamestnanec.Jmeno = textBoxJmeno.Text;
			zamestnanec.Prijmeni = textBoxPrijmeni.Text;
			zamestnanec.Zkratka = textBoxZkratka.Text;
			database.UpravitZamestnance(zamestnanec);
			OnItemsChanged(e);
			SpravneUdaje();
		}

		protected override void ButtonZavrit_Click(object? sender, EventArgs e)
		{
			textBoxJmeno.Text = zamestnanec.Jmeno;
			textBoxPrijmeni.Text = zamestnanec.Prijmeni;
			textBoxZkratka.Text = zamestnanec.Zkratka;
		}
	}
}
