using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace ÖvningArv
{
    class Point3D : Point
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D()
        {
            X = 4;
            Y = 3;
            Z = 8;
        }
        public Point3D(int x, int y, int z):base(x,y)
        {
            X = x;
            Y = y;
            Z = z;
        }
      
    }
}
/*

Uppgift 3

Bygg ut klassen Point med två konstruktors – en defaultkonstruktor, och en konstruktor som initierar de två fälten.

Lägg sedan till default-konstruktor och en konstruktor som initierar x, y, och z i klassen Point3D. Konstruktorn som initierar x, y och z ska anropa basklassens konstruktor som initierar x och y.

Testkör i debuggern för att se i vilken ordning som konstruktorerna anropas.

    
Uppgift 2

Skapa en klass kallad Point3D som ärver från klassen Point som du skapat i tidigare 
övningar. Point3D ska lägga till fältet z med samma datatyp som x och y i Point.
Skapa även get/set property för fältet. Skapa en instans av Point3D i Main, 
och prova att manipulera x, y och z. Notera: om Point innehåller Get-/Set-metoder
för åtkomst till fälten x och y så ändra dessa till properties.
*/
