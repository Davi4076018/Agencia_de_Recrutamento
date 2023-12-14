namespace Agencia_de_Recrutamento.App.Cadastros
{
    partial class CadastroRecrutador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroRecrutador));
            nomeTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            loginTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            senhaTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            emailTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            idTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // nomeTextbox
            // 
            nomeTextbox.AnimateReadOnly = false;
            nomeTextbox.AutoCompleteMode = AutoCompleteMode.None;
            nomeTextbox.AutoCompleteSource = AutoCompleteSource.None;
            nomeTextbox.BackgroundImageLayout = ImageLayout.None;
            nomeTextbox.CharacterCasing = CharacterCasing.Normal;
            nomeTextbox.Depth = 0;
            nomeTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nomeTextbox.HideSelection = true;
            nomeTextbox.Hint = "Nome";
            nomeTextbox.LeadingIcon = (Image)resources.GetObject("nomeTextbox.LeadingIcon");
            nomeTextbox.Location = new Point(69, 95);
            nomeTextbox.MaxLength = 32767;
            nomeTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            nomeTextbox.Name = "nomeTextbox";
            nomeTextbox.PasswordChar = '\0';
            nomeTextbox.PrefixSuffixText = null;
            nomeTextbox.ReadOnly = false;
            nomeTextbox.RightToLeft = RightToLeft.No;
            nomeTextbox.SelectedText = "";
            nomeTextbox.SelectionLength = 0;
            nomeTextbox.SelectionStart = 0;
            nomeTextbox.ShortcutsEnabled = true;
            nomeTextbox.Size = new Size(250, 48);
            nomeTextbox.TabIndex = 1;
            nomeTextbox.TabStop = false;
            nomeTextbox.TextAlign = HorizontalAlignment.Left;
            nomeTextbox.TrailingIcon = null;
            nomeTextbox.UseSystemPasswordChar = false;
            // 
            // loginTextbox
            // 
            loginTextbox.AnimateReadOnly = false;
            loginTextbox.AutoCompleteMode = AutoCompleteMode.None;
            loginTextbox.AutoCompleteSource = AutoCompleteSource.None;
            loginTextbox.BackgroundImageLayout = ImageLayout.None;
            loginTextbox.CharacterCasing = CharacterCasing.Normal;
            loginTextbox.Depth = 0;
            loginTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginTextbox.HideSelection = true;
            loginTextbox.Hint = "Login";
            loginTextbox.LeadingIcon = Properties.Resources.login_icon;
            loginTextbox.Location = new Point(69, 169);
            loginTextbox.MaxLength = 32767;
            loginTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            loginTextbox.Name = "loginTextbox";
            loginTextbox.PasswordChar = '\0';
            loginTextbox.PrefixSuffixText = null;
            loginTextbox.ReadOnly = false;
            loginTextbox.RightToLeft = RightToLeft.No;
            loginTextbox.SelectedText = "";
            loginTextbox.SelectionLength = 0;
            loginTextbox.SelectionStart = 0;
            loginTextbox.ShortcutsEnabled = true;
            loginTextbox.Size = new Size(250, 48);
            loginTextbox.TabIndex = 2;
            loginTextbox.TabStop = false;
            loginTextbox.TextAlign = HorizontalAlignment.Left;
            loginTextbox.TrailingIcon = null;
            loginTextbox.UseSystemPasswordChar = false;
            // 
            // senhaTextbox
            // 
            senhaTextbox.AnimateReadOnly = false;
            senhaTextbox.AutoCompleteMode = AutoCompleteMode.None;
            senhaTextbox.AutoCompleteSource = AutoCompleteSource.None;
            senhaTextbox.BackgroundImageLayout = ImageLayout.None;
            senhaTextbox.CharacterCasing = CharacterCasing.Normal;
            senhaTextbox.Depth = 0;
            senhaTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            senhaTextbox.HideSelection = true;
            senhaTextbox.Hint = "Senha";
            senhaTextbox.LeadingIcon = Properties.Resources.cadeado_aberto;
            senhaTextbox.Location = new Point(69, 243);
            senhaTextbox.MaxLength = 32767;
            senhaTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            senhaTextbox.Name = "senhaTextbox";
            senhaTextbox.PasswordChar = '*';
            senhaTextbox.PrefixSuffixText = null;
            senhaTextbox.ReadOnly = false;
            senhaTextbox.RightToLeft = RightToLeft.No;
            senhaTextbox.SelectedText = "";
            senhaTextbox.SelectionLength = 0;
            senhaTextbox.SelectionStart = 0;
            senhaTextbox.ShortcutsEnabled = true;
            senhaTextbox.Size = new Size(250, 48);
            senhaTextbox.TabIndex = 3;
            senhaTextbox.TabStop = false;
            senhaTextbox.TextAlign = HorizontalAlignment.Left;
            senhaTextbox.TrailingIcon = null;
            senhaTextbox.UseSystemPasswordChar = false;
            // 
            // emailTextbox
            // 
            emailTextbox.AnimateReadOnly = false;
            emailTextbox.AutoCompleteMode = AutoCompleteMode.None;
            emailTextbox.AutoCompleteSource = AutoCompleteSource.None;
            emailTextbox.BackgroundImageLayout = ImageLayout.None;
            emailTextbox.CharacterCasing = CharacterCasing.Normal;
            emailTextbox.Depth = 0;
            emailTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailTextbox.HideSelection = true;
            emailTextbox.Hint = "Email";
            emailTextbox.LeadingIcon = Properties.Resources.email_icon;
            emailTextbox.Location = new Point(69, 317);
            emailTextbox.MaxLength = 32767;
            emailTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            emailTextbox.Name = "emailTextbox";
            emailTextbox.PasswordChar = '\0';
            emailTextbox.PrefixSuffixText = null;
            emailTextbox.ReadOnly = false;
            emailTextbox.RightToLeft = RightToLeft.No;
            emailTextbox.SelectedText = "";
            emailTextbox.SelectionLength = 0;
            emailTextbox.SelectionStart = 0;
            emailTextbox.ShortcutsEnabled = true;
            emailTextbox.Size = new Size(250, 48);
            emailTextbox.TabIndex = 4;
            emailTextbox.TabStop = false;
            emailTextbox.TextAlign = HorizontalAlignment.Left;
            emailTextbox.TrailingIcon = null;
            emailTextbox.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(213, 391);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(106, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Cadastrar";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.cadastro_recrutador_image2;
            label1.Location = new Point(388, 64);
            label1.Name = "label1";
            label1.Size = new Size(252, 389);
            label1.TabIndex = 0;
            // 
            // idTextbox
            // 
            idTextbox.AnimateReadOnly = false;
            idTextbox.AutoCompleteMode = AutoCompleteMode.None;
            idTextbox.AutoCompleteSource = AutoCompleteSource.None;
            idTextbox.BackgroundImageLayout = ImageLayout.None;
            idTextbox.CharacterCasing = CharacterCasing.Normal;
            idTextbox.Depth = 0;
            idTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idTextbox.HideSelection = true;
            idTextbox.Hint = "ID";
            idTextbox.LeadingIcon = Properties.Resources.id_icon;
            idTextbox.Location = new Point(69, 381);
            idTextbox.MaxLength = 32767;
            idTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            idTextbox.Name = "idTextbox";
            idTextbox.PasswordChar = '\0';
            idTextbox.PrefixSuffixText = null;
            idTextbox.ReadOnly = false;
            idTextbox.RightToLeft = RightToLeft.No;
            idTextbox.SelectedText = "";
            idTextbox.SelectionLength = 0;
            idTextbox.SelectionStart = 0;
            idTextbox.ShortcutsEnabled = true;
            idTextbox.Size = new Size(119, 48);
            idTextbox.TabIndex = 6;
            idTextbox.TabStop = false;
            idTextbox.TextAlign = HorizontalAlignment.Left;
            idTextbox.TrailingIcon = null;
            idTextbox.UseSystemPasswordChar = false;
            // 
            // CadastroRecrutador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(idTextbox);
            Controls.Add(materialButton1);
            Controls.Add(emailTextbox);
            Controls.Add(senhaTextbox);
            Controls.Add(loginTextbox);
            Controls.Add(nomeTextbox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroRecrutador";
            Sizable = false;
            Text = "Cadastro do Recrutador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nomeTextbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit loginTextbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit senhaTextbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit emailTextbox;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit idTextbox;
    }
}