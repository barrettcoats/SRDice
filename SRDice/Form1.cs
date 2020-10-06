using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // import statement 

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, m;
            int ruleofone = 0;
            int SR4 = 0;
            bool v = Int32.TryParse(textBox1.Text, out n);
            bool u = Int32.TryParse(textBox3.Text, out m);
            if (v == true && u == true)
            {
                n = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox3.Text);
                if (n == 0)
                {
                    textBox2.Text = "I can't roll 0 dice.";
                }
                else if (n > 0 && n <= 40)
                {
                    // roll some dice (d6)
                    Random rand = new Random();
                    int hold;
                    int success = 0;
                    int rule = 6;
                    textBox2.Text = "Rolling _";
                    textBox2.Text += n;
                    textBox2.Text += "_ d6:\r\n\r\n";
                    for (int i = 0; i < n; i++)
                    {
                        rule = 6;
                        hold = rand.Next(1, 7);
                        if (label4.Text == "SR4" && hold >= 5)
                        {
                            SR4++;
                        }
                        if (hold == 1)
                        {
                            ruleofone++;
                        }
                        if (checkBox1.Checked == true && hold == 6)
                        {
                            while (rule == 6)
                            {
                                rule = rand.Next(1, 7);
                                hold += rule;
                            }
                        }
                        if (hold >= m)
                        {
                            success++;
                        }
                        textBox2.Text += hold;
                        textBox2.Text += "\r\n";
                    }
                    textBox2.Text += "\r\n\r\n";
                    if (ruleofone == n)
                    {
                        textBox2.Text += "You rolled all 1s. You glitched, drekhead.\r\n\r\n";
                    }
                    if (ruleofone > n/2 && label4.Text == "SR4")
                    {
                        textBox2.Text += "You rolled 1/2 your dice as 1s. You glitched, drekhead.\r\n\r\n";
                    }
                    if (m != 0 && label4.Text == "SR3")
                    {
                        textBox2.Text += "Successes: ";
                        textBox2.Text += success;
                    }
                    if (label4.Text == "SR4")
                    {
                        // SR4 = # of hits
                        // m = threshold

                        textBox2.Text += "# of hits: ";
                        textBox2.Text += SR4;

                        if (SR4 >= m)
                            textBox2.Text += "\r\nThreshold Passed";
                        else
                            textBox2.Text += "\r\nThreshold Failed";
                    }

                }
                else
                {
                    MessageBox.Show("Your number is way too huge. Less than 40, please.");
                }
            }
            else
            {
                MessageBox.Show("Illegal input. Try an integer between 1 and 40. No other characters.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            bool v = Int32.TryParse(textBox1.Text, out n);
            if (v)
            {
                // calculate # of successes
            }
            else
            {
                MessageBox.Show("Illegal input. Try an integer between 1 and 40. No other characters.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label4.Text == "SR3")
            {
                label2.Text = "Threshold:";
                label4.Text = "SR4";
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            else
            {
                label2.Text = "Target Number:";
                label4.Text = "SR3";
                checkBox1.Enabled = true;
            }
        }
    }
}
