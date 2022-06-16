Imports System.Net
Imports System.Web.Http

Public Class denemeController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"sdsd", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As MyRequest) As Object

        Dim adi As String = value.Adi
        Dim soy As String = value.Soyadi
        Dim yas As Integer = value.Yas

        Dim sonuc As String = adi & " " & soy & " " & yas

        Return sonuc
    End Function




    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
