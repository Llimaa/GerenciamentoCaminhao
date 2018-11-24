using GerenciamentoCaminhao.Dominio.Comandos.Entrada;
using GerenciamentoCaminhao.Dominio.Comandos.Manipulador;
using GerenciamentoCaminhao.Dominio.Comandos.Resultado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoCaminhao.WinForms
{
    public partial class frmCadastrarCaminhao : Form
    {
        private RegistrarComandoManipuladorCaminhao _registrarCaminhao;
        public frmCadastrarCaminhao(RegistrarComandoManipuladorCaminhao registrarCaminhao)
        {
            _registrarCaminhao = registrarCaminhao;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var registrarComandoCaminhao = (RegistrarComandoCaminhao)registrarComandoCaminhaoBindingSource.Current;
            var resposta = (RegistrarComandoResultadoCaminhao)_registrarCaminhao.Manipulador(registrarComandoCaminhao);

            MessageBox.Show(resposta.Mensagem.ToString());
            
            

        }

        private void registrarComandoCaminhaoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastrarCaminhao_Load(object sender, EventArgs e)
        {
            registrarComandoCaminhaoBindingSource.AddNew();
        }
    }
}
