

Imports System.Data.SqlClient
Imports System.Text

Public Class Form2
    Private Const ConnectionString As String = "Provider=SQLOLEDB; Data Source=.; Initial Catalog=RMS; User Id=sysdba; Password=masterkey"
    Public frm1 As New Form1
    Public dt As New DataTable
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dd As DateTime = "2018-04-05 12:17:37.093"
        TextBox1.Text = dd
        Me.BindGrid()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Add a CheckBox Column to the DataGridView at the first position.
        Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = "chk"
        checkBoxColumn.Width = 30
        checkBoxColumn.Name = "checkBoxColumn"
        DataGridView1.Columns.Insert(0, checkBoxColumn)
        dt.Columns.Add("GEMS")
        dt.Columns.Add("DDD")
        Dim r As DataRow = Nothing
        r = dt.NewRow
        r("GEMS") = "TEST1"
        r("DDD") = "TEST2"
        dt.Rows.Add(r)
        DataGridView1.DataSource = dt

        For i As Integer = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(0).Value = True
        Next
        frm1.DialogResult = DialogResult.OK
        'Me.Close()

    End Sub

    Private Sub BindGrid()



    End Sub

    Private Sub btnSaveTest_Click(sender As Object, e As EventArgs) Handles btnSaveTest.Click
        'Dim gmodule As New GeneralModule
        'If conn.State = ConnectionState.Closed Then conn.Open()
        'Dim t1 As OleDbTransaction = conn.BeginTransaction
        'Dim bln_tranIsCommit As Boolean = True

        'Dim objCmd As New OleDbCommand
        'objCmd.CommandType = CommandType.Text
        'objCmd.Connection = conn
        'objCmd.Transaction = t1
        'bln_tranIsCommit = False
        'strSql = "INSERT INTO MenuItem (MenuItemID,MenuItemName,MenuItemType,MajorGroupID,MinorGroupID," &
        '                   "MenuitemGroupID, MenuItemizeGroupID, DiscountItemizeGroupID, " &
        '                   "ServiceChargeItemizeGroupID,SuggestSellID,MenuItemSLUID,HHMenuItemSLUID,SaleVATID," &
        '                   "isSaleLimit,SaleLimit,MenuitemStatus,ActiveDate,ExpireDate,MenuitemImage,Status,LastUpdate,ProjectedCookTime,isProductWeight,ProductWeightType,ReceiptName,ItemStatus) VALUES (" &
        '               "?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,'A',getdate(),?,?,?,?,?)"
        'objCmd.CommandText = strSql

        'With objCmd

        '    .Parameters.Add(New OleDbParameter("MenuItemID", txtMenuItemID.Text))
        '    .Parameters.Add(New OleDbParameter("MenuItemName", txtMenuItemName.Text))
        '    .Parameters.Add(New OleDbParameter("MenuItemType", rdoMenuItemType.SelectedValue))
        '    .Parameters.Add(New OleDbParameter("MajorGroupID", IIf(ddlMajor.SelectedValue = "", DBNull.Value, ddlMajor.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("MinorGroupID", IIf(ddlMinor.SelectedValue = "", DBNull.Value, ddlMinor.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("MenuitemGroupID", IIf(ddlMenuitem.SelectedValue = "", DBNull.Value, ddlMenuitem.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("MenuItemizeGroupID", IIf(ddlMenuItemize.SelectedValue = "", DBNull.Value, ddlMenuItemize.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("DiscountItemizeGroupID", IIf(ddlDiscountItemize.SelectedValue = "", DBNull.Value, ddlDiscountItemize.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("ServiceChargeItemizeGroupID", IIf(ddlServiceCharge.SelectedValue = "", DBNull.Value, ddlServiceCharge.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("SuggestSellID", IIf(ddlSuggestSell.SelectedValue = "", DBNull.Value, ddlSuggestSell.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("MenuItemSLUID", IIf(ddlMenuItemSLU.SelectedValue = "", DBNull.Value, ddlMenuItemSLU.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("HHMenuItemSLUID", IIf(ddlHHMenuItemSLU.SelectedValue = "", DBNull.Value, ddlHHMenuItemSLU.SelectedValue)))
        '    .Parameters.Add(New OleDbParameter("SaleVATID", ddlVat.SelectedValue))
        '    .Parameters.Add(New OleDbParameter("isSaleLimit", IIf(cbxSellLimit.Checked, "T", "F")))
        '    .Parameters.Add(New OleDbParameter("SaleLimit", IIf(cbxSellLimit.Checked, IIf(txtLimitAmount.Text = "", DBNull.Value, txtLimitAmount.Text), DBNull.Value)))
        '    .Parameters.Add(New OleDbParameter("MenuitemStatus", ddlStatus.SelectedValue))
        '    .Parameters.Add(New OleDbParameter("ActiveDate", IIf(dpActiveDate.IsEmpty, DBNull.Value, dpActiveDate.SelectedDate)))
        '    .Parameters.Add(New OleDbParameter("ExpireDate", IIf(dpExpireDate.IsEmpty, DBNull.Value, dpExpireDate.SelectedDate)))
        '    .Parameters.Add(New OleDbParameter("MenuitemImage", Image))
        '    .Parameters.Add(New OleDbParameter("ProjectedCookTime", txtProjectCookTime.Text))
        '    .Parameters.Add(New OleDbParameter("isProductWeight", IIf(cbxIsProductWeightType.Checked, "T", "F")))
        '    .Parameters.Add(New OleDbParameter("ProductWeightType", IIf(cbxIsProductWeightType.Checked, IIf(rdoProductWeightType.SelectedValue = "", True, rdoProductWeightType.SelectedValue), DBNull.Value)))
        '    .Parameters.Add(New OleDbParameter("ReceiptName", Me.txtReceiptName.Text))
        '    .Parameters.Add(New OleDbParameter("ItemStatus", IIf(ddlChangeStatusTo.SelectedValue = "", DBNull.Value, ddlChangeStatusTo.SelectedValue)))
        'End With

        '        Insert into MemberRedeemPoint(MCODE, RedeemDate, MPOINT, RedeemPoint, Detail, isSHOPPENINGStatus)
        'Values()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strUnit As String = 4.546
        Dim decUnit As Decimal = 0
        decUnit = Math.Round(CDec(strUnit), 2)
        'decUnit = Math.Round(CDec(strUnit))


    End Sub

    Private Sub btnToString_Click(sender As Object, e As EventArgs) Handles btnToString.Click
        txtToString.Text = ""
        Dim T As String = ""
        For i As Integer = 0 To 100000 - 1
            T &= "T"
        Next
        txtToString.Text = T
    End Sub

    Private Sub btnStringBudder_Click(sender As Object, e As EventArgs) Handles btnStringBudder.Click
        txtStringBudder.Text = ""
        Dim SB As New StringBuilder
        For i As Integer = 0 To 100000 - 1
            SB.Append("T")
        Next
        txtStringBudder.Text = SB.ToString
    End Sub
End Class