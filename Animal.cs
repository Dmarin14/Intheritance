using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceExcersize
{
    public class Animal
    {
        private string _name = String.Empty;
        private string _color = String.Empty;
        private int _age = 0;
        private bool _isPredator = false;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Name");
                _name = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Color");
                _color = value;
            }

        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Age");
                _age = value;
            }
        }

        public bool IsPredator
        {
            get { return _isPredator;}
            set { _isPredator = value;}
        }

        public Animal()
        {

        }

        public Animal(string name, string color, int age, bool isPredator)
        {
            Name = name;
            Color = color;
            Age = age;
            IsPredator = isPredator;
        }

        
    }
}   
