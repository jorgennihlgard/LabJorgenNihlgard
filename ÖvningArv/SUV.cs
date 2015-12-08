using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace ÖvningArv
{
    class SUV :Car
    {

     
        public override void Drive()
        {
            Console.WriteLine("VROOM VROOM");
        }
    }
}

/*
Uppgift 5

Nu ska du testa att gömma metoder.

Utöka klassen Bil från tidigare övning genom att lägga till en ny metod som heter Drive. Metoden ska skriva ut "brum brum" till skärmen. Skapa en ny klass kallad SUV som ärver från Bil, och som även den har en metod som heter Drive, men denna metod ska skriva ut "VROOM VROOM" till skärmen.

Prova att kompilera, och lägg märke till att kompilatorn varnar för att du gömmer en metod utan att använda nyckelordet new. Lägg till nyckelordet new till Drive-metodens signatur och kompilera om.

I Main – skapa en instans av SUV. Skapa även en variabel av typen Bil, som refererar till samma instans. Anropa metoden Drive från båda referenserna och lägg märke till hur utskriften ser ut.

Det du gör när du omvandlar en SUV till en Bil är en implicit typomvandling, vilket går bra eftersom Bil är en SUV. För att omvandla på andra hållet, dvs från en Bil till en SUV, måste typkonverteringen göras explicit. Testa även detta.

Eftersom du gömmer metoden från basklassen så bestäms metodanropen redan vid kompilering.
*/
