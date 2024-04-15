using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
		Size size = new Size(988, 350);
		MinimumSize = size;
		MaximumSize = size;
	}

	protected void ObnovitTabulku(Zamestnanec zamestnanec)
	{
		tabulkaKlice.Rows.Clear();
		IEnumerable<Klic> klice = database!.ZiskatZapujceneKlice(zamestnanec);
		foreach (Klic klic in klice)
		{
			DataGridViewRow radek = new DataGridViewRow();
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.Id });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.NazevMistnosti });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.OznaceniDveri });
			radek.Cells.Add(new DataGridViewTextBoxCell { Value = klic.StavKlice });

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

	protected static void SpatneUdaje() => MessageBox.Show("ne");
	protected static void SpravneUdaje() => MessageBox.Show("ano");
}
