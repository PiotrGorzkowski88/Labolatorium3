using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    class King : Figure
    {
        public override bool CanMove(Position position)
        {
            int deltaX = Math.Abs(position.X - this.Position.X);
            int deltaY = Math.Abs(position.Y - this.Position.Y);

            if ((deltaX == 1) && (deltaY == 1))
                return true;

            if ((deltaX == 1) && (position.Y == this.Position.Y))
                return true;

            if ((deltaY == 1) && (position.X == this.Position.X))
                return true;

            return false;
        }

        public override string ToString()
        {
            return "I am king on position " + Position + ".";
        }
    }
}
