using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorerUpg2
{
    class Namn
    {
        private string förnamn;
        private string efternamn;

        public string NamnFörnamn
        {
            get{ return förnamn; }

            set{ förnamn = value; }
        }

        public string NamnEfternamn
        {
            get { return efternamn; }

            set { efternamn = value; }
        }

        public void NamnOutput(string förnamn, string efternamn)
        {
            Console.WriteLine($"Du skrev in ditt namn som: {förnamn} och {efternamn}");

        }

    }
}
