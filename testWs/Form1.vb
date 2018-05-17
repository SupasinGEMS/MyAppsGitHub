Imports System.Web

Public Class Form1
    Private Sub btnTestFunction_Click(sender As Object, e As EventArgs) Handles btnTestFunction.Click
        Dim strURL As String = "http://localhost/xxws/service.asmx/exeScalar"
        Dim strParam As String = "sql=select count(*) from checks"

        clsWebservice.Post_API_with_refJSON(strURL, strParam, "")

        Dim ss As New s
        ss.sql = "select count(*) from checks"
        ss.sqls = "1234"
        ' clsWebservice.Post_API_with_refJSON01(strURL, ss, "")


    End Sub

    Class s
        Public Property sql As String = ""
        Public Property sqls As String = ""
    End Class

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strURL As String = "http://localhost/xxws/Service.asmx/doLogin"
        Dim strParam As String = "UserID=" & System.Web.HttpUtility.UrlEncode(txtuser.Text) & " &Pass=" & System.Web.HttpUtility.UrlEncode(txtpass.Text)
        clsWebservice.Post_API_with_refJSON(strURL, strParam, "")

    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        'Dim strURL As String = "http://localhost/xxws/Service.asmx/HelloWorld?"
        'clsWebservice.Post_API_with_refJSON(strURL, "", "")

        'Dim strURLs As String = "http://localhost/xxws/Service.asmx/Hello"
        'Dim strParam As String = "strName=" & HttpUtility.UrlEncode(txtuser.Text) & ""
        'clsWebservice.Post_API_with_refJSON(strURLs, strParam, "")

        Dim strURLss As String = "http://localhost/xxws/Service.asmx/Hello?strName=" & txtuser.Text & ""
        clsWebservice.GET_API_with_refJSON(strURLss, "", "")
    End Sub

    Private Sub btncustomerG_Click(sender As Object, e As EventArgs) Handles btncustomerG.Click
        Dim strURL As String = "http://localhost/xxws/Service.asmx/customers?key=string&customer_id=string"
        clsWebservice.GET_API_with_refJSON(strURL, "", "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pointList As String = "{'point':1,'timestamp':'2018','expired_date':'2018-2-27 16:9:50'},{'point':2,'timestamp':'x','expired_date':'y'},{'point':3,'timestamp':'x','expired_date':'y'}"
        'pointList = ""
        Dim s As String = "{'point_list': [" & pointList & "],'error_code': 0,'error_msg': 'ok.','total_point': 0}"

        Dim clsRes As clsPoint_result = Newtonsoft.Json.JsonConvert.DeserializeObject(Of clsPoint_result)(s)

        Dim s2 As String = Newtonsoft.Json.JsonConvert.SerializeObject(clsRes.point_list, Newtonsoft.Json.Formatting.Indented)

        'จาก JSON เป็น DataTable หรือจาก class  เป็น DataTable 
        Dim dtres As DataTable = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(s2)
        Dim i As Integer = 1
    End Sub


    Class clsPoint_result
        Public Property error_code As String = ""
        Public Property error_msg As String = ""
        Public Property totail_point As Integer = 0
        Public Property point_list As New List(Of clsResult_listPoint)
    End Class
    Class clsResult_listPoint
        Public Property point As Integer = 0
        Public Property timestamp As String
        Private Property _expired_date As String = ""

        Public Property expired_date As String
            Set(value As String)
                Dim dtm As DateTime = Now
                Dim _format As String() = {"%y-%M-%d %H:%m:%s", "yyyy-MM-dd HH:mm:ss", "yyyy-M-d HH:mm:ss", "yyyy-M-d H:m:s"}
                'Dim _format As String() = {"yyyy-M-d H:m:s"}
                If DateTime.TryParseExact(value, _format, System.Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dtm) = False Then
                    dtm = Now
                End If

                _expired_date = dtm.ToString("dd") & "/" & dtm.ToString("MM") & "/" & dtm.Year & " " & dtm.ToString("HH") & ":" & dtm.ToString("mm") & ":" & dtm.ToString("ss")
            End Set
            Get
                If _expired_date Is Nothing Then Return ""
                Return _expired_date
            End Get
        End Property

    End Class

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form2

        Dim dt As DataTable = Nothing
        If frm.ShowDialog <> DialogResult.OK Then
            dt = frm.dt
        Else
            Dim a As String = ""
        End If
        Dim atime As String = "2018-03-14-18-45-09"
        atime = atime.Replace("-", ":")
        atime = atime.Substring(atime.Length - 8, 8)
        Dim aTimeN As DateTime
        If DateTime.TryParseExact(atime, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture _
                                    , System.Globalization.DateTimeStyles.None, aTimeN) Then
            'hidDocDate.Value = aTime.ToString("HH:mm:ss")
            aTimeN.ToString("HH:mm:ss")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'TextBox3.Text = CDbl(TextBox1.Text) - CDbl(TextBox2.Text)
        Dim dec1 As Decimal = 0
        If Decimal.TryParse(TextBox1.Text, dec1) = False Then dec1 = 0

        Dim dec2 As Decimal = 0
        If Decimal.TryParse(TextBox2.Text, dec2) = False Then dec2 = 0
        Dim sum As Decimal = 0
        sum = dec2 - dec1
        TextBox3.Text = sum

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("GEMS GitHub")
        MsgBox("GEMS GitHubTTSSSSSSS")
    End Sub
End Class
