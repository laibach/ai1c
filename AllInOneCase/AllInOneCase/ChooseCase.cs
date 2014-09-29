using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllInOneCase
{
    public partial class ChooseCase : Form
    {
        public String StartModus = "";

        public Object Object2Store = null;
        public String Object2Store_Type = "";

        public ChooseCase()
        {
            InitializeComponent();
        }

        private void ChooseCase_Load(object sender, EventArgs e)
        {
            hole_AlleCases("", "");
            hole_Kategorien();
        }

        private void Felder_ReadOnly()
        {
            textBoxName.ReadOnly = true;
            comboBoxKategorie.Enabled = false;
            richTextBoxBemerkung.ReadOnly = true;
            buttonNeuenCaseErstellen.Enabled = false;
        }

        private void Felder_ReadWrite()
        {
            textBoxName.ReadOnly = false;
            comboBoxKategorie.Enabled = true;
            richTextBoxBemerkung.ReadOnly = false;
            buttonNeuenCaseErstellen.Text = "Case ändern";
            buttonNeuenCaseErstellen.Enabled = true;
        }

        private void Felder_Clear()
        {
            textBoxName.Text = "";
            comboBoxKategorie.Text = "";
            richTextBoxBemerkung.Text = "";
        }

        SQLiteWrapper mysqlligt = new SQLiteWrapper();
        private void hole_Kategorien()
        {
            String Kategorie = "";

            comboBoxKategorie.Items.Clear();

            String tmpSQL = "Select * from Kategorien order by Kategorie";
            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                while (ODBCDataReader1.Read())
                {
                    Kategorie = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Kategorie")))
                        Kategorie = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Kategorie"));

                    comboBoxKategorie.Items.Add(Kategorie);
                }
            }
        }

        private bool istFileVorhanden(String Link, String CaseID)
        {
            String tmpSQL = "Select * from Files where Link = '" + Link + "' and CaseID = " + CaseID;
            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                if (ODBCDataReader1.HasRows)
                    return true;
            }

            return false;
        }

        private void hole_AlleCases(String SuchModus, String SuchParameter)
        {
            Felder_ReadOnly();
            long ID = 0;
            String CaseName = "";
            String Beschreibung = "";
            String Kategorie = "";
            DateTime? Neuanlage = null;
            DateTime? Edit = null;

            dataGridViewAlleCases.Rows.Clear();

            String tmpSQL = "";
            if (SuchModus.ToLower() == "suchen")
                tmpSQL = "Select * from Cases where Name like '" + SuchParameter + "%' order by Name";
            if (SuchModus.ToLower() == "alles suchen")
                tmpSQL = "Select * from Cases where Name like '" + SuchParameter + "%' or Kategorie like '" + SuchParameter + "%' order by Name";
            if (SuchModus == "erweiterte suche")
                tmpSQL = "Select * from Cases where Name like '" + SuchParameter + "%' or Kategorie like '" + SuchParameter + "%' or Beschreibung like '%" + SuchParameter + "%' order by Name";
            if (SuchModus == "")
                tmpSQL = "Select * from Cases order by Name";

            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                while (ODBCDataReader1.Read())
                {
                    ID = 0;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("ID")))
                        ID = ODBCDataReader1.GetInt32(ODBCDataReader1.GetOrdinal("ID"));
                    CaseName = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Name")))
                        CaseName = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Name"));
                    Beschreibung = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Beschreibung")))
                        Beschreibung = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Beschreibung"));
                    Kategorie = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Kategorie")))
                        Kategorie = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Kategorie"));
                    Neuanlage = null;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Neuanlage")))
                        Neuanlage = ODBCDataReader1.GetDateTime(ODBCDataReader1.GetOrdinal("Neuanlage"));
                    Edit = null;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Edit")))
                        Edit = ODBCDataReader1.GetDateTime(ODBCDataReader1.GetOrdinal("Edit"));

                    String SEdit = "";
                    if (Edit.HasValue)
                        SEdit = Edit.Value.ToShortDateString() + " " + Edit.Value.ToShortTimeString();
                    else
                        SEdit = "Nicht gesetzt";

                    String TextNeuanlage = "";
                    if (Neuanlage == null)
                        TextNeuanlage = "nicht gesetzt";
                    else
                        TextNeuanlage = Neuanlage.Value.ToShortDateString();

                    dataGridViewAlleCases.Rows.Add(ID.ToString(), CaseName, Kategorie, Beschreibung, SEdit, TextNeuanlage + " " + Neuanlage.Value.ToShortTimeString());
                }
            }
            else
            {
                MessageBox.Show("Fehler in der SQLite-Datenbank");
            }

            // Bei weniger als 5 Treffern
            if (dataGridViewAlleCases.RowCount < 5)
            {
                // und der 'alles suchen'-Suche
                if (SuchModus == "alles suchen")
                {
                    // nochmal nochmehr suchen...
                    hole_AlleCases("erweiterte suche", SuchParameter);
                }
            }
        }

        private void buttonNeuenCaseErstellen_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && comboBoxKategorie.Text != "")
            {
                String Bemerkung = "";
                if (richTextBoxBemerkung.Text == "")
                    Bemerkung = "NULL";
                else
                    Bemerkung = "'" + SQLiteWrapper.checkStringforOdbc(richTextBoxBemerkung.Text) + "'";
                String CaseName = SQLiteWrapper.checkStringforOdbc(textBoxName.Text);
                String Kategorie = SQLiteWrapper.checkStringforOdbc(comboBoxKategorie.Text);

                String tmpSQL = "";
                if (buttonNeuenCaseErstellen.Text == "Neuen Case erstellen")
                {
                    // Insert
                    tmpSQL = "Insert into Cases (Name, Kategorie, Edit, Beschreibung) Values('" + CaseName + "', '" + Kategorie + "', NULL, " + Bemerkung + ")";
                }
                else
                {
                    // Update
                    tmpSQL = "Update Cases Set Name = '" + CaseName + "', Kategorie = '" + Kategorie + "', Edit = Current_DateTime, Beschreibung = " + Bemerkung + ")";
                }

                mysqlligt.doSQL(tmpSQL);
                if (textBoxCaseSuchen.Text == "")
                    hole_AlleCases("", "");
                else
                    hole_AlleCases("Suchen", textBoxCaseSuchen.Text);
            }
            else
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Bitte dem Case einen Namen geben.");
                }
                else if (comboBoxKategorie.Text == "")
                {
                    MessageBox.Show("Bitte eine Kategorie auswählen");
                }
            }
        }

        private void dataGridViewAlleCases_DoubleClick(object sender, EventArgs e)
        {
            if (StartModus == "Case verwalten")
                Case_Bearbeiten();
            if (StartModus == "Case auswählen")
            {
                if (dataGridViewAlleCases.SelectedRows.Count > 0)
                {
                    speicher_CaseObject(Object2Store, Object2Store_Type, dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString());
                    this.Close();
                }
            }
        }

        private void speicher_FileName(String FileName, String Typ, String CaseID)
        {
            if (istFileVorhanden(FileName, CaseID) == false)
            {
                String tmpSQL = "Insert into Files (CaseID, Link, Typ) Values(" + CaseID + ", '" + FileName + "', '" + Typ + "')";
                mysqlligt.doSQL(tmpSQL);
            }
            else
            {
                MessageBox.Show("Der Link '" + FileName + "' ist in diesem Case bereits vorhanden.");
            }
        }

        private void speicher_CaseObject(Object O2Store, String ObjectType, String CaseID)
        {
            if (ObjectType == "FileList")
            {
                String[] FileList = O2Store as String[];
                foreach (String s in FileList)
                {
                    speicher_FileName(s,"Filename", CaseID);
                }

                hole_Files(CaseID);
            }

            MessageBox.Show(Object2Store_Type + "|" + Object2Store.GetType().ToString());
        }

        private void Case_Bearbeiten()
        {
            if (dataGridViewAlleCases.SelectedRows.Count > 0)
            {
                hole_Case(dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString());
                Felder_ReadWrite();
            }
        }

        private void dataGridViewAlleCases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlleCases.SelectedRows.Count > 0)
            {
                hole_Case(dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString());
                hole_Files(dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString());
            }
        }

        private void hole_Files(String CaseID)
        {
            String ID = "";
            String Link = "";
            String Beschreibung = "";
            DateTime? Neuanlage = null;
            String Typ = "";

            Felder_Clear();

            // panelFiles.Controls.Clear();
            dataGridViewFiles.Rows.Clear();

            String tmpSQL = "Select * from Files where CaseID = " + CaseID + " order by Link";
            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                while (ODBCDataReader1.Read())
                {
                    ID = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("ID")))
                        ID = ODBCDataReader1.GetInt32(ODBCDataReader1.GetOrdinal("ID")).ToString();
                    Link = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Link")))
                        Link = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Link")).ToString();
                    Beschreibung = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Beschreibung")))
                        Beschreibung = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Beschreibung")).ToString();
                    Neuanlage = null;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Neuanlage")))
                        Neuanlage = ODBCDataReader1.GetDateTime(ODBCDataReader1.GetOrdinal("Neuanlage"));
                    Typ = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Typ")))
                        Typ = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Typ")).ToString();

                    if (Typ == "Filename")
                    {
                        dataGridViewFiles.Rows.Add(ID, Link, Typ, Beschreibung, Neuanlage);
                        // Grafik auf Panel ablegen
                        /*
                        PictureBox newPB = new PictureBox();
                        newPB.Image = Text2Image(Link + " " + Typ);
                        newPB.Location = new Point(0, 0);
                        panelFiles.Controls.Add(newPB);
                        */
                    }
                }
            }
        }

        private Image Text2Image(String TextForImage)
        {
            Bitmap a = new Bitmap(100, 100);
            Size MyNewSize;

            using(Graphics g = Graphics.FromImage(a))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.DrawString(TextForImage, this.Font, Brushes.Black, new PointF(1, 1)); // requires font, brush etc
                MyNewSize = new Size(600, ((int)g.MeasureString(TextForImage, this.Font, 600, StringFormat.GenericTypographic).Height));
            }

            return CopyBitmap(a, new Rectangle(0,0,MyNewSize.Width, MyNewSize.Height));
        }

        static public Bitmap CopyBitmap(Bitmap srcBitmap, Rectangle section)
        {
            // Create the new bitmap and associated graphics object
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);

            // Draw the specified section of the source bitmap to the new one
            g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);

            // Clean up
            g.Dispose();

            // Return the bitmap
            return bmp;
        }

        private void hole_Case(String sID)
        {
            long ID = 0;
            String CaseName = "";
            String Beschreibung = "";
            String Kategorie = "";
            DateTime? Neuanlage = null;
            DateTime? Edit = null;

            String tmpSQL = "Select * from Cases Where ID = " + sID;
            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                while (ODBCDataReader1.Read())
                {
                    ID = 0;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("ID")))
                        ID = ODBCDataReader1.GetInt32(ODBCDataReader1.GetOrdinal("ID"));
                    CaseName = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Name")))
                        CaseName = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Name"));
                    Beschreibung = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Beschreibung")))
                        Beschreibung = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Beschreibung"));
                    Kategorie = "";
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Kategorie")))
                        Kategorie = ODBCDataReader1.GetString(ODBCDataReader1.GetOrdinal("Kategorie"));
                    Neuanlage = null;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Neuanlage")))
                        Neuanlage = ODBCDataReader1.GetDateTime(ODBCDataReader1.GetOrdinal("Neuanlage"));
                    Edit = null;
                    if (!ODBCDataReader1.IsDBNull(ODBCDataReader1.GetOrdinal("Edit")))
                        Edit = ODBCDataReader1.GetDateTime(ODBCDataReader1.GetOrdinal("Edit"));

                    textBoxName.Text = CaseName;
                    comboBoxKategorie.Text = Kategorie;
                    richTextBoxBemerkung.Text = Beschreibung;
                }
            }
            else
            {
                MessageBox.Show("Fehler in der SQLite-Datenbank");
            }
        }

        private bool gibts_Kategorie_schon(String SuchKategorie)
        {
            String tmpSQL = "Select * from Kategorien Where Kategorie = '" + SuchKategorie + "'";
            System.Data.SQLite.SQLiteDataReader ODBCDataReader1;
            ODBCDataReader1 = mysqlligt.doSQL(tmpSQL);
            if (ODBCDataReader1 != null)
            {
                if (ODBCDataReader1.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Case_Bearbeiten();
        }

        private void neuenCaseAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Felder_Clear();
            Felder_ReadWrite();
            buttonNeuenCaseErstellen.Text = "Neuen Case erstellen";
        }

        private void kategorieHinzufuegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextFeldEingabe tfe = new TextFeldEingabe();
            tfe.Titel = "Bitte eine Kategorie eingeben";
            tfe.TextFeld = "";

            tfe.ShowDialog();
            if (tfe.TextFeld != "")
            {
                if (gibts_Kategorie_schon(tfe.TextFeld) == false)
                {
                    String tmpSQL = "Insert into Kategorien (Kategorie) Values ('" + tfe.TextFeld + "')";
                    mysqlligt.doSQL(tmpSQL);
                    hole_Kategorien();
                }
                else
                {
                    MessageBox.Show("Kategorie ist bereits vorhanden.");
                }
            }
        }

        private void kategorieBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String AlteKategorie = comboBoxKategorie.Text;
            TextFeldEingabe tfe = new TextFeldEingabe();
            tfe.Titel = "Bitte eine Kategorie eingeben";
            tfe.TextFeld = "";

            tfe.ShowDialog();
            if (tfe.TextFeld != "" && AlteKategorie != tfe.TextFeld)
            {
                if (gibts_Kategorie_schon(tfe.TextFeld) == false)
                {
                    String tmpSQL = "Update Kategorien set Kategorie = '" + tfe.TextFeld + "' where Kategorie = '" + AlteKategorie + "'";
                    mysqlligt.doSQL(tmpSQL);
                    hole_Kategorien();
                }
                else
                {
                    MessageBox.Show("Kategorie ist bereits vorhanden.");
                }
            }
        }

        private void kategorieLoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String zuLoeschendeKategorie = comboBoxKategorie.Text;
            if (zuLoeschendeKategorie != "")
            {
                String tmpSQL = "Delete from Kategorien where Kategorie = '" + zuLoeschendeKategorie + "'";
                mysqlligt.doSQL(tmpSQL);
                hole_Kategorien();
            }
        }

        private void loeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlleCases.SelectedRows.Count > 0)
            {
                String ZuLoeschendeID = dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString();
                String tmpSQL = "Delete from Cases where ID = " + ZuLoeschendeID;
                mysqlligt.doSQL(tmpSQL);
                if (textBoxCaseSuchen.Text == "")
                    hole_AlleCases("", "");
                else
                    hole_AlleCases("Suchen", textBoxCaseSuchen.Text);
            }
        }

        private void textBoxCaseSuchen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                sucheCase(textBoxCaseSuchen.Text);
            }
        }

        private void sucheCase(String Suchtext)
        {
            hole_AlleCases("Suchen", Suchtext);
        }

        private void update_FileBeschreibung(String FileID, String Beschreibung)
        {
            String tmpSQL = "Update Files set Beschreibung = '" + SQLiteWrapper.checkStringforOdbc(Beschreibung) + "' where ID = " + FileID;
            mysqlligt.doSQL(tmpSQL);
        }

        private void beschreibungAendernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in dataGridViewFiles.SelectedRows)
                {
                    String Link = dgvr.Cells["dataGridViewTextBoxColumnLink"].Value.ToString();
                    TextFeldEingabe tfe = new TextFeldEingabe();
                    tfe.Titel = "Beschreibung für '" + Link + "' eingeben";
                    tfe.ShowDialog();
                    if (tfe.TextFeld != "")
                    {
                        update_FileBeschreibung(dgvr.Cells["dataGridViewTextBoxColumnFileID"].Value.ToString(), tfe.TextFeld);
                    }
                }
            }
        }

        private void fileLoeschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in dataGridViewFiles.SelectedRows)
                {
                    String FileID = dgvr.Cells["dataGridViewTextBoxColumnFileID"].Value.ToString();
                    String tmpSQL = "Delete from Files where ID = " + FileID;
                    mysqlligt.doSQL(tmpSQL);
                }
                hole_Files(dataGridViewAlleCases.CurrentRow.Cells["ColumnID"].Value.ToString());
            }
        }

        private void dataGridViewFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in dataGridViewFiles.SelectedRows)
                {
                    String Link = dgvr.Cells["dataGridViewTextBoxColumnLink"].Value.ToString();
                    String Typ = dgvr.Cells["dataGridViewTextBoxColumnTyp"].Value.ToString();

                    switch (Typ.ToLower())
                    {
                        case "filename":
                            System.Diagnostics.Process.Start(Link);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
