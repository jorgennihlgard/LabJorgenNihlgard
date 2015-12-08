using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOvning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button() { Height=100,Width= 100,Top= 0,Left= 0, Visible=true, BackColor=Color.HotPink};
            //Controls.Add(button);
            TextBox textbox = new TextBox() {Top=70,Left=100 };
            Controls.Add(textbox);
            TextBox textbox1 = new TextBox() {Top=100,Left=100 };
            Controls.Add(textbox1);
            Label label = new Label() {Top=130,Left=140};
            label.Text = "=";
            Controls.Add(label);
            TextBox textbox2 = new TextBox() {Top=160, Left= 100 };
            Controls.Add(textbox2);
            Button buttonDivide = new Button() {Height=20,Width=20,Top=190,Left=100, Text = "/" };
            Controls.Add(buttonDivide);
            Button buttonMultiply = new Button() { Height = 20, Width = 20, Top = 190, Left = 130,Text="x" };
            Controls.Add(buttonMultiply);
            Button buttonSub = new Button() { Height = 20, Width = 20, Top = 190, Left = 160,Text="-"};
            Controls.Add(buttonSub);
            Button buttonAdd = new Button() {Height=20, Width=20,Top=190,Left=190,Text="+"};
            Controls.Add(buttonAdd);

     
            
    }
    }
}
