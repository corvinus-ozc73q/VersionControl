using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Abstractions;

namespace Week6.Entities
{
    public class BallFactory: IToyFactory
    {
        public ConsoleColor BackColor { get; set;}
        public Color BallColor { get; private set; }

        public Toy CreateNew()
        {
            return new Ball(BallColor);
        }

        public static implicit operator BallFactory(CarFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
