using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double _currentNumber;
        private Action _lastAction;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberEntered(object sender, EventArgs e)
        {
            Button b = (Button) sender;

            switch (b.Tag)
            {
                case Action.Number:
                    textBox1.Text += b.Text; // textBox1.Text + b.text
                    break;
                case Action.Add:
                    _currentNumber = _currentNumber + GetNumber();
                    textBox1.Text = "";
                    _lastAction = (Action)b.Tag;
                    break;
                case Action.Subtract:
                    _currentNumber = _currentNumber - GetNumber();
                    textBox1.Text = "";
                    _lastAction = (Action)b.Tag;
                    break;
                case Action.Equal:
                    switch (_lastAction)
                    {
                        case Action.Add:
                            textBox1.Text = (_currentNumber + GetNumber()).ToString();
                            break;
                        case Action.Subtract:
                            textBox1.Text = (_currentNumber - GetNumber()).ToString();
                            break;
                        default:
                            textBox1.Text = "This button is fucked up";
                            break;
                    }

                    _lastAction = (Action)b.Tag;
                    break;
                case Action.Clear:
                    textBox1.Text = "";
                    _currentNumber = 0; 
                    _lastAction = (Action)b.Tag;
                    break;
            }
        }

        private double GetNumber()
        {
            return Convert.ToDouble(textBox1.Text);
        }
    }
}
