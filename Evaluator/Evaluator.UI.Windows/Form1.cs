using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        private bool _wasPoint = false;
        private bool _wasOperator = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            _wasOperator = false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            _wasOperator = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
            _wasOperator = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
            _wasOperator = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            _wasOperator = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            _wasOperator = false;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            _wasOperator = false;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            _wasOperator = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            _wasOperator = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            _wasOperator = false;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!_wasPoint)
            {
                txtDisplay.Text += ".";
                _wasPoint = true;
            }
            
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!_wasOperator)
            {
                txtDisplay.Text += "+";
                _wasPoint = false;
                _wasOperator = true;
            }            
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!_wasOperator)
            {
                txtDisplay.Text += "-";
                _wasPoint = false;
                _wasOperator = true;
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!_wasOperator)
            {
                txtDisplay.Text += "*";
                _wasPoint = false;
                _wasOperator = true;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!_wasOperator)
            {
                txtDisplay.Text += "/";
                _wasPoint = false;
                _wasOperator = true;
            }
        }
        private void btnPow_Click(object sender, EventArgs e)
        {
            if (!_wasOperator)
            {
                txtDisplay.Text += "^";
                _wasPoint = false;
                _wasOperator = true;
            }
        }
        private void btnOpenParentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
            _wasPoint = false;
        }
        private void btnCloseParentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
            _wasPoint = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $" = {MyEvaluator.Evaluate(txtDisplay.Text)}";
        }
    }
}