using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    class Bishop : Figure
    {
        public override bool CanMove(Position position)
        {
            Position checkedPosition = this.Position.Copy();
            while(checkedPosition.X < 8 && checkedPosition.Y < 8)
            {
                checkedPosition.X++;
                checkedPosition.Y++;
                if (position.Equals(checkedPosition))
                    return true;
            }

            checkedPosition = this.Position.Copy();
            while(checkedPosition.X >= 0 && checkedPosition.Y < 8)
            {
                checkedPosition.X--;
                checkedPosition.Y++;
                if (position.Equals(checkedPosition))
                    return true;
            }

            checkedPosition = this.Position.Copy();
            while (checkedPosition.X < 8 && checkedPosition.Y >= 0)
            {
                checkedPosition.X++;
                checkedPosition.Y--;
                if (position.IsEqual(checkedPosition))
                    return true;
            }

            checkedPosition = this.Position.Copy();
            while (checkedPosition.X >= 0 && checkedPosition.Y >= 0)
            {
                checkedPosition.X--;
                checkedPosition.Y--;
                if (position.IsEqual(checkedPosition))
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "I am bishop on position " + Position + ".";
        }
    }
}
