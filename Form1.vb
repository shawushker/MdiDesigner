Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim designerForm As New DesignerForm
        designerForm.ShowInTaskbar = True
        designerForm.Designer.MdiMode = True
        designerForm.ShowDialog()
        Me.Close()
    End Sub

End Class
