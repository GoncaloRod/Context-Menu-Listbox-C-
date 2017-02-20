using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxContextMenu
{
    public partial class Main : Form
    {
        // Lista de pessoas
        List<string> pessoas = new List<string>();

        // Menu de contexto
        ContextMenu cm;

        public Main()
        {
            InitializeComponent();

            // Configurar o menu de contexto
            cm = new ContextMenu();
            cm.MenuItems.Add("Editar", Editar);
            cm.MenuItems.Add("Eliminar", Eliminar);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pessoas.Add("José");
            pessoas.Add("Manel");
            pessoas.Add("Josefino");
            pessoas.Add("Mongoloide");

            lstPessoas.DataSource = pessoas;
        }

        private void lstPessoas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = lstPessoas.IndexFromPoint(e.Location);
                if (item >= 0)
                {
                    lstPessoas.SelectedIndex = item;
                    cm.Show(lstPessoas, e.Location);
                }
            }
        }

        private void Editar(object sender, EventArgs e)
        {
            MessageBox.Show($"Pessoa Editada! Item: {lstPessoas.SelectedIndex}");
        }

        private void Eliminar(object sender, EventArgs e)
        {
            MessageBox.Show($"Pessoa Eliminada! Item: {lstPessoas.SelectedIndex}");
        }
    }
}
