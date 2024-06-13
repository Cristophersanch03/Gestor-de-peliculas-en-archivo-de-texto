using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestor_de_peliculas_en_archivo_de_texto
{
    public partial class Form1 : Form
    {
        private List<Peliculas_class> listaPeliculas = new List<Peliculas_class>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbo_generos_SelectedIndexChanged(object sender, EventArgs e)
        {
}

        private void txt_duracion_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_duracion.Text, "[^0-9:]"))
            {
                MessageBox.Show("Por favor, ingresa la duración en formato hh:mm:ss.");

            }
        }

        private void txt_director_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_productora_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string titulo = txt_titulo.Text;
            string genero = cbo_generos.Text;
            string duracion = txt_duracion.Text;

            string director = txt_director.Text;
            string productora = txt_productora.Text;

            Peliculas_class pelicula = new Peliculas_class(titulo, genero, duracion, director, productora);
            listaPeliculas.Add(pelicula);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPeliculas;
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PELICULAS ALMACENAS", "peliculas.txt");

           
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                foreach (Peliculas_class pelicula in listaPeliculas)
                {
                    writer.WriteLine($"Título: {pelicula.Titulo}");
                    writer.WriteLine($"Género: {pelicula.Genero}");
                    writer.WriteLine($"Duración: {pelicula.Duracion} minutos");
                    writer.WriteLine($"Director: {pelicula.Director}");
                    writer.WriteLine($"Productora: {pelicula.Productora}");
                    writer.WriteLine();
                    writer.WriteLine();
                }
            }

            MessageBox.Show("Archivo creado correctamente.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_titulo.Text = "";
            txt_duracion.Text = "";
            txt_director.Text = "";
            txt_productora.Text = "";
       
        }
    }
}

