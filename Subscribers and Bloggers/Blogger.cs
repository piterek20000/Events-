using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Subskryber_Blogger
{
    class Blogger : Account_Class
    {
        #region Constructors basing on Account_Class constructors

        /// <summary>
        /// Simple cpnstructor
        /// </summary>
        /// <param name="name"></param>
        public Blogger(string name) : base(name)
        {
        }

        /// <summary>
        /// Advanced constructor
        /// </summary>
        /// <param name="name">Enter name</param>
        /// <param name="age">Enter age</param>
        /// <param name="info">Enter informations about what are you doing in the free time</param>
        public Blogger(string name, int age, string info) : base(name, age, info)
        {
        }

        #endregion

        #region Event Methods

        //Obiekt przechwytujaci subskrybentów
        public event EventHandler Subscribers; //Przechwytuje subskrybentów
        //EventHandler - to składowa .Net, która odpowiada za to, żeby obiekty które nasłuchują
        //mógł prawidłowo obsłużyć zdarzenie które zaistniało

        public void Show_Subscribers_Event(Create_New_Event EEE)
        {
            EventHandler Event_Subscribers = Subscribers;

            if (Event_Subscribers != null) //Sprawdzenie czy sa jacys subskrybenci
            {
                Event_Subscribers(this, EEE); //Jesli ktos nasluchuje wysyla mu dane 
            }
        }

        #endregion
    }

    public class Create_New_Event : EventArgs
    {
        private string _title;
        private bool _for_Adult_Onely;
        private int _duration;
        private string _event_Date;

        public string Event_Date
        {
            get { return _event_Date; }
            set { _event_Date = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public bool For_Adult_Onely
        {
            get { return _for_Adult_Onely; }
            set { _for_Adult_Onely = value; }
        }


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Create_New_Event(string title, bool for_adult, string Date, int duration)
        {
            Title = title;
            For_Adult_Onely = for_adult;
            Event_Date = Date;
            Duration = duration;
        }
    }
}
