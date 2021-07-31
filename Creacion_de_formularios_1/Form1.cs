using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_formularios_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wiiiButton_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World! " +
                "Katerin Estela Orellana Hernandez, " +
                "Rigoberto Alexander Mejia Sorto, " +
                "Jose Luis Muñoz Padilla, " +
                "Kerin Francisco Melendez Mejia, " +
                "Maria del Carmen Rodriguez Martinez, " +
                "Angel Ernesto Aparicio Martinez";
        }
    }
}
