namespace AjusteSped
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.textBoxAtual = new System.Windows.Forms.TextBox();
            this.textBoxNovo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxImposto = new System.Windows.Forms.ComboBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonExecutarQuery = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNovo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instancia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(72, 33);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(374, 21);
            this.comboBoxDatabase.TabIndex = 3;
            this.comboBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.comboBoxDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(72, 95);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDataInicial.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(198, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "até";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(231, 95);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDataFinal.TabIndex = 11;
            // 
            // textBoxAtual
            // 
            this.textBoxAtual.Location = new System.Drawing.Point(519, 94);
            this.textBoxAtual.Name = "textBoxAtual";
            this.textBoxAtual.Size = new System.Drawing.Size(77, 20);
            this.textBoxAtual.TabIndex = 13;
            // 
            // textBoxNovo
            // 
            this.textBoxNovo.Location = new System.Drawing.Point(602, 94);
            this.textBoxNovo.Name = "textBoxNovo";
            this.textBoxNovo.Size = new System.Drawing.Size(77, 20);
            this.textBoxNovo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(519, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Atual";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(602, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Novo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxImposto
            // 
            this.comboBoxImposto.FormattingEnabled = true;
            this.comboBoxImposto.Items.AddRange(new object[] {
            "CST PIS",
            "CST COFINS",
            "CST COFINS 2",
            "IPI CST"});
            this.comboBoxImposto.Location = new System.Drawing.Point(380, 94);
            this.comboBoxImposto.Name = "comboBoxImposto";
            this.comboBoxImposto.Size = new System.Drawing.Size(133, 21);
            this.comboBoxImposto.TabIndex = 17;
            this.comboBoxImposto.SelectedIndexChanged += new System.EventHandler(this.comboBoxImposto_SelectedIndexChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(602, 120);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(77, 23);
            this.buttonAdicionar.TabIndex = 19;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonExecutarQuery
            // 
            this.buttonExecutarQuery.Location = new System.Drawing.Point(570, 424);
            this.buttonExecutarQuery.Name = "buttonExecutarQuery";
            this.buttonExecutarQuery.Size = new System.Drawing.Size(109, 23);
            this.buttonExecutarQuery.TabIndex = 20;
            this.buttonExecutarQuery.Text = "Executar Query";
            this.buttonExecutarQuery.UseVisualStyleBackColor = true;
            this.buttonExecutarQuery.Click += new System.EventHandler(this.buttonExecutarQuery_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(499, 7);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(180, 20);
            this.textBoxUser.TabIndex = 22;
            this.textBoxUser.Text = "sa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "User Id:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(499, 33);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(180, 20);
            this.textBoxSenha.TabIndex = 24;
            this.textBoxSenha.Text = "senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Senha:";
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(72, 6);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(374, 21);
            this.comboBoxServer.TabIndex = 25;
            this.comboBoxServer.SelectedIndexChanged += new System.EventHandler(this.comboBoxServer_SelectedIndexChanged);
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // ColumnDataFinal
            // 
            this.ColumnDataFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataFinal.HeaderText = "Data Final";
            this.ColumnDataFinal.Name = "ColumnDataFinal";
            // 
            // ColumnDataInicial
            // 
            this.ColumnDataInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataInicial.HeaderText = "Data Inicial";
            this.ColumnDataInicial.Name = "ColumnDataInicial";
            // 
            // ColumnNovo
            // 
            this.ColumnNovo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNovo.HeaderText = "Novo";
            this.ColumnNovo.Name = "ColumnNovo";
            // 
            // ColumnAtual
            // 
            this.ColumnAtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAtual.HeaderText = "Atual";
            this.ColumnAtual.Name = "ColumnAtual";
            // 
            // ColumnImposto
            // 
            this.ColumnImposto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnImposto.HeaderText = "Imposto";
            this.ColumnImposto.Name = "ColumnImposto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImposto,
            this.ColumnAtual,
            this.ColumnNovo,
            this.ColumnDataInicial,
            this.ColumnDataFinal,
            this.ColumnDelete});
            this.dataGridView1.Location = new System.Drawing.Point(316, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(363, 252);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Location = new System.Drawing.Point(12, 166);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(298, 252);
            this.richTextBoxQuery.TabIndex = 27;
            this.richTextBoxQuery.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 454);
            this.Controls.Add(this.richTextBoxQuery);
            this.Controls.Add(this.comboBoxServer);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonExecutarQuery);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxImposto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNovo);
            this.Controls.Add(this.textBoxAtual);
            this.Controls.Add(this.dateTimePickerDataFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ajuste De Sped";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.TextBox textBoxAtual;
        private System.Windows.Forms.TextBox textBoxNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxImposto;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonExecutarQuery;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImposto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBoxQuery;
    }
}

