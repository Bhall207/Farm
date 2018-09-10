using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice5A
{
    class Lamb
    {
       private string name, eat, hobbies, joke;
        

        public Lamb(string name, string eat, string hobbies, string joke)
        {
            this.name = name;
            this.eat = eat;
            this.hobbies = hobbies;
            this.joke = joke;

        }

        public string Name()
        {
            return name;
        }
        public string Eat()
        {
            return eat;
        }
        public string Hobbies()
        {
            return hobbies;
        }
        public string Joke()
        {
            return joke;
        }
    }
}
