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

        private void PlaceMines() // đặt mìn
        {
            int placed = 0; // số mìn đã đặt
            while (placed < mines) //lặp đến khi đặt đủ số mìn
            {
                int x = rand.Next(rows), y = rand.Next(cols); // lấy vị trí ngẫu nhiên, x là dòng, y là cột
                if (!grid[x, y].IsMine) // nếu chưa có mìn ở vị trí đó
                {
                    grid[x, y].IsMine = true; // đặt mìn
                    placed++;
                }
            }


        }

        private void CalculateAdjacents() //tính số mìn xung quanh
        {
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j].IsMine) continue;
                    int count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dx[k], nj = j + dy[k];
                        if (ni >= 0 && nj >= 0 && ni < rows && nj < cols && grid[ni, nj].IsMine)
                            count++;
                    }
                    grid[i, j].AdjacentMines = count;
                }
            }
        }

        //sender là đối tượng nào đã phát sinh sự kiện đó, vd nút nào đã được click
        private void Cell_Click(object sender, MouseEventArgs e) // xử lý sự kiện click chuột
        {
            var btn = sender as CellButton; // ép kiểu sender về CellButton

            if (btn.IsRevealed) return; //nếu đã mở rồi thì thoát hàm

            if (e.Button == MouseButtons.Right) // cắm cờ, chuột phải
            {
                btn.IsFlagged = !btn.IsFlagged; // đảo trạng thái, lúc đầu false -> true, true -> false
                                                //btn.Text = btn.IsFlagged ? "\U0001F6A9" : ""; // điều kiện ? đúng : sai, mã hex của icon cái cờ
                btn.BackgroundImage = btn.IsFlagged ? Properties.Resources.flag : Properties.Resources.title;
                btn.BackgroundImageLayout = ImageLayout.Stretch;

                if (btn.IsFlagged) // nếu đang cắm cờ, trừ số mìn đi 1, ở trên đã đảo trạng thái rồi nên nếu bây giờ là true thì tức là đang cắm cờ
                    lb_BombShow.Text = (int.Parse(lb_BombShow.Text) - 1).ToString();
                else
                    lb_BombShow.Text = (int.Parse(lb_BombShow.Text) + 1).ToString();
                return; // thoát hàm
            }

            // kiểm tra lần click đầu tiên
            if (firstClick)
            {
                // Nếu ô trúng mìn, di chuyển mìn đi nơi khác
                if (btn.IsMine)
                {
                    btn.IsMine = false;

                    while (true)
                    {
                        int nx = rand.Next(rows);
                        int ny = rand.Next(cols);
                        if (!grid[nx, ny].IsMine && (nx != btn.Row || ny != btn.Col))
                        {
                            grid[nx, ny].IsMine = true;
                            break;
                        }
                    }
                }

                CalculateAdjacents();

                firstClick = false; // đánh dấu đã click lần đầu
            }

            Reveal(btn.Row, btn.Col);
            CheckWin();
        }

        private void Reveal(int x, int y) // mở ô
        {
            var btn = grid[x, y]; // lấy button tại vị trí (x,y)
            if (btn.IsRevealed || btn.IsFlagged) return; // đã mở hoặc đã cắm cờ -> thoát hàm
        
            btn.IsRevealed = true; // đánh dấu đã mở
            btn.BackgroundImage = null;  // bỏ ảnh nền (title)
            btn.BackColor = Color.LightGray; // nền ô đã mở
        
            if (btn.IsMine) // nếu là mìn
            {
                btn.BackgroundImage = Properties.Resources.bomb;
                GameOver(); // kết thúc trò chơi
                return;
            }
        
            if (btn.AdjacentMines > 0) // nếu có mìn xung quanh
                CellNumberColor.ApplyStyle(btn);
            else
            {
                CellNumberColor.ApplyStyle(btn);                               //(x - 1, y - 1) (x - 1, y) (x - 1, y + 1)
                int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };                      //  (x, y - 1)     (x, y)     (x, y + 1)
                int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };                      //(x + 1, y - 1) (x + 1, y) (x + 1, y + 1)
                for (int k = 0; k < 8; k++) // k là 8 hướng xung quanh ô (x,y)
                {
                    int ni = x + dx[k], nj = y + dy[k];
                    if (ni >= 0 && nj >= 0 && ni < rows && nj < cols) // kiểm tra trong phạm vi lưới, là có mấy cái ở góc thì chỉ có 3 hướng thôi, mà nếu ko có điều kiện thì nó sẽ tính 8 hướng và mở 8 hướng, nhưng mảng mình thì không có hướng đó nên nó sẽ báo lỗi.
                    Reveal(ni, nj); // đệ quy mở các ô xung quanh
                }
            }
        }
        private void GameOver()
        {
            foreach (var btn in grid)
            {
                if (btn.IsMine)
                    btn.BackgroundImage = Properties.Resources.bomb;
                btn.Enabled = false;
            }
            btn_LogoRestart.BackgroundImage = Properties.Resources.logo_loser;
            btn_LogoRestart.BackgroundImageLayout = ImageLayout.Stretch;
            lbl_Notify.Text = "Game Over!!!";
            tmr_TimeCount.Stop();
        }
        private void btn_LogoRestart_Click(object sender, EventArgs e)
        {
            // Mở lại form chọn độ khó
            var chooseForm = new ChooseDifficulty();
            chooseForm.Show();
            this.Close(); // đóng form game hiện tại
        }

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát trò chơi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CheckWin()
        {
            foreach (var btn in grid)
            {
                if (!btn.IsMine && !btn.IsRevealed) return; // IsMine false và IsRevealed false, nếu còn ô không phải mìn mà chưa mở thì chưa thắng, vd còn 1 ô IsMine = false  và IsRevealed = false, if (!false && !false) -> if (true && true) -> if (true) -> return
            }
            tmr_TimeCount.Stop();
            btn_LogoRestart.BackgroundImage = Properties.Resources.logo_normal;
            btn_LogoRestart.BackgroundImageLayout = ImageLayout.Stretch;
            lbl_Notify.Text = "You're win!!!";
        }
        private void Tmr_TimeCount_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            lb_TimeCount.Text = TimeSpan.FromSeconds(elapsedSeconds).ToString(@"mm\:ss");
        }
    }
}
