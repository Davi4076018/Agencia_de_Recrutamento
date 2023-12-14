namespace Agencia_de_Recrutamento.App.Cadastros
{
    partial class VagasAtivas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VagasAtivas));
            listViewVagas = new ListView();
            columnHeader2 = new ColumnHeader();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // listViewVagas
            // 
            listViewVagas.Activation = ItemActivation.OneClick;
            listViewVagas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVagas.AutoArrange = false;
            listViewVagas.BackColor = SystemColors.MenuBar;
            listViewVagas.BorderStyle = BorderStyle.None;
            listViewVagas.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listViewVagas.Cursor = Cursors.Hand;
            listViewVagas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listViewVagas.ForeColor = SystemColors.GrayText;
            listViewVagas.FullRowSelect = true;
            listViewVagas.HeaderStyle = ColumnHeaderStyle.None;
            listViewVagas.HotTracking = true;
            listViewVagas.HoverSelection = true;
            listViewVagas.LabelWrap = false;
            listViewVagas.Location = new Point(6, 67);
            listViewVagas.MultiSelect = false;
            listViewVagas.Name = "listViewVagas";
            listViewVagas.Size = new Size(788, 377);
            listViewVagas.SmallImageList = imageList1;
            listViewVagas.Sorting = SortOrder.Ascending;
            listViewVagas.TabIndex = 3;
            listViewVagas.UseCompatibleStateImageBehavior = false;
            listViewVagas.View = View.Details;
            listViewVagas.MouseClick += listViewVagas_MouseClick;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 1000;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "vagaAtiva_icon3.png");
            // 
            // VagasAtivas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewVagas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VagasAtivas";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vagas Ativas";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewVagas;
        private ImageList imageList1;
        private ColumnHeader columnHeader2;
    }
}