using System.Security.Policy;

namespace giao_diện_bán_hàng
{
    public partial class Form1 : Form
    {

        // Danh sách các sản phẩm (Ví dụ)
        List<SanPham> danhsach = new List<SanPham>();

        // Giỏ hàng
        List<SanPham> giohang = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
            danhsach.Add(new SanPham { Ten = "Sản phẩm A", Hinhanh = " ", Gia = 10000, Soluong = 5 });
            danhsach.Add(new SanPham { Ten = "Sản phẩm B", Hinhanh = " ", Gia = 20000, Soluong = 4 });
            danhsach.Add(new SanPham { Ten = "Sản phẩm C", Hinhanh = " ", Gia = 40000, Soluong = 2 });
            danhsach.Add(new SanPham { Ten = "Sản phẩm D", Hinhanh = " ", Gia = 5000, Soluong = 1 });
            danhsach.Add(new SanPham { Ten = "Sản phẩm E", Hinhanh = " ", Gia = 300000, Soluong = 7 });

            // Hiển thị danh sách sản phẩm lên DataGridView
            dataGridViewsanpham.DataSource = danhsach;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy index của hàng đang được chọn trong DataGridView giỏ hàng
            int rowIndex = dataGridViewgiohang.CurrentRow.Index;

            // Lấy sản phẩm cần xóa
            SanPham sanPhamXoa = giohang[rowIndex];
            // Tìm sản phẩm tương ứng trong danh sách sản phẩm
            int indexSanPhamTrongDanhSach = danhsach.FindIndex(sp => sp.Ten == sanPhamXoa.Ten);
            if (sanPhamXoa.Soluong > 1) { sanPhamXoa.Soluong--; }
            else
            {
                // Xóa sản phẩm khỏi giỏ hàng
                giohang.RemoveAt(rowIndex);
            }
            // Nếu tìm thấy sản phẩm, tăng số lượng lên 1
            if (indexSanPhamTrongDanhSach != -1)
            {
                danhsach[indexSanPhamTrongDanhSach].Soluong++;

                // Cập nhật lại DataGridView danh sách sản phẩm
                dataGridViewsanpham.Refresh();
            }

            // Cập nhật lại DataGridView giỏ hàng
            dataGridViewgiohang.DataSource = null;
            dataGridViewgiohang.DataSource = giohang;
            TinhTong();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewsanpham.CurrentRow.Index;
            var sanPham = danhsach[rowIndex];
            if (sanPham.Soluong == 0)
            {
                MessageBox.Show("Sản phẩm đã đạt số lượng tối đa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi hàm nếu số lượng bằng 0
            }
            SanPham sanPhamGioHang = new SanPham
            {
                Ten = sanPham.Ten,
                Hinhanh = sanPham.Hinhanh,
                Gia = sanPham.Gia,
                Soluong = 1
            };
            int indexsptronggio = giohang.FindIndex(sp => sp.Ten == sanPham.Ten);

            // Nếu tìm thấy sản phẩm, tăng số lượng lên 1
            if (indexsptronggio != -1)
            {
                giohang[indexsptronggio].Soluong++;

            }
            else
            {
                // Thêm sản phẩm vào giỏ hàng
                giohang.Add(sanPhamGioHang);

            }

            // Giảm số lượng sản phẩm trong danh sách
            sanPham.Soluong--;
            // Cập nhật lại DataGridView của giỏ hàng
            dataGridViewgiohang.DataSource = null;
            dataGridViewgiohang.DataSource = giohang;

            // Cập nhật lại DataGridView
            dataGridViewsanpham.Refresh();
            // Tính toán tổng
            TinhTong();
        }
        private void TinhTong()
        {
            int tongSoLuong = 0;
            decimal tongGiaTri = 0;

            foreach (SanPham sanPham in giohang)
            {
                tongSoLuong += sanPham.Soluong;
                tongGiaTri += sanPham.Gia * sanPham.Soluong;
            }

            // Cập nhật giao diện (ví dụ: sử dụng các label)
            txtsoluong.Text = tongSoLuong.ToString();
            txtthanhtien.Text = tongGiaTri.ToString("C"); // Định dạng tiền tệ

        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (result == DialogResult.Yes)
            {
                // Xóa giỏ hàng
                giohang.Clear();
                  // Cập nhật giao diện
                dataGridViewgiohang.DataSource = null;
                txtthanhtien.Text = "0";
                txtsoluong.Text = "0";

                MessageBox.Show("Đơn hàng của bạn đã được đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
public class SanPham
{
    public string Ten { get; set; }
    public string Hinhanh { get; set; }
    public decimal Gia { get; set; }

    public int Soluong {  get; set; }
}

