using capaDatos;
using capaLogica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encuestas
{
    public partial class frmGeneradorEncuestas : Form
    {
        public frmGeneradorEncuestas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGeneradorEncuestas_Load(object sender, EventArgs e)
        {
            // se cargan las encuestas
            Encuesta encuestas = new Encuesta();
            this.dgEncuestas.DataSource = encuestas.GetDatos();
            this.dgEncuestas.Columns["Id_Unico"].Visible = false;
            this.dgEncuestas.Columns["Fecha"].Visible = false;

            encuestas.LLenarArbol(this.treeView1);
           
            // se cargan los bloques
            Bloque bloque = new Bloque();
            this.dgBloque.DataSource = bloque.GetDatos();
            this.dgBloque.Columns["Id_Unico"].Visible = false;
            this.dgBloque.Columns["Id_Encuesta"].Visible = false;
           
        }



        
        /// ///////////////////////////////////////////////////////
        private void frmGeneradorEncuestas_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cerrar la aplicacion
            Application.Exit();
        }

        private void txtNuevaEncuesta_Click(object sender, EventArgs e)
        {
            csFP p = new csFP();
            /* Orden de las preguntas
             * 0 - Numero de Orden de la pregunta.
             * 1 - Texto de la pregunta.
             * 2 - Tipo de botones de las respuestas de la pregunta.
             * 3 - Conjunto de Opciones para elegir de la pregunta.
             * 4 - Botones de navegacion de la pregunta, se muestran con un numero 1.Anterior 2.Siguiente 4.Suspender 8.Finalizar (se pueden sumar)
             *  1	3	5	7	9	11	13	15
                2	3	6	7	10	11	14	15
                4	5	6	7	12	13	14	15
                8	9	10	11	12	13	14	15
             */
            ArrayList pre = new ArrayList(); 
            pre.Add(new object[] {"1", "Niño que Acción \"Sistema Operativo\" Usas?", "RadioButton", new string[] { "MacOS", "Windows", "Linux", "BeOS", "Ninguno" },"6" });
            pre.Add(new object[] {"2", "Con que equipo cuentas?"    , "CheckBox"    , new string[] {"Pc Escritorio", "Laptop", "Celular", "Tablet","Ninguno" }, "7" });
            pre.Add(new object[] {"3", "Cuantos a;os tienes?"       , "TextBox"     , new string[] {"Edad" } ,"3"});
            pre.Add(new object[] {"4", "Observaciones:"              , "RichTextBox" , new string[] {"Respuesta" }, "13" });

            
            MessageBox.Show( p.bloqueXML(Guid.NewGuid().ToString().ToUpper(),"Equipo de Computacion", pre));

        }
    }
}
