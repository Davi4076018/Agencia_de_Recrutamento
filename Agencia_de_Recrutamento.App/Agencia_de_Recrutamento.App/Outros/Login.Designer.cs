namespace Agencia_de_Recrutamento.App.Outros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            LoginText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            senhaText = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            entrarButton = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            Logo_Image = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Image = Properties.Resources.download;
            materialLabel1.Location = new Point(245, 144);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1, 0);
            materialLabel1.TabIndex = 0;
            // 
            // LoginText
            // 
            LoginText.AnimateReadOnly = false;
            LoginText.AutoCompleteMode = AutoCompleteMode.None;
            LoginText.AutoCompleteSource = AutoCompleteSource.None;
            LoginText.BackgroundImageLayout = ImageLayout.None;
            LoginText.CharacterCasing = CharacterCasing.Normal;
            LoginText.Depth = 0;
            LoginText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginText.HideSelection = true;
            LoginText.Hint = "Login";
            LoginText.LeadingIcon = Properties.Resources.login_icon;
            LoginText.Location = new Point(96, 214);
            LoginText.MaxLength = 32767;
            LoginText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            LoginText.Name = "LoginText";
            LoginText.PasswordChar = '\0';
            LoginText.PrefixSuffixText = null;
            LoginText.ReadOnly = false;
            LoginText.RightToLeft = RightToLeft.No;
            LoginText.SelectedText = "";
            LoginText.SelectionLength = 0;
            LoginText.SelectionStart = 0;
            LoginText.ShortcutsEnabled = true;
            LoginText.Size = new Size(250, 48);
            LoginText.TabIndex = 1;
            LoginText.TabStop = false;
            LoginText.TextAlign = HorizontalAlignment.Left;
            LoginText.TrailingIcon = null;
            LoginText.UseSystemPasswordChar = false;
            // 
            // senhaText
            // 
            senhaText.AnimateReadOnly = false;
            senhaText.AutoCompleteMode = AutoCompleteMode.None;
            senhaText.AutoCompleteSource = AutoCompleteSource.None;
            senhaText.BackgroundImageLayout = ImageLayout.None;
            senhaText.CharacterCasing = CharacterCasing.Normal;
            senhaText.Depth = 0;
            senhaText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            senhaText.HideSelection = true;
            senhaText.Hint = "Senha";
            senhaText.LeadingIcon = Properties.Resources.cadeado_aberto2;
            senhaText.Location = new Point(96, 284);
            senhaText.MaxLength = 32767;
            senhaText.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            senhaText.Name = "senhaText";
            senhaText.PasswordChar = '*';
            senhaText.PrefixSuffixText = null;
            senhaText.ReadOnly = false;
            senhaText.RightToLeft = RightToLeft.No;
            senhaText.SelectedText = "";
            senhaText.SelectionLength = 0;
            senhaText.SelectionStart = 0;
            senhaText.ShortcutsEnabled = true;
            senhaText.Size = new Size(250, 48);
            senhaText.TabIndex = 2;
            senhaText.TabStop = false;
            senhaText.TextAlign = HorizontalAlignment.Left;
            senhaText.TrailingIcon = null;
            senhaText.UseSystemPasswordChar = false;
            // 
            // entrarButton
            // 
            entrarButton.AutoSize = false;
            entrarButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            entrarButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            entrarButton.Depth = 0;
            entrarButton.HighEmphasis = true;
            entrarButton.Icon = null;
            entrarButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            entrarButton.Location = new Point(159, 355);
            entrarButton.Margin = new Padding(4, 6, 4, 6);
            entrarButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            entrarButton.Name = "entrarButton";
            entrarButton.NoAccentTextColor = Color.Empty;
            entrarButton.Size = new Size(113, 36);
            entrarButton.TabIndex = 3;
            entrarButton.Text = "Entrar";
            entrarButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            entrarButton.UseAccentColor = false;
            entrarButton.UseVisualStyleBackColor = true;
            entrarButton.Click += entrarButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Image = Properties.Resources.download;
            materialLabel2.Location = new Point(271, 144);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(1, 0);
            materialLabel2.TabIndex = 4;
            // 
            // Logo_Image
            // 
            Logo_Image.Image = Properties.Resources.logo_agencia;
            Logo_Image.Location = new Point(160, 86);
            Logo_Image.Name = "Logo_Image";
            Logo_Image.Size = new Size(112, 107);
            Logo_Image.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.Location = new Point(111, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(212, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ainda não é Cadastrado?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(linkLabel1);
            Controls.Add(Logo_Image);
            Controls.Add(materialLabel2);
            Controls.Add(entrarButton);
            Controls.Add(senhaText);
            Controls.Add(LoginText);
            Controls.Add(materialLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Sizable = false;
            Text = "Login do Recrutador";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit LoginText;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit senhaText;
        private ReaLTaiizor.Controls.MaterialButton entrarButton;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private Label Logo_Image;
        private LinkLabel linkLabel1;
    }
}