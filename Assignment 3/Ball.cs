using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // represents a ball with size, color, and throw count
    public class Ball
    {
        // fields
        private int size;
        private readonly Color color;
        private int throwCount;

        // constructor initializing size and color
        public Ball(int size, Color color)
        {
            this.size = size;       // set initial size
            this.color = color;     // assign color
            throwCount = 0;         // start with zero throws
        }

        // pops the ball by setting size to zero
        public void Pop()
        {
            size = 0;
        }

        // throws the ball if it's not popped
        public void ThrowBall()
        {
            if (size > 0)
                throwCount++;      // only increment when size > 0
        }

        // returns total throws
        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}
