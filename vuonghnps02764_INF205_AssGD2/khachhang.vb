Imports System.Data.SqlClient

Public Class frmKhachHang

    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM KhachHang_PS02764
            </sql>
        Connect(Sql, "KhachHang_PS02764")
        bsKhachHang.DataSource = ds.Tables("KhachHang_PS02764")
        dgvKhachHang.DataSource = bsKhachHang
        bsKhachHang.ResetBindings(False)
    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        FillKH()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
            <sql>
                insert into KhachHang_PS02764(MaKH, TenKH, SoDienThoai, DiaChi)
                values ('{0}', N'{1}', N'{2}', N'{3}')
            </sql>

        Sql = String.Format(Sql, txtMaKH.Text, txtTenKH.Text, txtSoDienThoai.Text, txtDiaChi.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
            <sql>
                UPDATE      KhachHang_PS02764
                SET         TenKH =N'{1}', SoDienThoai=N'{2}', DiaChi=N'{3}'
                WHERE        (MaKH = '{0}')
            </sql>

        Sql = String.Format(Sql, txtMaKH.Text, txtTenKH.Text, txtSoDienThoai.Text, txtDiaChi.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String =
            <sql>
                DELETE FROM KhachHang_PS02764
                WHERE        (KhachHang_PS02764.MaKH = '{0}')
            </sql>
        Sql = String.Format(Sql, txtMaKH.Text)

        ExecuteNonQuery(Sql)

        FillKH()
    End Sub

    Private Sub btnLamTrang_Click(sender As Object, e As EventArgs) Handles btnLamTrang.Click
        txtDiaChi.Clear()
        txtMaKH.Clear()
        txtSoDienThoai.Clear()
        txtTenKH.Clear()
    End Sub

    Private Sub btnSanPham_Click(sender As Object, e As EventArgs) Handles btnSanPham.Click
        frmSanPham.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmQuanLyBanHang.Show()
        Me.Hide()
    End Sub

    Private Sub dgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellContentClick
        Try
            Dim RowView As DataRowView = bsKhachHang.Current
            Dim Row As DataRow = RowView.Row

            txtMaKH.Text = Row("MaKH")
            txtTenKH.Text = Row("TenKH")
            txtSoDienThoai.Text = Row("SoDienThoai")
            txtDiaChi.Text = Row("DiaChi")
        Catch ex As Exception

        End Try
    End Sub
End Class