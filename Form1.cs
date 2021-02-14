using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe__IQ_game
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "o";
            turn = !turn;
            b.Enabled = false;

            chekforwinner();
        }

        private void chekforwinner()
        {
            bool thereisawinner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereisawinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereisawinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereisawinner = true;

            if (thereisawinner)
            {
                disableButtons();

                string winner = "";
                if (turn)
                    winner = "o";
                else
                    winner = "x";

                MessageBox.Show(winner + " Wins this match");
            }

        }

        private void disableButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }
    }
               
}
