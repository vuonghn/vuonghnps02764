<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.bsKhachHang = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLamTrang = New System.Windows.Forms.Button()
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.lblMaKhachHang = New System.Windows.Forms.Label()
        Me.lblTenKhachHang = New System.Windows.Forms.Label()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.lblSoDienThoai = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.lblDiaChi = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.Location = New System.Drawing.Point(286, 12)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.Size = New System.Drawing.Size(505, 316)
        Me.dgvKhachHang.TabIndex = 0
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(172, 12)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(108, 44)
        Me.btnCapNhat.TabIndex = 1
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(172, 112)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(108, 44)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(172, 62)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(108, 44)
        Me.btnThem.TabIndex = 1
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(172, 162)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(108, 44)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLamTrang
        '
        Me.btnLamTrang.Location = New System.Drawing.Point(172, 212)
        Me.btnLamTrang.Name = "btnLamTrang"
        Me.btnLamTrang.Size = New System.Drawing.Size(108, 44)
        Me.btnLamTrang.TabIndex = 1
        Me.btnLamTrang.Text = "Làm trắng"
        Me.btnLamTrang.UseVisualStyleBackColor = True
        '
        'btnSanPham
        '
        Me.btnSanPham.Location = New System.Drawing.Point(172, 265)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(108, 27)
        Me.btnSanPham.TabIndex = 1
        Me.btnSanPham.Text = "Sản Phẩm"
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(4, 32)
        Me.txtMaKH.Multiline = True
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(162, 44)
        Me.txtMaKH.TabIndex = 2
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(4, 109)
        Me.txtTenKH.Multiline = True
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(162, 44)
        Me.txtTenKH.TabIndex = 2
        '
        'lblMaKhachHang
        '
        Me.lblMaKhachHang.AutoSize = True
        Me.lblMaKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaKhachHang.Location = New System.Drawing.Point(13, 13)
        Me.lblMaKhachHang.Name = "lblMaKhachHang"
        Me.lblMaKhachHang.Size = New System.Drawing.Size(116, 16)
        Me.lblMaKhachHang.TabIndex = 3
        Me.lblMaKhachHang.Text = "Mã Khách Hàng"
        '
        'lblTenKhachHang
        '
        Me.lblTenKhachHang.AutoSize = True
        Me.lblTenKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenKhachHang.Location = New System.Drawing.Point(13, 90)
        Me.lblTenKhachHang.Name = "lblTenKhachHang"
        Me.lblTenKhachHang.Size = New System.Drawing.Size(122, 16)
        Me.lblTenKhachHang.TabIndex = 3
        Me.lblTenKhachHang.Text = "Tên Khách Hàng"
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(4, 187)
        Me.txtSoDienThoai.Multiline = True
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(162, 44)
        Me.txtSoDienThoai.TabIndex = 2
        '
        'lblSoDienThoai
        '
        Me.lblSoDienThoai.AutoSize = True
        Me.lblSoDienThoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoDienThoai.Location = New System.Drawing.Point(13, 168)
        Me.lblSoDienThoai.Name = "lblSoDienThoai"
        Me.lblSoDienThoai.Size = New System.Drawing.Size(106, 16)
        Me.lblSoDienThoai.TabIndex = 3
        Me.lblSoDienThoai.Text = "Số Điện Thoại"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(4, 265)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(162, 63)
        Me.txtDiaChi.TabIndex = 2
        '
        'lblDiaChi
        '
        Me.lblDiaChi.AutoSize = True
        Me.lblDiaChi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaChi.Location = New System.Drawing.Point(13, 246)
        Me.lblDiaChi.Name = "lblDiaChi"
        Me.lblDiaChi.Size = New System.Drawing.Size(57, 16)
        Me.lblDiaChi.TabIndex = 3
        Me.lblDiaChi.Text = "Địa Chỉ"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(172, 298)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Quản Lý"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 340)
        Me.Controls.Add(Me.lblDiaChi)
        Me.Controls.Add(Me.lblSoDienThoai)
        Me.Controls.Add(Me.lblTenKhachHang)
        Me.Controls.Add(Me.lblMaKhachHang)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnLamTrang)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvKhachHang As System.Windows.Forms.DataGridView
    Friend WithEvents bsKhachHang As System.Windows.Forms.BindingSource
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnLamTrang As System.Windows.Forms.Button
    Friend WithEvents btnSanPham As System.Windows.Forms.Button
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents lblMaKhachHang As System.Windows.Forms.Label
    Friend WithEvents lblTenKhachHang As System.Windows.Forms.Label
    Friend WithEvents txtSoDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents lblSoDienThoai As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaChi As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
