using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* TO DO FOR THIS FORM -------------------------------------------------------------------
 * 
 * Setup reference tables in database for: 
 *      Class Names ============================================================================ DONE
 *  (1) starting attributes ==================================================================== DONE
 *  (2) Initial Point Costs ==================================================================== DONE
 *  (3) Point Cost Increase ==================================================================== DONE
 *  (4) Initial Point Stat Growth ============================================================== DONE
 *  (5) Point Stat Growth Increase ============================================================= DONE
 *  (6) Skills
 *      (a) Offensive Skills
 *      (b) Defensive Skills
 *      (c) White Magic
 *      (d) Black Magic
 *      -- what classes have access (account for class upgrade)
 *      -- prerequisite skills
 *      -- level required
 *      -- special requirements
 *      -- warmup/cooldown 
 *          (check World Unknown guide for other fields that may not yet be used, 
 *          but should be included in database design)
 *  (7) Equipment
 *      (a) Weapon
 *          -- check for Type == 'Ax', clear & disable shield slot
 *      (b) Shield
 *      (c) Head
 *      (d) Body
 *      (e) Arms
 *      (f) Legs
 *      (g) Accessory
 *      -- include type (hat, helmet, etc.) in table
 *      (h) List of valid equipment types for classes ========================================= DONE
 *          -- accounts for class upgrade ===================================================== DONE
 *      Default AP Distribution Options (Balanced, Offensive, Defensive)
 *  (8) Enemy Stats
 *      -- expect this to be long, take care of this LATER
 *
 * Setup 4 (or more?) Dictionaries in PlayerCharacter.cs to hold the categories 2 through 5 above, with attributes as keys
 * select values using LINQ in character class constructors. Assign starting attributes to attribute fields
 *
 * Use collections (what kind?) to hold attributes in Character.cs and attribute levels in PlayerCharacter.cs
 * 
 * Save character info (name, class, description, attributes, attribute levels, skills, equipment) in a table using LINQ
 *
 * Decide how to handle class upgrades (ex. Knight -> Dark Knight) and reversing such. Possibly have upgraded class as derived class,
 * use base class as parameter in derived class constructor, and overloaded constructor in base class using derived class as parameter
 * and clearing out skills & equipment that are no longer valid. Display (as noted below) confirmation message that states abilities and
 * equipment may be lost
 *
 * Class Upgrade radio button, confirmation message box, clear/repopulate form to reflect changes
*/
namespace Last_Dream_Character_Builder
{
    public partial class CharacterCreationForm : Form
    {
        // character being created
        PlayerCharacter newPC;

        public CharacterCreationForm()
        {
            InitializeComponent();
        }

        private void CreateCharBtn_Click(object sender, EventArgs e)
        {
            // Character name, class, and description
            string charName, charClass, charDescription;

            charName = charNameTxtBox.Text;
            charClass = charClassComboBox.Text;
            charDescription = charDescriptionTxtBox.Text;

            // If a name was entered and a class was selected, disable the charClassComboBox, enable the containers for attributes, skills, and equipment,
            // create a character of the selected class, and set the attribute control values to their initial attributes
            if (charName != "" && charClassComboBox.Items.Contains(charClass))
            {
                charClassComboBox.Enabled = false;
                baseAttributesGrpBox.Enabled = true;
                skillsTabControl.Enabled = true;
                equipmentGrpBox.Enabled = true;

                CreateCharacter(charClass); //creates a character of the selected class

                // set the attribute numericUpDown control values and minimums to the new character's initial attributes
                hpUpDown.Value = newPC.MaxHP;
                mpUpDown.Value = newPC.MaxMP;
                atkUpDown.Value = newPC.Attack;
                defUpDown.Value = newPC.Defense;
                intUpDown.Value = newPC.Intelligence;
                agiUpDown.Value = newPC.Agility;
                accUpDown.Value = newPC.Accuracy;
                crtUpDown.Value = newPC.Critical;
                preUpDown.Value = newPC.Preemption;
                mgdUpDown.Value = newPC.MagicDefense;

                hpUpDown.Minimum = hpUpDown.Value;
                mpUpDown.Minimum = mpUpDown.Value;
                atkUpDown.Minimum = atkUpDown.Value;
                defUpDown.Minimum = defUpDown.Value;
                intUpDown.Minimum = intUpDown.Value;
                agiUpDown.Minimum = agiUpDown.Value;
                accUpDown.Minimum = accUpDown.Value;
                crtUpDown.Minimum = crtUpDown.Value;
                preUpDown.Minimum = preUpDown.Value;
                mgdUpDown.Minimum = mgdUpDown.Value;
            }
            else // otherwise, request that the user enter a name and select a class
            {
                MessageBox.Show("Please enter a name and select a class");
            }
        }

        // Creates a character of a given class
        private void CreateCharacter(string className)
        {
            switch(className)
            {
                case "Knight":
                    newPC = new Knight();
                    break;
                default:
                    MessageBox.Show("Error: CreateCharacter method received an invalid argument");
                    break;
            }
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveCharBtn_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        // set up this and PlayerCharacter to change level up or down 1 at a time, limit and use MessageBox if change will put cumulative AP under available AP ----------------------------------
        private void CharLevelUpDown_ValueChanged(object sender, EventArgs e)
        {
            newPC.LevelChange((int)CharLevelUpDown.Value);

            abilityPointsOutLbl.Text = newPC.AbilityPointsAvailable.ToString() + " / " + newPC.AbilityPointsCumulative;
        }
    }
}
