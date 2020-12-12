using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAimlessly
{
    public partial class ResultItem : UserControl
    {
        private string _word = "Word1";
        private string _question = "Question 0";
        private Color _indicator = Color.DarkGreen; 
        public string Word 
        { 
            get => _word; 
            set 
            {
                _word = value;
                WordChanged?.Invoke(lblWord);
            } 
        }
        public string Question 
        {
            get => _question; 
            set 
            {
                _question = value;
                QuestionChanged?.Invoke(lblQuestionCounter);
            } 
        }
        public Color Indicator 
        {
            get => _indicator; 
            set
            {
                _indicator = value;
                IndicatorChanged?.Invoke(pnlIndicator);
            } 
        }
        public ResultItem()
        {
            InitializeComponent();
        }

        private void ResultItem_Load(object sender, EventArgs e)
        {
            WordChanged += ResultItem_WordChanged;
            QuestionChanged += ResultItem_QuestionChanged;
            IndicatorChanged += ResultItem_IndicatorChanged;
            lblWord.Text = Word;
            lblQuestionCounter.Text = Question;
            pnlIndicator.BackColor = Indicator;
        }

        private void ResultItem_IndicatorChanged(object sender)
        {
            Panel pnl = sender as Panel;
            pnl.BackColor = Indicator;
        }

        private void ResultItem_QuestionChanged(object sender)
        {
            Label lbl = sender as Label;
            lbl.Text = Question;
        }

        private void ResultItem_WordChanged(object sender)
        {
            Label lbl = sender as Label;
            lbl.Text = Word;
        }

        public delegate void TextChangeHandler(object sender);
        public delegate void ColorChange(object sender);

        public event TextChangeHandler WordChanged;
        public event TextChangeHandler QuestionChanged;
        public event ColorChange IndicatorChanged;
    }
}
