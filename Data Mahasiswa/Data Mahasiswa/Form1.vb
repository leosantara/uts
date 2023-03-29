
Imports System.IO.File

Public Class Form1
    Dim dataList As New ArrayList()

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim filePath As String = "D:\Latihan\Desktop\Data Mahasiswa\data.txt"
        LoadDataFromFile2(filePath)
        ' Looping untuk mengakses setiap elemen dalam array
        For i As Integer = 0 To dataList.Count - 1
            ' Menambahkan elemen ke dalam label dengan tanda koma sebagai pemisah
            Label5.Text &= dataList(i) & ", "
        Next

        ' Menghilangkan tanda koma terakhir
        Label5.Text = Label5.Text.TrimEnd(", ")
        ' Membuka dialog untuk memilih file gambar
        Dim imagePath As String = "D:\Latihan\Desktop\Data Mahasiswa\1.png"

        ' Menampilkan gambar di PictureBox
        PictureBox1.Image = Image.FromFile(imagePath)

        dataList.Clear()
    End Sub


    ' Menampilkan gambar di PictureBox

    Private Sub LoadDataFromFile2(ByVal filePath As String)
        ' Mendapatkan data dari file teks
        Dim lines() As String = System.IO.File.ReadAllLines(filePath)

        ' Mendeklarasikan ArrayList untuk menyimpan data


        ' Looping untuk memasukkan setiap data ke dalam ArrayList
        For Each line As String In lines
            Dim data() As String = line.Split(";")
            For Each d As String In data
                dataList.Add(d)
            Next
        Next
    End Sub
End Class
