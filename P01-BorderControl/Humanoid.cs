using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BorderControl
{
    public abstract class Humanoid
    {
        public Humanoid(string id)
        {
            ID = id;
        }

        public string ID { get; set; }

    }
}
