using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    //You rank players in the game from highest to lowest score.So far you're using an algorithm that sorts in O(n\lg{n})O(nlgn) time, but players are complaining that their rankings aren't updated fast enough.You need a faster sorting algorithm.

    //Write a function that takes:


    //an array of unsortedScores
    //the highestPossibleScore in the game
    //and returns a sorted array of scores in less than O(n\lg{ n})O(nlgn) time.

    //For example:

    //  int[] unsortedScores = { 37, 89, 41, 65, 91, 53 };
    //    final int HIGHEST_POSSIBLE_SCORE = 100;

    //    int[] sortedScores = sortScores(unsortedScores, HIGHEST_POSSIBLE_SCORE);
    //    // sortedScores: [37, 41, 53, 65, 89, 91]

    //    We’re defining nn as the number of unsortedScores because we’re expecting the number of players to keep climbing.

    //    And we'll treat highestPossibleScore as a constant instead of factoring it into our big O time and space costs, because the highest possible score isn’t going to change. Even if we do redesign the game a little, the scores will stay around the same order of magnitude.
    public class ScoreSorter
    {
        public int[] SortScores(int[] unsortedScores, int highestPossibleScore)
        {
            //big array
            var scoreToCounts = new int[highestPossibleScore+1];
            foreach (var score in unsortedScores)
            {
                scoreToCounts[score]++;
            }
            var outputArray = new int[unsortedScores.Length];
            var currentSortedIndex = 0;
            for (int i = 0; i < scoreToCounts.Length; i++)
            {
                for (int j = 0; j < scoreToCounts[i]; j++)
                {
                    outputArray[currentSortedIndex] = i;
                    currentSortedIndex++;
                }
            }
            
            return outputArray;
        }
    }
}
