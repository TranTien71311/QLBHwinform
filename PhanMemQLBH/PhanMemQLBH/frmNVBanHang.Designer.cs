namespace PhanMemQLBH
{
    partial class frmNVBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbeSoLuong = new DevComponents.DotNetBar.LabelX();
            this.butLuu = new DevComponents.DotNetBar.ButtonX();
            this.buthemHD = new DevComponents.DotNetBar.ButtonX();
            this.cbbMaSP = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bntReset = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cbbMaKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.label = new DevComponents.DotNetBar.LabelX();
            this.txtMaHD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.butTim = new DevComponents.DotNetBar.ButtonX();
            this.txtThanhTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnKhachHang = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.txtDonGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSoLuong = new DevComponents.DotNetBar.PanelEx();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.panelEx1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx5.SuspendLayout();
            this.txtSoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbeSoLuong
            // 
            this.lbeSoLuong.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbeSoLuong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbeSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeSoLuong.Location = new System.Drawing.Point(223, 129);
            this.lbeSoLuong.Name = "lbeSoLuong";
            this.lbeSoLuong.Size = new System.Drawing.Size(185, 37);
            this.lbeSoLuong.TabIndex = 41;
            // 
            // butLuu
            // 
            this.butLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.butLuu.Enabled = false;
            this.butLuu.Image = global::PhanMemQLBH.Properties.Resources.icons8_checked_40;
            this.butLuu.Location = new System.Drawing.Point(307, 174);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(131, 45);
            this.butLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butLuu.TabIndex = 32;
            this.butLuu.Text = "Thanh Toán";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // buthemHD
            // 
            this.buthemHD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buthemHD.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buthemHD.Enabled = false;
            this.buthemHD.Image = global::PhanMemQLBH.Properties.Resources.icons8_plus_40;
            this.buthemHD.Location = new System.Drawing.Point(32, 174);
            this.buthemHD.Name = "buthemHD";
            this.buthemHD.Size = new System.Drawing.Size(131, 45);
            this.buthemHD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buthemHD.TabIndex = 36;
            this.buthemHD.Text = "Thêm Hóa Đơn";
            this.buthemHD.Click += new System.EventHandler(this.buthemHD_Click);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.DisplayMember = "Text";
            this.cbbMaSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.ItemHeight = 21;
            this.cbbMaSP.Location = new System.Drawing.Point(197, 11);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(241, 27);
            this.cbbMaSP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbMaSP.TabIndex = 32;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtMaNV);
            this.panelEx1.Controls.Add(this.txtTongTien);
            this.panelEx1.Controls.Add(this.bntReset);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.dtpNgayBan);
            this.panelEx1.Controls.Add(this.cbbMaKH);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.label);
            this.panelEx1.Controls.Add(this.txtMaHD);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Controls.Add(this.butThem);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(4, 68);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(431, 270);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 11;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(173, 52);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PreventEnterBeep = true;
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(241, 23);
            this.txtMaNV.TabIndex = 44;
            // 
            // txtTongTien
            // 
            // 
            // 
            // 
            this.txtTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(173, 231);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PreventEnterBeep = true;
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(241, 23);
            this.txtTongTien.TabIndex = 28;
            // 
            // bntReset
            // 
            this.bntReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntReset.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.bntReset.Image = global::PhanMemQLBH.Properties.Resources.icons8_restart_40;
            this.bntReset.Location = new System.Drawing.Point(283, 174);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(131, 45);
            this.bntReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntReset.TabIndex = 40;
            this.bntReset.Text = "Reset";
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(3, 225);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(142, 37);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Tổng Tiền";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(173, 142);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(241, 26);
            this.dtpNgayBan.TabIndex = 26;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DisplayMember = "Text";
            this.cbbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.ItemHeight = 21;
            this.cbbMaKH.Location = new System.Drawing.Point(173, 99);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(241, 27);
            this.cbbMaKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbMaKH.TabIndex = 25;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(3, 132);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(142, 37);
            this.labelX5.TabIndex = 23;
            this.labelX5.Text = "Ngày Bán";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(3, 89);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(164, 37);
            this.labelX4.TabIndex = 22;
            this.labelX4.Text = "Tên Khách Hàng";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 37);
            this.label.TabIndex = 21;
            this.label.Text = "Mã Nhân Viên";
            // 
            // txtMaHD
            // 
            // 
            // 
            // 
            this.txtMaHD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(173, 11);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PreventEnterBeep = true;
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(241, 23);
            this.txtMaHD.TabIndex = 20;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(3, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(142, 37);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Mã Hóa Đơn";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx4.Location = new System.Drawing.Point(444, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(447, 241);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 18;
            this.panelEx4.Text = "panelEx4";
            // 
            // butThem
            // 
            this.butThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.butThem.Image = global::PhanMemQLBH.Properties.Resources.icons8_plus_40;
            this.butThem.Location = new System.Drawing.Point(3, 174);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(131, 45);
            this.butThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butThem.TabIndex = 2;
            this.butThem.Text = "Tạo Hóa Đơn";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(32, 131);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(185, 37);
            this.labelX11.TabIndex = 40;
            this.labelX11.Text = "Số Lượng Sản Phẩm Còn :";
            // 
            // butTim
            // 
            this.butTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butTim.BackColor = System.Drawing.Color.Transparent;
            this.butTim.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.butTim.Image = global::PhanMemQLBH.Properties.Resources.icons8_search_40;
            this.butTim.Location = new System.Drawing.Point(577, 2);
            this.butTim.Name = "butTim";
            this.butTim.Size = new System.Drawing.Size(46, 45);
            this.butTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butTim.TabIndex = 10;
            this.butTim.Click += new System.EventHandler(this.butTim_Click);
            // 
            // txtThanhTien
            // 
            // 
            // 
            // 
            this.txtThanhTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(197, 227);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PreventEnterBeep = true;
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(241, 23);
            this.txtThanhTien.TabIndex = 31;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(2, -4);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1042, 35);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 67;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelX1.Location = new System.Drawing.Point(472, -10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(140, 48);
            this.labelX1.SymbolColor = System.Drawing.Color.White;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Bán Hàng";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnKhachHang);
            this.panelEx2.Controls.Add(this.btnThoat);
            this.panelEx2.Controls.Add(this.buttonX1);
            this.panelEx2.Controls.Add(this.btnTroVe);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(2, 28);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(159, 477);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 66;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKhachHang.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnKhachHang.Image = global::PhanMemQLBH.Properties.Resources.icons8_contacts_40;
            this.btnKhachHang.Location = new System.Drawing.Point(4, 57);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(152, 45);
            this.btnKhachHang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKhachHang.TabIndex = 25;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThoat.Image = global::PhanMemQLBH.Properties.Resources.icons8_cancel_404;
            this.btnThoat.Location = new System.Drawing.Point(3, 429);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 45);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Red;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = global::PhanMemQLBH.Properties.Resources.icons8_check_401;
            this.buttonX1.Location = new System.Drawing.Point(4, 9);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(152, 45);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 23;
            this.buttonX1.Text = "In Hóa Đơn";
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnTroVe.Image = global::PhanMemQLBH.Properties.Resources.icons8_restart_401;
            this.btnTroVe.Location = new System.Drawing.Point(4, 108);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(152, 45);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 22;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx5.Controls.Add(this.lbeSoLuong);
            this.panelEx5.Controls.Add(this.labelX11);
            this.panelEx5.Controls.Add(this.butLuu);
            this.panelEx5.Controls.Add(this.buthemHD);
            this.panelEx5.Controls.Add(this.cbbMaSP);
            this.panelEx5.Controls.Add(this.txtThanhTien);
            this.panelEx5.Controls.Add(this.txtDonGia);
            this.panelEx5.Controls.Add(this.txtSoL);
            this.panelEx5.Controls.Add(this.labelX10);
            this.panelEx5.Controls.Add(this.labelX9);
            this.panelEx5.Controls.Add(this.labelX8);
            this.panelEx5.Controls.Add(this.labelX7);
            this.panelEx5.Controls.Add(this.panelEx6);
            this.panelEx5.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx5.Location = new System.Drawing.Point(433, 68);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(445, 270);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 18;
            // 
            // txtDonGia
            // 
            // 
            // 
            // 
            this.txtDonGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(198, 95);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PreventEnterBeep = true;
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(241, 23);
            this.txtDonGia.TabIndex = 30;
            // 
            // txtSoL
            // 
            // 
            // 
            // 
            this.txtSoL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoL.Location = new System.Drawing.Point(197, 55);
            this.txtSoL.Name = "txtSoL";
            this.txtSoL.PreventEnterBeep = true;
            this.txtSoL.Size = new System.Drawing.Size(241, 23);
            this.txtSoL.TabIndex = 29;
            this.txtSoL.TextChanged += new System.EventHandler(this.txtSoL_TextChanged);
            this.txtSoL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoL_KeyPress);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(32, 225);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(142, 37);
            this.labelX10.TabIndex = 25;
            this.labelX10.Text = "Thành Tiền";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(32, 89);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(142, 37);
            this.labelX9.TabIndex = 24;
            this.labelX9.Text = "Đơn Giá";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(32, 45);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(142, 37);
            this.labelX8.TabIndex = 23;
            this.labelX8.Text = "Số Lượng";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(32, 5);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(159, 37);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "Tên Sản Phẩm";
            // 
            // panelEx6
            // 
            this.panelEx6.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx6.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx6.Location = new System.Drawing.Point(444, 0);
            this.panelEx6.Name = "panelEx6";
            this.panelEx6.Size = new System.Drawing.Size(447, 241);
            this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx6.Style.GradientAngle = 90;
            this.panelEx6.TabIndex = 18;
            this.panelEx6.Text = "panelEx6";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(223, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PreventEnterBeep = true;
            this.txtTimKiem.Size = new System.Drawing.Size(348, 29);
            this.txtTimKiem.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.CanvasColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSoLuong.Controls.Add(this.dgvBanHang);
            this.txtSoLuong.Controls.Add(this.panelEx5);
            this.txtSoLuong.Controls.Add(this.panelEx1);
            this.txtSoLuong.Controls.Add(this.butTim);
            this.txtSoLuong.Controls.Add(this.txtTimKiem);
            this.txtSoLuong.DisabledBackColor = System.Drawing.Color.Empty;
            this.txtSoLuong.Location = new System.Drawing.Point(163, 28);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(881, 477);
            this.txtSoLuong.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.txtSoLuong.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtSoLuong.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtSoLuong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.txtSoLuong.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.txtSoLuong.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.txtSoLuong.Style.GradientAngle = 90;
            this.txtSoLuong.TabIndex = 65;
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHang.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Location = new System.Drawing.Point(4, 336);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.Size = new System.Drawing.Size(874, 141);
            this.dgvBanHang.TabIndex = 19;
            this.dgvBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHang_CellClick);
            // 
            // frmNVBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 505);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.txtSoLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNVBanHang";
            this.Text = "frmNVBanHang";
            this.Load += new System.EventHandler(this.frmNVBanHang_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx5.ResumeLayout(false);
            this.txtSoLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbeSoLuong;
        private DevComponents.DotNetBar.ButtonX butLuu;
        private DevComponents.DotNetBar.ButtonX buthemHD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbMaSP;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
        private DevComponents.DotNetBar.ButtonX bntReset;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbMaKH;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX label;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.ButtonX butThem;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX butTim;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThanhTien;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDonGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoL;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.PanelEx panelEx6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.PanelEx txtSoLuong;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHD;
        private DevComponents.DotNetBar.ButtonX btnKhachHang;
    }
}