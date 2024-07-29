using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Play_Math.Quizz
{
    public partial class FrmQuizz : Form
    {
        private readonly Random _rand = new Random();

        private readonly Quiz _currentQuiz;

        private int _currentQuestionIndex;

        public FrmQuizz(QuestionLevel level, OperationType opType, int numberOfQuestions)
        {
            InitializeComponent();
            _currentQuiz = new Quiz(level, opType, numberOfQuestions);
            InitializeButtonEventHandlers();
        }

        private void InitializeButtonEventHandlers()
        {
            btnResult1.Click += CheckAnswer;
            btnResult2.Click += CheckAnswer;
            btnResult3.Click += CheckAnswer;
            btnResult4.Click += CheckAnswer;
        }

        private void FrmQuizz_Load(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void StartQuiz()
        {
            _currentQuestionIndex = 0;
            _currentQuiz.GenerateQuestions();
            DisplayNextQuestion();
        }

        private void DisplayNextQuestion()
        {
            if (_currentQuestionIndex < _currentQuiz.Questions.Count)
            {
                var question = _currentQuiz.Questions[_currentQuestionIndex];
                DisplayQuestion(question);
                GenerateAnswerOptions(question.CorrectAnswer);
            }
            else
            {
                ShowQuizResults();
            }
        }

        private void DisplayQuestion(Question question)
        {
            lblQuestion1.Text = question.Number1.ToString();
            lblQuestion2.Text = question.Number2.ToString();
            lblOperation1.Text = GetOperationSymbol(question.OpType);
        }

        private void GenerateAnswerOptions(int correctAnswer)
        {
            var answers = new List<int> { correctAnswer };
            while (answers.Count < 4)
            {
                int wrongAnswer = GenerateWrongAnswer(correctAnswer);
                if (!answers.Contains(wrongAnswer))
                {
                    answers.Add(wrongAnswer);
                }
            }

            answers.Shuffle();

            btnResult1.Text = answers[0].ToString();
            btnResult2.Text = answers[1].ToString();
            btnResult3.Text = answers[2].ToString();
            btnResult4.Text = answers[3].ToString();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int chosenAnswer = int.Parse(button.Text);
            var currentQuestion = _currentQuiz.Questions[_currentQuestionIndex];

            if (chosenAnswer == currentQuestion.CorrectAnswer)
            {
                button.BackColor = Color.Green;
                _currentQuiz.CorrectAnswers++;
            }
            else
            {
                button.BackColor = Color.Red;
                _currentQuiz.IncorrectAnswers++;
            }

            _currentQuestionIndex++;
            Task.Delay(1000).ContinueWith(_ =>
            {
                ResetButtonColors();
                DisplayNextQuestion();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ResetButtonColors()
        {
            btnResult1.BackColor = SystemColors.Control;
            btnResult2.BackColor = SystemColors.Control;
            btnResult3.BackColor = SystemColors.Control;
            btnResult4.BackColor = SystemColors.Control;
        }

        private void ShowQuizResults()
        {
            MessageBox.Show($"Quiz completed!\nCorrect Answers: {_currentQuiz.CorrectAnswers}\nIncorrect Answers: {_currentQuiz.IncorrectAnswers}");
            Close();
        }

        private string GetOperationSymbol(OperationType opType) =>
            opType switch
            {
                OperationType.Addition => "+",
                OperationType.Subtraction => "-",
                OperationType.Multiplication => "*",
                OperationType.Division => "/",
                _ => "?"
            };

        private int GenerateWrongAnswer(int correctAnswer)
        {
            int wrongAnswer;
            do
            {
                wrongAnswer = correctAnswer + _rand.Next(-10, 11);
            } while (wrongAnswer == correctAnswer);
            return wrongAnswer;
        }
    }

    public enum QuestionLevel
    {
        Easy = 1,
        Medium,
        Hard,
        Mixed
    }

    public enum OperationType
    {
        Addition = 1,
        Subtraction,
        Multiplication,
        Division,
        Mixed
    }

    public class Question
    {
        public int Number1 { get; }
        public int Number2 { get; }
        public OperationType OpType { get; }
        public QuestionLevel Level { get; }
        public int CorrectAnswer { get; }

        public Question(int number1, int number2, OperationType opType, QuestionLevel level, int correctAnswer)
        {
            Number1 = number1;
            Number2 = number2;
            OpType = opType;
            Level = level;
            CorrectAnswer = correctAnswer;
        }
    }

    public class Quiz
    {
        private readonly Random _rand = new Random();
        public List<Question> Questions { get; } = new List<Question>();
        public QuestionLevel Level { get; }
        public OperationType OpType { get; }
        public int NumberOfQuestions { get; }
        public int CorrectAnswers { get; set; }
        public int IncorrectAnswers { get; set; }
        public bool IsPass => CorrectAnswers >= IncorrectAnswers;

        public Quiz(QuestionLevel level, OperationType opType, int numberOfQuestions)
        {
            Level = level;
            OpType = opType;
            NumberOfQuestions = numberOfQuestions;
        }

        public void GenerateQuestions()
        {
            Questions.Clear();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions.Add(GenerateQuestion());
            }
        }

        private Question GenerateQuestion()
        {
            var level = Level == QuestionLevel.Mixed ? (QuestionLevel)_rand.Next(1, 4) : Level;
            var opType = OpType == OperationType.Mixed ? (OperationType)_rand.Next(1, 5) : OpType;

            var (number1, number2) = GenerateNumbers(level);
            int correctAnswer = CalculateAnswer(number1, number2, opType);

            return new Question(number1, number2, opType, level, correctAnswer);
        }

        private (int, int) GenerateNumbers(QuestionLevel level) =>
            level switch
            {
                QuestionLevel.Easy => (_rand.Next(1, 10), _rand.Next(1, 10)),
                QuestionLevel.Medium => (_rand.Next(11, 30), _rand.Next(11, 30)),
                QuestionLevel.Hard => (_rand.Next(31, 100), _rand.Next(31, 100)),
                _ => throw new ArgumentOutOfRangeException(nameof(level))
            };

        private int CalculateAnswer(int number1, int number2, OperationType opType) =>
            opType switch
            {
                OperationType.Addition => number1 + number2,
                OperationType.Subtraction => number1 - number2,
                OperationType.Multiplication => number1 * number2,
                OperationType.Division => number1 / number2,
                _ => throw new ArgumentOutOfRangeException(nameof(opType))
            };
    }

    public static class ListExtensions
    {
        private static Random _rand = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}