namespace CNPA
{
    partial class Cadastro
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
            txtNome = new TextBox();
            comboAcesso = new ComboBox();
            pictureBox1 = new PictureBox();
            btnIniciarCaptura = new Button();
            btnCapturar = new Button();
            btnCadastrar = new Button();
            lnlNome = new Label();
            label3 = new Label();
            lblStatus = new Label();
            label4 = new Label();
            txtCPF = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(619, 32);
            label1.TabIndex = 1;
            label1.Text = "CNAP - Controle Nacional de Propriedades Agrícolas";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(17, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(650, 23);
            txtNome.TabIndex = 2;
            // 
            // comboAcesso
            // 
            comboAcesso.FormattingEnabled = true;
            comboAcesso.Items.AddRange(new object[] { "Público", "Diretoria", "Ministro" });
            comboAcesso.Location = new Point(18, 191);
            comboAcesso.Name = "comboAcesso";
            comboAcesso.Size = new Size(117, 23);
            comboAcesso.TabIndex = 3;
            comboAcesso.Text = "Público";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 319);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarCaptura
            // 
            btnIniciarCaptura.Location = new Point(17, 545);
            btnIniciarCaptura.Name = "btnIniciarCaptura";
            btnIniciarCaptura.Size = new Size(227, 23);
            btnIniciarCaptura.TabIndex = 4;
            btnIniciarCaptura.Text = "Iniciar Captura";
            btnIniciarCaptura.UseVisualStyleBackColor = true;
            btnIniciarCaptura.Click += btnIniciarCaptura_Click;
            // 
            // btnCapturar
            // 
            btnCapturar.Location = new Point(435, 545);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(232, 23);
            btnCapturar.TabIndex = 5;
            btnCapturar.Text = "Salvar Foto";
            btnCapturar.UseVisualStyleBackColor = true;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(126, 615);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(434, 84);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lnlNome
            // 
            lnlNome.AutoSize = true;
            lnlNome.Location = new Point(18, 119);
            lnlNome.Name = "lnlNome";
            lnlNome.Size = new Size(40, 15);
            lnlNome.TabIndex = 8;
            lnlNome.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 171);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 9;
            label3.Text = "Nível de Acesso";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(435, 571);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 71);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 12;
            label4.Text = "CPF (Sem símbolos)";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(18, 90);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(650, 23);
            txtCPF.TabIndex = 1;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 724);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(lnlNome);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCapturar);
            Controls.Add(btnIniciarCaptura);
            Controls.Add(pictureBox1);
            Controls.Add(comboAcesso);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            FormClosed += Cadastro_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private ComboBox comboAcesso;
        private PictureBox pictureBox1;
        private Button btnIniciarCaptura;
        private Button btnCapturar;
        private Button btnCadastrar;
        private Label lnlNome;
        private Label label3;
        private Label lblStatus;
        private Label label2;
        private Label label4;
        private TextBox txtCPF;
    }
}