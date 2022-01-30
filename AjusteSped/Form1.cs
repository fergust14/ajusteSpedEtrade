using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjusteSped
{
    public partial class Form1 : Form
    {
        String instanciaNome;
        String databaseNome;
        SqlConnection conexao;
        String querySql;
        SqlDataAdapter data_adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetLoadServer(ComboBox combo)
        {
            string serverName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey registry = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instansKey = registry.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instansKey != null)
                {
                    foreach (var instanceName in instansKey.GetValueNames())
                    {
                        combo.Items.Add(serverName + "\\" + instanceName);

                    }
                }
            }
            combo.Text = combo.Items[1].ToString();
        }
        private void GetLoadDatabases(ComboBox comboDB)
        {
            comboDB.Items.Clear();
            conexao = new SqlConnection($@"Server={comboBoxServer.Text};User Id={textBoxUser.Text};Password={textBoxSenha.Text};");
            conexao.Open();
            var command = new System.Data.SqlClient.SqlCommand();
            command.Connection = conexao;
            command.CommandType = CommandType.Text;
            command.CommandText = "select name from sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            DataTable dataBases = dataset.Tables[0];
            try
            {
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    comboBoxDatabase.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
            comboDB.Text = comboDB.Items[0].ToString();
        }

        public void rodarQuery(string imposto, string atual, string novo, string inicial, string final)
        {
            try
            {
                conexao = new SqlConnection($@"Server={instanciaNome};Database={databaseNome};User Id={textBoxUser.Text};Password={textBoxSenha.Text};");
                conexao.Open();
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine(_filePath);
                StreamReader sr = new StreamReader(_filePath + $"/{imposto}.txt");
                querySql = $"declare @atual as int, @novo as int, @inicial as date, @final as date set @atual = '{atual}'; set @novo = '{novo}'; set @inicial = '{inicial}'; set @final = '{final}'" + sr.ReadToEnd();
                //data_adapter = new SqlDataAdapter();
                //data_adapter.SelectCommand = new SqlCommand(querySql, conexao);
                //DataSet data_set = new DataSet();
                //data_adapter.Fill(data_set);
                SqlCommand comando = new SqlCommand(querySql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Query executada com sucesso!");
                conexao.Close();
            }

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBoxImposto.Text, textBoxAtual.Text, textBoxNovo.Text, dateTimePickerDataInicial.Value.ToString("yyyy-MM-dd"), dateTimePickerDataFinal.Value.ToString("yyyy-MM-dd"));
            mostrarQuery(comboBoxImposto.Text, textBoxAtual.Text, textBoxNovo.Text, dateTimePickerDataInicial.Value.ToString("yyyy-MM-dd"), dateTimePickerDataFinal.Value.ToString("yyyy-MM-dd")); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                mostrarQuery(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnDelete")
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetLoadDatabases(comboBoxDatabase);
        }

        private void comboBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            instanciaNome = comboBoxServer.Text;
            databaseNome = comboBoxDatabase.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLoadServer(comboBoxServer);
        }

        private void buttonExecutarQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = new DataGridView();
                dgv = dataGridView1;
                
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if(row.Cells[4].Value != null) 
                    {
                        dataGridView1.CurrentRow.Selected = true;
                        string imposto = row.Cells[0].Value.ToString();
                        string atual = row.Cells[1].Value.ToString();
                        string novo = row.Cells[2].Value.ToString();
                        string inicial = row.Cells[3].Value.ToString();
                        string final = row.Cells[4].Value.ToString();
                        rodarQuery(imposto, atual, novo, inicial, final);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void mostrarQuery(string imposto, string atual, string novo, string inicial, string final)
        {
            try 
            {
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine(_filePath);
                StreamReader sr = new StreamReader(_filePath + $"/{imposto}.txt");
                querySql = $"declare @atual as int, @novo as int, @inicial as date, @final as date \r\nset @atual = '{atual}'; \r\nset @novo = '{novo}'; \r\nset @inicial = '{inicial}'; \r\nset @final = '{final}'\r\n" + sr.ReadToEnd();
                richTextBoxQuery.Text = querySql;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxImposto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine(_filePath);
                StreamReader sr = new StreamReader(_filePath + $"/{comboBoxImposto.Text}.txt");
                richTextBoxQuery.Text = sr.ReadToEnd();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
