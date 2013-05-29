namespace AllInOneCase
{
    partial class ChooseCase
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAlleCases = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumLetzteAenderung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatumNeuerstellung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripCases = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenCaseAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loeschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxBemerkung = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.contextMenuStripKategorie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kategorieHinzufuegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieLoeschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNeuenCaseErstellen = new System.Windows.Forms.Button();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnFileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFileBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFileNeuanlage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.beschreibungAendernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileLoeschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCaseSuchen = new System.Windows.Forms.TextBox();
            this.buttonCaseSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlleCases)).BeginInit();
            this.contextMenuStripCases.SuspendLayout();
            this.contextMenuStripKategorie.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.panelFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.contextMenuStripFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAlleCases
            // 
            this.dataGridViewAlleCases.AllowUserToAddRows = false;
            this.dataGridViewAlleCases.AllowUserToDeleteRows = false;
            this.dataGridViewAlleCases.AllowUserToOrderColumns = true;
            this.dataGridViewAlleCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlleCases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlleCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlleCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnKategorie,
            this.ColumnBeschreibung,
            this.ColumnDatumLetzteAenderung,
            this.ColumnDatumNeuerstellung});
            this.dataGridViewAlleCases.ContextMenuStrip = this.contextMenuStripCases;
            this.dataGridViewAlleCases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAlleCases.Location = new System.Drawing.Point(1, 33);
            this.dataGridViewAlleCases.MultiSelect = false;
            this.dataGridViewAlleCases.Name = "dataGridViewAlleCases";
            this.dataGridViewAlleCases.ReadOnly = true;
            this.dataGridViewAlleCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlleCases.Size = new System.Drawing.Size(621, 128);
            this.dataGridViewAlleCases.TabIndex = 0;
            this.dataGridViewAlleCases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlleCases_CellClick);
            this.dataGridViewAlleCases.DoubleClick += new System.EventHandler(this.dataGridViewAlleCases_DoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 43;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 60;
            // 
            // ColumnKategorie
            // 
            this.ColumnKategorie.HeaderText = "Kategorie";
            this.ColumnKategorie.Name = "ColumnKategorie";
            this.ColumnKategorie.ReadOnly = true;
            this.ColumnKategorie.Width = 77;
            // 
            // ColumnBeschreibung
            // 
            this.ColumnBeschreibung.HeaderText = "Beschreibung";
            this.ColumnBeschreibung.Name = "ColumnBeschreibung";
            this.ColumnBeschreibung.ReadOnly = true;
            this.ColumnBeschreibung.Width = 97;
            // 
            // ColumnDatumLetzteAenderung
            // 
            this.ColumnDatumLetzteAenderung.HeaderText = "geändert";
            this.ColumnDatumLetzteAenderung.Name = "ColumnDatumLetzteAenderung";
            this.ColumnDatumLetzteAenderung.ReadOnly = true;
            this.ColumnDatumLetzteAenderung.Width = 74;
            // 
            // ColumnDatumNeuerstellung
            // 
            this.ColumnDatumNeuerstellung.HeaderText = "erstellt am";
            this.ColumnDatumNeuerstellung.Name = "ColumnDatumNeuerstellung";
            this.ColumnDatumNeuerstellung.ReadOnly = true;
            this.ColumnDatumNeuerstellung.Width = 79;
            // 
            // contextMenuStripCases
            // 
            this.contextMenuStripCases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bearbeitenToolStripMenuItem,
            this.neuenCaseAnlegenToolStripMenuItem,
            this.loeschenToolStripMenuItem});
            this.contextMenuStripCases.Name = "contextMenuStripCases";
            this.contextMenuStripCases.Size = new System.Drawing.Size(183, 70);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // neuenCaseAnlegenToolStripMenuItem
            // 
            this.neuenCaseAnlegenToolStripMenuItem.Name = "neuenCaseAnlegenToolStripMenuItem";
            this.neuenCaseAnlegenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.neuenCaseAnlegenToolStripMenuItem.Text = "Neuen Case anlegen";
            this.neuenCaseAnlegenToolStripMenuItem.Click += new System.EventHandler(this.neuenCaseAnlegenToolStripMenuItem_Click);
            // 
            // loeschenToolStripMenuItem
            // 
            this.loeschenToolStripMenuItem.Name = "loeschenToolStripMenuItem";
            this.loeschenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loeschenToolStripMenuItem.Text = "Löschen";
            this.loeschenToolStripMenuItem.Click += new System.EventHandler(this.loeschenToolStripMenuItem_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(59, 166);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(563, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bemerkung";
            // 
            // richTextBoxBemerkung
            // 
            this.richTextBoxBemerkung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxBemerkung.Location = new System.Drawing.Point(59, 219);
            this.richTextBoxBemerkung.Name = "richTextBoxBemerkung";
            this.richTextBoxBemerkung.Size = new System.Drawing.Size(563, 91);
            this.richTextBoxBemerkung.TabIndex = 5;
            this.richTextBoxBemerkung.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategorie";
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.ContextMenuStrip = this.contextMenuStripKategorie;
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Location = new System.Drawing.Point(59, 192);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(563, 21);
            this.comboBoxKategorie.TabIndex = 7;
            // 
            // contextMenuStripKategorie
            // 
            this.contextMenuStripKategorie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorieHinzufuegenToolStripMenuItem,
            this.kategorieBearbeitenToolStripMenuItem,
            this.kategorieLoeschenToolStripMenuItem});
            this.contextMenuStripKategorie.Name = "contextMenuStripKategorie";
            this.contextMenuStripKategorie.Size = new System.Drawing.Size(188, 70);
            // 
            // kategorieHinzufuegenToolStripMenuItem
            // 
            this.kategorieHinzufuegenToolStripMenuItem.Name = "kategorieHinzufuegenToolStripMenuItem";
            this.kategorieHinzufuegenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kategorieHinzufuegenToolStripMenuItem.Text = "Kategorie hinzufügen";
            this.kategorieHinzufuegenToolStripMenuItem.Click += new System.EventHandler(this.kategorieHinzufuegenToolStripMenuItem_Click);
            // 
            // kategorieBearbeitenToolStripMenuItem
            // 
            this.kategorieBearbeitenToolStripMenuItem.Name = "kategorieBearbeitenToolStripMenuItem";
            this.kategorieBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kategorieBearbeitenToolStripMenuItem.Text = "Kategorie bearbeiten";
            this.kategorieBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.kategorieBearbeitenToolStripMenuItem_Click);
            // 
            // kategorieLoeschenToolStripMenuItem
            // 
            this.kategorieLoeschenToolStripMenuItem.Name = "kategorieLoeschenToolStripMenuItem";
            this.kategorieLoeschenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kategorieLoeschenToolStripMenuItem.Text = "Kategorie löschen";
            this.kategorieLoeschenToolStripMenuItem.Click += new System.EventHandler(this.kategorieLoeschenToolStripMenuItem_Click);
            // 
            // buttonNeuenCaseErstellen
            // 
            this.buttonNeuenCaseErstellen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNeuenCaseErstellen.Location = new System.Drawing.Point(2, 316);
            this.buttonNeuenCaseErstellen.Name = "buttonNeuenCaseErstellen";
            this.buttonNeuenCaseErstellen.Size = new System.Drawing.Size(912, 23);
            this.buttonNeuenCaseErstellen.TabIndex = 8;
            this.buttonNeuenCaseErstellen.Text = "Neuen Case erstellen";
            this.buttonNeuenCaseErstellen.UseVisualStyleBackColor = true;
            this.buttonNeuenCaseErstellen.Click += new System.EventHandler(this.buttonNeuenCaseErstellen_Click);
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.panelFiles);
            this.groupBoxFiles.Location = new System.Drawing.Point(628, 1);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(282, 309);
            this.groupBoxFiles.TabIndex = 11;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.dataGridViewFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(3, 16);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(276, 290);
            this.panelFiles.TabIndex = 0;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToOrderColumns = true;
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnFileID,
            this.dataGridViewTextBoxColumnLink,
            this.dataGridViewTextBoxColumnTyp,
            this.dataGridViewTextBoxColumnFileBeschreibung,
            this.dataGridViewTextBoxColumnFileNeuanlage});
            this.dataGridViewFiles.ContextMenuStrip = this.contextMenuStripFiles;
            this.dataGridViewFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFiles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(270, 271);
            this.dataGridViewFiles.TabIndex = 1;
            this.dataGridViewFiles.DoubleClick += new System.EventHandler(this.dataGridViewFiles_DoubleClick);
            // 
            // dataGridViewTextBoxColumnFileID
            // 
            this.dataGridViewTextBoxColumnFileID.HeaderText = "ID";
            this.dataGridViewTextBoxColumnFileID.Name = "dataGridViewTextBoxColumnFileID";
            this.dataGridViewTextBoxColumnFileID.ReadOnly = true;
            this.dataGridViewTextBoxColumnFileID.Visible = false;
            this.dataGridViewTextBoxColumnFileID.Width = 43;
            // 
            // dataGridViewTextBoxColumnLink
            // 
            this.dataGridViewTextBoxColumnLink.HeaderText = "Link";
            this.dataGridViewTextBoxColumnLink.Name = "dataGridViewTextBoxColumnLink";
            this.dataGridViewTextBoxColumnLink.ReadOnly = true;
            this.dataGridViewTextBoxColumnLink.Width = 52;
            // 
            // dataGridViewTextBoxColumnTyp
            // 
            this.dataGridViewTextBoxColumnTyp.HeaderText = "Typ";
            this.dataGridViewTextBoxColumnTyp.Name = "dataGridViewTextBoxColumnTyp";
            this.dataGridViewTextBoxColumnTyp.ReadOnly = true;
            this.dataGridViewTextBoxColumnTyp.Width = 50;
            // 
            // dataGridViewTextBoxColumnFileBeschreibung
            // 
            this.dataGridViewTextBoxColumnFileBeschreibung.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumnFileBeschreibung.Name = "dataGridViewTextBoxColumnFileBeschreibung";
            this.dataGridViewTextBoxColumnFileBeschreibung.ReadOnly = true;
            this.dataGridViewTextBoxColumnFileBeschreibung.Width = 97;
            // 
            // dataGridViewTextBoxColumnFileNeuanlage
            // 
            this.dataGridViewTextBoxColumnFileNeuanlage.HeaderText = "erstellt am";
            this.dataGridViewTextBoxColumnFileNeuanlage.Name = "dataGridViewTextBoxColumnFileNeuanlage";
            this.dataGridViewTextBoxColumnFileNeuanlage.ReadOnly = true;
            this.dataGridViewTextBoxColumnFileNeuanlage.Width = 79;
            // 
            // contextMenuStripFiles
            // 
            this.contextMenuStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beschreibungAendernToolStripMenuItem,
            this.toolStripSeparator1,
            this.fileLoeschenToolStripMenuItem});
            this.contextMenuStripFiles.Name = "contextMenuStripFiles";
            this.contextMenuStripFiles.Size = new System.Drawing.Size(187, 54);
            // 
            // beschreibungAendernToolStripMenuItem
            // 
            this.beschreibungAendernToolStripMenuItem.Name = "beschreibungAendernToolStripMenuItem";
            this.beschreibungAendernToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.beschreibungAendernToolStripMenuItem.Text = "Beschreibung ändern";
            this.beschreibungAendernToolStripMenuItem.Click += new System.EventHandler(this.beschreibungAendernToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // fileLoeschenToolStripMenuItem
            // 
            this.fileLoeschenToolStripMenuItem.Name = "fileLoeschenToolStripMenuItem";
            this.fileLoeschenToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fileLoeschenToolStripMenuItem.Text = "File löschen";
            this.fileLoeschenToolStripMenuItem.Click += new System.EventHandler(this.fileLoeschenToolStripMenuItem_Click);
            // 
            // textBoxCaseSuchen
            // 
            this.textBoxCaseSuchen.Location = new System.Drawing.Point(2, 7);
            this.textBoxCaseSuchen.Name = "textBoxCaseSuchen";
            this.textBoxCaseSuchen.Size = new System.Drawing.Size(545, 20);
            this.textBoxCaseSuchen.TabIndex = 12;
            this.textBoxCaseSuchen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaseSuchen_KeyPress);
            // 
            // buttonCaseSuchen
            // 
            this.buttonCaseSuchen.Location = new System.Drawing.Point(553, 5);
            this.buttonCaseSuchen.Name = "buttonCaseSuchen";
            this.buttonCaseSuchen.Size = new System.Drawing.Size(69, 23);
            this.buttonCaseSuchen.TabIndex = 13;
            this.buttonCaseSuchen.Text = "Suchen";
            this.buttonCaseSuchen.UseVisualStyleBackColor = true;
            // 
            // ChooseCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 342);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.buttonNeuenCaseErstellen);
            this.Controls.Add(this.buttonCaseSuchen);
            this.Controls.Add(this.textBoxCaseSuchen);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxBemerkung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewAlleCases);
            this.Name = "ChooseCase";
            this.Text = "ChooseCase";
            this.Load += new System.EventHandler(this.ChooseCase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlleCases)).EndInit();
            this.contextMenuStripCases.ResumeLayout(false);
            this.contextMenuStripKategorie.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.contextMenuStripFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlleCases;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxBemerkung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.Button buttonNeuenCaseErstellen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCases;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenCaseAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loeschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripKategorie;
        private System.Windows.Forms.ToolStripMenuItem kategorieHinzufuegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieLoeschenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFileBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFileNeuanlage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatumLetzteAenderung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatumNeuerstellung;
        private System.Windows.Forms.TextBox textBoxCaseSuchen;
        private System.Windows.Forms.Button buttonCaseSuchen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem beschreibungAendernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileLoeschenToolStripMenuItem;
    }
}