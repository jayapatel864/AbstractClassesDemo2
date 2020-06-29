using System;




namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var jayasCar = new Car();
            jayasCar.Make = "Honda";
            jayasCar.Model = "CRV";
            jayasCar.Year = 2016;
            jayasCar.EngineNoise = "vroom";
            jayasCar.HonkNoise = "veep";
            jayasCar.IsDriveable = true;

            var dadsCar = new Car();
            dadsCar.Make = "Audi";
            dadsCar.Model = "A 8";
            dadsCar.Year = 2014;
            dadsCar.EngineNoise = "broom";
            dadsCar.HonkNoise = "beep";
            dadsCar.IsDriveable = true;

               

        }
    }
}
