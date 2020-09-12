using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class GamePlay : Form
    {
        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void GamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {

            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {

            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {

            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {

            }
        }
    }
}
