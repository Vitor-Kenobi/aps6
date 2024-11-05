namespace CNPA
{
    partial class Informacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPerfil = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtNome = new Label();
            txtStatus = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 19);
            label1.Name = "label1";
            label1.Size = new Size(619, 32);
            label1.TabIndex = 0;
            label1.Text = "CNAP - Controle Nacional de Propriedades Agrícolas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 76);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            txtPerfil.AutoSize = true;
            txtPerfil.Location = new Point(65, 76);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(0, 15);
            txtPerfil.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(862, 464);
            dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 76);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(284, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(12, 15);
            txtNome.TabIndex = 5;
            txtNome.Text = "-";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(614, 76);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(12, 15);
            txtStatus.TabIndex = 6;
            txtStatus.Text = "-";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Enabled = false;
            btnCadastrar.Location = new Point(757, 580);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(129, 23);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Novo Usuário";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Informacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 613);
            Controls.Add(btnCadastrar);
            Controls.Add(txtStatus);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtPerfil);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Informacoes";
            Text = "Informacoes";
            FormClosed += Informacoes_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txtPerfil;
        private DataGridView dataGridView1;
        private Label label3;
        private Label txtNome;
        private Label txtStatus;
        private Button btnCadastrar;
    }
}