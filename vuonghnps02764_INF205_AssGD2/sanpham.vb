Imports System.Data.SqlClient

Public Class frmSanPham

    Private Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT * FROM SanPham_PS02764
            </sql>
        Connect(Sql, "SanPham_PS02764")
        bsSanPham.DataSource = ds.Tables("SanPham_PS02764")
        dgvSanPham.DataSource = bsSanPham
        bsSanPham.ResetBindings(False)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        FillSP()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                insert into SanPham_PS02764(MaSP, TenSP, MaLoaiSP, HanSuDung, DonGia, MaKH)
                values ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}')
            </sql>

        Sql = String.Format(Sql, txtMaSP.Text, txtTenSP.Text, txtMaLoaiSP.Text, txtHanSD.Text, txtDonGia.Text, txtMaKH.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
           <sql>
                UPDATE      SanPham_PS02764
                SET         TenSP =N'{1}', MaLoaiSP='{2}', HanSuDung='{3}', DonGia='{4}', MaKH='{5}'
                WHERE        (MaSP = '{0}')
            </sql>

        Sql = String.Format(Sql, txtMaSP.Text, txtTenSP.Text, txtMaLoaiSP.Text, txtHanSD.Text, txtDonGia.Text, txtMaKH.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM SanPham_PS02764
                WHERE        (SanPham_PS02764.MaSP = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaSP.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnLamTrang_Click(sender As Object, e As EventArgs) Handles btnLamTrang.Click
        txtDonGia.Clear()
        txtHanSD.Clear()
        txtMaKH.Clear()
        txtMaLoaiSP.Clear()
        txtMaSP.Clear()
        txtTenSP.Clear()
    End Sub

    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnKhachHang.Click
        frmKhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmQuanLyBanHang.Show()
        Me.Hide()
    End Sub
End Class