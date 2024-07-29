
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Play_Math.Quizz
{
    public partial class FrmQuizz : Form
    {
        private readonly Random _rand = new Random();

        private int correctAnswer; // Store the correct answer for comparison

        public FrmQuizz()
        {
            InitializeComponent();
            InitializeButtonEventHandlers(); // Initialize button event handlers
        }

        public FrmQuizz(QuestionLevel Level, OperationType OpType)
        {
            InitializeComponent();
            this.OpType = OpType;
            this.Level = Level;
            InitializeButtonEventHandlers(); // Initialize button event handlers
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

        public OperationType OpType { get; set; }
        public QuestionLevel Level { get; set; }

        public class Question
        {
            public int Number1 { get; set; }
            public int Number2 { get; set; }
            public OperationType OpType { get; set; }
            public QuestionLevel Level { get; set; }
            public int CorrectAnswer { get; set; }
            public int PlayerAnswer { get; set; }
            public bool IsCorrect => PlayerAnswer == CorrectAnswer;
        }

        public class Quiz
        {
            public List<Question> Questions { get; set; } = new List<Question>();
            public int NumberOfQuestions { get; set; }
            public OperationType OpType { get; set; }
            public QuestionLevel Level { get; set; }
            public int CorrectAnswers { get; set; }
            public int IncorrectAnswers { get; set; }
            public bool IsPass => CorrectAnswers >= IncorrectAnswers;
        }

        private int GenerateRandomNumber(int from, int to) => _rand.Next(from, to);

        private string GetOperationSymbol(OperationType opType) =>
            opType switch
            {
                OperationType.Addition => "+",
                OperationType.Subtraction => "-",
                OperationType.Multiplication => "*",
                OperationType.Division => "/",
                _ => "?"
            };

        private Question GenerateQuestion(OperationType opType, QuestionLevel level)
        {
            if (level == QuestionLevel.Mixed) level = (QuestionLevel)GenerateRandomNumber(1, 3);
            if (opType == OperationType.Mixed) opType = (OperationType)GenerateRandomNumber(1, 4);

            int number1 = level switch
            {
                QuestionLevel.Easy => GenerateRandomNumber(1, 10),
                QuestionLevel.Medium => GenerateRandomNumber(11, 30),
                QuestionLevel.Hard => GenerateRandomNumber(31, 100),
                _ => 1
            };

            int number2 = level switch
            {
                QuestionLevel.Easy => GenerateRandomNumber(1, 10),
                QuestionLevel.Medium => GenerateRandomNumber(11, 30),
                QuestionLevel.Hard => GenerateRandomNumber(31, 100),
                _ => 1
            };

            int correctAnswer = opType switch
            {
                OperationType.Addition => number1 + number2,
                OperationType.Subtraction => number1 - number2,
                OperationType.Multiplication => number1 * number2,
                OperationType.Division => number1 / number2,
                _ => 0
            };

            return new Question
            {
                Number1 = number1,
                Number2 = number2,
                OpType = opType,
                Level = level,
                CorrectAnswer = correctAnswer
            };
        }

        private void FrmQuizz_Load(object sender, EventArgs e)
        {
            FillQuestions();
        }

        private void FillQuestions()
        {
            var qu = GenerateQuestion(OpType, Level);
            lblQuestion1.Text = qu.Number1.ToString();
            lblQuestion2.Text = qu.Number2.ToString();
            lblOperation1.Text = GetOperationSymbol(qu.OpType);

            correctAnswer = qu.CorrectAnswer; // Store the correct answer

            GenerateAnswers(correctAnswer, 4);
        }

        private void GenerateAnswers(int correctAnswer, int numOfAnswers)
        {
            List<int> answers = new List<int> { correctAnswer };

            while (answers.Count < numOfAnswers)
            {
                int wrongAnswer = _rand.Next(correctAnswer - 10, correctAnswer + 10);

                if (!answers.Contains(wrongAnswer) && wrongAnswer != correctAnswer)
                {
                    answers.Add(wrongAnswer);
                }
            }

            answers = ShuffleAnswers(answers);

            btnResult1.Text = answers[0].ToString();
            btnResult2.Text = answers[1].ToString();
            btnResult3.Text = answers[2].ToString();
            btnResult4.Text = answers[3].ToString();
        }

        private List<int> ShuffleAnswers(List<int> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                int randomIndex = _rand.Next(i, answers.Count);
                int temp = answers[i];
                answers[i] = answers[randomIndex];
                answers[randomIndex] = temp;
            }

            return answers;
        }

        private void InitializeButtonEventHandlers()
        {
            btnResult1.Click += CheckAnswer;
            btnResult2.Click += CheckAnswer;
            btnResult3.Click += CheckAnswer;
            btnResult4.Click += CheckAnswer;
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            int chosenAnswer = int.Parse(clickedButton.Text);

            if (chosenAnswer == correctAnswer)
            {
                //MessageBox.Show("Correct :-)", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clickedButton.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                //MessageBox.Show($"Incorrect :-( Correct Answer: {correctAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clickedButton.BackColor = System.Drawing.Color.Red;
            }
        }

    }
}
