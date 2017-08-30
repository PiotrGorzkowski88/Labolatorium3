using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    class Castle : Figure
    {
        public override bool CanMove(Position position)
        {
            return position.X == this.Position.X || position.Y == this.Position.Y;
        }

        public override string ToString()
        {
            return "I am castle on position " + Position + ".";
        }
    }
}
