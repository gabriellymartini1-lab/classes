using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using login_2.BD;
using Sunny.UI;

namespace login_2
{
    public partial class cadastro : UIForm
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_idade.Text) || string.IsNullOrEmpty(tb_genero.Text))
            {
                MessageBox.Show("por favor, insira valores :3 ");
                return;
            }
            autorCRUD.Cadastrar(tb_nome.Text, int.Parse(tb_idade.Text), char.Parse(tb_genero.Text));
            MessageBox.Show("autor cadastrado com sucesso! S2 ");
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
