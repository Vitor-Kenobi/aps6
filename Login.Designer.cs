namespace CNPA
{
    partial class Login
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
            label4 = new Label();
            txtCPF = new TextBox();
            btnIniciarCaptura = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnVerificar = new Button();
            txtResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 143);
            label4.Name = "label4";
            label4.Size = new Size(177, 15);
            label4.TabIndex = 17;
            label4.Text = "Digite o seu CPF (sem símbolos)";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(76, 162);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(650, 23);
            txtCPF.TabIndex = 13;
            // 
            // btnIniciarCaptura
            // 
            btnIniciarCaptura.Location = new Point(77, 545);
            btnIniciarCaptura.Name = "btnIniciarCaptura";
            btnIniciarCaptura.Size = new Size(243, 80);
            btnIniciarCaptura.TabIndex = 15;
            btnIniciarCaptura.Text = "Iniciar Captura";
            btnIniciarCaptura.UseVisualStyleBackColor = true;
            btnIniciarCaptura.Click += btnIniciarCaptura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(77, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 319);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 94);
            label1.Name = "label1";
            label1.Size = new Size(619, 32);
            label1.TabIndex = 14;
            label1.Text = "CNAP - Controle Nacional de Propriedades Agrícolas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 202);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 18;
            label2.Text = "Scaneie o seu rosto para autenticar";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(326, 545);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(400, 80);
            btnVerificar.TabIndex = 19;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(326, 632);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(12, 15);
            txtResultado.TabIndex = 20;
            txtResultado.Text = "-";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 734);
            Controls.Add(txtResultado);
            Controls.Add(btnVerificar);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(btnIniciarCaptura);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtCPF;
        private Button btnIniciarCaptura;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnVerificar;
        private Label txtResultado;
    }
}