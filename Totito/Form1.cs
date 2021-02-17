using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totito
{
    public partial class Form1 : Form
    {
        String jugador = "";
        int tiro;
        Boolean inicioJugador = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!inicioJugador)
            {
                jugador = button10.Text;
                inicioJugador = true;
                button10.Enabled = false;
                button11.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button5.Text == "")
            {
                button5.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button5.Text == button4.Text) && (button5.Text == button6.Text))
                    {
                        MessageBox.Show("El ganador es el jugador " + button5.Text);
                    }
                    else if ((button5.Text == button2.Text) && (button5.Text == button8.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button5.Text);
                    }
                    else if ((button5.Text == button3.Text) && (button5.Text == button7.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button5.Text);
                    }
                    else if ((button5.Text == button1.Text) && (button5.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button5.Text);                       
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                } else
                {
                    jugador = "X";
                }
            }                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button1.Text == "")
            {
                button1.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button1.Text);
                    }
                    else if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button1.Text);
                    }
                    else if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button1.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                Console.WriteLine(jugador);
                return;
            }

            if (button9.Text == "")
            {
                button9.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button9.Text == button6.Text) && (button9.Text == button3.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button9.Text);
                    }
                    else if ((button9.Text == button8.Text) && (button9.Text == button7.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button9.Text);
                    }
                    else if ((button9.Text == button5.Text) && (button9.Text == button1.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button9.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button2.Text == "")
            {
                button2.Text = jugador;
                this.tiro++;

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }

            if (tiro >= 5)
            {
                if ((button2.Text == button1.Text) && (button2.Text == button3.Text))
                {
                    nuevoDialog("El ganador es el jugador " + button2.Text);
                }
                else if ((button2.Text == button5.Text) && (button2.Text == button8.Text))
                {
                    nuevoDialog("El ganador es el jugador " + button2.Text);
                }           
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button3.Text == "")
            {
                button3.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button3.Text == button2.Text) && (button3.Text == button1.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button3.Text);
                    }
                    else if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button3.Text);
                    }
                    else if ((button3.Text == button5.Text) && (button3.Text == button7.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button3.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button4.Text == "")
            {
                button4.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button4.Text == button1.Text) && (button4.Text == button7.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button4.Text);
                    }
                    else if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button4.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button6.Text == "")
            {
                button6.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button6.Text == button3.Text) && (button6.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button6.Text);
                    }
                    else if ((button6.Text == button5.Text) && (button4.Text == button4.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button6.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button7.Text == "")
            {
                button7.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button7.Text == button1.Text) && (button7.Text == button4.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button7.Text);
                    }
                    else if ((button7.Text == button5.Text) && (button7.Text == button3.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button7.Text);
                    }
                    else if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button7.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                return;
            }

            if (button8.Text == "")
            {
                button8.Text = jugador;
                this.tiro++;

                if (tiro >= 5)
                {
                    if ((button8.Text == button7.Text) && (button8.Text == button9.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button8.Text);
                    }
                    else if ((button8.Text == button5.Text) && (button8.Text == button2.Text))
                    {
                        nuevoDialog("El ganador es el jugador " + button8.Text);
                    }
                }

                if (jugador == "X")
                {
                    jugador = "O";
                }
                else
                {
                    jugador = "X";
                }
            }           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!inicioJugador)
            {
                jugador = button11.Text;
                inicioJugador = true;
                button11.Enabled = false;
                button10.Enabled = false;
            }
        }

        public DialogResult nuevoDialog (String mensaje)
        {
            DialogResult dr = MessageBox.Show(mensaje+ "\n Desea jugar de nuevo?", "Información", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            } else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
            return dr;
        }
    }
}
