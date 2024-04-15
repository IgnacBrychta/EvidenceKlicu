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

			ObnovitTabulku(zamestnanec);
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

		const int indexIdKlice = 0;
		protected override void TabulkaKlice_CellContentClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= tabulkaKlice.RowCount - 1 || e.ColumnIndex < 4) return;

			DataGridViewRow selectedRow = tabulkaKlice.Rows[e.RowIndex];
			int id = (int)selectedRow.Cells[indexIdKlice].Value;
			Klic? klic = database.ZiskatKlic(id);
			if (klic is null) return;

			DataGridViewCell cell = tabulkaKlice[e.ColumnIndex, e.RowIndex];
			bool? zapujcit = cell.Value == "Zapůjčit";
			if (!zapujcit.HasValue) return;
			if ((bool)zapujcit)//e.ColumnIndex == tabulkaKlice.Columns["Zapujcit"].Index)
			{
				database.ZapujcitKlic(klic, zamestnanec, DateTime.Now);
			}
			else// if (e.ColumnIndex == tabulkaKlice.Columns["Vratit"].Index)
			{
				database.VratitKlic(klic, zamestnanec, DateTime.Now);
			}

			ObnovitTabulku(zamestnanec);
		}

		protected override void ButtonZavrit_Click(object? sender, EventArgs e)
		{
			textBoxJmeno.Text = zamestnanec.Jmeno;
			textBoxPrijmeni.Text = zamestnanec.Prijmeni;
			textBoxZkratka.Text = zamestnanec.Zkratka;
		}
	}
}
