using System;
using System.Windows.Forms;
using Play_Math.Quizz;

namespace Play_Math
{
    public partial class Form1 : Form
    {
        private QuizSettings _quizSettings;

        public Form1()
        {
            InitializeComponent();
            _quizSettings = new QuizSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            InitializeComboBoxes();
            InitializeNumberOfQuestions();
            UpdateStartButtonState();
        }

        private void InitializeComboBoxes()
        {
            InitializeComboBox(CBQuize_Level, typeof(QuestionLevel));
            InitializeComboBox(CBOperation_Type, typeof(OperationType));
        }

        private void InitializeComboBox(ComboBox comboBox, Type enumType)
        {
            comboBox.DataSource = Enum.GetValues(enumType);
            comboBox.SelectedIndex = 0;
        }

        private void InitializeNumberOfQuestions()
        {
            Nu_NumberQuestion.Minimum = 1;
            Nu_NumberQuestion.Maximum = 10;
            Nu_NumberQuestion.Value = 10; // Default value
            _quizSettings.NumberOfQuestions = (int)Nu_NumberQuestion.Value;
        }

        private void UpdateStartButtonState()
        {
            btnStartQuize.Enabled = _quizSettings.IsValid();
        }

        private void btnStartQuize_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmQuizz  quizForm = new FrmQuizz(_quizSettings.Level, _quizSettings.OpType, _quizSettings.NumberOfQuestions))
                {
                    quizForm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBQuize_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            _quizSettings.Level = (QuestionLevel)CBQuize_Level.SelectedItem;
            UpdateStartButtonState();
        }

        private void CBOperation_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            _quizSettings.OpType = (OperationType)CBOperation_Type.SelectedItem;
            UpdateStartButtonState();
        }

        private void Nu_NumberQuestion_ValueChanged(object sender, EventArgs e)
        {
            _quizSettings.NumberOfQuestions = (int)Nu_NumberQuestion.Value;
            UpdateStartButtonState();
        }
    }

    public class QuizSettings
    {
        public QuestionLevel Level { get; set; }
        public OperationType OpType { get; set; }
        public int NumberOfQuestions { get; set; }

        public bool IsValid()
        {
            return Enum.IsDefined(typeof(QuestionLevel), Level) &&
                   Enum.IsDefined(typeof(OperationType), OpType) &&
                   NumberOfQuestions > 0 && NumberOfQuestions <= 10;
        }
    }
}