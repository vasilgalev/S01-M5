using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BorderControl
{
    internal class Robot : Humanoid
    {
        public string Model { get; set; }
        public Robot(string model,string id) 
        : base(id)
        {
            this.Model = model;
        }
    }
}
