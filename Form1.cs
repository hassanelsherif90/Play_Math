using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play_Math.Quizz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Play_Math.Quizz.FrmQuizz;


namespace Play_Math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public QuestionLevel Level { get; set; }
        public OperationType OpType { get; set; }
        public int NumberOfQuestions { get; set; }

        private void btnStartQuize_Click(object sender, EventArgs e)
        {
            Form frm = new FrmQuizz(Level, OpType);
            frm.ShowDialog();
        }

        private void FillQuizzLevel()
        {
            CBQuize_Level.DataSource = Enum.GetValues(typeof(QuestionLevel));
        }

        private void FillQuestionsLevel()
        {
            CBOperation_Type.DataSource = Enum.GetValues(typeof(OperationType));
        }

        private void CBQuize_Level_SelectedIndexChanged(object sender, EventArgs e)
        {

            Level = (QuestionLevel)CBQuize_Level.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillQuestionsLevel();
            FillQuizzLevel();
        }

        private void Nu_NumberQuestion_ValueChanged(object sender, EventArgs e)
        {
            NumberOfQuestions = (int)Nu_NumberQuestion.Value;
        }

        private void CBOperation_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpType = (OperationType)CBOperation_Type.SelectedItem;
        }


    }
}
