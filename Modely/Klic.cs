using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceKlicu.Modely;

public class Klic
{
	public int Id { get; set; }
	public string NazevMistnosti { get; set; }
	public string OznaceniDveri {  get; set; }
	public int PocetVyrobenychKusu { get; set; }
	public StavKlice StavKlice { get; set; }
	public Klic(string nazevMistnosti, string oznaceniDveri, int pocetVyrobenychKusu, StavKlice stavKlice, int id = -1)
	{
		Id = id;
		NazevMistnosti = nazevMistnosti;
		OznaceniDveri = oznaceniDveri;
		PocetVyrobenychKusu = pocetVyrobenychKusu;
		StavKlice = stavKlice;
	}

	public override string ToString()
	{
		return $"{Id}: {StavKlice}";
	}
}
