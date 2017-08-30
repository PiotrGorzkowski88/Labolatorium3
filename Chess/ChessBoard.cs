using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pg_chess.Chess
{
    class ChessBoard : IEnumerable<Figure>, ISerializable
    {
        private Dictionary<Position, Figure> figures = new Dictionary<Position, Figure>();

        public void Add(Position position, Figure figure)
        {
            figures.Add(position, figure);
        }

        public Figure this[Position position]
        {
            get
            {
                return figures[position];
            }
            
            set
            {
                if(IsFigureOn(position))
                {
                    figures[position] = value;
                } else
                {
                    figures.Add(position, value);
                }
            }
        }

        public int Count()
        {
            return figures.Count();
        }

        public bool IsFigureOn(Position position)
        {
            return figures.ContainsKey(position);
        }

        public IEnumerator<Figure> GetEnumerator()
        {
            return figures.Values.GetEnumerator();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)figures).GetObjectData(info, context);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
