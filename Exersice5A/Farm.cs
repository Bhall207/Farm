using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice5A
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("Welcome to Olde Mcdonalds old school farm how do ya do");

        }
        public void ChickenHello(Chicken chickenLittle)
        {
            Console.WriteLine($"{chickenLittle.Name()}{chickenLittle.Eat()}{chickenLittle.Hobbies()}{chickenLittle.Joke()}");
        }
        public void LambHello(Lamb blackSheep)
        {
            Console.WriteLine($"{blackSheep.Name()}{blackSheep.Eat()}{blackSheep.Hobbies()}{blackSheep.Joke()}");
        }
        public void PigHello(Pig wilber)
        {
            Console.WriteLine($"{wilber.Name()}{wilber.Eat()}{wilber.Hobbies()}{wilber.Joke()}");
        }
        public void CowHello(Cow maryMoo)
        {
            Console.WriteLine($"{maryMoo.Name()}{maryMoo.Eat()}{maryMoo.Hobbies()}{maryMoo.Joke()}");
        }
    }
}