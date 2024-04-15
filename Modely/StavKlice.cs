using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceKlicu.Modely;

public enum StavKlice
{
	ZapujcenZamestnanci = 0,
	Nedostupny = 1,
	Dostupny = 2,
}
public static partial class Extensions
{
	public static string ActualRepresentation(this StavKlice stavKlice)
	{
		switch (stavKlice)
		{
			case StavKlice.Dostupny:
				return "Dostupný";
			case StavKlice.Nedostupny:
				return "Nedostupný";
			case StavKlice.ZapujcenZamestnanci:
				return "Lze vrátit";
			default:
				return "Chyba";
		}
	}
}