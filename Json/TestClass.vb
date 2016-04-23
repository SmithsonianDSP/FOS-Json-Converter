Public Class TestClass
    Public Shared Sub RunOutput()
        Dim NewTest As New ProcessJson("E:\Visual Studio Projects\FOS Json Converter\Vault1.json",
                                       "E:\Visual Studio Projects\FOS Json Converter\Output Test 1.csv")


        Process.Start("E:\Visual Studio Projects\FOS Json Converter\Output Test 1.csv")

    End Sub
End Class
