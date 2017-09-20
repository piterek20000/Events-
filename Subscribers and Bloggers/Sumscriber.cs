using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Subskryber_Blogger
{
    class Subscriber : Account_Class
    {
        #region Constructors basing on Account_Class constructors

        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="name">Enter name</param>
        public Subscriber(string name) : base(name)
        {
        }

        /// <summary>
        /// Advanced constructor
        /// </summary>
        /// <param name="name">Enter name</param>
        /// <param name="age">Enter age</param>
        /// <param name="info">Enter informations about what are you doing in the free time</param>
        public Subscriber(string name, int age, string info) : base(name, age, info)
        {
        }

        #endregion

        public string Bloger_Name { get; set; }

        #region Subscribe Methods

        /// <summary>
        /// Subscribe Blogger Method
        /// </summary>
        /// <param name="A">Bloger Name</param>
        public void Subscribe_Blogger(Blogger A)
        {
           Bloger_Name = A.Name;
           A.Subscribers += Blogger_Event;
        }

        /// <summary>
        /// Method Subscribe Blogger
        /// </summary>
        /// <param name="A">Blogger</param>
        public void Un_subscribe(Blogger A)
        {
            A.Subscribers -= Blogger_Event;
        }

        /// <summary>
        /// Show Bloger Events Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Blogger_Event(object sender, EventArgs e)
        {
            if (e is Create_New_Event)
            {
                Create_New_Event AAAAA = e as Create_New_Event;

                if (AAAAA.For_Adult_Onely == true && Age < 18)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine("\n\t\t Hello {0}!!!", Name);
                    Console.WriteLine("\t {0}", AAAAA.Title);
                    Console.WriteLine("\n\t Event only for adult!!!\n");
                    Console.WriteLine("==================================");
                }

                else
                {
                    Console.WriteLine("\n\n\n\t\t Hello {0}!!!", Name);
                    Console.WriteLine("\n Bloger {0} just created new event!", Bloger_Name);
                    Console.WriteLine("\n\n\t {0}", AAAAA.Title);
                    Console.WriteLine("\t Data: {0}", AAAAA.Event_Date);
                    if (AAAAA.For_Adult_Onely)
                    {
                        Console.WriteLine("\t Only for adult!!!");
                    }
                }
            }
        }

        #endregion
    }
}
