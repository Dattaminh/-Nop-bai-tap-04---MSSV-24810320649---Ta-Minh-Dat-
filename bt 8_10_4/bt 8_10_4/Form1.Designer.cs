namespace bt_8_10_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbSoDo = new GroupBox();
            flpSoDo = new FlowLayoutPanel();
            gbThongKe = new GroupBox();
            lblKhungGio = new Label();
            cboKhungGio = new ComboBox();
            lblSoVitriChon = new Label();
            lblTamTinh = new Label();
            btnXacNhan = new Button();
            btnHuyChon = new Button();

            gbSoDo.SuspendLayout();
            gbThongKe.SuspendLayout();
            SuspendLayout();

            // 
            // gbSoDo
            // 
            gbSoDo.Controls.Add(flpSoDo);
            gbSoDo.Location = new Point(20, 20);
            gbSoDo.Name = "gbSoDo";
            gbSoDo.Size = new Size(470, 360);
            gbSoDo.TabIndex = 0;
            gbSoDo.TabStop = false;
            gbSoDo.Text = "Sơ đồ vị trí (4 x 5)";

            // 
            // flpSoDo
            // 
            flpSoDo.AutoScroll = true;
            flpSoDo.Dock = DockStyle.Fill;
            flpSoDo.Location = new Point(3, 23);
            flpSoDo.Name = "flpSoDo";
            flpSoDo.Padding = new Padding(10);
            flpSoDo.Size = new Size(464, 334);
            flpSoDo.TabIndex = 0;

            // 
            // gbThongKe
            // 
            gbThongKe.Controls.Add(lblKhungGio);
            gbThongKe.Controls.Add(cboKhungGio);
            gbThongKe.Controls.Add(lblSoVitriChon);
            gbThongKe.Controls.Add(lblTamTinh);
            gbThongKe.Controls.Add(btnXacNhan);
            gbThongKe.Controls.Add(btnHuyChon);
            gbThongKe.Location = new Point(510, 20);
            gbThongKe.Name = "gbThongKe";
            gbThongKe.Size = new Size(320, 360);
            gbThongKe.TabIndex = 1;
            gbThongKe.TabStop = false;
            gbThongKe.Text = "Thống kê & Đặt bàn";

            // lblKhungGio
            lblKhungGio.AutoSize = true;
            lblKhungGio.Location = new Point(20, 40);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Size = new Size(116, 20);
            lblKhungGio.Text = "Chọn khung giờ:";

            // cboKhungGio
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(20, 70);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(280, 28);
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;

            // lblSoVitriChon
            lblSoVitriChon.AutoSize = true;
            lblSoVitriChon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSoVitriChon.ForeColor = Color.DarkBlue;
            lblSoVitriChon.Location = new Point(20, 130);
            lblSoVitriChon.Name = "lblSoVitriChon";
            lblSoVitriChon.Size = new Size(192, 23);
            lblSoVitriChon.Text = "Số vị trí đang chọn: 0";

            // lblTamTinh
            lblTamTinh.AutoSize = true;
            lblTamTinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTamTinh.ForeColor = Color.DarkGreen;
            lblTamTinh.Location = new Point(20, 170);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(187, 25);
            lblTamTinh.Text = "Tạm tính tiền: 0 VNĐ";

            // btnXacNhan
            btnXacNhan.BackColor = Color.LightSkyBlue;
            btnXacNhan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXacNhan.Location = new Point(20, 230);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(280, 45);
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;

            // btnHuyChon
            btnHuyChon.Location = new Point(20, 290);
            btnHuyChon.Name = "btnHuyChon";
            btnHuyChon.Size = new Size(280, 40);
            btnHuyChon.Text = "Hủy chọn tất cả";
            btnHuyChon.UseVisualStyleBackColor = true;
            btnHuyChon.Click += btnHuyChon_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 400);
            Controls.Add(gbThongKe);
            Controls.Add(gbSoDo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            Load += Form1_Load;
            gbSoDo.ResumeLayout(false);
            gbThongKe.ResumeLayout(false);
            gbThongKe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbSoDo;
        private FlowLayoutPanel flpSoDo;
        private GroupBox gbThongKe;
        private Label lblKhungGio;
        private ComboBox cboKhungGio;
        private Label lblSoVitriChon;
        private Label lblTamTinh;
        private Button btnXacNhan;
        private Button btnHuyChon;
    }
}