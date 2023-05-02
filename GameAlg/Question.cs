using System;
using System.Collections.Generic;
using System.Linq;

namespace GameAlg
{
    class Question
    {
        private int _id { get; }
        private string _text { get; }
        private string _answer { get; }
        private List<String> _choices { get; }

        public Question(int id, string text, string answer, List<String> choices)
        {
            _id = id;
            _text = text;
            _answer = answer;
            _choices = choices;
        }

        public List<String> ShuffleChoices()
        {
            var random = new Random();
            return _choices.OrderBy(x => random.Next()).ToList();
        }

        public string GetText()
        {
            return _text;
        }

        public string GetAnswer()
        {
            return _answer;
        }

        public List<String> GetChoices()
        {
            return _choices;
        }
    }
}
