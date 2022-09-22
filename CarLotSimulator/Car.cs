using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string make, int year, string model, string enginenoise, string honknoise, string isdriveable)
        {
            Make = make;
            Year = year;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
        }
        public void MakeEngineNoise (string noise)
        {
            Console.WriteLine($"The sound of the engine {noise}");
        }
        public void MakeHonkNoise (string noise)
        {
            Console.WriteLine($"the sound of the honk is {noise}");
        }


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Enginenoise { get; }
        public string Honknoise { get; }
        public string Isdriveable { get; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

    }
}
