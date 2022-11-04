using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Abstractions;

namespace Week6.Entities
{
    public class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        public static implicit operator BallFactory(CarFactory v)
        {
            throw new NotImplementedException();
        }
    }
}
