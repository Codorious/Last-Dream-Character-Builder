using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Last_Dream_Character_Builder
{
    abstract class PlayerCharacter : Character
    {
        // Character level
        private int charLevel;
        // available and cumulative ability points (AP) (points used to increase attributes)
        protected int abilityPointsCumulative, abilityPointsAvailable;
        // attribute level (number of times an attribute has been increased) (HP, MP, ATK, DEF, INT, AGI, ACC, CRT, PRE, MGD)
        protected int[] attributeLvl = new int[10];
        protected int attributeLevelHP, attributeLevelMP, attributeLevelAttack, attributeLevelDefense, attributeLevelInt, 
            attributeLevelAgi, attributeLevelAcc, attributeLevelCrt, attributeLevelPre, attributeLevelMgd;
        // Attributes : HP, MP, Attack, Defense, Intelligence, 
        int[] attributes = new int[10];
        protected int healthPoints, manaPoints, attack, defense, intelligence, 
            agility, accuracy, critical, preemption, magicDefense;
        // Dictionary with Element or something as value to hold the following reference values (IPC, PCI, IPSG, PSGI)
        // Initial Point Cost: This is how many AP it costs to increase a given attribute the first time (i.e. buy the first attributeLevel of this attribute).
        // Point Cost Increase: For every ATT_LVL in the given attribute, the cost of increasing the attribute increases by this amount.
        // Initial Point Stat Growth: This is how much the stat will go up upon buying the first attributeLevel of the given attribute.
        // Point Stat Growth Increase: For every attributeLevel in a given attribute, the number of points you gain in the stat increases by this much.
        Dictionary<string, PlayerAttribute> stats = new Dictionary<string, PlayerAttribute>;
        

        // constructor
        public  PlayerCharacter(int startHP, int startMP,
            int startAtk, int startDef, int startInt, int startAgi,
            int startAcc, int startCrt, int startPre, int startMgd)
            : base(startHP, startMP, startAtk, startDef, startInt, startAgi, startAcc, startCrt, startPre, startMgd)
        {
            // Character level starts at 1, and available and cumulative AP start at 0 for all classes
            charLevel = 1;
            abilityPointsCumulative = 0;
            abilityPointsAvailable = 0;

            stats[0] = 

            // all attribute levels start at 0 for all player characters
        }

        public int CharLevel {get => charLevel; }
        public int AbilityPointsCumulative { get => abilityPointsCumulative; }
        public int AbilityPointsAvailable { get => abilityPointsAvailable; }

        //
        private static void SetStat()
        {

        }
        /*
         *     class PlayerAttribute
    {
        public int attValue { get; set; }
        public int attLevel { get; set; }
        public int initPointCost { get; set; }
        public double pointCostInc { get; set; }
        public int initPointStatGrowth { get; set; }
        public double pointStatGrowthInc { get; set; }
    }
         */
        // Changes the character's level, and updates available and cumulative ability points to reflect this
        public void LevelIncrease()
        {
            charLevel = newLevel;

            // current available and cumulative AP
            int oldCumulativeAP = abilityPointsCumulative;


        }
    }
}
