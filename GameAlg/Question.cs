using System;
using System.Collections.Generic;
using System.Linq;

namespace GameAlg
{
    class Question
    {
        private int _id;
        private string _text;
        private string _answer;
        private List<String> _choices;

        public string Text
        {
            get => _text;
        }

        public string Answer
        {
            get => _answer;
        }

        public List<String> Choices
        {
            get => _choices;
        }

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
    }
}
