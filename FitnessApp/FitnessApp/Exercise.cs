using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    //What it is: one specific movement - squat, lunge, etc.
    //    Изчисляване на тренировъчен обем(sets × reps × weight)
    internal class Exercise
    {
  
            // Exersice name (example "Squat", "Lunge")
            public string Name { get; set; }

            public int Sets { get; set; }

            public int Reps { get; set; }

            public double Weight { get; set; }

            public Exercise(string name, int sets, int reps, double weight)
            {
                Name = name;
                Sets = sets;
                Reps = reps;
                Weight = weight;
            }

            public double CalculateTrainingVolume()
            {
                return Sets * Reps * Weight;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Exercise: {Name}");
                Console.WriteLine($"Sets: {Sets}, Reps: {Reps}, Weight: {Weight} kg");
                Console.WriteLine($"Training Volume: {CalculateTrainingVolume()} kg");
            }
        }
    }
