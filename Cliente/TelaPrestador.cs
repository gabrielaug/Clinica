using Cliente.localhost1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class TelaPrestador : Form
    {
        
        public TelaPrestador()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CADASTRAR_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();

            Prestador prestador = new Prestador();

            prestador.NmPrestador = txtNmPrestador.Text;
            prestador.NrConselho = NrConselho.Text;
            prestador.Telefone = TelefonePrestador.Text;
            prestador.Cpf = cpfprestador.Text;
            try
            {
                s.CadastrarPrestador(prestador);
                MessageBox.Show("Prestador Cadastrado.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            

        }

        private void NmPrestador_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            Prestador prestador = new Prestador();

            prestador.CdPrestador = Convert.ToInt32(CdPrestador.Text);
            prestador.SnAtivo = "N";

            try
            {
                s.InativarPrestador(prestador);
                MessageBox.Show("Prestador Inativado.");
            }
            catch
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            Prestador prestador = new Prestador();
            prestador.CdPrestador = Convert.ToInt32(CdPrestador.Text);
            prestador.NmPrestador = txtNmPrestador.Text;
            prestador.NrConselho = NrConselho.Text;
            prestador.Telefone = TelefonePrestador.Text;
            prestador.Cpf = cpfprestador.Text;

            s.AtualizarPrestador(prestador);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();

            Prestador prestador = new Prestador();
            listView1.Items.Clear();
            List<Prestador> p = new List<Prestador>();
            foreach(Prestador i in s.ListaPrestadores(prestador))
            {
                listView1.Items.Add(Convert.ToString(i.CdPrestador), 0);
                listView1.Items.Add(i.NmPrestador, 1);
                listView1.Items.Add(i.Cpf, 2);
                listView1.Items.Add(i.Telefone, 3);
                listView1.Items.Add(i.NrConselho, 4);
                listView1.Items.Add(i.SnAtivo, 5);
            }


        }
    }
}
