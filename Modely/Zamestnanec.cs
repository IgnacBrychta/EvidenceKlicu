using EvidenceKlicu.Db;

namespace EvidenceKlicu.Modely;

public class Zamestnanec
{
    public int Id { get; set; }
	public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Zkratka { get; set; }
	public DateTime? DatumVypujceni { get; set; }
	public DateTime? DatumVraceni { get; set; }
	public Zamestnanec(string jmeno, string prijmeni, string zkratka, int id = -1)
    {
        Id = id;
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        Zkratka = zkratka;
    }

	public Zamestnanec(string jmeno, string prijmeni, string zkratka, DateTime? datumVypujceni, DateTime? datumVraceni, int id = -1)
	{
		Id = id;
		Jmeno = jmeno;
		Prijmeni = prijmeni;
		Zkratka = zkratka;
        DatumVypujceni = datumVypujceni;
        DatumVraceni = datumVraceni;
	}

	public static bool JsouUdajeSpravne(string jmeno, string prijmeni, string zkratka, DbOmezeni dbOmezeni)
    {
#warning lepší oveření
        return
            !string.IsNullOrEmpty(jmeno) &&
            jmeno.Length <= dbOmezeni.MaxPocetZnakuJmena &&
            !string.IsNullOrEmpty(prijmeni) &&
            prijmeni.Length <= dbOmezeni.MaxPocetZnakuJmena &&
            !string.IsNullOrEmpty(zkratka) &&
            zkratka.Length == dbOmezeni.PocetZnakuZkratky;
    }

	public override string ToString()
	{
        return $"{Id}: {Prijmeni} {Jmeno} ({Zkratka})";
	}
}
