using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceExcersize
{
    public class Reptile : Animal
    {
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }
        public bool IsPoisonous { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, string color, int age, bool isPredator, double length, double weight, 
            string habitat, bool isPoisonous) : base (name, color, age, isPredator)
        {
            Length = length;
            Weight = weight;
            Habitat = habitat;
            IsPoisonous = isPoisonous;
        }
        public override string ToString()
        {
            return $"\nAnimal Name: {Name} \nAnimal Color: {Color} \nAnimal Age: {Age} \nTrue if predatory: {IsPredator} \nLength: {Length} \nWeight: {Weight}" +
                $"\nAnimal Location: {Habitat} \nTrue if poisonous: {IsPoisonous}";
        }
    }
}
