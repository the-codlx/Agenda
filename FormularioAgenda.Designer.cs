namespace Agenda
{
    partial class FormularioAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAgenda));
            this.btnsalvar = new System.Windows.Forms.Button();
            this.dataGridAgenda = new System.Windows.Forms.DataGridView();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(90, 617);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(197, 41);
            this.btnsalvar.TabIndex = 0;
            this.btnsalvar.Text = "Inserir";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridAgenda
            // 
            this.dataGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgenda.Location = new System.Drawing.Point(45, 136);
            this.dataGridAgenda.Name = "dataGridAgenda";
            this.dataGridAgenda.RowHeadersWidth = 51;
            this.dataGridAgenda.RowTemplate.Height = 24;
            this.dataGridAgenda.Size = new System.Drawing.Size(1010, 446);
            this.dataGridAgenda.TabIndex = 1;
            this.dataGridAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgenda_CellClick);
            this.dataGridAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgenda_CellContentClick);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(38, 50);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(95, 40);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "NOME:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Sitka Banner", 16.2F);
            this.txtnome.Location = new System.Drawing.Point(136, 50);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(384, 41);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(323, 617);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(197, 41);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(818, 617);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(197, 41);
            this.btnatualizar.TabIndex = 5;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(567, 617);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(197, 41);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(573, 50);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(97, 40);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "EMAIL:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Sitka Banner", 16.2F);
            this.txtemail.Location = new System.Drawing.Point(671, 50);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(384, 41);
            this.txtemail.TabIndex = 8;
            // 
            // FormularioAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1094, 700);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.dataGridAgenda);
            this.Controls.Add(this.btnsalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormularioAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView dataGridAgenda;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
    }
}

