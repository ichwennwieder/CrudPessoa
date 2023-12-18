namespace CrudPessoa
{
    partial class Form1
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
            lbID = new Label();
            dgPessoa = new DataGridView();
            txtID = new TextBox();
            txtNome = new TextBox();
            lbNome = new Label();
            txtCPF = new TextBox();
            lbCPF = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(22, 48);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            lbID.Click += label1_Click;
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(22, 279);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.RowTemplate.Height = 25;
            dgPessoa.Size = new Size(755, 150);
            dgPessoa.TabIndex = 1;
            dgPessoa.CellMouseClick += dgPessoa_CellMouseClick;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(22, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(152, 23);
            txtID.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(22, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(152, 23);
            txtNome.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(22, 102);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(22, 176);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(152, 23);
            txtCPF.TabIndex = 6;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Location = new Point(22, 158);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(28, 15);
            lbCPF.TabIndex = 5;
            lbCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(22, 213);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(195, 231);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(276, 231);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(357, 231);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCPF);
            Controls.Add(lbCPF);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(txtID);
            Controls.Add(dgPessoa);
            Controls.Add(lbID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private DataGridView dgPessoa;
        private TextBox txtID;
        private TextBox txtNome;
        private Label lbNome;
        private TextBox txtCPF;
        private Label lbCPF;
        private TextBox txtEmail;
        private Label lbEmail;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
    }
}
