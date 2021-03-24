using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_23_03_2021
{
    public partial class frm000Geral : Form
    {
        public frm000Geral()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Alo Mundo!");
            MessageBox.Show("Alo mundo!",
               "Estudos iniciais");
            MessageBox.Show("Alo mundo!",
                "Estudos iniciais", MessageBoxButtons.OKCancel);
            MessageBox.Show("Alo mundo!",
               "Estudos iniciais",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Angélica Resende Araújo\nRua: XXXXXX XXXXXXX XXXXXX\nnro XXX\nCidade: XXXXXXX\nEstado: XX\nCEP:XXXXX-XXX",
                            "Dados do Cliente",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList o_arlGeral = new ArrayList();

            //Add elementos
            o_arlGeral.Add(3);
            o_arlGeral.Add("João");
            o_arlGeral.Add(1.65);
            o_arlGeral.Add(DateTime.Now);
            o_arlGeral.Add("João");
            o_arlGeral.Add("João");

            //Exibe todos os elemento
            foreach(Object Item in o_arlGeral)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }

            // Verifica se contem o elemento
            if (o_arlGeral.Contains("João"))
            {
                MessageBox.Show("O Array List contem o nome: João",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Array List NÃO contem o nome: João",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            // Remove o primeiro João que encontrar na lista
            o_arlGeral.Remove("João");

            MessageBox.Show("O primeiro João encontrado na lista foi removido",
            "Remoção", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Exibe todos os elementos
            foreach (Object Item in o_arlGeral)
            {
                Console.WriteLine("Item: " + Item.ToString());
            }

            // Remove todos os elementos
            o_arlGeral.Clear();

            MessageBox.Show("Todos os itens da lista foram removidos.",
            "Remoção", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> lstStarWars = new List<string>();

            // Adiciona um elemento
            lstStarWars.Add("Luke Skywalker");
            lstStarWars.Add("Darth Vader");
            lstStarWars.Add("Han Solo");
            lstStarWars.Add("Chewbacca");

            // Exibe todos os elementos da lista
            foreach (string item in lstStarWars)
            {
                Console.WriteLine("Nomes: " + item.ToString());
            }

            // Remove o item
            lstStarWars.Remove("Chewbacca");

            // Adiciona itens na lista
            lstStarWars.Add("Leia Organa");
            lstStarWars.Add("R2D2");
            lstStarWars.Add("C3PO");
            lstStarWars.Add("BB8");

            // Verifica se um elemento se encontra na lista
            if (lstStarWars.Contains("Han Solo"))
            {
                MessageBox.Show("Han Solo – Positivo Operante",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Han Solo – Inativo",
                "Pesquisa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            Console.WriteLine("\n\n\n");

            // Exibe todos os elementos da lista
            foreach (Object Item in lstStarWars)
            {
                Console.WriteLine("Novos Itens: " + Item.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hashtable o_hstEmailAluno = new Hashtable();

            //Add elementos
            o_hstEmailAluno.Add("jose.maria@google.com", "José Maria");
            o_hstEmailAluno.Add("carlostixeira@hotmail.com","Carlos Teixeira");
            o_hstEmailAluno.Add("pedropaulo@msn.com", "Pedro paulo");

            //Exibe tofo os elemento com Base na chave
            Console.WriteLine("====== CHAVE ======");
            foreach(Object Item in o_hstEmailAluno.Keys)
            {
                Console.WriteLine("Item.Chave: " + Item.ToString());
            }

            //Exibe todos os elementos com Base no valor
            Console.WriteLine("====== VALOR ======");
            foreach (Object Item in o_hstEmailAluno.Values)
            {
                Console.WriteLine("Item.Valor: " + Item.ToString());
            }

            //Verifica se contém o elemento
            if (o_hstEmailAluno.Contains("pedropaulo@msn.com"))
            {
                MessageBox.Show("O Hashtable contém o e-mail: pedropaulo@msn.com",
                                "Pesquisa,",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Hashtable Não contém o e-mail: pedropaulo@msn.com",
                   "Pesquisa,",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            }

            //Remove o elemento com base na sua chace
            o_hstEmailAluno.Remove("pedropaulo@msn.com");

            //Exibe todos os elementos Independente da chace ou valor
            Console.Write("====== CHAVE/VALOR ======");

            //Cada item é um Hashtable é armazenado em um par de chave/valor
            //armazenado em um objeto DictionaryEntry
            foreach(DictionaryEntry Item in o_hstEmailAluno)
            {
                Console.WriteLine(Item.Key.ToString() + " ==> " + Item.Value.ToString());
            }
        }

        private void frm000Geral_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x, total;
            x = 0;
            total = 100 / x;

            Console.WriteLine("Resultado: " + total);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;
                x = 0;

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch
            {
                MessageBox.Show("Não é possível divisão por zero.",
                                "Tratamento de Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;
                x = 0;

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                "Tratamento de Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int x, total;
                x = 0;

                if (x == 0)
                {
                    throw new Exception("O valor de X deve ser maior que zero.");
                }

                total = 100 / x;

                Console.WriteLine("Resultado: " + total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                "Tratamento de Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
