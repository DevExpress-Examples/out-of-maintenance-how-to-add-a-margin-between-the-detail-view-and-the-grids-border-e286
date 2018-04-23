Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)
        Me.Order_DetailsTableAdapter1.Fill(Me.NwindDataSet.Order_Details)
    End Sub
End Class
