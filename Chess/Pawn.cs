using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    class Pawn : Figure
    {
        public override bool CanMove(Position position)
        {
            int deltaY = position.Y - this.Position.Y;

            if(position.X != this.Position.X)
            {
                return false;
            }

            if(this.Color == ChessColor.Black && deltaY == -1)
            {
                return true;
            }

            if (this.Color == ChessColor.White && deltaY == 1)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "I am pawn on position " + Position + ".";
        }
    }
}
