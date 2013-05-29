using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AllInOneCase
{
    public partial class TextFeldEingabe : Form
    {
        public String Titel = "Bitte einen Text eingeben";
        public String TextFeld = "";

        public TextFeldEingabe()
        {
            InitializeComponent();
        }

        private void TextFeldEingabe_Load(object sender, EventArgs e)
        {
            this.Text = Titel;
            textBoxText.Text = TextFeld;
            this.ControlBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            TextFeld = textBoxText.Text;
            this.Close();
        }
    }
}
