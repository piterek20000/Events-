using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Subskryber_Blogger
{
    public abstract class Account_Class
    {
        #region Informations about Subscriber

        private string _name;
        private int _age;
        private string _informations;

        public string Informations
        {
            get { return _informations; }
            set { _informations = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        /// <summary>
        /// Simple constructor
        /// </summary>
        /// <param name="name"></param>
        public Account_Class(string name)
        {
            Name = name;
            Age = 1;
            Informations = "NO INFORMATIONS ABOUT ACCOUNT";
        }

        /// <summary>
        /// Advanced constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="info"></param>
        public Account_Class(string name, int age, string info)
        {
            Name = name;
            Age = age;
            Informations = info;
        }
    }
}
