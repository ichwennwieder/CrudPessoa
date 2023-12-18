using CrudPessoa.Models;
using CrudPessoa.Repository;
using System;

namespace CrudPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(0, txtNome.Text, txtCPF.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepository();
            pessoaRepositorio.Inserir(pessoa);
            LimparCampos();
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(Convert.ToInt32(txtID.Text), txtNome.Text, txtCPF.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepository();
            pessoaRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepository();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtID.Text));
            LimparCampos();
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void LimparCampos()
        {
            txtCPF.Text = string.Empty;
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void BuscarTodasPessoas(PessoaRepository pessoaRepository)
        {
            var pessoas = pessoaRepository.BuscarTodasPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepository();
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void dgPessoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtID.Text = dgv.CurrentRow.Cells["Id"].Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"].Value?.ToString();
            txtCPF.Text = dgv.CurrentRow.Cells["CPF"].Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value?.ToString();
        }
    }
}
