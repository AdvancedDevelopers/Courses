using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    class AccessModifiers
    {
        //Public , Private , Internal and Protected
        private string _myname;
        public string MyName { get { return _myname; } }
        public string _oldName;
        internal DateTime _Age;
        protected string Address;
        public AccessModifiers(string MyName)
        {
            _Age = DateTime.Now;
            _myname = MyName;
        }
    }
}
