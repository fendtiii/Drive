using System;
using System.Windows.Forms;

namespace Drive
{
    public partial class FormShortcutKeys : Form
    {
        public FormShortcutKeys()
        {
            InitializeComponent();
        }

        private void FormShortcutKeys_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}