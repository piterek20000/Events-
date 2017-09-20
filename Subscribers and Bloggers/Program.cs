using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Subskryber_Blogger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create bloggers
            Blogger AAA = new Blogger("Piotr",22,"Piłka nożna");
            Blogger BBB = new Blogger("Beata", 18, "Architektura");
            Blogger CCC = new Blogger("Agnieszka");
            Blogger DDD = new Blogger("Grzesiek");
            Blogger EEE = new Blogger("Krzysiek", 16, "Projektowanie wnetrz");

            //create subscribers
            Subscriber A = new Subscriber("Piotr", 22, "Piłka nożna");
            Subscriber B = new Subscriber("Beata", 55, "Agregaty");
            Subscriber C = new Subscriber("Aga", 14, "Łowiectwo");
            Subscriber D = new Subscriber("Booler", 33, "Grzyby");
            Subscriber E = new Subscriber("Beata", 66, "Projekty ubrań");
            Subscriber F = new Subscriber("Beata");
            Subscriber G = new Subscriber("Gacek");
            
            //Subscribe bloggers by subscribers
            A.Subscribe_Blogger(AAA);
            A.Subscribe_Blogger(CCC);
            A.Subscribe_Blogger(EEE);
            B.Subscribe_Blogger(AAA);
            G.Subscribe_Blogger(CCC);
            D.Subscribe_Blogger(EEE);
            A.Subscribe_Blogger(AAA);
            A.Subscribe_Blogger(CCC);
            A.Subscribe_Blogger(EEE);
            C.Subscribe_Blogger(AAA);
            C.Subscribe_Blogger(CCC);
            C.Subscribe_Blogger(EEE);
            F.Subscribe_Blogger(AAA);
            F.Subscribe_Blogger(CCC);
            F.Subscribe_Blogger(EEE);
            E.Subscribe_Blogger(AAA);
            E.Subscribe_Blogger(CCC);
            C.Subscribe_Blogger(EEE);
            G.Subscribe_Blogger(AAA);
            G.Subscribe_Blogger(CCC);
            G.Subscribe_Blogger(EEE);

            //Create new events
            Create_New_Event Event1 = new Create_New_Event("Free coffe", true, "12.01.2018", 230);
            Create_New_Event Event2 = new Create_New_Event("News!!!", true, "12.12.2019", 15);
            Create_New_Event Event3 = new Create_New_Event("Informations", true, "6.6.2018", 22);
            Create_New_Event Event4 = new Create_New_Event("New video", false, "1.01.2018", 280);
            Create_New_Event Event5 = new Create_New_Event("Free time", false, "2.01.2018", 240);

            AAA.Show_Subscribers_Event(Event1);
            AAA.Show_Subscribers_Event(Event2);
            AAA.Show_Subscribers_Event(Event3);
            AAA.Show_Subscribers_Event(Event4);

            CCC.Show_Subscribers_Event(Event1);
            CCC.Show_Subscribers_Event(Event2);
            CCC.Show_Subscribers_Event(Event3);
            CCC.Show_Subscribers_Event(Event4);
            CCC.Show_Subscribers_Event(Event5);

            Console.ReadLine();
        }
    }
}
