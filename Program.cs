using System.Collections.Generic;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Topic_1___The_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //S.B

            //Part 1

            string firstName, favMovie;
            firstName = "Sak";
            favMovie = "The Matrix";

            //a - all lowercase
            Console.WriteLine($"Hello I'm {firstName}, and my favorite movie is {favMovie}.".ToLower());
            
            //b - only the movie is all uppercase
            favMovie = favMovie.ToUpper();
            Console.WriteLine($"Hello I'm {firstName}, and my favorite movie is {favMovie}.");

            //c - Use the .Contains() method to determine whether the movie title (now all capital letters) contains the word “THE” in it.Print out ‘True’, or ‘False’. 
            Console.WriteLine($"does the movie title contain the word 'THE'?");
            Console.WriteLine(favMovie.Contains("THE"));

            //d - Use the .Replace() method to replace the letter “A” with “@” and “E” with “3”. Once done, print the new string.
            favMovie = favMovie.Replace("A", "@").Replace("E", "3");
            firstName = firstName.Replace("A", "@").Replace("E", "3");
            Console.WriteLine($"Hello I'm {firstName}, and my favorite movie is {favMovie}.");




            //space to separate the two parts
            Console.WriteLine(" ");
            Console.WriteLine(" ");
           



            //Part 2
            //Make a variable with an appropriate name that stores your favourite quote from a movie, TV show or song(or any other source you like).The quote must be at least a short sentence.
            string favQuote = "'You are the only feller who got half of their brain eaten by wolves and ended up more intelligent.' -Arthur Morgan";
            favMovie = favMovie.ToUpper();
            
            //a & b - Remove all of the vowels from the quote by replacing then with the empty string (“”).
            favQuote = favQuote.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
            favQuote = favQuote.Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");
            Console.WriteLine(favQuote);


            //space to separate the two parts
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            //Part 3
            //Use the internet to find some ASCII art. Have your program print out TWO different ASCII art images.

            //a - print out 2 pictures side by side.
            //You may use a combination of Console.Write() and Console.WriteLine() statements to print each line of the images on the same line.

            string image1, image2;
            image1 = "                  __\r\n                 / _,\\\r\n                 \\_\\\r\n      ,,,,    _,_)  #      /)\r\n     (= =)D__/    __/     //\r\n    C/^__)/     _(    ___//\r\n      \\_,/  -.   '-._/,--'\r\n_\\\\_,  /           -//.\r\n \\_ \\_/  -,._ _     ) )\r\n   \\/    /    )    / /\r\n   \\-__,/    (    ( (\r\n              \\.__,-)\\_\r\n               )\\_ / -(\r\n    b'ger     / -(////\r\n             ////";
            image2 = "       .-\"-.            .-\"-.            .-\"-.           .-\"-.\r\n     _/_-.-_\\_        _/.-.-.\\_        _/.-.-.\\_       _/.-.-.\\_\r\n    / __} {__ \\      /|( o o )|\\      ( ( o o ) )     ( ( o o ) )\r\n   / //  \"  \\\\ \\    | //  \"  \\\\ |      |/  \"  \\|       |/  \"  \\|\r\n  / / \\'---'/ \\ \\  / / \\'---'/ \\ \\      \\'/^\\'/         \\ .-. /\r\n  \\ \\_/`\"\"\"`\\_/ /  \\ \\_/`\"\"\"`\\_/ /      /`\\ /`\\         /`\"\"\"`\\\r\n   \\           /    \\           /      /  /|\\  \\       /       \\\r\n\r\n-={ see no evil }={ hear no evil }={ speak no evil }={ have no fun }=-";

            Console.WriteLine($"{image1}   {image2}");

            Console.ReadLine();
        }
    }
}
