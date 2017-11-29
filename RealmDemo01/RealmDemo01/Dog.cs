using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace RealmDemo01
{
    public class Dog : RealmObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person Owner { get; set; }
    }
}
