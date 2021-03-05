using System;
using System.IO;
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

        private void inicializarTablero()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            jugador = "";
            inicioJugador = false;
            button10.Enabled = true;
            button11.Enabled = true;
            Console.WriteLine(jugador);
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
            Console.WriteLine(jugador);

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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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
                    else if ((button6.Text == button5.Text) && (button6.Text == button4.Text))
                    {
                        nuevoDialog("El ganador es el jugador 44" + button6.Text);
                    }
                }

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

                jugador = cambiarJugador(jugador);
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

        private String cambiarJugador(String jugador)
        {
            if (jugador == "X")
            {
                jugador = "O";
            }
            else
            {
                jugador = "X";
            }

            return jugador;
        }

        public DialogResult nuevoDialog (String mensaje)
        {
            DialogResult dr = MessageBox.Show(mensaje+ "\n Desea jugar de nuevo?", "Información", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                inicializarTablero();
            } else if (dr == DialogResult.No)
            {
                Application.Exit();
            }
            return dr;
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            String texto;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    using (StreamWriter file = new StreamWriter(Path.GetFullPath(saveFileDialog1.FileName), true))
                    {
                        texto = button1.Text + '|' + button2.Text + '|' + button3.Text + '|'
                        + button4.Text + '|' + button5.Text + '|' + button6.Text + '|' + button7.Text + '|'
                        + button8.Text + '|' + button9.Text + '|' + tiro + '|' + jugador;

                        file.WriteLine(texto);
                        file.Close();
                        inicializarTablero();

                }

            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                String filePath;
                String fileContent;
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        char delimitador = '|';
                        String[] valores = fileContent.Split(delimitador);
                        button1.Text = valores[0];
                        button2.Text = valores[1];
                        button3.Text = valores[2];
                        button4.Text = valores[3];
                        button5.Text = valores[4];
                        button6.Text = valores[5];
                        button7.Text = valores[6];
                        button8.Text = valores[7];
                        button9.Text = valores[8];
                        tiro = int.Parse(valores[9]);
                        jugador = valores[10];
                        button10.Enabled = false;
                        button11.Enabled = false; 
                    }
                }
            }
        }        
    }
}
