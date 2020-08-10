using System;

namespace DealingWithExceptionsn
{
    class Program
    {
        static void Main(string[] args)
        {
            var johnCurrier = new Currier() { Name = "John" };

            johnCurrier.Deliver();
        }
    }

    public class Currier
    {
        public string Name { get; set; }

        public void Deliver()
        {
            Move(100, Surface.Grass);
            Move(200, Surface.Ground);
            Move(1, Surface.Obstacle);

            GiveProduct();
        }

        private void GiveProduct() 
        {
            Console.WriteLine("The product has been delivered");
        }

        private void Move(int distance, Surface surface) 
        {
            //Some logic..

            if (surface == Surface.Obstacle)
            {
                throw new Exception("A wheel is broken");
            }
        }

        public enum Surface {
            Ground,
            Grass,
            Obstacle
        }
    } 
}
