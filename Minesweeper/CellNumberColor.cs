using Minesweeper;
using System.Drawing;
using System.Windows.Forms;

public class CellNumberColor
{
    public static void ApplyStyle(CellButton btn) // Áp dụng kiểu cho ô
    {
        btn.UseVisualStyleBackColor = false; // không dùng kiểu mặc định
        btn.FlatStyle = FlatStyle.Flat; // kiểu nút phẳng
        btn.FlatAppearance.BorderSize = 1; // bỏ viền
        btn.FlatAppearance.BorderColor = Color.DarkGray; // màu viền

        if (btn.AdjacentMines > 0) // nếu có mìn xung quanh
        {
            btn.Text = btn.AdjacentMines.ToString(); // hiện số mìn
            btn.Font = new Font("Britannic", 14, FontStyle.Bold); // font chữ
            btn.ForeColor = GetColorForNumber(btn.AdjacentMines); // màu chữ theo số
            btn.BackColor = Color.LightGray; // nền ô đã mở
        }
        else // nếu không có mìn xung quanh
        {
            btn.Text = "";
            btn.BackColor = Color.LightGray; // ô trống
        }
    }

    private static Color GetColorForNumber(int n) // lấy màu theo số
    {
        switch (n)
        {
            case 1: return Color.Blue;
            case 2: return Color.Green;
            case 3: return Color.Red;
            case 4: return Color.DarkBlue;
            case 5: return Color.Brown;
            case 6: return Color.Teal;
            case 7: return Color.Black;
            case 8: return Color.Gray;
            default: return Color.Black;
        }
    }
}
