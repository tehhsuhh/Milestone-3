using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; (i + index) <= (yourInventory.Length - 1); i++)
            {
                if (index + i == yourInventory.Length - 1)
                {
                    
                    yourInventory[index + i] = null;
                }
                else
                {
                   
                    yourInventory[index + i] = yourInventory[index + i + 1];
                }
            }
            inventoryFinalIndex--;
        }
    }
    }
}
