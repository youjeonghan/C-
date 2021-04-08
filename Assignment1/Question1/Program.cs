using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question1\n");
            string indent = "   ";

            // Shape Output
            Console.WriteLine(" *********" + indent + "  ***  " + indent + "  *  " + indent + "    *    ");
            Console.WriteLine(" *       *" + indent + " *   * " + indent + " *** " + indent + "   * *   ");
            Console.WriteLine(" *       *" + indent + "*     *" + indent + "*****" + indent + "  *   *  ");
            Console.WriteLine(" *       *" + indent + "*     *" + indent + "  *  " + indent + " *     * ");
            Console.WriteLine(" *       *" + indent + "*     *" + indent + "  *  " + indent + "*       *");
            Console.WriteLine(" *       *" + indent + "*     *" + indent + "  *  " + indent + " *     * ");
            Console.WriteLine(" *       *" + indent + "*     *" + indent + "  *  " + indent + "  *   *  ");
            Console.WriteLine(" *       *" + indent + " *   * " + indent + "  *  " + indent + "   * *   ");
            Console.WriteLine(" *********" + indent + "  ***  " + indent + "  *  " + indent + "    *    ");
        }
    }
}
