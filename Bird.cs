using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceExcersize
{
    public class Bird : Animal
    {
        public bool Sings { get; set; }
        public bool IsRare { get; set; }
        public string AreaFound { get; set; }
        public bool Swims { get; set; }

        public Bird()
        {

        }

        public Bird(string name, string color, int age, bool isPredator, bool sings, bool isRare, string areaFound, 
            bool swims) : base (name,color,age,isPredator)
        {
            Sings = sings;
            IsRare = isRare;
            AreaFound = areaFound;
            Swims = swims;
        }

        public override string ToString()
        {
            return $"\nAnimal Name: {Name} \nAnimal Color: {Color} \nAnimal Age: {Age} \nTrue if predatory: {IsPredator} \nTrue if sings: {Sings} \nTrue if rare: {IsRare}" +
                $"\nAnimal Location: {AreaFound} \nTrue if swims: {Swims}";
        }
    }
}
