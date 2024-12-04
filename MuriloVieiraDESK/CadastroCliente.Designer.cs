namespace MuriloVieiraDESK
{
    partial class CadastroCliente
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
            btnInserir = new Button();
            btnAlterar = new Button();
            btnBuscarId = new Button();
            btnListar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEndereco = new TextBox();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(54, 191);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(137, 191);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(218, 191);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(75, 23);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "Buscar";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += button3_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(299, 191);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(54, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(378, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(54, 118);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(183, 23);
            txtTelefone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefone";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 144);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "Endereco";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(54, 162);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(344, 23);
            txtEndereco.TabIndex = 11;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 652);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnListar);
            Controls.Add(btnBuscarId);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnAlterar;
        private Button btnBuscarId;
        private Button btnListar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEndereco;
    }
}