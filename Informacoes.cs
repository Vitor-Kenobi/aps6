namespace CNPA
{
    public partial class Informacoes : Form
    {

        public Informacoes(string perfil, string nome)
        {
            InitializeComponent();

            txtPerfil.Text = perfil;
            txtNome.Text = nome;
            VerificaAcesso(perfil);

            AcessarBanco db = new AcessarBanco();
            dataGridView1.DataSource = db.GetInvestigacoes(perfil);
        }

        private void VerificaAcesso(string perfil)
        {
            string texto = "";
            switch (perfil)
            {
                case "Público":
                    texto = "Mostrando apenas informações públicas.";
                    break;
                case "Diretoria":
                    texto = "Mostrando informações de nível 1 e 2";
                    break;
                case "Ministro":
                    texto = "Mostrando todas as informações.";
                    btnCadastrar.Enabled = true;
                    break;
            }

            txtStatus.Text = texto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro novoForm = new Cadastro();
            novoForm.Show();
        }

        private void Informacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reconhecimento.FinalizarCaptura();
        }
    }
}
