Imports System.Data.SqlClient

Public Class SQLControl
    Private DBCon As New SqlConnection("Server=DESKTOP-JHVG5RN\SQLEXPRESS01;Database=schoolsystem;Trusted_Connection=True;")
    Private DBCmd As SqlCommand
    Public SQLDS As DataSet

    'DB data
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable



    'QUERRY PARAMETER PUBLIC so we dont have to create new list on each run 
    Public Params As New List(Of SqlParameter)

    'STATISCTS OF QUERRY
    Public RecordCount As Integer
    Public Execption As String

    Public Sub New()
    End Sub

    'let the app connect to the server
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    'EXECUTE QUERRY add / delete / update and reset //try catch error
    Public Sub ExecQuery(Query As String)
        'reset
        RecordCount = 0
        Execption = ""

        Try
            DBCon.Open()
            'create db command
            DBCmd = New SqlCommand(Query, DBCon)

            'paramter loaded to db command

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            ' MAKE IT CLEAN FOR NEXT QUERY
            Params.Clear()

            'exec command And fill data / new table

            DBDT = New DataTable
            'test
            DBDA = New SqlDataAdapter(DBCmd)
            SQLDS = New DataSet
            'test
            DBDA.Fill(SQLDS)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'capture error
            Execption = "We have query error Error: " & vbNewLine & ex.Message


        Finally
            'close connection'
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try


    End Sub
    'add last para
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'error checking
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Execption) Then Return False
        If Report = True Then MsgBox(Execption, MsgBoxStyle.Critical, "Execption:")
        Return True
    End Function
End Class
