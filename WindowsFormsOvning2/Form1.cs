using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOvning2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label = new Label();
            TextBox textbox = new TextBox() { Width = 200, Height = 50, Top = 150, Left = 50 };
            Controls.Add(textbox);
            Button buttonCe = new Button() { Width = 50, Height = 50, Top = 200, Left = 50,Text="CE"};
            Controls.Add(buttonCe);
            Button buttonC = new Button() { Width = 50, Height = 50, Top = 200, Left = 100,Text= "C"};
            Controls.Add(buttonC);
            Button buttonDel = new Button() { Width = 50, Height = 50, Top = 200, Left = 150,Text="Del" };
            Controls.Add(buttonDel);
            Button buttonDivide = new Button() { Width = 50, Height = 50, Top = 200, Left = 200, Text="/" };
            Controls.Add(buttonDivide);
            Button button7 = new Button() { Width = 50, Height = 50, Top = 250, Left = 50, Text= "7"};
            Controls.Add(button7);
            Button button8 = new Button() { Width = 50, Height = 50, Top = 250, Left = 100, Text = "8" };
            Controls.Add(button8);
            Button button9 = new Button() { Width = 50, Height = 50, Top = 250, Left = 150, Text = "9" };
            Controls.Add(button9);
            Button buttonMultiply = new Button() { Width = 50, Height = 50, Top = 250, Left = 200 ,Text="X"};
            Controls.Add(buttonMultiply);
            Button button4 = new Button() { Width = 50, Height = 50, Top = 300, Left = 50, Text="4" };
            Controls.Add(button4);
            Button button5 = new Button() { Width = 50, Height = 50, Top = 300, Left =100, Text="5" };
            Controls.Add(button5);
            Button button6 = new Button() { Width = 50, Height = 50, Top = 300, Left = 150, Text="6" };
            Controls.Add(button6);
            Button buttonSub = new Button() { Width = 50, Height = 50, Top = 300, Left = 200, Text="-" };
            Controls.Add(buttonSub);
            Button button1 = new Button() { Width = 50, Height = 50, Top = 350, Left = 50, Text = "1" };
            Controls.Add(button1);
            Button button2 = new Button() { Width = 50, Height = 50, Top = 350, Left = 100, Text = "2" };
            Controls.Add(button2);
            Button button3 = new Button() { Width = 50, Height = 50, Top = 350, Left = 150, Text = "3" };
            Controls.Add(button3);
            Button buttonAdd = new Button() { Width = 50, Height = 50, Top = 350, Left = 200, Text = "+" };
            Controls.Add(buttonAdd);
            Button buttonNeg = new Button() { Width = 50, Height = 50, Top = 400, Left = 50, Text = "+-" };
            Controls.Add(buttonNeg);
            Button button0 = new Button() { Width = 50, Height = 50, Top = 400, Left = 100, Text = "0" };
            Controls.Add(button0);
            Button buttonComma = new Button() { Width = 50, Height = 50, Top = 400, Left = 150, Text = "." };
            Controls.Add(buttonComma);
            Button buttonEquals = new Button() { Width = 50, Height = 50, Top = 400, Left = 200, Text = "=" };
            Controls.Add(buttonEquals);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
