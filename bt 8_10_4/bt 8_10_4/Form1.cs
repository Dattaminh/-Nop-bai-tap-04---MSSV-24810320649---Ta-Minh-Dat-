namespace bt_8_10_4
{
    public partial class Form1 : Form
    {
        private const string TRANG_THAI_TRONG = "TRONG";       
        private const string TRANG_THAI_DANG_CHON = "DANG_CHON"; 
        private const string TRANG_THAI_DA_DAT = "DA_DAT";       

        
        private const decimal GIA_SANG = 100000m;
        private const decimal GIA_TOI = 150000m;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.Items.Clear();
            cboKhungGio.Items.Add("Ca Sáng (100.000 VNĐ / vị trí)");
            cboKhungGio.Items.Add("Ca Tối (150.000 VNĐ / vị trí)");
            cboKhungGio.SelectedIndex = 0;

            
            TaoSoDoViTri(20);

            
            KhoaViTriDaDat(3);
            KhoaViTriDaDat(12);

            CapNhatThongKeRealtime();
        }

        private void TaoSoDoViTri(int soLuongViTri)
        {
            flpSoDo.Controls.Clear();

            for (int i = 1; i <= soLuongViTri; i++)
            {
                Button btnSeat = new Button();
                btnSeat.Name = $"btnSeat_{i}";
                btnSeat.Text = $"Vị trí {i}";
                btnSeat.Size = new Size(80, 60);
                btnSeat.Margin = new Padding(5);
                btnSeat.Cursor = Cursors.Hand;
                btnSeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                
                btnSeat.Tag = TRANG_THAI_TRONG;
                btnSeat.BackColor = Color.LightGray;

                
                btnSeat.Click += ViTri_Click;

                
                flpSoDo.Controls.Add(btnSeat);
            }
        }

        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            string trangThaiHienTai = btn.Tag.ToString();

            
            if (trangThaiHienTai == TRANG_THAI_DA_DAT)
            {
                MessageBox.Show("Vị trí này đã có người đặt trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (trangThaiHienTai == TRANG_THAI_TRONG)
            {
                btn.Tag = TRANG_THAI_DANG_CHON;
                btn.BackColor = Color.LightGreen;
            }
            
            else if (trangThaiHienTai == TRANG_THAI_DANG_CHON)
            {
                btn.Tag = TRANG_THAI_TRONG;
                btn.BackColor = Color.LightGray;
            }

            
            CapNhatThongKeRealtime();
        }

        private void CapNhatThongKeRealtime()
        {
            int soViTriDangChon = 0;

            
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == TRANG_THAI_DANG_CHON)
                {
                    soViTriDangChon++;
                }
            }

            
            decimal donGia = (cboKhungGio.SelectedIndex == 0) ? GIA_SANG : GIA_TOI;
            decimal tongTien = soViTriDangChon * donGia;

           
            lblSoVitriChon.Text = $"Số vị trí đang chọn: {soViTriDangChon}";
            lblTamTinh.Text = $"Tạm tính tiền: {tongTien:#,##0} VNĐ";
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKeRealtime();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soViTriDangChon = 0;
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == TRANG_THAI_DANG_CHON)
                {
                    soViTriDangChon++;
                }
            }

            if (soViTriDangChon == 0)
            {
                MessageBox.Show("Vui lòng click chọn ít nhất 1 vị trí trên sơ đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal donGia = (cboKhungGio.SelectedIndex == 0) ? GIA_SANG : GIA_TOI;
            decimal tongTien = soViTriDangChon * donGia;
            string khungGioText = cboKhungGio.SelectedItem.ToString();

            DialogResult confirm = MessageBox.Show(
                $"XÁC NHẬN ĐẶT BÀN/VỊ TRÍ:\n\n" +
                $"- Khung giờ: {khungGioText}\n" +
                $"- Số lượng: {soViTriDangChon} vị trí\n" +
                $"- Thành tiền: {tongTien:#,##0} VNĐ\n\n" +
                $"Bạn có chắc chắn muốn xác nhận không?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                
                foreach (Control ctrl in flpSoDo.Controls)
                {
                    if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == TRANG_THAI_DANG_CHON)
                    {
                        btn.Tag = TRANG_THAI_DA_DAT;
                        btn.BackColor = Color.Tomato;
                        btn.ForeColor = Color.White;
                    }
                }

                MessageBox.Show("Đặt vị trí thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatThongKeRealtime();
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == TRANG_THAI_DANG_CHON)
                {
                    btn.Tag = TRANG_THAI_TRONG;
                    btn.BackColor = Color.LightGray;
                }
            }

            CapNhatThongKeRealtime();
        }

        private void KhoaViTriDaDat(int sttViTri)
        {
            string btnName = $"btnSeat_{sttViTri}";
            if (flpSoDo.Controls.ContainsKey(btnName))
            {
                Button btn = flpSoDo.Controls[btnName] as Button;
                if (btn != null)
                {
                    btn.Tag = TRANG_THAI_DA_DAT;
                    btn.BackColor = Color.Tomato;
                    btn.ForeColor = Color.White;
                }
            }
        }
    }
}
