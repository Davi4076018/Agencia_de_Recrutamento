namespace Agencia_de_Recrutamento.App.Cadastros
{
    partial class CadastroCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCandidato));
            TextCandidatoID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ButtonSalvarCandidato = new ReaLTaiizor.Controls.MaterialButton();
            TextCandidatoFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCandidatoCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCandidatoEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCandidatoBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCandidatoEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCandidatoNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbCidadeCandidato = new ReaLTaiizor.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // TextCandidatoID
            // 
            resources.ApplyResources(TextCandidatoID, "TextCandidatoID");
            TextCandidatoID.AnimateReadOnly = false;
            TextCandidatoID.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoID.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoID.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoID.Depth = 0;
            TextCandidatoID.HideSelection = true;
            TextCandidatoID.LeadingIcon = Properties.Resources.id_novo_icon;
            TextCandidatoID.MaxLength = 32767;
            TextCandidatoID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoID.Name = "TextCandidatoID";
            TextCandidatoID.PasswordChar = '\0';
            TextCandidatoID.ReadOnly = false;
            TextCandidatoID.SelectedText = "";
            TextCandidatoID.SelectionLength = 0;
            TextCandidatoID.SelectionStart = 0;
            TextCandidatoID.ShortcutsEnabled = true;
            TextCandidatoID.TabStop = false;
            TextCandidatoID.TextAlign = HorizontalAlignment.Right;
            TextCandidatoID.TrailingIcon = null;
            TextCandidatoID.UseSystemPasswordChar = false;
            // 
            // ButtonSalvarCandidato
            // 
            resources.ApplyResources(ButtonSalvarCandidato, "ButtonSalvarCandidato");
            ButtonSalvarCandidato.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvarCandidato.Depth = 0;
            ButtonSalvarCandidato.HighEmphasis = true;
            ButtonSalvarCandidato.Icon = null;
            ButtonSalvarCandidato.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvarCandidato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvarCandidato.Name = "ButtonSalvarCandidato";
            ButtonSalvarCandidato.NoAccentTextColor = Color.Empty;
            ButtonSalvarCandidato.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvarCandidato.UseAccentColor = false;
            ButtonSalvarCandidato.UseVisualStyleBackColor = true;
            ButtonSalvarCandidato.Click += ButtonCandidatoSalvar_Click;
            // 
            // TextCandidatoFormacao
            // 
            resources.ApplyResources(TextCandidatoFormacao, "TextCandidatoFormacao");
            TextCandidatoFormacao.AnimateReadOnly = false;
            TextCandidatoFormacao.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoFormacao.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoFormacao.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoFormacao.Depth = 0;
            TextCandidatoFormacao.HideSelection = true;
            TextCandidatoFormacao.LeadingIcon = Properties.Resources.formacao_icon;
            TextCandidatoFormacao.MaxLength = 32767;
            TextCandidatoFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoFormacao.Name = "TextCandidatoFormacao";
            TextCandidatoFormacao.PasswordChar = '\0';
            TextCandidatoFormacao.ReadOnly = false;
            TextCandidatoFormacao.SelectedText = "";
            TextCandidatoFormacao.SelectionLength = 0;
            TextCandidatoFormacao.SelectionStart = 0;
            TextCandidatoFormacao.ShortcutsEnabled = true;
            TextCandidatoFormacao.TabStop = false;
            TextCandidatoFormacao.TextAlign = HorizontalAlignment.Right;
            TextCandidatoFormacao.TrailingIcon = null;
            TextCandidatoFormacao.UseSystemPasswordChar = false;
            // 
            // TextCandidatoCPF
            // 
            resources.ApplyResources(TextCandidatoCPF, "TextCandidatoCPF");
            TextCandidatoCPF.AnimateReadOnly = false;
            TextCandidatoCPF.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoCPF.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoCPF.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoCPF.Depth = 0;
            TextCandidatoCPF.HideSelection = true;
            TextCandidatoCPF.LeadingIcon = Properties.Resources.id_icon;
            TextCandidatoCPF.MaxLength = 32767;
            TextCandidatoCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoCPF.Name = "TextCandidatoCPF";
            TextCandidatoCPF.PasswordChar = '\0';
            TextCandidatoCPF.ReadOnly = false;
            TextCandidatoCPF.SelectedText = "";
            TextCandidatoCPF.SelectionLength = 0;
            TextCandidatoCPF.SelectionStart = 0;
            TextCandidatoCPF.ShortcutsEnabled = true;
            TextCandidatoCPF.TabStop = false;
            TextCandidatoCPF.TextAlign = HorizontalAlignment.Right;
            TextCandidatoCPF.TrailingIcon = null;
            TextCandidatoCPF.UseSystemPasswordChar = false;
            // 
            // TextCandidatoEndereco
            // 
            resources.ApplyResources(TextCandidatoEndereco, "TextCandidatoEndereco");
            TextCandidatoEndereco.AnimateReadOnly = false;
            TextCandidatoEndereco.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoEndereco.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoEndereco.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoEndereco.Depth = 0;
            TextCandidatoEndereco.HideSelection = true;
            TextCandidatoEndereco.LeadingIcon = Properties.Resources.endereco_icon;
            TextCandidatoEndereco.MaxLength = 32767;
            TextCandidatoEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoEndereco.Name = "TextCandidatoEndereco";
            TextCandidatoEndereco.PasswordChar = '\0';
            TextCandidatoEndereco.ReadOnly = false;
            TextCandidatoEndereco.SelectedText = "";
            TextCandidatoEndereco.SelectionLength = 0;
            TextCandidatoEndereco.SelectionStart = 0;
            TextCandidatoEndereco.ShortcutsEnabled = true;
            TextCandidatoEndereco.TabStop = false;
            TextCandidatoEndereco.TextAlign = HorizontalAlignment.Right;
            TextCandidatoEndereco.TrailingIcon = null;
            TextCandidatoEndereco.UseSystemPasswordChar = false;
            // 
            // TextCandidatoBairro
            // 
            resources.ApplyResources(TextCandidatoBairro, "TextCandidatoBairro");
            TextCandidatoBairro.AnimateReadOnly = false;
            TextCandidatoBairro.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoBairro.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoBairro.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoBairro.Depth = 0;
            TextCandidatoBairro.HideSelection = true;
            TextCandidatoBairro.LeadingIcon = Properties.Resources.bairro_icon;
            TextCandidatoBairro.MaxLength = 32767;
            TextCandidatoBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoBairro.Name = "TextCandidatoBairro";
            TextCandidatoBairro.PasswordChar = '\0';
            TextCandidatoBairro.ReadOnly = false;
            TextCandidatoBairro.SelectedText = "";
            TextCandidatoBairro.SelectionLength = 0;
            TextCandidatoBairro.SelectionStart = 0;
            TextCandidatoBairro.ShortcutsEnabled = true;
            TextCandidatoBairro.TabStop = false;
            TextCandidatoBairro.TextAlign = HorizontalAlignment.Right;
            TextCandidatoBairro.TrailingIcon = null;
            TextCandidatoBairro.UseSystemPasswordChar = false;
            // 
            // TextCandidatoEmail
            // 
            resources.ApplyResources(TextCandidatoEmail, "TextCandidatoEmail");
            TextCandidatoEmail.AnimateReadOnly = false;
            TextCandidatoEmail.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoEmail.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoEmail.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoEmail.Depth = 0;
            TextCandidatoEmail.HideSelection = true;
            TextCandidatoEmail.LeadingIcon = Properties.Resources.email_icon;
            TextCandidatoEmail.MaxLength = 32767;
            TextCandidatoEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoEmail.Name = "TextCandidatoEmail";
            TextCandidatoEmail.PasswordChar = '\0';
            TextCandidatoEmail.ReadOnly = false;
            TextCandidatoEmail.SelectedText = "";
            TextCandidatoEmail.SelectionLength = 0;
            TextCandidatoEmail.SelectionStart = 0;
            TextCandidatoEmail.ShortcutsEnabled = true;
            TextCandidatoEmail.TabStop = false;
            TextCandidatoEmail.TextAlign = HorizontalAlignment.Right;
            TextCandidatoEmail.TrailingIcon = null;
            TextCandidatoEmail.UseSystemPasswordChar = false;
            // 
            // TextCandidatoNome
            // 
            resources.ApplyResources(TextCandidatoNome, "TextCandidatoNome");
            TextCandidatoNome.AnimateReadOnly = false;
            TextCandidatoNome.AutoCompleteMode = AutoCompleteMode.None;
            TextCandidatoNome.AutoCompleteSource = AutoCompleteSource.None;
            TextCandidatoNome.CharacterCasing = CharacterCasing.Normal;
            TextCandidatoNome.Depth = 0;
            TextCandidatoNome.HideSelection = true;
            TextCandidatoNome.LeadingIcon = Properties.Resources.name_icon;
            TextCandidatoNome.MaxLength = 32767;
            TextCandidatoNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCandidatoNome.Name = "TextCandidatoNome";
            TextCandidatoNome.PasswordChar = '\0';
            TextCandidatoNome.ReadOnly = false;
            TextCandidatoNome.SelectedText = "";
            TextCandidatoNome.SelectionLength = 0;
            TextCandidatoNome.SelectionStart = 0;
            TextCandidatoNome.ShortcutsEnabled = true;
            TextCandidatoNome.TabStop = false;
            TextCandidatoNome.TextAlign = HorizontalAlignment.Right;
            TextCandidatoNome.TrailingIcon = null;
            TextCandidatoNome.UseSystemPasswordChar = false;
            // 
            // cbCidadeCandidato
            // 
            cbCidadeCandidato.AutoResize = false;
            cbCidadeCandidato.BackColor = Color.FromArgb(255, 255, 255);
            cbCidadeCandidato.Depth = 0;
            cbCidadeCandidato.DrawMode = DrawMode.OwnerDrawVariable;
            cbCidadeCandidato.DropDownHeight = 174;
            cbCidadeCandidato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidadeCandidato.DropDownWidth = 121;
            resources.ApplyResources(cbCidadeCandidato, "cbCidadeCandidato");
            cbCidadeCandidato.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCidadeCandidato.FormattingEnabled = true;
            cbCidadeCandidato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCidadeCandidato.Name = "cbCidadeCandidato";
            cbCidadeCandidato.StartIndex = 0;
            // 
            // CadastroCandidato
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbCidadeCandidato);
            Controls.Add(TextCandidatoID);
            Controls.Add(ButtonSalvarCandidato);
            Controls.Add(TextCandidatoFormacao);
            Controls.Add(TextCandidatoCPF);
            Controls.Add(TextCandidatoEndereco);
            Controls.Add(TextCandidatoBairro);
            Controls.Add(TextCandidatoEmail);
            Controls.Add(TextCandidatoNome);
            MaximizeBox = false;
            Name = "CadastroCandidato";
            Sizable = false;
            Load += CadastroCandidato_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoID;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvarCandidato;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoFormacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCandidatoNome;
        private ReaLTaiizor.Controls.MaterialComboBox cbCidadeCandidato;
    }
}