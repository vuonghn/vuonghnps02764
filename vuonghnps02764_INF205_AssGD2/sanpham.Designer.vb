<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHanSuDung = New System.Windows.Forms.Label()
        Me.lblMaLoaiSP = New System.Windows.Forms.Label()
        Me.lblTenSP = New System.Windows.Forms.Label()
        Me.lblMaSanPham = New System.Windows.Forms.Label()
        Me.txtHanSD = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLamTrang = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.bsSanPham = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.lblDonGia = New System.Windows.Forms.Label()
        Me.lblMaKhachHang = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHanSuDung
        '
        Me.lblHanSuDung.AutoSize = True
        Me.lblHanSuDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHanSuDung.Location = New System.Drawing.Point(55, 162)
        Me.lblHanSuDung.Name = "lblHanSuDung"
        Me.lblHanSuDung.Size = New System.Drawing.Size(98, 16)
        Me.lblHanSuDung.TabIndex = 19
        Me.lblHanSuDung.Text = "Hạn Sử Dụng"
        '
        'lblMaLoaiSP
        '
        Me.lblMaLoaiSP.AutoSize = True
        Me.lblMaLoaiSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaLoaiSP.Location = New System.Drawing.Point(25, 112)
        Me.lblMaLoaiSP.Name = "lblMaLoaiSP"
        Me.lblMaLoaiSP.Size = New System.Drawing.Size(137, 16)
        Me.lblMaLoaiSP.TabIndex = 18
        Me.lblMaLoaiSP.Text = "Mã Loại Sản Phẩm"
        '
        'lblTenSP
        '
        Me.lblTenSP.AutoSize = True
        Me.lblTenSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenSP.Location = New System.Drawing.Point(25, 62)
        Me.lblTenSP.Name = "lblTenSP"
        Me.lblTenSP.Size = New System.Drawing.Size(109, 16)
        Me.lblTenSP.TabIndex = 17
        Me.lblTenSP.Text = "Tên Sản Phẩm"
        '
        'lblMaSanPham
        '
        Me.lblMaSanPham.AutoSize = True
        Me.lblMaSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaSanPham.Location = New System.Drawing.Point(7, 19)
        Me.lblMaSanPham.Name = "lblMaSanPham"
        Me.lblMaSanPham.Size = New System.Drawing.Size(103, 16)
        Me.lblMaSanPham.TabIndex = 16
        Me.lblMaSanPham.Text = "Mã Sản Phẩm"
        '
        'txtHanSD
        '
        Me.txtHanSD.Location = New System.Drawing.Point(10, 181)
        Me.txtHanSD.Multiline = True
        Me.txtHanSD.Name = "txtHanSD"
        Me.txtHanSD.Size = New System.Drawing.Size(162, 25)
        Me.txtHanSD.TabIndex = 14
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(10, 131)
        Me.txtMaLoaiSP.Multiline = True
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(162, 25)
        Me.txtMaLoaiSP.TabIndex = 13
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(12, 81)
        Me.txtTenSP.Multiline = True
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(162, 25)
        Me.txtTenSP.TabIndex = 12
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(178, 62)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(108, 44)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(178, 298)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 30)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Quản Lý"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLamTrang
        '
        Me.btnLamTrang.Location = New System.Drawing.Point(178, 212)
        Me.btnLamTrang.Name = "btnLamTrang"
        Me.btnLamTrang.Size = New System.Drawing.Size(108, 44)
        Me.btnLamTrang.TabIndex = 8
        Me.btnLamTrang.Text = "Làm trắng"
        Me.btnLamTrang.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(178, 162)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(108, 44)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(178, 112)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(108, 44)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(178, 12)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(108, 44)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnKhachHang
        '
        Me.btnKhachHang.Location = New System.Drawing.Point(178, 265)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Size = New System.Drawing.Size(108, 27)
        Me.btnKhachHang.TabIndex = 10
        Me.btnKhachHang.Text = "Khách Hàng"
        Me.btnKhachHang.UseVisualStyleBackColor = True
        '
        'dgvSanPham
        '
        Me.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(292, 12)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.Size = New System.Drawing.Size(505, 316)
        Me.dgvSanPham.TabIndex = 4
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(121, 12)
        Me.txtMaSP.Multiline = True
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(51, 30)
        Me.txtMaSP.TabIndex = 20
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(10, 231)
        Me.txtDonGia.Multiline = True
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(162, 25)
        Me.txtDonGia.TabIndex = 14
        '
        'lblDonGia
        '
        Me.lblDonGia.AutoSize = True
        Me.lblDonGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonGia.Location = New System.Drawing.Point(55, 212)
        Me.lblDonGia.Name = "lblDonGia"
        Me.lblDonGia.Size = New System.Drawing.Size(63, 16)
        Me.lblDonGia.TabIndex = 19
        Me.lblDonGia.Text = "Đơn Giá"
        '
        'lblMaKhachHang
        '
        Me.lblMaKhachHang.AutoSize = True
        Me.lblMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKhachHang.Location = New System.Drawing.Point(7, 276)
        Me.lblMaKhachHang.Name = "lblMaKhachHang"
        Me.lblMaKhachHang.Size = New System.Drawing.Size(116, 16)
        Me.lblMaKhachHang.TabIndex = 16
        Me.lblMaKhachHang.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(121, 269)
        Me.txtMaKH.Multiline = True
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(51, 30)
        Me.txtMaKH.TabIndex = 20
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 335)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.lblDonGia)
        Me.Controls.Add(Me.lblHanSuDung)
        Me.Controls.Add(Me.lblMaLoaiSP)
        Me.Controls.Add(Me.lblTenSP)
        Me.Controls.Add(Me.lblMaKhachHang)
        Me.Controls.Add(Me.lblMaSanPham)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtHanSD)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLamTrang)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.bsSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHanSuDung As System.Windows.Forms.Label
    Friend WithEvents lblMaLoaiSP As System.Windows.Forms.Label
    Friend WithEvents lblTenSP As System.Windows.Forms.Label
    Friend WithEvents lblMaSanPham As System.Windows.Forms.Label
    Friend WithEvents txtHanSD As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLamTrang As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents bsSanPham As System.Windows.Forms.BindingSource
    Friend WithEvents btnKhachHang As System.Windows.Forms.Button
    Friend WithEvents dgvSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents lblDonGia As System.Windows.Forms.Label
    Friend WithEvents lblMaKhachHang As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
End Class
