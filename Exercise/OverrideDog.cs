using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
   public class OverrideDog
    {
        public string Name;
        public int Weight;

        public OverrideDog(string name, int weight)
        {
            Name = name;
            Weight = weight;

        }
        public override bool Equals(object obj)
        {
            if (obj is OverrideDog)
            {
                var CompareElement = obj as OverrideDog;
                if (CompareElement.Name == Name && CompareElement.Weight == Weight)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public override int GetHashCode()
        {
            return int.Parse("{weight}");
        }
    }
}
