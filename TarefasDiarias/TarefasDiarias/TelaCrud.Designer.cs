namespace TarefasDiarias
{
    partial class TelaCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCrud));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtID = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            dgvTarefas = new DataGridView();
            dtpPrazo = new DateTimePicker();
            button1 = new Button();
            cbPrioridades = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 36);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1029, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1130, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(txtDescricao);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(dgvTarefas);
            panel2.Controls.Add(dtpPrazo);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(cbPrioridades);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 36);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 510);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.CustomizableEdges = customizableEdges1;
            txtID.DefaultText = "";
            txtID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtID.Font = new Font("Segoe UI", 9F);
            txtID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtID.Location = new Point(54, 313);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "";
            txtID.ReadOnly = true;
            txtID.SelectedText = "";
            txtID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtID.Size = new Size(77, 30);
            txtID.TabIndex = 17;
            // 
            // txtDescricao
            // 
            txtDescricao.CustomizableEdges = customizableEdges3;
            txtDescricao.DefaultText = "";
            txtDescricao.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescricao.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescricao.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Font = new Font("Segoe UI", 9F);
            txtDescricao.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Location = new Point(57, 118);
            txtDescricao.Margin = new Padding(4, 5, 4, 5);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescricao.Size = new Size(466, 31);
            txtDescricao.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.CustomizableEdges = customizableEdges5;
            txtTitulo.DefaultText = "";
            txtTitulo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitulo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitulo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Font = new Font("Segoe UI", 9F);
            txtTitulo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Location = new Point(54, 40);
            txtTitulo.Margin = new Padding(4, 5, 4, 5);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Titulo";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTitulo.Size = new Size(466, 31);
            txtTitulo.TabIndex = 15;
            txtTitulo.TextChanged += txtTitulo_TextChanged_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(208, 375);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 51);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(54, 375);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 51);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvTarefas
            // 
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(531, 40);
            dgvTarefas.Margin = new Padding(4, 5, 4, 5);
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.RowHeadersWidth = 51;
            dgvTarefas.Size = new Size(682, 450);
            dgvTarefas.TabIndex = 12;
            dgvTarefas.CellClick += dgvTarefas_CellClick;
            // 
            // dtpPrazo
            // 
            dtpPrazo.Location = new Point(54, 190);
            dtpPrazo.Margin = new Padding(4, 5, 4, 5);
            dtpPrazo.Name = "dtpPrazo";
            dtpPrazo.Size = new Size(466, 31);
            dtpPrazo.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(414, 252);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(108, 51);
            button1.TabIndex = 10;
            button1.Text = "Cadastar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbPrioridades
            // 
            cbPrioridades.FormattingEnabled = true;
            cbPrioridades.Items.AddRange(new object[] { "Alta", "Media", "Baixo" });
            cbPrioridades.Location = new Point(54, 262);
            cbPrioridades.Margin = new Padding(4, 5, 4, 5);
            cbPrioridades.Name = "cbPrioridades";
            cbPrioridades.Size = new Size(328, 33);
            cbPrioridades.TabIndex = 9;
            // 
            // TelaCrud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaCrud";
            Text = "TelaCrud";
            Load += TelaCrud_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private DateTimePicker dtpPrazo;
        private DataGridView dgvTarefas;
        private Button btnExcluir;
        private Button btnEditar;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private ComboBox cbPrioridades;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
    }
}