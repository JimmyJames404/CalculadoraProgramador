using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProgramador
{
    public partial class Form1 : Form
    {/*
        int k;
        float f;
        int mantisa=23;
        int exponente = 8;
        int sign = 1;
        lo anteriror es para IEEE754*/
        bool nose;
        int op = 0, n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        void HabilitarTodo() 
        {
            Dos.Enabled = true;
            Tres.Enabled = true;
            Cuatro.Enabled = true;
            Cinco.Enabled = true;
            Seis.Enabled = true;
            Siete.Enabled = true;
            Ocho.Enabled = true;
            Nueve.Enabled = true;
            Diez.Enabled = true;
            Once.Enabled = true;
            Doce.Enabled = true;
            Trece.Enabled = true;
            Catorce.Enabled = true;
            Quince.Enabled = true;
        }
        void Deshabilitar() 
        {
            HabilitarTodo();
            switch (op) 
            {
                case 0:
                    Diez.Enabled = false;
                    Once.Enabled = false;
                    Doce.Enabled = false;
                    Trece.Enabled = false;
                    Catorce.Enabled = false;
                    Quince.Enabled = false;
                    break;
                case 1:
                    Diez.Enabled = false;
                    Once.Enabled = false;
                    Doce.Enabled = false;
                    Trece.Enabled = false;
                    Catorce.Enabled = false;
                    Quince.Enabled = false;
                    Dos.Enabled = false;
                    Tres.Enabled = false;
                    Cuatro.Enabled = false;
                    Cinco.Enabled = false;
                    Seis.Enabled = false;
                    Siete.Enabled = false;
                    Ocho.Enabled = false;
                    Nueve.Enabled = false;
                    break;
                case 2:
                    Diez.Enabled = false;
                    Once.Enabled = false;
                    Doce.Enabled = false;
                    Trece.Enabled = false;
                    Catorce.Enabled = false;
                    Quince.Enabled = false;
                    Ocho.Enabled = false;
                    Nueve.Enabled = false;
                    break;
            }
        }

        void DecimalABin() 
        {
            B.Text = "";
            while (n != 0)
            {
                B.Text = (n % 2).ToString() + B.Text;
                n /= 2;
            }
        }
        void DecimalAOctal() 
        {
            O.Text = "";
            while (n != 0)
            {
                O.Text = (n % 8).ToString() + O.Text;
                n /= 8;
            }
        }
        void DecimalAHexa() 
        {
            H.Text = "";
            while (n != 0)
            {
                switch (n % 16) 
                {
                    case 10: H.Text = "A" + H.Text; break;
                    case 11: H.Text = "B" + H.Text; break;
                    case 12: H.Text = "C" + H.Text; break;
                    case 13: H.Text = "D" + H.Text; break;
                    case 14: H.Text = "E" + H.Text; break;
                    case 15: H.Text = "F" + H.Text; break;
                    default: H.Text = (n % 16).ToString() + H.Text; break;
                }
                n /= 16;
            }
        }

        void BinADecimal()
        {
            n = 0;

            for (int x = B.Text.Length - 1, y = 0; x >= 0; x--, y++)
                n += (int)(int.Parse(B.Text[x].ToString()) * Math.Pow(2, y));
        }
        void OctalADecimal()
        {
            n = 0;
            for (int x = O.Text.Length - 1, y = 0; x >= 0; x--, y++)
                n += (int)(int.Parse(O.Text[x].ToString()) * Math.Pow(8, y));
        }
        void HexaADecimal()
        {
            n = 0;
            for (int x = H.Text.Length - 1, y = 0; x >= 0; x--, y++)
            {
                switch (H.Text[x])
                {
                    case 'A': n += (int)(10 * Math.Pow(16, y)); break;
                    case 'B': n += (int)(11 * Math.Pow(16, y)); break;
                    case 'C': n += (int)(12 * Math.Pow(16, y)); break;
                    case 'D': n += (int)(13 * Math.Pow(16, y)); break;
                    case 'E': n += (int)(14 * Math.Pow(16, y)); break;
                    case 'F': n += (int)(15 * Math.Pow(16, y)); break;
                    default: n += (int)(int.Parse(H.Text[x].ToString()) * Math.Pow(16, y)); break;
                }
            }
        }

        void DecimalATodo() 
        {
            n = int.Parse(D.Text);
            DecimalABin();
            n = int.Parse(D.Text);
            DecimalAOctal();
            n = int.Parse(D.Text);
            DecimalAHexa();
        }
        void BinarioATodo() 
        {
            BinADecimal();
            D.Text = n.ToString();
            DecimalATodo();
        }
        void OctalATodo()
        {
            OctalADecimal();
            D.Text = n.ToString();
            DecimalATodo();
        }
        void HexaATodo()
        {
            HexaADecimal();
            D.Text = n.ToString();
            DecimalATodo();
        }



        #region Radios
        private void Decimal_CheckedChanged(object sender, EventArgs e)
        {
            op = 0;
            Deshabilitar();
            cambio();
        }
        private void Binario_CheckedChanged(object sender, EventArgs e)
        {
            op = 1;
            Deshabilitar();
            cambio();
        }
        private void Octal_CheckedChanged(object sender, EventArgs e)
        {
            op = 2;
            Deshabilitar();
            cambio();
        }
        private void Hexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            op = 3;
            Deshabilitar();
            cambio();
        }
        #endregion
        void Escribir(string FF) 
        {
            
            switch (op) 
            {
                case 0:
                    if (D.Text == "0")
                        D.Text = "";
                    D.Text += FF;
                    DecimalATodo();
                    break;
                case 1:
                    if (B.Text == "0")
                        B.Text = "";
                    B.Text += FF;
                    BinarioATodo();
                    break;
                case 2:
                    if (O.Text == "0")
                        O.Text = "";
                    O.Text += FF;
                    OctalATodo();
                    break;
                case 3:
                    if (H.Text == "0")
                        H.Text = "";
                    H.Text += FF;
                    HexaATodo();
                    break;
            }
        }
        #region Botones
        private void Uno_Click(object sender, EventArgs e)
        {
            Escribir("1");
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            Escribir("2");
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            Escribir("3");
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            Escribir("4");
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            Escribir("5");
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            Escribir("6");
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            Escribir("7");
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            Escribir("8");
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            Escribir("9");
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            Escribir("0");
        }

        private void Del_Click(object sender, EventArgs e)
        {
            string t = "";
            switch(op)
            {
                case 0:
                    t = D.Text;
                    D.Text = "";
                    for (int x = 0; x < t.Length - 1; x++)
                        D.Text += t[x];
                    if (D.Text == "") D.Text = "0";
                    DecimalATodo();
                    break;
                case 1:
                    t = B.Text;
                    B.Text = "";
                    for (int x = 0; x < t.Length - 1; x++)
                        B.Text += t[x];
                    if (B.Text == "") B.Text = "0";
                    BinarioATodo();
                    break;
                case 2:
                    t = O.Text;
                    O.Text = "";
                    for (int x = 0; x < t.Length - 1; x++)
                        O.Text += t[x];
                    if (O.Text == "") O.Text = "0";
                    OctalATodo();
                    break;
                case 3:
                    t = H.Text;
                    H.Text = "";
                    for (int x = 0; x < t.Length - 1; x++)
                        H.Text += t[x];
                    if (H.Text == "") H.Text = "0";
                    HexaATodo();
                    break;
            }

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            H.Text = "0";
            D.Text = "0";
            B.Text = "0";
            O.Text = "0";
        }

        private void Diez_Click(object sender, EventArgs e)
        {
            Escribir("A");
        }

        private void Once_Click(object sender, EventArgs e)
        {
            Escribir("B");
        }

        private void Doce_Click(object sender, EventArgs e)
        {
            Escribir("C");
        }

        private void Trece_Click(object sender, EventArgs e)
        {
            Escribir("D");
        }

        private void Catorce_Click(object sender, EventArgs e)
        {
            Escribir("E");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
          
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        

          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (nose == false)
            {
                panel3.Visible = true;
                nose = true;
            }
            else
            {
                panel3.Visible = false;
                nose = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
            if (nose == false)
            {
                panel3.Visible = true;
                
                nose = true;
            }
            else
            {
                panel3.Visible = false;
                nose = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quince_Click(object sender, EventArgs e)
        {
            Escribir("F");
        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            if(textBox2.Text=="" || textBox2.Text == "0")
            {
                MessageBox.Show("No tiene punto decimal");
            }
            else
            {
                
            }
        }

        private void cambio()
        {
            if(Binario.Checked == true)
            {
                b1.Visible = true;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
            }
            if (Hexadecimal.Checked == true)
            {
                b1.Visible = false;
                b2.Visible = true;
                b3.Visible = false;
                b4.Visible = false;
            }
            if (Decimal.Checked == true)
            {
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = true;
                b4.Visible = false;
            }
            if (Octal.Checked == true)
            {
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = true;
            }

        }

        #endregion

    }
}
