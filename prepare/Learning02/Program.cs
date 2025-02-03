using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        /*
        Nouns
        ====
        - X and 0
        - x board

        verbs
        ====
        -display
        -place a sym
        - who won
        - is game finished

        */

        box

        string var = "";



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe\n");

            
            char[] board = {'X', '0', ' ',            '0', ' ', 'X',           '0', 'X', ' '};

            Display(board);

        }
    

    static void MakeMove(char[] board, int x, int y, char symbol)
    {
        int index = x * 3 + y;
        board[index] = symbol;
    }

    }
}
