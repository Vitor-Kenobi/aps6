using MathNet.Numerics;

namespace CNPA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // private static string projDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        private static string projDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string imgDir = projDir + @"\resources\imagens\";

        private string nivelAcesso, nome;
        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            AcessarBanco db = new AcessarBanco();
            string[] dados = db.GetUsuario(txtCPF.Text);

            if (dados[0] != null)
            {
                nome = dados[0];
                nivelAcesso = dados[1];
                Reconhecimento.IniciarCaptura(pictureBox1);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Reconhecimento.CapturarImagem("temp");

            string path1 = @$"{imgDir}{txtCPF.Text}.jpg";
            string path2 = @$"{imgDir}\temp.jpg";

            Reconhecimento re = new Reconhecimento(path1, path2);
            double dot = re.Comparar();

            MessageBox.Show("Previsão: " + dot.Round(2), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dot >= 0.60)
            {
                MessageBox.Show("Autenticação bem sucedida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Informacoes proxForm = new Informacoes(nivelAcesso, nome);
                proxForm.Show();
                this.Close();
            }
            else if (dot > 0.28 && dot < 0.60)
            {
                txtResultado.Text = "Por favor, tente novamente!";
            }
            else if (dot <= 0.28)
            {
                txtResultado.Text = "Não é a mesma pessoa.";
            }
        }
    }
}
