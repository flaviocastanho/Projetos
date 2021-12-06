using System;

namespace ConsoleSealed
{
    internal class Sealed
    {
        sealed class SealedClass
        {
            public int x;
            public int y;
        }

        static void Main()
        {
            /*             
                Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela. No exemplo a seguir, a classe B herda da classe A, mas nenhuma classe pode herdar da classe B.
            */

            var sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine($"x = {sc.x}, y = {sc.y}");
        }
    }
}
