using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Adicionar as colunas ao dataGriview
            dgvTarefas.Columns.Add("colTarefas", "Tarefas");
            dgvTarefas.Columns.Add("colResponsavel", "Responsavel");
            dgvTarefas.Columns.Add("colSetor", "Setor");
            dgvTarefas.Columns.Add("colData", "Data Limite");
            //Popular o combobox:
            string[] setores = { "Administrativo", "Financeiro", "Supoerte", "Atendimento", "Desenvolvimento" };
            //Adicionar os setores ao cmb
            cmbSetor.Items.AddRange(setores);   
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se os campo estão vazios
            if (string.IsNullOrEmpty(txbNomeTarefa.Text) && txbNomeTarefa.Text.Length < 3)
            {
                MessageBox.Show("O nome da tarefa não pode ficar vazio", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txbNomeResponsavel.Text) && txbNomeResponsavel.Text.Length < 3)
            {
                MessageBox.Show("O nome do responsável não pode ficar vazio", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbSetor.SelectedIndex == -1)
            {
                MessageBox.Show("O setor não pode ficar vazio", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpLimite.Value < DateTime.Today)
            {
                MessageBox.Show("Não é possível adicionar tarefas em datas passadas!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tarefa = txbNomeTarefa.Text;
                string resp = txbNomeResponsavel.Text;
                string setor = cmbSetor.Text;
                DateTime linste = dtpLimite.Value;

                //Adiconar a linha:
                dgvTarefas.Rows.Add(tarefa, resp, setor, linste);

                //Limpar os campos 
                txbNomeTarefa.Clear();
                txbNomeResponsavel.Clear();
                cmbSetor.SelectedIndex = -1;
                dtpLimite.Value = DateTime.Today; //Retornar a data de hoje 
            }
        }

        private void pibApagar_Click(object sender, EventArgs e)
        {
            //Verificar se existe alguma celula selecionada:
            if(dgvTarefas.SelectedCells.Count > 0)
            {

              // Obeter a linha selecionada
              int linhaSelecionada = dgvTarefas.SelectedCells[0].RowIndex;

              //Perguntar se o usuario quer realmente remover
              DialogResult resultado = MessageBox.Show("Tem certeza que quer remover?", "ATENÇÃO!" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
              if (resultado == DialogResult.Yes)
              {
               //Apagar 
               dgvTarefas.Rows.RemoveAt(linhaSelecionada);
              }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           pibApagar_Click(pibApagar, EventArgs.Empty);
        }
    }
}
