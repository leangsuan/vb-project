Imports System.Data
Imports System.Data.SqlClient

Module Module1

    Friend constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb\project\project\Dormitory.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"

    '-- สร้างอินสแตนซ์ของคลาสของ ADO.NET เพื่อให้สะดวกต่อการนำไปใช้งาน
    Friend connection As SqlConnection
    Friend command As SqlCommand
    Friend dataSt As DataSet
    Friend adapter As SqlDataAdapter
    Friend bindingSrc As BindingSource
    Friend reader As SqlDataReader
    Friend sql As String

    '-- ฟังก์ชันสำหรับตรวจสอบว่าเป็นเลขจำนวนเต็มหรือไม่
    Friend Function IsInteger(ByVal num As Double) As Boolean
        If num Mod 1 <> 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Module
