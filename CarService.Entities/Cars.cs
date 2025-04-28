using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Entities
{
    public class Cars
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string imageUrl { get; set; }
    }

  //  function GenerateRandomCar() {
  //const cars = [
  //  { name: "Toyota Corolla", imageUrl: "/images/Toyota-Corolla.jpg", gradient: "from-blue-600 to-indigo-900" },
  //  { name: "BMW X5", imageUrl: "/images/BMW-X5.jpg", gradient: "from-orange-400 to-red-600" },
  //  { name: "Audi A4", imageUrl: "/images/Audi-A4.jpg", gradient: "from-black to-gray-800" },
  //  { name: "Mercedes A-Class", imageUrl: "/images/Mercedes-A-Class.jpg", gradient: "from-red-800 to-gray-950" }
  //];

  //const years = [2018, 2019, 2020, 2021, 2022];

  //const problems = [
  //  // Easy (User özü düzəldəcək)
  //  { level: "Easy", problem: "Flat Tire", description: "The tire loses air pressure and needs replacement." },
  //  { level: "Easy", problem: "Oil Change", description: "The engine oil needs to be changed regularly." },
  //  { level: "Easy", problem: "Air Filter Replacement", description: "The air filter is dirty and needs replacement." },
  //  { level: "Easy", problem: "Battery Replacement", description: "The battery is dead and requires replacement." },
  //  { level: "Easy", problem: "Wiper Blade Change", description: "The wiper blades are worn out and need changing." },

  //  // Medium
  //  { level: "Medium", problem: "Brake Pad Replacement", description: "Brake pads are worn and need replacement." },
  //  { level: "Medium", problem: "Coolant Leak Repair", description: "Coolant system is leaking and requires repair." },
  //  { level: "Medium", problem: "Spark Plug Replacement", description: "Spark plugs are faulty and need changing." },
  //  { level: "Medium", problem: "Wheel Alignment", description: "Wheels need realignment to fix steering issues." },
  //  { level: "Medium", problem: "Headlight Replacement", description: "The headlights are broken or burnt out." },

  //  // Difficult
  //  { level: "Difficult", problem: "Transmission Failure", description: "Transmission system is failing completely." },
  //  { level: "Difficult", problem: "Engine Overheating", description: "Engine overheats and may be seriously damaged." },
  //  { level: "Difficult", problem: "Timing Belt Failure", description: "Timing belt has broken and engine synchronization is lost." },
  //  { level: "Difficult", problem: "Fuel Pump Failure", description: "Fuel pump has failed, causing fuel delivery issues." },
  //  { level: "Difficult", problem: "Clutch System Failure", description: "Clutch has completely failed and needs full replacement." },
  //];
  //const randomCar = cars[Math.floor(Math.random() * cars.length)];
  //const randomYear = years[Math.floor(Math.random() * years.length)];
  //const randomProblem = problems[Math.floor(Math.random() * problems.length)];

}
