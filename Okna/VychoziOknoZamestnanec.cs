using System;
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

	protected void ObnovitTabulku()
	{
		tabulkaKlice.Rows.Clear();
		IEnumerable<Klic> zamestnanci = database!.ZiskatVsechnyKlice();
		/*foreach (Zamestnanec item in zamestnanci)
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

			tabulkaKlice.Rows.Add(radek);
		}*/
	}

	protected static void SpatneUdaje() => MessageBox.Show("ne");
	protected static void SpravneUdaje() => MessageBox.Show("ano");
}
