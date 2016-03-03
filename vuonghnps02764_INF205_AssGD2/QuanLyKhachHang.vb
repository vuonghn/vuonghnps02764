Public Class frmQuanLyBanHang

    
    Private Sub btnKhachHang_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        frmKhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmSanPham.Show()
        Me.Hide()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub frmQuanLyBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
