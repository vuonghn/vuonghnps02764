<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyBanHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyBanHang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSanPham = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'btnKhachHang
        '
        Me.btnKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhachHang.ForeColor = System.Drawing.Color.Red
        Me.btnKhachHang.Location = New System.Drawing.Point(13, 13)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Size = New System.Drawing.Size(87, 35)
        Me.btnKhachHang.TabIndex = 1
        Me.btnKhachHang.Text = "Khách Hàng"
        Me.btnKhachHang.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Giảng viên: Lê Văn Phụng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(447, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Trình bày: Hồ Nhân Vương"
        '
        'btnSanPham
        '
        Me.btnSanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSanPham.ForeColor = System.Drawing.Color.Red
        Me.btnSanPham.Location = New System.Drawing.Point(106, 12)
        Me.btnSanPham.Name = "btnSanPham"
        Me.btnSanPham.Size = New System.Drawing.Size(87, 35)
        Me.btnSanPham.TabIndex = 1
        Me.btnSanPham.Text = "Sản Phẩm"
        Me.btnSanPham.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.DimGray
        Me.btnThoat.Location = New System.Drawing.Point(710, 12)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 35)
        Me.btnThoat.TabIndex = 1
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmQuanLyBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(809, 323)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnSanPham)
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuanLyBanHang"
        Me.Text = "Quản Lý Bán Hàng"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKhachHang As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSanPham As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button

End Class
