namespace CNPA
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            Reconhecimento.IniciarCaptura(pictureBox1);
        }

        private void Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reconhecimento.FinalizarCaptura();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Reconhecimento.CapturarImagem(txtCPF.Text);
            lblStatus.Text = "Foto salva com sucesso.";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AcessarBanco db = new AcessarBanco();

            db.InserirUsuario(txtCPF.Text,txtNome.Text, comboAcesso.Text);

            MessageBox.Show("Usuário cadastrado com sucesso!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
