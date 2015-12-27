Public Class Form1

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAboutDev.Click
        frmAboutDev.ShowDialog()
    End Sub

    Private Sub menuAboutProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAboutProduct.Click
        frmAboutProduct.ShowDialog()
    End Sub

End Class
