using EvidenceKlicu.Modely;
using System.Data.Common;
using System.Data.SqlClient;

namespace EvidenceKlicu.Db;

public class Database
{
    private static string cestaKeSkriptum = "../../../Db/Sql/";
	readonly SqlConnection sqlServerPripojeni;
	public readonly DbOmezeni dbOmezeni;
	public Database(string pripojovaciRetezec)
	{
		sqlServerPripojeni = new SqlConnection(pripojovaciRetezec);
        sqlServerPripojeni.Open();
		dbOmezeni = new DbOmezeni()
		{
			MaxPocetZnakuJmena = 64,
			PocetZnakuZkratky = 2,
			PocetCiferCislaMistnosti = 4
		};
	}

	private static string NacistSkript(string jmenoSkriptu)
    {
        using FileStream fs = new FileStream(cestaKeSkriptum + jmenoSkriptu, FileMode.Open, FileAccess.Read);
        using StreamReader sr = new StreamReader(fs);
        return sr.ReadToEnd();
    }

    public void UzavritPripojeni()
    {
        sqlServerPripojeni.Close();
    }
	#region Sprava databaze
	public bool ExistujeDatabaze()
    {
        string skript = NacistSkript(Skripty.ExistujeDatabaze);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        using SqlDataReader reader = prikaz.ExecuteReader();
        _ = reader.Read();
        bool dbExistuje = (int)reader[0] == 1;
        return dbExistuje;
    }

	#region Sprava tabulek
    public StavTabulky ZjistitStavTabulkyKlice()
    {
        string skript = NacistSkript(Skripty.StavTabulkyKlice);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public StavTabulky ZjistitStavTabulkyZamestnanci()
	{
		string skript = NacistSkript(Skripty.StavTabulkyZamstnanci);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public StavTabulky ZjistitStavTabulkyZaznamyVypujceni()
	{
		string skript = NacistSkript(Skripty.StavTabulkyZaznamyVypujceni);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public void OpravitTabulky()
    {
		string skript = NacistSkript(Skripty.SmazatVsechnyTabulky);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
        VytvoritTabulky();
	}
	public void VytvoritTabulky()
    {
        VytvoritTabulkuKlice();
        VytvoritTabulkuZamestnanci();
        VytvoritTabulkuZaznamyVypujceni();
	}

	private void VytvoritTabulkuZamestnanci()
	{
		string skript = NacistSkript(Skripty.VytvoritTabulkuZamestnanci);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	private void VytvoritTabulkuZaznamyVypujceni()
	{
		string skript = NacistSkript(Skripty.VytvoritTabulkuZaznamyVypujceni);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	private void VytvoritTabulkuKlice()
    {
		string skript = NacistSkript(Skripty.VytvoritTabulkuKlice);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
    }
    #endregion
    public void ZmenitPripojovaciRetezec(string pripojovaciRetezec)
    {
        sqlServerPripojeni.Close();
        sqlServerPripojeni.ConnectionString = pripojovaciRetezec;
        sqlServerPripojeni.Open();
    }

	public void VytvoritDatabazi()
	{
        string skript = NacistSkript(Skripty.VytvoritDatabazi);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	#endregion

	public IEnumerable<Klic> ZiskatVsechnyKlice()
    {
		string skript = NacistSkript(Skripty.ZiskatVsechnyKlice);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader data = prikaz.ExecuteReader();
		foreach (DbDataRecord item in data)
		{
			yield return new Klic(
				(int)item[1],
				(string)item[2],
				(string)item[3],
				(int)item[4],
				StavKlice.Neznamy,
				(int)item[0]
				)
			{ PocetPujcenychKusu = (int)item[5] };
		}
	}
	
	public IEnumerable<Zamestnanec> ZiskatVsechnyZamestnance()
    {
		string skript = NacistSkript(Skripty.ZiskatVsechnyZamestnance);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader data = prikaz.ExecuteReader();
		foreach (DbDataRecord item in data)
		{
			yield return new Zamestnanec(
				(string)item[1],
				(string)item[2],
				(string)item[3],
				(int)item[0]
				);
		}
    }

	public IEnumerable<Klic> ZiskatZapujceneKlice(Zamestnanec zamestnanec)
    {
		string skript = NacistSkript(Skripty.ZiskatKliceZamestnance);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("@ZamestnanecId", zamestnanec.Id);
		using SqlDataReader data = prikaz.ExecuteReader();
		foreach (DbDataRecord item in data)
		{
			yield return new Klic(
				(int)item[1],
				(string)item[2],
				(string)item[3],
				(int)item[4],
				(StavKlice)item[5],
				item[6] is DBNull ? null : (DateTime)item[6],
				item[7] is DBNull ? null : (DateTime)item[7],
				(int)item[0]
				);
		}
	}

	public IEnumerable<Zamestnanec> ZiskatZamestnanceDluziciKlic(Klic klic)
	{
		string skript = NacistSkript(Skripty.ZiskatZamestnanceDluziciKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("@KlicId", klic.Id);
		using SqlDataReader data = prikaz.ExecuteReader();
		foreach (DbDataRecord item in data)
		{
			yield return new Zamestnanec(
				(string)item[1],
				(string)item[2],
				(string)item[3],
				item[4] is DBNull ? null : (DateTime)item[4],
				item[5] is DBNull ? null : (DateTime)item[5],
				(int)item[0]
				);
		}
	}

	public void ZapujcitKlic(Klic zapujcenyKlic, Zamestnanec pujcujiciZamestnanec, DateTime casVypujceni)
	{
		string skript = NacistSkript(Skripty.ZapujcitKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("KlicId", zapujcenyKlic.Id);
		prikaz.Parameters.AddWithValue("ZamestnanecId", pujcujiciZamestnanec.Id);
		prikaz.Parameters.AddWithValue("DatumVypujceni", casVypujceni);
		_ = prikaz.ExecuteNonQuery();
	}

	public void VratitKlic(Klic zapujcenyKlic, Zamestnanec vracejiciZamestnanec, DateTime casVraceni)
	{
		string skript = NacistSkript(Skripty.VratitKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("KlicId", zapujcenyKlic.Id);
		prikaz.Parameters.AddWithValue("ZamestnanecId", vracejiciZamestnanec.Id);
		prikaz.Parameters.AddWithValue("DatumVraceni", casVraceni);
		_ = prikaz.ExecuteNonQuery();
	}

	public Zamestnanec? ZiskatZamestnance(int id)
	{
		string skript = NacistSkript(Skripty.ZiskatZamestnance);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", id);
		using SqlDataReader reader = prikaz.ExecuteReader();

		if (!reader.Read()) return null;

		string jmeno = reader.GetString(1); 
		string prijmeni = reader.GetString(2);
		string zkratka = reader.GetString(3); 

		return new Zamestnanec(jmeno, prijmeni, zkratka, id);
	}

	public Klic? ZiskatKlic(int id)
	{
		string skript = NacistSkript(Skripty.ZiskatKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", id);
		using SqlDataReader reader = prikaz.ExecuteReader();

		if (!reader.Read()) return null;

		return new Klic(
				reader.GetInt32(1),
				reader.GetString(2),
				reader.GetString(3),
				reader.GetInt32(4),
				StavKlice.Neznamy,
				reader.GetInt32(0)
				);
	}

	public void PridatNovehoZamestnance(Zamestnanec zamestnanec)
    {
        string skript = NacistSkript(Skripty.PridatZamestnance);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        prikaz.Parameters.AddWithValue("Jmeno", zamestnanec.Jmeno);
		prikaz.Parameters.AddWithValue("Prijmeni", zamestnanec.Prijmeni);
		prikaz.Parameters.AddWithValue("Zkratka", zamestnanec.Zkratka);
        using SqlDataReader reader = prikaz.ExecuteReader();
        //int id = reader.GetInt32(0);
        //zamestnanec.Id = id;
    }

    public void UpravitZamestnance(Zamestnanec zamestnanec)
    {
        string skript = NacistSkript(Skripty.UpravitZamestnance);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", zamestnanec.Id);
        prikaz.Parameters.AddWithValue("Jmeno", zamestnanec.Jmeno);
        prikaz.Parameters.AddWithValue("Prijmeni", zamestnanec.Prijmeni);
        prikaz.Parameters.AddWithValue("Zkratka", zamestnanec.Zkratka);        

        _ = prikaz.ExecuteNonQuery();
    }

    public void OdstranitZamestnance(Zamestnanec zamestnanec)
    {
		string skript = NacistSkript(Skripty.OdstranitZamestnance);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", zamestnanec.Id);
		_ = prikaz.ExecuteNonQuery();
    }

    public void PridatNovyKlic(Klic klic)
	{
		string skript = NacistSkript(Skripty.PridatKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Cislo", klic.Cislo);
		prikaz.Parameters.AddWithValue("NazevMistnosti", klic.NazevMistnosti);
		prikaz.Parameters.AddWithValue("OznaceniDveri", klic.OznaceniDveri);
		prikaz.Parameters.AddWithValue("PocetKusu", klic.PocetVyrobenychKusu);
		using SqlDataReader reader = prikaz.ExecuteReader();
		//int id = reader.GetInt32(0);
	}

	public void UpravitKlic(Klic klic)
	{
		string skript = NacistSkript(Skripty.UpravitKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", klic.Id);
		prikaz.Parameters.AddWithValue("NazevMistnosti", klic.NazevMistnosti);
		prikaz.Parameters.AddWithValue("OznaceniDveri", klic.OznaceniDveri);
		prikaz.Parameters.AddWithValue("PocetKusu", klic.PocetVyrobenychKusu);

		_ = prikaz.ExecuteNonQuery();
	}

	public void OdstranitKlic(Klic klic)
	{
		string skript = NacistSkript(Skripty.SmazatKlic);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		prikaz.Parameters.AddWithValue("Id", klic.Id);

		_ = prikaz.ExecuteNonQuery();
	}
}
