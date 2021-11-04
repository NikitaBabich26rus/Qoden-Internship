using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    public class WordStatistics
    {
        private double _numberPointsForProcent;

        private List<string> ParseWords(string text)
            => text.Split(' ')
                .ToList();

        private bool IsContainWordFromWords(string word, List<(string, int)> words)
            => words
                .Select(a => a.Item1)
                .Contains(word);

        public List<string> GetStatistics(string text)
        {
            var words = ParseWords(text);
            var wordStatistics = new List<(string, int)>();

            foreach (var word in words)
            {
                if (!IsContainWordFromWords(word, wordStatistics))
                {
                    wordStatistics.Add((word, words.Count(a => a == word)));
                }
            }
            var sortedWordStatistics = wordStatistics.OrderBy(a => a.Item2);
            _numberPointsForProcent = 10.0 / sortedWordStatistics.Last().Item2;

            var maxLenghtWord = sortedWordStatistics
                .Select(a => a.Item1.Length)
                .Max();

            return sortedWordStatistics
                .Select(a => GetWordStatistics(a.Item1, maxLenghtWord, a.Item2))
                .ToList();
        }

        private string GetWordStatistics(string word, int maxLenghtWord, int repetitionRate)
        {
            var result = "";
            for (int i = 0; i < maxLenghtWord - word.Length; i++)
            {
                result += '_';
            }
            result += $"{word} ";
            var res = Math.Round(repetitionRate * _numberPointsForProcent);
            for (int i = 0;  i < Convert.ToInt32(Math.Round(repetitionRate * _numberPointsForProcent)); i++)
            {
                result += '.';
            }
            return result;
        }
    }
}
