Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Data.SqlClient
Imports System.Data
'-----
Imports Newtonsoft.Json
Imports System
Imports System.Web


Public Class clsWebservice
    Public Shared Property HttpUtility As Object

    Public Shared Function Post_API_with_refJSON(ByVal uri As String, ByVal postParam As Object, ByRef json_res As String, Optional _timeOut As Integer = 10000) As Boolean
        Dim postData As String = Newtonsoft.Json.JsonConvert.SerializeObject(postParam)
        Dim byte_dataPOST As Byte() = System.Text.Encoding.UTF8.GetBytes(postParam) 'postData)

        Dim _request As HttpWebRequest = DirectCast(WebRequest.Create(uri), HttpWebRequest)
        _request.Method = "POST"
        _request.ContentLength = byte_dataPOST.Length
        '_request.ContentType = "application/json"
        _request.ContentType = "application/x-www-form-urlencoded"
        _request.Timeout = _timeOut

        Dim strDataReturn As String
        Dim _sCode As HttpStatusCode = HttpStatusCode.NoContent
        Using requestStream As Stream = _request.GetRequestStream()
            requestStream.Write(byte_dataPOST, 0, byte_dataPOST.Length())

            Using _response As HttpWebResponse = DirectCast(_request.GetResponse(), HttpWebResponse)
                _sCode = _response.StatusCode
                Using streamReader As StreamReader = New StreamReader(_response.GetResponseStream())
                    strDataReturn = streamReader.ReadToEnd()
                End Using
            End Using
        End Using

        If _sCode <> HttpStatusCode.OK Then
            json_res = String.Format("POST failed. Received HTTP {0}", _sCode)
            'Throw New ApplicationException(message)
            'Return message
        Else
            json_res = strDataReturn
            Return True
        End If

        Return False
    End Function

    Public Shared Function GET_API_with_refJSON(ByVal uri As String, ByVal GETParam As Object, ByRef json_res As String, Optional _timeOut As Integer = 10000) As Boolean
        Dim GETData As String = Newtonsoft.Json.JsonConvert.SerializeObject(GETParam)
        Dim byte_dataGET As Byte() = System.Text.Encoding.UTF8.GetBytes(GETParam) 'postData)

        Dim _request As HttpWebRequest = DirectCast(WebRequest.Create(uri), HttpWebRequest)
        _request.Method = "GET"
        _request.ContentLength = byte_dataGET.Length

        _request.ContentType = "text/xml; charset=utf-8"
        _request.Timeout = _timeOut

        Dim strDataReturn As String
        Dim _sCode As HttpStatusCode = HttpStatusCode.NoContent
        'Using requestStream As Stream = _request.GetRequestStream()
        '    requestStream.Write(byte_dataGET, 0, byte_dataGET.Length())

        Using _response As HttpWebResponse = DirectCast(_request.GetResponse(), HttpWebResponse)
            _sCode = _response.StatusCode
            Using streamReader As StreamReader = New StreamReader(_response.GetResponseStream())
                strDataReturn = streamReader.ReadToEnd()
            End Using
        End Using
        'End Using

        ''=== 
        'Dim lsEmployee = JsonConvert.DeserializeObject(strDataReturn)

        Dim obj = JsonConvert.DeserializeObject(Of cusResponse)(strDataReturn) 'อ่านค่าจาก ที่เป็น JSON มาใส่ไว้ใน Class เก็บไว้ในตัวแปร Object จะสามารถเรียกใช้ได้
        Dim cus_id, fname, lname, Em, Te As String
        cus_id = obj.results.customer_id.ToString()
        fname = obj.results.first_name.ToString()
        lname = obj.results.last_name.ToString()
        Em = obj.results.emails.ToString()
        Te = obj.results.tels.ToString()

        Dim cusResult As cusResponse = New cusResponse(obj.error_code.ToString(), obj.error_msg.ToString()) 'ใส่ค่าเข้าไปให้ที่ class ที่เราสร้างขึ้น


        'Dim cusResult As cusResponse = New cusResponse
        'cusResult.error_code = obj.error_code.ToString()
        'cusResult.error_msg = obj.error_msg.ToString()
        '===

        If _sCode <> HttpStatusCode.OK Then
            json_res = String.Format("GET failed. Received HTTP {0}", _sCode)
            'Throw New ApplicationException(message)
            'Return message
        Else
            json_res = strDataReturn
            Return True
        End If

        Return False
    End Function

    Class cusResponse
        Public Property error_code As String = ""
        Public Property error_msg As String = ""
        Public Property results As New cusResponse_results
        Sub New()
        End Sub
        Sub New(code As String, msg As String)
            error_code = code
            error_msg = msg
        End Sub
    End Class

    Class cusResponse_results
        Public Property customer_id As String = ""
        Public Property first_name As String = ""
        Public Property last_name As String = ""
        Public Property emails As String = ""
        Public Property tels As String = ""
        'Sub New()
        'End Sub
        'Sub New(id As String, fname As String, lname As String, email As String, tel As String)
        '    customer_id = id
        '    first_name = fname
        '    last_name = lname
        '    emails = email
        '    tels = tel
        'End Sub
    End Class


    Public Shared Function Post_API_with_refJSON01(ByVal uri As String, ByVal postParam As Object, ByRef json_res As String, Optional _timeOut As Integer = 10000) As Boolean
        Dim postData As String = Newtonsoft.Json.JsonConvert.SerializeObject(postParam)
        Dim byte_dataPOST As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
        Dim _request As HttpWebRequest = DirectCast(WebRequest.Create(uri), HttpWebRequest)
        _request.Method = "POST"
        _request.ContentLength = byte_dataPOST.Length
        '_request.ContentType = "application/json"
        _request.ContentType = "application/x-www-form-urlencoded"
        _request.Timeout = _timeOut

        Dim strDataReturn As String
        Dim _sCode As HttpStatusCode = HttpStatusCode.NoContent
        Using requestStream As Stream = _request.GetRequestStream()
            requestStream.Write(byte_dataPOST, 0, byte_dataPOST.Length())

            Using _response As HttpWebResponse = DirectCast(_request.GetResponse(), HttpWebResponse)
                _sCode = _response.StatusCode
                Using streamReader As StreamReader = New StreamReader(_response.GetResponseStream())
                    strDataReturn = streamReader.ReadToEnd()
                End Using
            End Using
        End Using

        If _sCode <> HttpStatusCode.OK Then
            json_res = String.Format("POST failed. Received HTTP {0}", _sCode)
            'Throw New ApplicationException(message)
            'Return message
        Else
            json_res = strDataReturn
            Return True
        End If

        Return False
    End Function



End Class
