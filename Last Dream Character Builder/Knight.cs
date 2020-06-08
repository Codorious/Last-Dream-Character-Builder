using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Dream_Character_Builder
{
    class Knight : PlayerCharacter
    {



        // Initial attributes
        const int INITIAL_HP = 30, INITIAL_MP = 20,
            INITIAL_ATK = 4, INITIAL_DEF = 3, INITIAL_INT = 1, INITIAL_AGI = 1,
            INITIAL_ACC = 2, INITIAL_CRT = 1, INITIAL_PRE = 1, INITIAL_MGD = 1;
        // Initial Point Cost: This is how many AP it costs to increase a given attribute the first time (i.e. buy the first attributeLevel of this attribute).
        const int IPC_HP = 4, IPC_MP = 6, 
            IPC_ATK = 5, IPC_DEF = 4, IPC_INT = 6, IPC_AGI = 6, 
            IPC_ACC = 5, IPC_CRT = 10, IPC_PRE = 6, IPC_MGD = 6;
        // Point Cost Increase: For every ATT_LVL in the given attribute, the cost of increasing the attribute increases by this amount.
        const double PCI_HP = 0.03, PCI_MP = 0.05,
            PCI_ATK = 0.03, PCI_DEF = 0.03, PCI_INT = 0.05, PCI_AGI = 0.04,
            PCI_ACC = 0.04, PCI_CRT = 0.04, PCI_PRE = 0.04, PCI_MGD = 0.05;
        // Initial Point Stat Growth: This is how much the stat will go up upon buying the first attributeLevel of the given attribute.
        const int IPSG_HP = 10, IPSG_MP = 5,
            IPSG_ATK = 1, IPSG_DEF = 1, IPSG_INT = 1, IPSG_AGI = 1,
            IPSG_ACC = 1, IPSG_CRT = 1, IPSG_PRE = 1, IPSG_MGD = 1;
        // Point Stat Growth Increase: For every attributeLevel in a given attribute, the number of points you gain in the stat increases by this much.
        const double PSGI_HP = 0.0, PSGI_MP = 0.05,
            PSGI_ATK = 0.0, PSGI_DEF = 0.0, PSGI_INT = 0.0, PSGI_AGI = 0.0,
            PSGI_ACC = 0.0, PSGI_CRT = 0.0, PSGI_PRE = 0.0, PSGI_MGD = 0.0;

        
        // Constructor
        public Knight()
            : base(INITIAL_HP, INITIAL_MP, 
                  INITIAL_ATK, INITIAL_DEF, INITIAL_INT, INITIAL_AGI, 
                  INITIAL_ACC, INITIAL_CRT, INITIAL_PRE, INITIAL_MGD)
        { 
            
        }

        //
    }
}
