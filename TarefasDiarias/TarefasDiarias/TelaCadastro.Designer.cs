namespace TarefasDiarias
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            txtSenhas = new Guna.UI2.WinForms.Guna2TextBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lblNome = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 36);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(526, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(636, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSenhas);
            panel2.Controls.Add(txtNome);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblNome);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCadastrar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 36);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 510);
            panel2.TabIndex = 1;
            // 
            // txtSenhas
            // 
            txtSenhas.CustomizableEdges = customizableEdges1;
            txtSenhas.DefaultText = "";
            txtSenhas.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenhas.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenhas.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenhas.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenhas.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenhas.Font = new Font("Segoe UI", 9F);
            txtSenhas.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenhas.Location = new Point(144, 310);
            txtSenhas.Margin = new Padding(4, 6, 4, 6);
            txtSenhas.Name = "txtSenhas";
            txtSenhas.PasswordChar = '*';
            txtSenhas.PlaceholderText = "Senha";
            txtSenhas.SelectedText = "";
            txtSenhas.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSenhas.Size = new Size(352, 45);
            txtSenhas.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.CustomizableEdges = customizableEdges3;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(144, 229);
            txtNome.Margin = new Padding(4, 6, 4, 6);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNome.Size = new Size(469, 45);
            txtNome.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(144, 130);
            txtEmail.Margin = new Padding(4, 6, 4, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(469, 45);
            txtEmail.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(658, 430);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 330);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(79, 229);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(506, 316);
            btnCadastrar.Margin = new Padding(4, 5, 4, 5);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(108, 39);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Casdastrar ";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnCadastrar;
        private Label label3;
        private Label lblNome;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSenhas;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}