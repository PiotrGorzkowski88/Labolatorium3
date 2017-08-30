using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pg_chess.Chess;

namespace pg_chess
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine("#######################################################");
            Console.WriteLine("##                  Laboratorium nr3                 ##");
            Console.WriteLine("#######################################################");
            Console.WriteLine();
        }

        static void CheckNewAndOverride()
        {
            Console.WriteLine("Checking new and override differences...\n");
            Pawn p = new Pawn();
            Console.WriteLine("ChildClass: " + p); //Child class
            Figure f = p;
            Console.WriteLine("ParentClass: " + f); //Parent class
        }

        private static void OnMoveFigure(Figure figure, Position position)
        {
            Console.WriteLine(figure + " I've just moved to " + position + ".");
        }

        static void Main(string[] args)
        {
            //Writing header
            Header();

            //Checkint new and override operators
            CheckNewAndOverride();

            //Making figures
            Figure figure1 = new Pawn();
            figure1.Color = ChessColor.Black;
            figure1.Position = new Position(1,4);

            Figure figure2 = new Pawn();
            figure2.Color = ChessColor.White;
            figure2.Position = new Position(3, 4);

            Figure figure3 = new King();
            figure3.Color = ChessColor.Black;
            figure3.Position = new Position(5, 4);

            Figure figure4 = new Bishop();
            figure4.Color = ChessColor.White;
            figure4.Position = new Position(5, 5);

            Figure figure5 = new Castle();
            figure5.Color = ChessColor.White;
            figure5.Position = new Position(3, 7);

            //Creating delegate
            MoveEvent onMoveEvent = new MoveEvent(OnMoveFigure);

            //Adding delegate to figures callbacks.
            figure3.OnMove = onMoveEvent;
            figure5.OnMove = onMoveEvent;

            //Checking delegate
            figure3.Position = new Position(1, 1);
            figure5.Position = new Position(2, 5);

            //Is error when there will be no delegate
            try
            {
                figure1.Position = new Position(2, 7);
                Console.WriteLine("Is error when there will be no delegate? Everithing is OK.");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //Creating chessBoard
            ChessBoard chessBoard = new ChessBoard();

            //Putting figures on chessboard
            chessBoard[figure1.Position] = figure1;
            chessBoard[figure2.Position] = figure2;
            chessBoard[figure3.Position] = figure3;
            chessBoard[figure4.Position] = figure4;
            chessBoard[figure5.Position] = figure5;

            //Check hoe many is on figures is on chessboard
            Console.WriteLine("On chessboard is " + chessBoard.Count() + " figures.");

            //Reading Key
            Console.ReadKey();
        }
    }
}
