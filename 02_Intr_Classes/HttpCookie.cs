using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Intr_Classes
{
    public class HttpClass
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpClass()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

    }
}
