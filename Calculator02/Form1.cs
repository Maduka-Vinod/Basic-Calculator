namespace Calculator02
{
    public partial class Form1 : Form
    {
        string operation = "";
        double resultValue = 0;
        bool isOperationPerform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (tb_Results.Text == "0" || isOperationPerform)
            {
                tb_Results.Clear();
            }
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!tb_Results.Text.Contains("."))
                {
                    tb_Results.Text = tb_Results.Text + btn.Text;
                }
            }
            else
            {
                tb_Results.Text = tb_Results.Text + btn.Text;
            }

            isOperationPerform = false;
        }

        private void Opereation_Perfrom(object sender, EventArgs e)
        {
            if (resultValue != 0)
            {
                button18.PerformClick();


            }
            else
            {
                Button btn = (Button)sender;
                operation = btn.Text;
                resultValue = double.Parse(tb_Results.Text);
                lb_Results.Text = resultValue + operation;
                isOperationPerform = true;
            }



        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_Results.Text = "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            tb_Results.Text = "0";
            lb_Results.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tb_Results.Text = (resultValue + double.Parse(tb_Results.Text)).ToString();
                    break;
                case "-":
                    tb_Results.Text = (resultValue - double.Parse(tb_Results.Text)).ToString();
                    break;
                case "*":
                    tb_Results.Text = (resultValue * double.Parse(tb_Results.Text)).ToString();
                    break;
                case "/":
                    tb_Results.Text = (resultValue / double.Parse(tb_Results.Text)).ToString();
                    break;

            }
        }
    }
}