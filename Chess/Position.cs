using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    public class Position
    {
        int _x;
        int _y;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position Copy()
        {
            return new Position(X, Y);
        }

        public override string ToString()
        {
            return X + ", " + Y;
        }

        public override bool Equals(object obj)
        {
            if(! (obj is Position) )
            {
                return false;
            } 

            return X == ((Position) obj).X && Y == ((Position) obj).Y;
        }

        public bool IsEqual(Position obj)
        {
            return X == obj.X && Y == obj.Y;
        }

        public override int GetHashCode()
        {
            return X + (Y * 100);
        }
    }
}
