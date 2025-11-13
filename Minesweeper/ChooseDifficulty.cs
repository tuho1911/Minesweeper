using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class ChooseDifficulty : Form
    {
        public int rows { get; private set; }
        public int cols { get; private set; }
        public int mines { get; private set; }

        public ChooseDifficulty()
        {
            InitializeComponent();
        }
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (rdb_Easy.Checked)
            {
                rows = 9;
                cols = 9;
                mines = 10;
            }
            else if (rdb_Medium.Checked)
            {
                rows = 15;
                cols = 15;
                mines = 40;
            }
            else if (rdb_Hard.Checked)
            {
                rows = 21;
                cols = 21;
                mines = 100;
            }
            this.Hide();
            var gameForm = new MainGame(rows, cols, mines);
            gameForm.FormClosed += (s, args) => Application.Exit();
            gameForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
