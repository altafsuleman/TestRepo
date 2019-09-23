using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestHello
{
    public static class Greeting
    {
        public static string SayHello()
        {
            var json = JsonConvert.SerializeObject(new Person()
            {
                Name = "WIN"
            });
            return "Hello from Suleman, " + DateTime.Now + json;
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
