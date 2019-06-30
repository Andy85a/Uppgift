using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UppgiftförTimeCare
{
    // kom på senare att det skulle va polymorphism men tyckte det här var smidigare.
    // jag försökte lite med polymorphism, jag har kommenterat bort det.
    class Animal { 
                          

        static void Main(string[] args)
        {
            var animal = new[] { "cow", "dog", "cat", "duck", "pig" };
            var sound = new[] { "moo", "woof", "mjau", "quack", "nöff" };
            var anso = animal.Zip(sound, (a, s) => new { Word1 = a, Word2 = s });

            foreach (var a in anso)
            {
                Console.WriteLine("Old McDonald had a farm \n" +
                                      "E - I - E - I - O\n " +
                                      "And on his farm he had a"+" "+ a.Word1+ "\n" +
                                      " E - I - E - I - O\n" +
                                      "With a"+" "+ a.Word2 +" "+ a.Word2+ " "+"here\n" +
                                      "and a" + " " + a.Word2 + " " + a.Word2 + " " + "  there\n" +
                                      "here a"+" " + a.Word2+", there a"+" "+a.Word2+" , everywhere a"+" "+a.Word2 +" " +a.Word2+"\n"
                                                                );
            }
            var animal2 = new[] { "cow", "dog", "cat", "duck", "pig","rooster" };//etc
            var sound2 = new[] { "moo", "woof", "mjau", "quack", "nöff", "kukkeliku" };//etc
            var anso2 = animal.Zip(sound, (a, s) => new { Word1 = a, Word2 = s });

            foreach (var a in anso2)
            {
                Console.WriteLine("Old McDonald had a farm \n" +
                                      "E - I - E - I - O\n " +
                                      "And on his farm he had a" + " " + a.Word1 + "\n" +
                                      " E - I - E - I - O\n" +
                                      "With a" + " " + a.Word2 + " " + a.Word2 + " " + "here\n" +
                                      "and a" + " " + a.Word2 + " " + a.Word2 + " " + "  there\n" +
                                      "here a" + " " + a.Word2 + ", there a" + " " + a.Word2 + " , everywhere a" + " " + a.Word2 + " " + a.Word2 + "\n"
                                                                );
            }


            string input;
            Console.Write("Please write an animal of your own preference\n");
            Console.ReadKey();
            input = Console.ReadLine();
            string input2;
            Console.Write("Please write which sound you want it to have of your own preference\n");
            input2 = Console.ReadLine();
            Console.WriteLine("Old McDonald had a farm \n" +
                                  "E - I - E - I - O\n " +
                                  "And on his farm he had a"+" "+input+"\n" +
                                  " E - I - E - I - O\n" +
                                  "With a" +" "+input2 +" " +input2 +"here\n" +
                                  "and a"+" " + input2 + " "+ input2+ "there\n" +
                                  "here a" + " "+ input2+ ", there a"+" " + input2+", everywhere a" +" " + input2 + " "+ input2+".\n"
                                                            );
            Console.ReadKey();

        }
    }
}
