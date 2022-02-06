namespace Kóło_i_Krzyzyk___Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;


        private void bRestartuj_Click_1(object sender, EventArgs e)
        
        {
            Reset();
            wO.Text = "0";
            wX.Text = "0";
            KtoOX.Text = "O";
            gracz1 = true;
        }

        private void Reset()
        {
            ruch = 0;
            Button[] aall = new Button[9];
            aall[0] = b1;
            aall[1] = b2;
            aall[2] = b3;
            aall[3] = b4;
            aall[4] = b5;
            aall[5] = b6;
            aall[6] = b7;
            aall[7] = b8;
            aall[8] = b9;
            foreach (Button b in aall)
            {
                b.Enabled = true;
                b.Text = "";
            }

        }

        private void Sprawdz()
        {
            if (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                Wygrana();
            }
            else if (b4.Text != "" && b4.Text == b5.Text && b5.Text == b6.Text)
            {
                Wygrana();
            }
            else if (b7.Text != "" && b7.Text == b8.Text && b8.Text == b9.Text)
            {
                Wygrana();
            }
            else if (b1.Text != "" && b1.Text == b4.Text && b4.Text == b7.Text)
            {
                Wygrana();
            }
            else if (b2.Text != "" && b2.Text == b5.Text && b5.Text == b8.Text)
            {
                Wygrana();
            }
            else if (b3.Text != "" && b3.Text == b6.Text && b6.Text == b9.Text)
            {
                Wygrana();
            }
            else if (b1.Text != "" && b1.Text == b5.Text && b5.Text == b9.Text)
            {
                Wygrana();
            }
            else if (b3.Text != "" && b3.Text == b5.Text && b5.Text == b7.Text)
            {
                Wygrana();
            }
            else if (ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();

            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa Gracz: " + (gracz1 ? "0" : "X"), "Wygrana!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)

                wO.Text = ((int.Parse(wO.Text)) + 1).ToString();

            else

                wX.Text = ((int.Parse(wX.Text)) + 1).ToString();
            Reset();


        }

        private void b1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }



        private void b2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            KtoOX.Text = gracz1 ? "O" : "X";
        }

        
    }
}