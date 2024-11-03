namespace CNPA
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCaminho1 = new TextBox();
            txtCaminho2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrev = new TextBox();
            label3 = new Label();
            btnComparar = new Button();
            btnSel1 = new Button();
            btnSel2 = new Button();
            selAcuracidade = new NumericUpDown();
            label4 = new Label();
            txtResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)selAcuracidade).BeginInit();
            SuspendLayout();
            // 
            // txtCaminho1
            // 
            txtCaminho1.Location = new Point(31, 79);
            txtCaminho1.Name = "txtCaminho1";
            txtCaminho1.Size = new Size(417, 23);
            txtCaminho1.TabIndex = 0;
            // 
            // txtCaminho2
            // 
            txtCaminho2.Location = new Point(31, 126);
            txtCaminho2.Name = "txtCaminho2";
            txtCaminho2.Size = new Size(417, 23);
            txtCaminho2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 61);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 2;
            label1.Text = "Caminho da Imagem 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 108);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Caminho da Imagem 2";
            // 
            // txtPrev
            // 
            txtPrev.Location = new Point(29, 247);
            txtPrev.Multiline = true;
            txtPrev.Name = "txtPrev";
            txtPrev.Size = new Size(149, 38);
            txtPrev.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 215);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado da Comparação";
            // 
            // btnComparar
            // 
            btnComparar.Location = new Point(183, 160);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(354, 52);
            btnComparar.TabIndex = 6;
            btnComparar.Text = "Comparar";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // btnSel1
            // 
            btnSel1.Location = new Point(454, 79);
            btnSel1.Name = "btnSel1";
            btnSel1.Size = new Size(75, 23);
            btnSel1.TabIndex = 7;
            btnSel1.Text = "Selecionar";
            btnSel1.UseVisualStyleBackColor = true;
            btnSel1.Click += btnSel1_Click;
            // 
            // btnSel2
            // 
            btnSel2.Location = new Point(454, 125);
            btnSel2.Name = "btnSel2";
            btnSel2.Size = new Size(75, 23);
            btnSel2.TabIndex = 8;
            btnSel2.Text = "Selecionar";
            btnSel2.UseVisualStyleBackColor = true;
            btnSel2.Click += btnSel2_Click;
            // 
            // selAcuracidade
            // 
            selAcuracidade.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            selAcuracidade.Location = new Point(30, 181);
            selAcuracidade.Name = "selAcuracidade";
            selAcuracidade.Size = new Size(129, 23);
            selAcuracidade.TabIndex = 9;
            selAcuracidade.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 163);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Acuracidade";
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(196, 260);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(12, 15);
            txtResultado.TabIndex = 11;
            txtResultado.Text = "-";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 770);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(selAcuracidade);
            Controls.Add(btnSel2);
            Controls.Add(btnSel1);
            Controls.Add(btnComparar);
            Controls.Add(label3);
            Controls.Add(txtPrev);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCaminho2);
            Controls.Add(txtCaminho1);
            Name = "Principal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)selAcuracidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCaminho1;
        private TextBox txtCaminho2;
        private Label label1;
        private Label label2;
        private TextBox txtPrev;
        private Label label3;
        private Button btnComparar;
        private Button btnSel1;
        private Button btnSel2;
        private NumericUpDown selAcuracidade;
        private Label label4;
        private Label txtResultado;
    }
}
