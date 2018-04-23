<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GridControl1 = New detailViewMargin.MyGridControl
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NwindDataSet = New detailViewMarginVB.nwindDataSet
        Me.GridView1 = New detailViewMargin.MyGridView
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrdersTableAdapter = New detailViewMarginVB.nwindDataSetTableAdapters.OrdersTableAdapter
        Me.GridView2 = New detailViewMargin.MyGridView
        Me.colOrderID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Order_DetailsTableAdapter1 = New detailViewMarginVB.nwindDataSetTableAdapters.Order_DetailsTableAdapter
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OrdersBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        GridLevelNode2.LevelTemplate = Me.GridView2
        GridLevelNode2.RelationName = "OrdersOrder Details"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(899, 539)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NwindDataSet
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "nwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colOrderID
        '
        Me.colOrderID.Caption = "OrderID"
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        Me.colOrderID.Visible = True
        Me.colOrderID.VisibleIndex = 0
        '
        'colCustomerID
        '
        Me.colCustomerID.Caption = "CustomerID"
        Me.colCustomerID.FieldName = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.Visible = True
        Me.colCustomerID.VisibleIndex = 1
        '
        'colEmployeeID
        '
        Me.colEmployeeID.Caption = "EmployeeID"
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.Visible = True
        Me.colEmployeeID.VisibleIndex = 2
        '
        'colOrderDate
        '
        Me.colOrderDate.Caption = "OrderDate"
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 3
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID1, Me.colProductID, Me.colUnitPrice, Me.colQuantity, Me.colDiscount})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'colOrderID1
        '
        Me.colOrderID1.Caption = "OrderID"
        Me.colOrderID1.FieldName = "OrderID"
        Me.colOrderID1.Name = "colOrderID1"
        Me.colOrderID1.Visible = True
        Me.colOrderID1.VisibleIndex = 0
        '
        'colProductID
        '
        Me.colProductID.Caption = "ProductID"
        Me.colProductID.FieldName = "ProductID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Visible = True
        Me.colProductID.VisibleIndex = 1
        '
        'colUnitPrice
        '
        Me.colUnitPrice.Caption = "UnitPrice"
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 2
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        '
        'colDiscount
        '
        Me.colDiscount.Caption = "Discount"
        Me.colDiscount.FieldName = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.Visible = True
        Me.colDiscount.VisibleIndex = 4
        '
        'Order_DetailsTableAdapter1
        '
        Me.Order_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 539)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As detailViewMargin.MyGridControl
    Friend WithEvents GridView1 As detailViewMargin.MyGridView
    Friend WithEvents NwindDataSet As detailViewMarginVB.nwindDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As detailViewMarginVB.nwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As detailViewMargin.MyGridView
    Friend WithEvents colOrderID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Order_DetailsTableAdapter1 As detailViewMarginVB.nwindDataSetTableAdapters.Order_DetailsTableAdapter

End Class
