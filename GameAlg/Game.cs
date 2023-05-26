using System;
using System.Collections.Generic;
using System.Xml;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAlg
{
    public partial class Game : Form
    {
        private List<Question> _questions = new List<Question>(); // lista cu intrebari
        private int _currentQuestionIndex = 0; // indexul intrebarii curente
        private int _questionsNumber = 0; // numarul total de intrebari
        private int _userScore = 0; // scorul utilizatorului

        // timer
        private Timer _timer;
        private int _remainingSeconds = 30;


        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadQuestions("questions.xml"); // incarcare intrebari
            totalQuestionsLabel.Text = _questionsNumber.ToString(); // update la numarul total de intrebari in functie de cate intrebari sunt in XML
            StartTimer();
            DisplayCurrentQuestion();
        }

        private void LoadQuestions(string fileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileName);

            XmlNodeList questionNodes = xmlDoc.GetElementsByTagName("question");
            foreach (XmlNode questionNode in questionNodes)
            {
                int id = int.Parse(questionNode.Attributes["id"].Value);
                string text = questionNode.SelectSingleNode("text").InnerText;
                string answer = questionNode.SelectSingleNode("answer").InnerText;

                List<string> choices = new List<string>();
                XmlNodeList choiceNodes = questionNode.SelectNodes("choices/choice");

                foreach (XmlNode choiceNode in choiceNodes)
                {
                    choices.Add(choiceNode.InnerText);
                }
                _questions.Add(new Question(id, text, answer, choices));
            }
            _questionsNumber = _questions.Count; // numar total intrebari

            // randomizare intrebari
            Random rand = new Random();
            _questions = _questions.OrderBy(q => rand.Next()).ToList();
        }

        private void DisplayCurrentQuestion()
        {
            _remainingSeconds = 30; // resetare time 

            questionNrLabel.Text = (_currentQuestionIndex + 1).ToString();
            Question currentQuestion = _questions[_currentQuestionIndex];

            questionLabel.Text = currentQuestion.Text;
            questionLabel.AutoSize = true;

            // populare lista cu alegeriv - alegerile sunt randomizate
            List<string> choices = currentQuestion.ShuffleChoices();
            answer1.Text = choices[0];
            answer2.Text = choices[1];
            answer3.Text = choices[2];
            answer4.Text = choices[3];

            // debifate toate by default
            answer1.Checked = false;
            answer2.Checked = false;
            answer3.Checked = false;
            answer4.Checked = false;
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            // Verificare daca raspunsul e corect
            RadioButton selectedAnswer = null;
            foreach (Control control in questionBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    selectedAnswer = radioButton;
                    break;
                }
            }

            // update scor
            if (selectedAnswer != null)
            {
                Question currentQuestion = _questions[_currentQuestionIndex];
                string correctAnswer = currentQuestion.Answer;

                if (selectedAnswer.Text == correctAnswer)
                {
                    _userScore += 5;
                    scoreNumber.Text = _userScore.ToString();
                }
            }

            // Urmatoarea intrebare
            _currentQuestionIndex++;
            if (_currentQuestionIndex == _questionsNumber)
            {
                _timer.Stop();
                MessageBox.Show("Joc terminat! Scor total: " + _userScore, "Felicitari!", MessageBoxButtons.OK);
            }
            else
            {
                DisplayCurrentQuestion();
            }
        }

        private void StartTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000; // o secunda
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _remainingSeconds--;

            if (_remainingSeconds >= 0)
            {
                secondsLeftLabel.Text = _remainingSeconds.ToString();
            }
            else
            {
                _timer.Stop();
                MessageBox.Show("S-a scurs timpul!", "Timp scurs", MessageBoxButtons.OK);
                NextButtonClick(null, null);
            }
        }
    }
}
