using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    public delegate void MoveEvent(Figure figure, Position position);

    abstract public class Figure
    {
        public ChessColor Color { get; set; }
        protected Position _position;

        public Position Position {
            get { return _position; }
            set {
                _position = value;
                OnMove?.Invoke(this,value);
            }
        }

        public MoveEvent OnMove { get; set; }
        
        public Figure() { }
        
        public abstract bool CanMove(Position position);

        public override string ToString()
        {
            return "?";
        }
    }
}
