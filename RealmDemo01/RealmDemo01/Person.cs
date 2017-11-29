using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;


namespace RealmDemo01
{
    public class Person : RealmObject
    {
        public string Name { get; set; }
        public IList<Dog> Dogs { get; }
    }
}
