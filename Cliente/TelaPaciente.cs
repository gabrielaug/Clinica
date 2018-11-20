using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente.localhost1;
using System.Web.Services.Protocols;
using System.Xml;


namespace Cliente
{

  
    public partial class TelaPaciente : Form
    {
        public TelaPaciente()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NmPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void NmSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cpfpaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void RgPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtNascimento_TextChanged(object sender, EventArgs e)
        {


        }

        private void EmailPaciente_TextChanged(object sender, EventArgs e)
        {


        }

        private void NmPai_TextChanged(object sender, EventArgs e)
        {


        }

        private void NmMae_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Service1 s = new Service1();
            Paciente paciente = new Paciente();
            paciente.Telefone = TelPaciente.Text;
            paciente.NmMae = NmMae.Text;
            paciente.NmPai = NmPai.Text;
            paciente.Email = EmailPaciente.Text;
            paciente.Rg = RgPaciente.Text;
            paciente.Cpf = Cpfpaciente.Text;
            paciente.NmPaciente = NmPaciente.Text;
            paciente.DtNascimento = DateTime.Parse(DtNascimento.Text);
            paciente.NmSocial = NmSocial.Text;
            // paciente.CdPaciente = Convert.ToInt32(CdPaciente.Text);
            paciente.Endereco = EndPac.Text;
            paciente.Bairro = BairroPac.Text;
            paciente.Estado = EstadoPac.Text;
            s.CadastrarPaciente(paciente);
            //s.CadastrarPaciente(paciente);
            CdPaciente.Text = Convert.ToString(paciente.CdPaciente);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            Paciente paciente = new Paciente();
            paciente.Telefone = TelPaciente.Text;
            paciente.NmMae = NmMae.Text;
            paciente.NmPai = NmPai.Text;
            paciente.Email = EmailPaciente.Text;
            paciente.Rg = RgPaciente.Text;
            paciente.Cpf = Cpfpaciente.Text;
            paciente.NmPaciente = NmPaciente.Text;
            paciente.DtNascimento = DateTime.Parse(DtNascimento.Text);
            paciente.NmSocial = NmSocial.Text;
            // paciente.CdPaciente = Convert.ToInt32(CdPaciente.Text);
            paciente.Endereco = EndPac.Text;
            paciente.Bairro = BairroPac.Text;
            paciente.Estado = EstadoPac.Text;
            s.AlterarPaciente(paciente);
            //s.CadastrarPaciente(paciente);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service1 s = new Service1();
            Paciente paciente = new Paciente();
            paciente.CdPaciente = Convert.ToInt32(CdPaciente.Text);
            s.ListaPaciente(paciente);
              TelPaciente.Text = paciente.Telefone;
              NmMae.Text = paciente.NmMae ;
              NmPai.Text = paciente.NmPai;
              EmailPaciente.Text = paciente.Email;
              RgPaciente.Text = paciente.Rg;
              Cpfpaciente.Text = paciente.Cpf;
              NmPaciente.Text = paciente.NmPaciente;
              DtNascimento.Text = Convert.ToString(paciente.DtNascimento);
              NmSocial.Text = paciente.NmSocial;

              EndPac.Text = paciente.Endereco;
              BairroPac.Text = paciente.Bairro;


            // paciente.CdPaciente = Convert.ToInt32(CdPaciente.Text);
            
          



        }
    }


            

        }
    

