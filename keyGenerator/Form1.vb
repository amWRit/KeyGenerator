Public Class Form1
    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        Dim prodId = productID.Text
        Dim program_id = 2267918298
        Dim prodKey As String = Hex(Encrypt(program_id,
            prodId))
        productKey.Text = prodKey
    End Sub

    ' Simple encryption and decryption.
    Public Shared Function Encrypt(ByVal seed As UInt32, ByVal value _
        As Long) As Long
        Dim rand As New Random(CInt(seed \ 2))
        Dim pass As Long = CInt((value Xor CUInt(UInt32.MaxValue *
        rand.NextDouble())))
        Return pass
    End Function
End Class
