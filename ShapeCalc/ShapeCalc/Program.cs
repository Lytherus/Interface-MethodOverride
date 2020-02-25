using System;

namespace ShapeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            outputSentence();
            outputSentence(6,7,'w');
            outputSentence(true);
            outputSentence(9.8);
            outputSentence(3);

        }

        static void outputSentence()
        {
            Console.WriteLine("This is no parameters.");
        }
        static void outputSentence(int x)
        {
            Console.WriteLine("This is an int parameter.");
        }
        static void outputSentence(double x)
        {
            Console.WriteLine("This is a double parameter.");
        }
        static void outputSentence(bool t)
        {
            Console.WriteLine("This is the bool parameter.");
        }
        static void outputSentence(int x, int y, char z)
        {
            Console.WriteLine("This is three parameters.");
        }
    }
}
