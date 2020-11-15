using System;

namespace Greetings
{
    public class Greeter 
    {
        public Greeter(string name) 
        {
            _Name = name;
        }
        private string _Name;
        public string SayHello() {
            return $"Hallo {_Name}!";
        }
        public string SayGoodBye() {
            return $"Tschüss {_Name}!";
        }
    }
}