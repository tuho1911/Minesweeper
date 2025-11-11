using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class CellButton: Button
    {
        public int Row { get; set; } //Vị trí hàng
        public int Col { get; set; } //Vị trí cột
        public bool IsMine { get; set; } //Có phải mìn không
        public bool IsRevealed { get; set; } //Đã được mở chưa
        public bool IsFlagged { get; set; } //Đã được cắm cờ chưa
        public int AdjacentMines { get; set; } //Số mìn xung quanh
    }
}
