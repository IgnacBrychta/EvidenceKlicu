using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceKlicu.Db;

internal static class Skripty
{
    public const string ExistujeDatabaze = "DATABASE EXISTS.sql";
    public const string StavTabulkyKlice = "TABLE EXISTS Klice.sql";
	public const string StavTabulkyZamstnanci = "TABLE EXISTS Zamestnanci.sql";
	public const string StavTabulkyZaznamyVypujceni = "TABLE EXISTS ZaznamyVypujceni.sql";
	public const string SmazatVsechnyTabulky = "DROP ALL TABLES.sql";
	public const string VytvoritTabulkuKlice = "CREATE TABLE Klice.sql";
	public const string VytvoritTabulkuZamestnanci = "CREATE TABLE Zamestnanci.sql";
	public const string VytvoritTabulkuZaznamyVypujceni = "CREATE TABLE ZaznamyVypujceni.sql";
	public const string VytvoritDatabazi = "CREATE DATABASE EvidenceKlicu.sql";
	public const string PridatZamestnance = "INSERT Zamestnanec.sql";
	public const string UpravitZamestnance = "UPDATE Zamestnance.sql";
	public const string OdstranitZamestnance = "DELETE Zamestnanec.sql";
	public const string ZiskatVsechnyZamestnance = "SELECT all Zamestnanci.sql";
	public const string ZiskatZamestnance = "SELECT Zamestnanec.sql";
	public const string ZiskatKlic = "SELECT Klic.sql";





}
