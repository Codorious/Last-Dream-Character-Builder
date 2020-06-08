using System;
using System.Windows.Forms;

namespace Last_Dream_Character_Builder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void CharCreateBtn_Click(object sender, EventArgs e)
        {
            CharacterCreationForm charForm = new CharacterCreationForm();

            charForm.ShowDialog();


        }

        private void CharEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void PartyCreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void PartyEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void EnemyTestBtn_Click(object sender, EventArgs e)
        {

        }

        private void CharCompareBtn_Click(object sender, EventArgs e)
        {

        }

        // Closes the main form and with it the application
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
