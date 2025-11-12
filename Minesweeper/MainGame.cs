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
    public partial class MainGame : Form
    {
        private int rows, cols, mines;
        private CellButton[,] grid; // Mảng 2 chiều, kiểu CellButton, chưa có dữ liệu, tên grid
        private readonly Random rand = new Random(); // Tạo số ngẫu nhiên
        private int elapsedSeconds = 0;
        private bool firstClick = true; // Biến kiểm tra lần click đầu tiên
        public MainGame(int rows, int cols, int mines)
        {
            InitializeComponent();
            this.rows = rows;
            this.cols = cols;
            this.mines = mines;
            if (rows == 9) this.Size = new Size(450, 400);
            if (rows == 15) this.Size = new Size(650, 550);
            if (rows == 21) this.Size = new Size(900, 800); // chỉnh kích thước form cho hard
            StartGame();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            tmr_TimeCount.Tick += Tmr_TimeCount_Tick;
        }// nay la form1_load trong code goc

        private void StartGame()
        {
            int size = 30; // kích thước ô

            lb_TimeCount.Text = "00:00"; // label hiển thị thời gian
            lb_BombShow.Text = mines.ToString(); // label hiển thị số mìn
            btn_LogoRestart.BackgroundImage = Properties.Resources.logo_start;
            btn_LogoRestart.BackgroundImageLayout = ImageLayout.Stretch;
            tmr_TimeCount.Start();
            panel1.Controls.Clear();

            grid = new CellButton[rows, cols]; // khởi tạo mảng 2 chiều, kích thước rows x cols
            panel1.Width = cols * size; // chiều rộng panel
            panel1.Height = rows * size; // chiều cao panel

            // Tạo button lưới
            for (int i = 0; i < rows; i++) // dòng  
            {
                for (int j = 0; j < cols; j++) // cột
                {
                    var btn = new CellButton(); // tạo button mới
                    btn.Row = i; // gán vị trí dòng
                    btn.Col = j; // gán vị trí cột
                    btn.Width = size; // chiều rộng
                    btn.Height = size; // chiều cao
                    btn.Left = j * size;
                    btn.Top = i * size;
                    btn.FlatAppearance.BorderSize = 0; // bỏ viền
                    btn.FlatStyle = FlatStyle.Flat; // kiểu nút phẳng
                    btn.FlatAppearance.MouseOverBackColor = TransparencyKey; // khi rê chuột vào thì không đổi màu
                    btn.FlatAppearance.MouseDownBackColor = TransparencyKey; // khi nhấn chuột thì không đổi màu
                    btn.BackgroundImage = Properties.Resources.title; // ảnh ô chưa mở
                    btn.BackgroundImageLayout = ImageLayout.Stretch;   // cho nó căng vừa ô
                    btn.MouseDown += Cell_Click; // xử lý click chuột
                    panel1.Controls.Add(btn);
                    grid[i, j] = btn;
                }
            }
            PlaceMines(); // đặt mìn
            CalculateAdjacents();
        }
    }
}
