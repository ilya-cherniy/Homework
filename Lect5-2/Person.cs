using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect5_2
{
    [Serializable]
    class Person
    {
        private string test;
       
        [JsonIgnore] //this attriabute provides ability to skip some object during serialization
        public string Name { get; set; }
        public int Age { get; set; }
        //[JsonProperty(PropertyName = "CompanyName")]
        public string CompanyName { get; set; }
        
        public Person(string input)
        {
            test = input;
        }
    }
}
