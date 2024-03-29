﻿using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player 1");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);

            //xxxxxxxxxxxxxxxxxxxxxxxx
            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            Console.SetCursorPosition(35, 19);

            Console.Write("Player 2");

            Console.SetCursorPosition(35, 20);

            Console.Write("Please Enter Row: ");
            var row1 = Console.ReadLine();

            Console.SetCursorPosition(35, 22);


            Console.Write("Please Enter Column: ");
            var column1 = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);            

        }

    }
}
