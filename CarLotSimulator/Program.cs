using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car Car1 = new Car();
            Car1.Year = 2020;
            Car1.Make = "Lamborhini.";
            Car1.Model = "Huracan Evo RWD.";
            Car1.EngineNoise = "is loud.";
            Car1.HonkNoise = "loud and the perfect pitch.";
            Car1.IsDriveable = "Easy to drive.";
            CarLot CarLot1 = new CarLot();
            CarLot1.CarList.Add(Car1);
            Console.WriteLine($"The make of the car is {Car1.Make}");
            Console.WriteLine($"The year of the car is {Car1.Year}.");
            Console.WriteLine($"The model of the car is {Car1.Model}");
            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHonkNoise(Car1.HonkNoise);
            Console.WriteLine($"The car is {Car1.IsDriveable}");
            Console.WriteLine();
            Console.WriteLine($"This is car number {CarLot.numberOfCars}");
            Console.WriteLine("---------------------------------------------------------------");


            Car Car2 = new Car("BMW.", 2021, "Mini Cooper JCW GP.", "is loud.", "loud.", "easy to drive.");
            {
               
                Car2.Year = 2018;
                Car2.Make = "Dodge.";
                Car2.Model = "Dodge Hellcat Challenger.";
                Car2.EngineNoise = "is loud and whines.";
                Car2.HonkNoise = "weak.";
                Car2.IsDriveable = "Easy to drive.";
                CarLot CarLot2 = new CarLot();
                CarLot2.CarList.Add(Car2);
                Console.WriteLine();
                Console.WriteLine($"The make of the car is {Car2.Make}");
                Console.WriteLine($"The year of the car is {Car2.Year}.");
                Console.WriteLine($"The model of the car is {Car2.Model}");
                Car2.MakeEngineNoise(Car2.EngineNoise);
                Car2.MakeHonkNoise(Car2.HonkNoise);
                Console.WriteLine($"The car is {Car2.IsDriveable}");
                
            }
            Console.WriteLine();
            Console.WriteLine($"This is car number {CarLot.numberOfCars}");
            Console.WriteLine("---------------------------------------------------------------");


            Car Car3 = new Car();
            Car3.Year = 2021;
            Car3.Make = "BMW.";
            Car3.Model = "Mini Cooper JCW GP.";
            Car3.EngineNoise = "is loud.";
            Car3.HonkNoise = "loud.";
            Car3.IsDriveable = "easy to drive.";
            
            CarLot CarLot3 = new CarLot();
            CarLot3.CarList.Add(Car3);
            foreach (var car in CarLot3.CarList)
            {
                Console.WriteLine($"The make of the car is {Car3.Make}");
                Console.WriteLine($"The year of the car is {Car3.Year}.");
                Console.WriteLine($"The model of the car is {Car3.Model}");
                Car3.MakeEngineNoise(Car3.EngineNoise);
                Car3.MakeHonkNoise(Car3.HonkNoise);
                Console.WriteLine($"The car is {Car3.IsDriveable}");
            }
            Console.WriteLine();
            Console.WriteLine($"This is car number {CarLot.numberOfCars}");
            Console.WriteLine("---------------------------------------------------------------");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a CarLot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
