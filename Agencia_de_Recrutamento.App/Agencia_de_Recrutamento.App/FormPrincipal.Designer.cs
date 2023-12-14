namespace Agencia_de_Recrutamento.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            recrutadorLabel = new Label();
            VagasTab = new ReaLTaiizor.Controls.MaterialTabControl();
            iniciotab1 = new TabPage();
            vagastab1 = new TabPage();
            cadastroempresatab1 = new TabPage();
            cadastrocandidatotab1 = new TabPage();
            cadastrocidadetab1 = new TabPage();
            cadastrovagatab1 = new TabPage();
            VagasTab.SuspendLayout();
            SuspendLayout();
            // 
            // recrutadorLabel
            // 
            recrutadorLabel.AutoSize = true;
            recrutadorLabel.BackColor = Color.FromArgb(63, 81, 181);
            recrutadorLabel.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            recrutadorLabel.ForeColor = Color.White;
            recrutadorLabel.Location = new Point(266, 32);
            recrutadorLabel.Name = "recrutadorLabel";
            recrutadorLabel.Size = new Size(187, 23);
            recrutadorLabel.TabIndex = 1;
            recrutadorLabel.Text = "Nome do Recrutador";
            // 
            // VagasTab
            // 
            VagasTab.Controls.Add(iniciotab1);
            VagasTab.Controls.Add(vagastab1);
            VagasTab.Controls.Add(cadastrovagatab1);
            VagasTab.Controls.Add(cadastroempresatab1);
            VagasTab.Controls.Add(cadastrocandidatotab1);
            VagasTab.Controls.Add(cadastrocidadetab1);
            VagasTab.Depth = 0;
            VagasTab.Dock = DockStyle.Fill;
            VagasTab.Location = new Point(3, 64);
            VagasTab.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            VagasTab.Multiline = true;
            VagasTab.Name = "VagasTab";
            VagasTab.SelectedIndex = 0;
            VagasTab.Size = new Size(711, 389);
            VagasTab.TabIndex = 3;
            VagasTab.SelectedIndexChanged += VagasTab_Click;
            // 
            // iniciotab1
            // 
            iniciotab1.BackColor = Color.FromArgb(238, 249, 255);
            iniciotab1.BackgroundImage = Properties.Resources.fundo_area_inicial;
            iniciotab1.BackgroundImageLayout = ImageLayout.Center;
            iniciotab1.Location = new Point(4, 24);
            iniciotab1.Name = "iniciotab1";
            iniciotab1.Size = new Size(703, 361);
            iniciotab1.TabIndex = 3;
            iniciotab1.Text = "Área Inicial";
            // 
            // vagastab1
            // 
            vagastab1.Location = new Point(4, 24);
            vagastab1.Name = "vagastab1";
            vagastab1.Padding = new Padding(3);
            vagastab1.Size = new Size(703, 361);
            vagastab1.TabIndex = 0;
            vagastab1.Text = "Vagas Ativas";
            vagastab1.UseVisualStyleBackColor = true;
            // 
            // cadastroempresatab1
            // 
            cadastroempresatab1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroempresatab1.Location = new Point(4, 24);
            cadastroempresatab1.Name = "cadastroempresatab1";
            cadastroempresatab1.Size = new Size(703, 361);
            cadastroempresatab1.TabIndex = 4;
            cadastroempresatab1.Text = "Nova Empresa";
            cadastroempresatab1.UseVisualStyleBackColor = true;
            // 
            // cadastrocandidatotab1
            // 
            cadastrocandidatotab1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrocandidatotab1.Location = new Point(4, 24);
            cadastrocandidatotab1.Name = "cadastrocandidatotab1";
            cadastrocandidatotab1.Size = new Size(703, 361);
            cadastrocandidatotab1.TabIndex = 5;
            cadastrocandidatotab1.Text = "Novo Candidato";
            cadastrocandidatotab1.UseVisualStyleBackColor = true;
            // 
            // cadastrocidadetab1
            // 
            cadastrocidadetab1.Location = new Point(4, 24);
            cadastrocidadetab1.Name = "cadastrocidadetab1";
            cadastrocidadetab1.Size = new Size(703, 361);
            cadastrocidadetab1.TabIndex = 6;
            cadastrocidadetab1.Text = "Nova Cidade";
            cadastrocidadetab1.UseVisualStyleBackColor = true;
            // 
            // cadastrovagatab1
            // 
            cadastrovagatab1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrovagatab1.Location = new Point(4, 24);
            cadastrovagatab1.Name = "cadastrovagatab1";
            cadastrovagatab1.Padding = new Padding(3);
            cadastrovagatab1.Size = new Size(703, 361);
            cadastrovagatab1.TabIndex = 1;
            cadastrovagatab1.Text = "Nova Vaga";
            cadastrovagatab1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(717, 456);
            Controls.Add(VagasTab);
            Controls.Add(recrutadorLabel);
            DrawerTabControl = VagasTab;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormPrincipal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área do Recrutador :";
            Load += FormPrincipal_Load;
            VagasTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label recrutadorLabel;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private ReaLTaiizor.Controls.MaterialTabControl VagasTab;
        private TabPage vagastab1;
        private TabPage iniciotab1;
        private TabPage cadastroempresatab1;
        private TabPage cadastrocandidatotab1;
        private TabPage cadastrocidadetab1;
        private TabPage cadastrovagatab1;
    }
}