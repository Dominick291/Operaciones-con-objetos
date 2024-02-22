using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones_con_objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<Persona> personas = new List<Persona>();
        private void button1_Click(object sender, EventArgs e)
        {
            

            Persona persona = new Persona();
            persona.Dpi = textBox1.Text;
            persona.Nombre = textBox2.Text;
            persona.Apellido = textBox3.Text;
            persona.Fechanacimiento = monthCalendar1.SelectionStart;

            personas.Add(persona);


        }

        private void Mostrar()
        {
            // para decrile que lo borre para ingresar nuevo dato
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
            dataGridView1.Refresh();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            personas = personas.OrderBy(p => p.Apellido).ToList();
            Mostrar();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            string dpi = textBox1.Text;

            personas.RemoveAll(p => p.Dpi == dpi);

            Mostrar();
        }
    }
}
