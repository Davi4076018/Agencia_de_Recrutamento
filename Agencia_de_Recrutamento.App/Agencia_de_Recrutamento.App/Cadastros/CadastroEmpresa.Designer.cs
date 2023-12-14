namespace Agencia_de_Recrutamento.App.Cadastros
{
    partial class CadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            ButtonSalvarEmpresa = new ReaLTaiizor.Controls.MaterialButton();
            TextEmpresaCNPJ = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEmpresaEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEmpresaBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEmpresaNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbCidadeEmpresa = new ReaLTaiizor.Controls.MaterialComboBox();
            TextEmpresaID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // ButtonSalvarEmpresa
            // 
            ButtonSalvarEmpresa.AutoSize = false;
            ButtonSalvarEmpresa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvarEmpresa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvarEmpresa.Depth = 0;
            ButtonSalvarEmpresa.HighEmphasis = true;
            ButtonSalvarEmpresa.Icon = null;
            ButtonSalvarEmpresa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvarEmpresa.Location = new Point(487, 275);
            ButtonSalvarEmpresa.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvarEmpresa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvarEmpresa.Name = "ButtonSalvarEmpresa";
            ButtonSalvarEmpresa.NoAccentTextColor = Color.Empty;
            ButtonSalvarEmpresa.Size = new Size(111, 48);
            ButtonSalvarEmpresa.TabIndex = 26;
            ButtonSalvarEmpresa.Text = "Salvar";
            ButtonSalvarEmpresa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvarEmpresa.UseAccentColor = false;
            ButtonSalvarEmpresa.UseVisualStyleBackColor = true;
            ButtonSalvarEmpresa.Click += ButtonEmpresaSalvar_Click;
            // 
            // TextEmpresaCNPJ
            // 
            TextEmpresaCNPJ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextEmpresaCNPJ.AnimateReadOnly = false;
            TextEmpresaCNPJ.AutoCompleteMode = AutoCompleteMode.None;
            TextEmpresaCNPJ.AutoCompleteSource = AutoCompleteSource.None;
            TextEmpresaCNPJ.BackgroundImageLayout = ImageLayout.None;
            TextEmpresaCNPJ.CharacterCasing = CharacterCasing.Normal;
            TextEmpresaCNPJ.Depth = 0;
            TextEmpresaCNPJ.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEmpresaCNPJ.HideSelection = true;
            TextEmpresaCNPJ.Hint = "CNPJ";
            TextEmpresaCNPJ.LeadingIcon = Properties.Resources.id_icon;
            TextEmpresaCNPJ.Location = new Point(352, 104);
            TextEmpresaCNPJ.MaxLength = 32767;
            TextEmpresaCNPJ.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEmpresaCNPJ.Name = "TextEmpresaCNPJ";
            TextEmpresaCNPJ.PasswordChar = '\0';
            TextEmpresaCNPJ.PrefixSuffixText = null;
            TextEmpresaCNPJ.ReadOnly = false;
            TextEmpresaCNPJ.RightToLeft = RightToLeft.No;
            TextEmpresaCNPJ.SelectedText = "";
            TextEmpresaCNPJ.SelectionLength = 0;
            TextEmpresaCNPJ.SelectionStart = 0;
            TextEmpresaCNPJ.ShortcutsEnabled = true;
            TextEmpresaCNPJ.Size = new Size(246, 48);
            TextEmpresaCNPJ.TabIndex = 25;
            TextEmpresaCNPJ.TabStop = false;
            TextEmpresaCNPJ.TextAlign = HorizontalAlignment.Left;
            TextEmpresaCNPJ.TrailingIcon = null;
            TextEmpresaCNPJ.UseSystemPasswordChar = false;
            // 
            // TextEmpresaEndereco
            // 
            TextEmpresaEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextEmpresaEndereco.AnimateReadOnly = false;
            TextEmpresaEndereco.AutoCompleteMode = AutoCompleteMode.None;
            TextEmpresaEndereco.AutoCompleteSource = AutoCompleteSource.None;
            TextEmpresaEndereco.BackgroundImageLayout = ImageLayout.None;
            TextEmpresaEndereco.CharacterCasing = CharacterCasing.Normal;
            TextEmpresaEndereco.Depth = 0;
            TextEmpresaEndereco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEmpresaEndereco.HideSelection = true;
            TextEmpresaEndereco.Hint = "Endereço";
            TextEmpresaEndereco.LeadingIcon = Properties.Resources.endereco_icon;
            TextEmpresaEndereco.Location = new Point(29, 273);
            TextEmpresaEndereco.MaxLength = 32767;
            TextEmpresaEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEmpresaEndereco.Name = "TextEmpresaEndereco";
            TextEmpresaEndereco.PasswordChar = '\0';
            TextEmpresaEndereco.PrefixSuffixText = null;
            TextEmpresaEndereco.ReadOnly = false;
            TextEmpresaEndereco.RightToLeft = RightToLeft.No;
            TextEmpresaEndereco.SelectedText = "";
            TextEmpresaEndereco.SelectionLength = 0;
            TextEmpresaEndereco.SelectionStart = 0;
            TextEmpresaEndereco.ShortcutsEnabled = true;
            TextEmpresaEndereco.Size = new Size(301, 48);
            TextEmpresaEndereco.TabIndex = 24;
            TextEmpresaEndereco.TabStop = false;
            TextEmpresaEndereco.TextAlign = HorizontalAlignment.Left;
            TextEmpresaEndereco.TrailingIcon = null;
            TextEmpresaEndereco.UseSystemPasswordChar = false;
            // 
            // TextEmpresaBairro
            // 
            TextEmpresaBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextEmpresaBairro.AnimateReadOnly = false;
            TextEmpresaBairro.AutoCompleteMode = AutoCompleteMode.None;
            TextEmpresaBairro.AutoCompleteSource = AutoCompleteSource.None;
            TextEmpresaBairro.BackgroundImageLayout = ImageLayout.None;
            TextEmpresaBairro.CharacterCasing = CharacterCasing.Normal;
            TextEmpresaBairro.Depth = 0;
            TextEmpresaBairro.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEmpresaBairro.HideSelection = true;
            TextEmpresaBairro.Hint = "Bairro";
            TextEmpresaBairro.LeadingIcon = Properties.Resources.bairro_icon;
            TextEmpresaBairro.Location = new Point(352, 188);
            TextEmpresaBairro.MaxLength = 32767;
            TextEmpresaBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEmpresaBairro.Name = "TextEmpresaBairro";
            TextEmpresaBairro.PasswordChar = '\0';
            TextEmpresaBairro.PrefixSuffixText = null;
            TextEmpresaBairro.ReadOnly = false;
            TextEmpresaBairro.RightToLeft = RightToLeft.No;
            TextEmpresaBairro.SelectedText = "";
            TextEmpresaBairro.SelectionLength = 0;
            TextEmpresaBairro.SelectionStart = 0;
            TextEmpresaBairro.ShortcutsEnabled = true;
            TextEmpresaBairro.Size = new Size(246, 48);
            TextEmpresaBairro.TabIndex = 23;
            TextEmpresaBairro.TabStop = false;
            TextEmpresaBairro.TextAlign = HorizontalAlignment.Left;
            TextEmpresaBairro.TrailingIcon = null;
            TextEmpresaBairro.UseSystemPasswordChar = false;
            // 
            // TextEmpresaNome
            // 
            TextEmpresaNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextEmpresaNome.AnimateReadOnly = false;
            TextEmpresaNome.AutoCompleteMode = AutoCompleteMode.None;
            TextEmpresaNome.AutoCompleteSource = AutoCompleteSource.None;
            TextEmpresaNome.BackgroundImageLayout = ImageLayout.None;
            TextEmpresaNome.CharacterCasing = CharacterCasing.Normal;
            TextEmpresaNome.Depth = 0;
            TextEmpresaNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEmpresaNome.HideSelection = true;
            TextEmpresaNome.Hint = "Nome";
            TextEmpresaNome.LeadingIcon = Properties.Resources.name_icon;
            TextEmpresaNome.Location = new Point(29, 104);
            TextEmpresaNome.MaxLength = 32767;
            TextEmpresaNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEmpresaNome.Name = "TextEmpresaNome";
            TextEmpresaNome.PasswordChar = '\0';
            TextEmpresaNome.PrefixSuffixText = null;
            TextEmpresaNome.ReadOnly = false;
            TextEmpresaNome.RightToLeft = RightToLeft.No;
            TextEmpresaNome.SelectedText = "";
            TextEmpresaNome.SelectionLength = 0;
            TextEmpresaNome.SelectionStart = 0;
            TextEmpresaNome.ShortcutsEnabled = true;
            TextEmpresaNome.Size = new Size(301, 48);
            TextEmpresaNome.TabIndex = 20;
            TextEmpresaNome.TabStop = false;
            TextEmpresaNome.TextAlign = HorizontalAlignment.Left;
            TextEmpresaNome.TrailingIcon = null;
            TextEmpresaNome.UseSystemPasswordChar = false;
            // 
            // cbCidadeEmpresa
            // 
            cbCidadeEmpresa.AutoResize = false;
            cbCidadeEmpresa.BackColor = Color.FromArgb(255, 255, 255);
            cbCidadeEmpresa.Depth = 0;
            cbCidadeEmpresa.DrawMode = DrawMode.OwnerDrawVariable;
            cbCidadeEmpresa.DropDownHeight = 174;
            cbCidadeEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidadeEmpresa.DropDownWidth = 121;
            cbCidadeEmpresa.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCidadeEmpresa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCidadeEmpresa.FormattingEnabled = true;
            cbCidadeEmpresa.Hint = "Cidade";
            cbCidadeEmpresa.IntegralHeight = false;
            cbCidadeEmpresa.ItemHeight = 43;
            cbCidadeEmpresa.Location = new Point(29, 187);
            cbCidadeEmpresa.MaxDropDownItems = 4;
            cbCidadeEmpresa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbCidadeEmpresa.Name = "cbCidadeEmpresa";
            cbCidadeEmpresa.Size = new Size(301, 49);
            cbCidadeEmpresa.StartIndex = 0;
            cbCidadeEmpresa.TabIndex = 28;
            // 
            // TextEmpresaID
            // 
            TextEmpresaID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextEmpresaID.AnimateReadOnly = false;
            TextEmpresaID.AutoCompleteMode = AutoCompleteMode.None;
            TextEmpresaID.AutoCompleteSource = AutoCompleteSource.None;
            TextEmpresaID.BackgroundImageLayout = ImageLayout.None;
            TextEmpresaID.CharacterCasing = CharacterCasing.Normal;
            TextEmpresaID.Depth = 0;
            TextEmpresaID.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEmpresaID.HideSelection = true;
            TextEmpresaID.Hint = "ID";
            TextEmpresaID.LeadingIcon = Properties.Resources.id_novo_icon;
            TextEmpresaID.Location = new Point(352, 273);
            TextEmpresaID.MaxLength = 32767;
            TextEmpresaID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEmpresaID.Name = "TextEmpresaID";
            TextEmpresaID.PasswordChar = '\0';
            TextEmpresaID.PrefixSuffixText = null;
            TextEmpresaID.ReadOnly = false;
            TextEmpresaID.RightToLeft = RightToLeft.No;
            TextEmpresaID.SelectedText = "";
            TextEmpresaID.SelectionLength = 0;
            TextEmpresaID.SelectionStart = 0;
            TextEmpresaID.ShortcutsEnabled = true;
            TextEmpresaID.Size = new Size(111, 48);
            TextEmpresaID.TabIndex = 29;
            TextEmpresaID.TabStop = false;
            TextEmpresaID.TextAlign = HorizontalAlignment.Left;
            TextEmpresaID.TrailingIcon = null;
            TextEmpresaID.UseSystemPasswordChar = false;
            // 
            // CadastroEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 369);
            Controls.Add(TextEmpresaID);
            Controls.Add(cbCidadeEmpresa);
            Controls.Add(ButtonSalvarEmpresa);
            Controls.Add(TextEmpresaCNPJ);
            Controls.Add(TextEmpresaEndereco);
            Controls.Add(TextEmpresaBairro);
            Controls.Add(TextEmpresaNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroEmpresa";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Empresa";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvarEmpresa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEmpresaCNPJ;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEmpresaEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEmpresaBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEmpresaNome;
        private ReaLTaiizor.Controls.MaterialComboBox cbCidadeEmpresa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEmpresaID;
    }
}