using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1_CharacterEditor
{
    public class Character
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        decimal age;

        public decimal Age
        {
            get { return age; }
            set { age = value; }
        }

        public Character()
        {

        }

        public override string ToString()
        {
            return name;
        }
    }
}
