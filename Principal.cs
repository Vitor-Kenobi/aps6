using MathNet.Numerics;
using static CNPA.Reconhecimento;
namespace CNPA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSel1_Click(object sender, EventArgs e)
        {
            txtCaminho1.Text = selecArquivo();
        }

        private void btnSel2_Click(object sender, EventArgs e)
        {
            txtCaminho2.Text = selecArquivo();
        }

        private String selecArquivo()
        {
            String diretorio;
            using (OpenFileDialog dirDialog = new OpenFileDialog())
            {
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    return diretorio = dirDialog.FileName;
                }
                else
                    return diretorio = "Algo deu errado";
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (txtCaminho1 != null && txtCaminho2 != null)
            {
                Reconhecimento re = new Reconhecimento(txtCaminho1.Text, txtCaminho2.Text);
                double dot = re.Comparar();

                txtPrev.Text = "Previsão: " + dot.Round(2);
                    if (dot >= (double) selAcuracidade.Value/100)
                    {
                        txtResultado.Text = "Ambas as fotos mostram a mesma pessoa.";
                    }
                    else if (dot > 0.28 && dot < (double)selAcuracidade.Value / 100)
                    {
                        txtResultado.Text = "Difícil dizer se é a mesma pessoa...";
                    }
                    else if (dot <= 0.28)
                    {
                        txtResultado.Text = "Não é a mesma pessoa.";
                    }
            }
        }
    }
}
