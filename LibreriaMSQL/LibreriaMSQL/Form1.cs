using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace LibreriaMSQL
{
    public partial class Form1 : Form
        {
        public int Id;
    
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);




        }

        public void ListaLibro_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tabladatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Libros TituloBox = new Libros();
                TituloBox.Titulo = Titulo.Text;
                TituloBox.Descripcion = Descripcion.Text;
                TituloBox.NumeroPaginas = int.Parse(NumeroPaginas.Text);
                TituloBox.FechaPublicacion =CajaFecha.Value.ToShortDateString();

                Metodo.EliminarLibros(TituloBox);
                this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);

            }
            catch(FormatException)
            {
                MessageBox.Show("Introduce un valor valido.");
            }



        }

        private void Guardar_Click(object sender, EventArgs e)// Creamos un objeto de la clase libros y vamos recuperando cada uno de sus campos.
        {
             Libros TituloBox = new Libros();
             TituloBox.Titulo = Titulo.Text;
             TituloBox.Descripcion = Descripcion.Text;
             TituloBox.NumeroPaginas = int.Parse(NumeroPaginas.Text);
             TituloBox.FechaPublicacion = CajaFecha.Value.ToShortDateString();

            Metodo.CrearLibros(TituloBox);
            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            Libros TituloBox = new Libros();
            
            TituloBox.ID = Id;
            TituloBox.Titulo = Titulo.Text;
            TituloBox.Descripcion = Descripcion.Text;
            TituloBox.NumeroPaginas = int.Parse(NumeroPaginas.Text);
            TituloBox.FechaPublicacion = CajaFecha.Value.ToShortDateString();

            Metodo.ModificarLibros(TituloBox);
            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);



        }

        private void Filas(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;
            Id = int.Parse(dataGridView1.Rows[Indice].Cells[0].Value.ToString());
            Titulo.Text = dataGridView1.Rows[Indice].Cells[1].Value.ToString();
            CajaFecha.Text = dataGridView1.Rows[Indice].Cells[2].Value.ToString();
            Descripcion.Text = dataGridView1.Rows[Indice].Cells[3].Value.ToString();
            NumeroPaginas.Text = dataGridView1.Rows[Indice].Cells[4].Value.ToString();

        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Id = -1;
            Titulo.Text = "";
            CajaFecha.Text = "";
            Descripcion.Text = "";
            NumeroPaginas.Text = "";


                
        }
    }  } 
