using EvidenceKlicu.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvidenceKlicu.Modely;

public class Klic
{
	public int Id { get; set; }
	public int Cislo { get; set; }
	public string NazevMistnosti { get; set; }
	public string OznaceniDveri {  get; set; }
	public int PocetVyrobenychKusu { get; set; }
	public int PocetPujcenychKusu { get; set; }
	public DateTime? DatumVypujceni { get; set; }
	public DateTime? DatumVraceni { get; set; }
	public StavKlice StavKlice { get; set; }
	public Klic(int cislo, string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu, StavKlice stavKlice, int id = -1)
	{
		Id = id;
		Cislo = cislo;
		NazevMistnosti = nazevMistnosti;
		OznaceniDveri = oznaceniDveri;
		PocetVyrobenychKusu = pocetVyrobenychKusu;
		StavKlice = stavKlice;
	}

	public Klic(int cislo, string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu, StavKlice stavKlice, DateTime? datumVypujceni, DateTime? datumVraceni, int id = -1)
	{
		Id = id;
		Cislo = cislo;
		NazevMistnosti = nazevMistnosti;
		OznaceniDveri = oznaceniDveri;
		PocetVyrobenychKusu = pocetVyrobenychKusu;
		StavKlice = stavKlice;
		DatumVypujceni = datumVypujceni;
		DatumVraceni = datumVraceni;
	}

	public override string ToString()
	{
		return $"{Id}: {StavKlice}";
	}

	public static bool JsouUdajeSpravne(string cislo, string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu, DbOmezeni dbOmezeni)
	{
		return
		cislo.Length == dbOmezeni.PocetCiferCislaMistnosti &&
		nazevMistnosti.Length <= dbOmezeni.MaxPocetZnakuJmena &&
			!string.IsNullOrEmpty(nazevMistnosti) &&
			oznaceniDveri.Length <= dbOmezeni.MaxPocetZnakuJmena &&
			!string.IsNullOrEmpty(oznaceniDveri) &&
			pocetVyrobenychKusu >= 0;
	}
}
