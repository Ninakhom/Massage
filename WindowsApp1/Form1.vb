Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ConnectDatabase()
        cmd = New MySqlCommand("select * from staff where username=@username and userpassword=@password", conn)
        cmd.Parameters.AddWithValue("@username", txtUname.Text)
        cmd.Parameters.AddWithValue("@password", txtpwd.Text)
        dr = cmd.ExecuteReader()

        If (dr.HasRows) Then
            ' Successful login
            MessageBox.Show("OK")
        Else
            ' Invalid credentials
            MessageBox.Show("ຊື່ແລະລະຫັດບໍ່ຖືກຕ້ອງ")
        End If

        dr.Close()
    End Sub
End Class
