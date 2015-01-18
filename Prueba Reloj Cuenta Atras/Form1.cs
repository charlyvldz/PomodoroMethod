using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Resources;

using System.Media;//Librería que nos da la opción de reproducir sonidos desde nuestro código con
                   //        formato *.wav

namespace Prueba_Reloj_Cuenta_Atras
{
    public partial class frmPomodoro : Form
    {
        public frmPomodoro()
        {
            InitializeComponent();
        }

        #region "VARIABLES USADAS"
        private int horas, minutos, segundos, repeticionespomodoro;
        string hr, min, seg;
        #endregion
        
        #region "BOTONES DE CONTROL"
        private void btndetener_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
            btniniciar.Enabled = true;
            btndetener.Enabled = false;
            btndescansocorto.Enabled = true;
            lbltiempo.Text = "00:00";
            lbltiempo.Visible = true;
            detenerAlerta("alarma.wav");
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {

            horas = 0;
            minutos = 25;
            segundos = 0;


            tiempo.Enabled = true;

            lbltiempo.Visible = true;
            btniniciar.Enabled = false;
            lbltiempo.Text = "";
            btndescansocorto.Enabled = false;
            btndescansolargo.Enabled = false;


            btndetener.Enabled = true;


            while (repeticionespomodoro < 5)
            {
                tiempo.Enabled = true;
                tiempo.Start();
                repeticionespomodoro++;
                lblpomodoros.Text = repeticionespomodoro.ToString();
                break;
            }

            if (repeticionespomodoro == 5)
            {
                tiempo.Stop();
                tiempo.Enabled = false;
                btniniciar.Enabled = false;
                btndescansocorto.Enabled = false;
                btndescansolargo.Enabled = true;
                MessageBox.Show("Le recomendamos un descanso largo para recuperarse del tiempo invertido. Según los estudios realizados debe tomar un descanso ahora.", "Recomendación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tiempo.Enabled = true;
                tiempo.Start();
                

            }

        }

        private void btndescansocorto_Click(object sender, EventArgs e)
        {
            horas = 0;
            minutos = 5;
            segundos = 0;


            tiempo.Enabled = true;

            lbltiempo.Visible = true;
            btniniciar.Enabled = false;
            lbltiempo.Text = "";


            btndetener.Enabled = true;


        }

        private void btndescansolargo_Click(object sender, EventArgs e)
        {
            horas = 0;
            minutos = 15;
            segundos = 0;


            tiempo.Enabled = true;

            lbltiempo.Visible = true;
            btniniciar.Enabled = false;
            lbltiempo.Text = "";
            repeticionespomodoro = 0;


            btndetener.Enabled = true;
            

        }
        #endregion

        #region "TEMPORIZADOR"
        private void tiempo_Tick(object sender, EventArgs e)
        {



            //Disminuimos de 1 en 1 los segundos;

            segundos--;

            //En caso de que se agote la cuenta, ordenamos lo que debe hacer
            //en este caso debe deshabilitar el Timer
            //Esconder el Contador
          
            if ((horas == 00) && (minutos == 0) && (segundos == 0))
            {
                tiempo.Stop();
                tiempo.Enabled = false;
                lbltiempo.Visible = true;
                lbltiempo.Text = "00:00";
                
                reproducirAlerta("alarma.wav");
            }


            //En caso contrario seguira disminuyendo los segundos de uno en uno y cuando 
            //el valor sea -1 le asignara el valor de 59 y restara un minuto, asi mismo cuando 
            //el valor de minutos sea el equivalente a -1 le asignara el valor de 59 y restara uno al 
            //al valor de las horas.
            else
            {
                if (segundos == -1)
                {
                    segundos = 59;
                    minutos--;
                }


                if (minutos == -1)
                {
                    minutos = 59;


                    if (horas > 0)
                    {
                        horas--;
                    }
                    else
                    {
                        horas = 0;
                    }
                    
                }


                hr = horas.ToString();
                min = minutos.ToString();
                seg = segundos.ToString();


                //En las siguientes condiciones se analiza el formato de los minutos y segundos agregándole un cero
                //   a la izquierda si se requiere y si no, que aparezca sin el mismo
                if (minutos < 10)
                {
                    lbltiempo.Text = min +":"+"0"+seg;

                    if (segundos < 10)
                    {
                        lbltiempo.Text = "0" + min + ":" + "0" + seg;
                    }
                    else
                    {
                        lbltiempo.Text = "0" + min + ":"+ seg;
                    }

                }
                else
                {
                    lbltiempo.Text = min + ":" + seg;
                }
                
            }
            


        }
        #endregion
        
        #region "MÉTODO PARA REPRODUCIR SONIDOS DE ALARMA"
        private void reproducirAlerta(string ruta)
        {
            SoundPlayer reproducesonido = new SoundPlayer();
            reproducesonido.SoundLocation = ruta;
            reproducesonido.Load();
            reproducesonido.Play();
        }

        private void detenerAlerta(string ruta)
        {
            SoundPlayer detensonido = new SoundPlayer();
            reproducirAlerta(ruta);
            detensonido.Stop();

        }

        #endregion
        
        #region "EVENTOS DE NOTIFICACIONES"
        private void iconodenotificacion_DoubleClick(object sender, EventArgs e)
        {
            //Hacemos visible el formulario
            this.Show();
            this.WindowState = FormWindowState.Normal;
            //Ocultamos el icono de la bandeja de sistema
            iconodenotificacion.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Si el estado actual de la ventana es "minimizado"...
            if (this.WindowState== FormWindowState.Minimized)
            {
                //Ocultamos el formulario
                this.Visible = false;
                //Hacemos visible el icono de la bandeja del sistema
                iconodenotificacion.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si Cerramos la aplicación que se cierre también el proceso
            Application.Exit();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
                  
            lbltiempo.Text = "00:00";
            lbltiempo.Visible = true;
            
        }
        #endregion

        

    }
}




