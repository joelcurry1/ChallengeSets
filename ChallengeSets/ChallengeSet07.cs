using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {

            //if (businesses == null) return 0;
            //List<Business> negativenet = new List<Business>();
            //for (int i = 1; i <= businesses.Count; i++)
            //{
            //    if (i %4 == 0)
            //    {
            //        negativenet.Add(businesses[i - 1]);
            //    }
            //}
            //return negativenet.Count();
            int counter = 0;

            if (businesses == null || businesses.Count < 1) return 0;

            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue < biz.TotalExpenses)
                {
                    counter++;
                }
            }
            return counter;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            //List<string> businesses1 = new List<string>() { " " };
            //var result = string.Join(", ", businesses1.ToArray());

            //return result;
            string CommaSeperatedAnswer = "";

            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue > biz.TotalExpenses)
                {
                    CommaSeperatedAnswer += $"{biz.Name},";
                }
            }
            return CommaSeperatedAnswer.TrimEnd(',');

        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null)
            {
                return $"{business.Name}";
            }

            while (business.ParentCompany != null)
            {
                business = business.ParentCompany;
            }
            return $"{business.Name}";
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            //0 win check
            if (finalBoard[0,0] == 'O' && (finalBoard[0,0] == finalBoard[0,1]) && (finalBoard[0,1] == finalBoard[0,2]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[1, 0] == 'O' && (finalBoard[1, 0] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[1, 2]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[2, 0] == 'O' && (finalBoard[2, 0] == finalBoard[2, 1]) && (finalBoard[2, 1] == finalBoard[2, 2]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 0] == 'O' && (finalBoard[0, 0] == finalBoard[1, 0]) && (finalBoard[1, 0] == finalBoard[2, 0]))
            {
                return TicTacToeResult.O;
            }
        
            else if (finalBoard[0, 1] == 'O' && (finalBoard[0, 1] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[2, 1]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 2] == 'O' && (finalBoard[0, 2] == finalBoard[1, 2]) && (finalBoard[1, 2] == finalBoard[2, 2]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 0] == 'O' && (finalBoard[0, 0] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[2, 2]))
            {
                return TicTacToeResult.O;
            }
            else if (finalBoard[0, 2] == 'O' && (finalBoard[0, 2] == finalBoard[1, 1]) && (finalBoard[0, 1] == finalBoard[2, 0]))
            {
                return TicTacToeResult.O;
            }

            //X win check
            else if (finalBoard[0, 0] == 'X' && (finalBoard[0, 0] == finalBoard[0, 1]) && (finalBoard[0, 1] == finalBoard[0, 2]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[1, 0] == 'X' && (finalBoard[1, 0] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[1, 2]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[2, 0] == 'X' && (finalBoard[2, 0] == finalBoard[2, 1]) && (finalBoard[2, 1] == finalBoard[2, 2]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 0] == 'X' && (finalBoard[0, 0] == finalBoard[1, 0]) && (finalBoard[1, 0] == finalBoard[2, 0]))
            {
                return TicTacToeResult.X;
            }

            else if (finalBoard[0, 1] == 'X' && (finalBoard[0, 1] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[2, 1]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 2] == 'X' && (finalBoard[0, 2] == finalBoard[1, 2]) && (finalBoard[1, 2] == finalBoard[2, 2]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 0] == 'X' && (finalBoard[0, 0] == finalBoard[1, 1]) && (finalBoard[1, 1] == finalBoard[2, 2]))
            {
                return TicTacToeResult.X;
            }
            else if (finalBoard[0, 2] == 'X' && (finalBoard[0, 2] == finalBoard[1, 1]) && (finalBoard[0, 1] == finalBoard[2, 1]))
            {
                return TicTacToeResult.X;
            }
            else
            {
                return TicTacToeResult.Draw;
            }
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            List<int[]> list = new List<int[]>();
            

            if (numbers.Length < 1)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == targetNumber)
                    {
                        list.Add(numbers[i]);
                    }
                }
            }

            if (numbers.Length == list.Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
