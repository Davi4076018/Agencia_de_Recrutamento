namespace Agencia_de_Recrutamento.App.Cadastros
{
    partial class CadastroVaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVaga));
            TextVagaDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            TextVagaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextVagaSalario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextVagaTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbEmpresaVaga = new ReaLTaiizor.Controls.MaterialComboBox();
            cbCandidatoVaga = new ReaLTaiizor.Controls.MaterialComboBox();
            TextVagaID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbRecrutadorVaga = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // TextVagaDescricao
            // 
            TextVagaDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextVagaDescricao.AnimateReadOnly = false;
            TextVagaDescricao.AutoCompleteMode = AutoCompleteMode.None;
            TextVagaDescricao.AutoCompleteSource = AutoCompleteSource.None;
            TextVagaDescricao.BackgroundImageLayout = ImageLayout.None;
            TextVagaDescricao.CharacterCasing = CharacterCasing.Normal;
            TextVagaDescricao.Depth = 0;
            TextVagaDescricao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextVagaDescricao.HideSelection = true;
            TextVagaDescricao.Hint = "Descrição";
            TextVagaDescricao.LeadingIcon = Properties.Resources.descricao_icon1;
            TextVagaDescricao.Location = new Point(19, 171);
            TextVagaDescricao.MaxLength = 32767;
            TextVagaDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextVagaDescricao.Name = "TextVagaDescricao";
            TextVagaDescricao.PasswordChar = '\0';
            TextVagaDescricao.PrefixSuffixText = null;
            TextVagaDescricao.ReadOnly = false;
            TextVagaDescricao.RightToLeft = RightToLeft.No;
            TextVagaDescricao.SelectedText = "";
            TextVagaDescricao.SelectionLength = 0;
            TextVagaDescricao.SelectionStart = 0;
            TextVagaDescricao.ShortcutsEnabled = true;
            TextVagaDescricao.Size = new Size(569, 48);
            TextVagaDescricao.TabIndex = 36;
            TextVagaDescricao.TabStop = false;
            TextVagaDescricao.TextAlign = HorizontalAlignment.Left;
            TextVagaDescricao.TrailingIcon = null;
            TextVagaDescricao.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(477, 397);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(111, 48);
            materialButton2.TabIndex = 34;
            materialButton2.Text = "Salvar";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += ButtonVagaSalvar_Click;
            // 
            // TextVagaFormacao
            // 
            TextVagaFormacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextVagaFormacao.AnimateReadOnly = false;
            TextVagaFormacao.AutoCompleteMode = AutoCompleteMode.None;
            TextVagaFormacao.AutoCompleteSource = AutoCompleteSource.None;
            TextVagaFormacao.BackgroundImageLayout = ImageLayout.None;
            TextVagaFormacao.CharacterCasing = CharacterCasing.Normal;
            TextVagaFormacao.Depth = 0;
            TextVagaFormacao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextVagaFormacao.HideSelection = true;
            TextVagaFormacao.Hint = "Formação";
            TextVagaFormacao.LeadingIcon = Properties.Resources.formacao_icon;
            TextVagaFormacao.Location = new Point(19, 397);
            TextVagaFormacao.MaxLength = 32767;
            TextVagaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextVagaFormacao.Name = "TextVagaFormacao";
            TextVagaFormacao.PasswordChar = '\0';
            TextVagaFormacao.PrefixSuffixText = null;
            TextVagaFormacao.ReadOnly = false;
            TextVagaFormacao.RightToLeft = RightToLeft.No;
            TextVagaFormacao.SelectedText = "";
            TextVagaFormacao.SelectionLength = 0;
            TextVagaFormacao.SelectionStart = 0;
            TextVagaFormacao.ShortcutsEnabled = true;
            TextVagaFormacao.Size = new Size(429, 48);
            TextVagaFormacao.TabIndex = 32;
            TextVagaFormacao.TabStop = false;
            TextVagaFormacao.TextAlign = HorizontalAlignment.Left;
            TextVagaFormacao.TrailingIcon = null;
            TextVagaFormacao.UseSystemPasswordChar = false;
            // 
            // TextVagaSalario
            // 
            TextVagaSalario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextVagaSalario.AnimateReadOnly = false;
            TextVagaSalario.AutoCompleteMode = AutoCompleteMode.None;
            TextVagaSalario.AutoCompleteSource = AutoCompleteSource.None;
            TextVagaSalario.BackgroundImageLayout = ImageLayout.None;
            TextVagaSalario.CharacterCasing = CharacterCasing.Normal;
            TextVagaSalario.Depth = 0;
            TextVagaSalario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextVagaSalario.HideSelection = true;
            TextVagaSalario.Hint = "Salario";
            TextVagaSalario.LeadingIcon = (Image)resources.GetObject("TextVagaSalario.LeadingIcon");
            TextVagaSalario.Location = new Point(355, 92);
            TextVagaSalario.MaxLength = 32767;
            TextVagaSalario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextVagaSalario.Name = "TextVagaSalario";
            TextVagaSalario.PasswordChar = '\0';
            TextVagaSalario.PrefixSuffixText = null;
            TextVagaSalario.ReadOnly = false;
            TextVagaSalario.RightToLeft = RightToLeft.No;
            TextVagaSalario.SelectedText = "";
            TextVagaSalario.SelectionLength = 0;
            TextVagaSalario.SelectionStart = 0;
            TextVagaSalario.ShortcutsEnabled = true;
            TextVagaSalario.Size = new Size(233, 48);
            TextVagaSalario.TabIndex = 33;
            TextVagaSalario.TabStop = false;
            TextVagaSalario.TextAlign = HorizontalAlignment.Left;
            TextVagaSalario.TrailingIcon = null;
            TextVagaSalario.UseSystemPasswordChar = false;
            // 
            // TextVagaTitulo
            // 
            TextVagaTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextVagaTitulo.AnimateReadOnly = false;
            TextVagaTitulo.AutoCompleteMode = AutoCompleteMode.None;
            TextVagaTitulo.AutoCompleteSource = AutoCompleteSource.None;
            TextVagaTitulo.BackgroundImageLayout = ImageLayout.None;
            TextVagaTitulo.CharacterCasing = CharacterCasing.Normal;
            TextVagaTitulo.Depth = 0;
            TextVagaTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextVagaTitulo.HideSelection = true;
            TextVagaTitulo.Hint = "Titulo";
            TextVagaTitulo.LeadingIcon = Properties.Resources.titulo_icon;
            TextVagaTitulo.Location = new Point(19, 92);
            TextVagaTitulo.MaxLength = 32767;
            TextVagaTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextVagaTitulo.Name = "TextVagaTitulo";
            TextVagaTitulo.PasswordChar = '\0';
            TextVagaTitulo.PrefixSuffixText = null;
            TextVagaTitulo.ReadOnly = false;
            TextVagaTitulo.RightToLeft = RightToLeft.No;
            TextVagaTitulo.SelectedText = "";
            TextVagaTitulo.SelectionLength = 0;
            TextVagaTitulo.SelectionStart = 0;
            TextVagaTitulo.ShortcutsEnabled = true;
            TextVagaTitulo.Size = new Size(310, 48);
            TextVagaTitulo.TabIndex = 31;
            TextVagaTitulo.TabStop = false;
            TextVagaTitulo.TextAlign = HorizontalAlignment.Left;
            TextVagaTitulo.TrailingIcon = null;
            TextVagaTitulo.UseSystemPasswordChar = false;
            // 
            // cbEmpresaVaga
            // 
            cbEmpresaVaga.AutoResize = false;
            cbEmpresaVaga.BackColor = Color.FromArgb(255, 255, 255);
            cbEmpresaVaga.Depth = 0;
            cbEmpresaVaga.DrawMode = DrawMode.OwnerDrawVariable;
            cbEmpresaVaga.DropDownHeight = 174;
            cbEmpresaVaga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpresaVaga.DropDownWidth = 121;
            cbEmpresaVaga.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEmpresaVaga.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEmpresaVaga.FormattingEnabled = true;
            cbEmpresaVaga.Hint = "Empresa";
            cbEmpresaVaga.IntegralHeight = false;
            cbEmpresaVaga.ItemHeight = 43;
            cbEmpresaVaga.Location = new Point(19, 248);
            cbEmpresaVaga.MaxDropDownItems = 4;
            cbEmpresaVaga.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEmpresaVaga.Name = "cbEmpresaVaga";
            cbEmpresaVaga.Size = new Size(301, 49);
            cbEmpresaVaga.StartIndex = 0;
            cbEmpresaVaga.TabIndex = 39;
            // 
            // cbCandidatoVaga
            // 
            cbCandidatoVaga.AutoResize = false;
            cbCandidatoVaga.BackColor = Color.FromArgb(255, 255, 255);
            cbCandidatoVaga.Depth = 0;
            cbCandidatoVaga.DrawMode = DrawMode.OwnerDrawVariable;
            cbCandidatoVaga.DropDownHeight = 174;
            cbCandidatoVaga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCandidatoVaga.DropDownWidth = 121;
            cbCandidatoVaga.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCandidatoVaga.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCandidatoVaga.FormattingEnabled = true;
            cbCandidatoVaga.Hint = "Candidato";
            cbCandidatoVaga.IntegralHeight = false;
            cbCandidatoVaga.ItemHeight = 43;
            cbCandidatoVaga.Location = new Point(339, 247);
            cbCandidatoVaga.MaxDropDownItems = 4;
            cbCandidatoVaga.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCandidatoVaga.Name = "cbCandidatoVaga";
            cbCandidatoVaga.Size = new Size(249, 49);
            cbCandidatoVaga.StartIndex = 0;
            cbCandidatoVaga.TabIndex = 40;
            // 
            // TextVagaID
            // 
            TextVagaID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextVagaID.AnimateReadOnly = false;
            TextVagaID.AutoCompleteMode = AutoCompleteMode.None;
            TextVagaID.AutoCompleteSource = AutoCompleteSource.None;
            TextVagaID.BackgroundImageLayout = ImageLayout.None;
            TextVagaID.CharacterCasing = CharacterCasing.Normal;
            TextVagaID.Depth = 0;
            TextVagaID.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextVagaID.HideSelection = true;
            TextVagaID.Hint = "ID";
            TextVagaID.LeadingIcon = Properties.Resources.id_novo_icon;
            TextVagaID.Location = new Point(477, 325);
            TextVagaID.MaxLength = 32767;
            TextVagaID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextVagaID.Name = "TextVagaID";
            TextVagaID.PasswordChar = '\0';
            TextVagaID.PrefixSuffixText = null;
            TextVagaID.ReadOnly = false;
            TextVagaID.RightToLeft = RightToLeft.No;
            TextVagaID.SelectedText = "";
            TextVagaID.SelectionLength = 0;
            TextVagaID.SelectionStart = 0;
            TextVagaID.ShortcutsEnabled = true;
            TextVagaID.Size = new Size(111, 48);
            TextVagaID.TabIndex = 41;
            TextVagaID.TabStop = false;
            TextVagaID.TextAlign = HorizontalAlignment.Left;
            TextVagaID.TrailingIcon = null;
            TextVagaID.UseSystemPasswordChar = false;
            // 
            // cbRecrutadorVaga
            // 
            cbRecrutadorVaga.AutoResize = false;
            cbRecrutadorVaga.BackColor = Color.FromArgb(255, 255, 255);
            cbRecrutadorVaga.Depth = 0;
            cbRecrutadorVaga.DrawMode = DrawMode.OwnerDrawVariable;
            cbRecrutadorVaga.DropDownHeight = 174;
            cbRecrutadorVaga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRecrutadorVaga.DropDownWidth = 121;
            cbRecrutadorVaga.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbRecrutadorVaga.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbRecrutadorVaga.FormattingEnabled = true;
            cbRecrutadorVaga.Hint = "Recrutador";
            cbRecrutadorVaga.IntegralHeight = false;
            cbRecrutadorVaga.ItemHeight = 43;
            cbRecrutadorVaga.Location = new Point(19, 325);
            cbRecrutadorVaga.MaxDropDownItems = 4;
            cbRecrutadorVaga.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbRecrutadorVaga.Name = "cbRecrutadorVaga";
            cbRecrutadorVaga.Size = new Size(429, 49);
            cbRecrutadorVaga.StartIndex = 0;
            cbRecrutadorVaga.TabIndex = 42;
            // 
            // CadastroVaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 475);
            Controls.Add(cbRecrutadorVaga);
            Controls.Add(TextVagaID);
            Controls.Add(cbCandidatoVaga);
            Controls.Add(cbEmpresaVaga);
            Controls.Add(TextVagaDescricao);
            Controls.Add(materialButton2);
            Controls.Add(TextVagaFormacao);
            Controls.Add(TextVagaSalario);
            Controls.Add(TextVagaTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroVaga";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Vaga";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextVagaDescricao;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextVagaFormacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextVagaSalario;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextVagaTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ReaLTaiizor.Controls.MaterialComboBox cbEmpresaVaga;
        private ReaLTaiizor.Controls.MaterialComboBox cbCandidatoVaga;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextVagaID;
        private ReaLTaiizor.Controls.MaterialComboBox cbRecrutadorVaga;
    }
}