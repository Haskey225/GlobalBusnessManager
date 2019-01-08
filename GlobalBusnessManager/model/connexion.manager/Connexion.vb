Imports MySql.Data.MySqlClient
Public Class Connexion
    Protected connexion As MySqlConnection
    Sub New(ByVal user As String, ByVal password As String)
        connexion = New MySqlConnection
        connexion.ConnectionString = ("server=192.168.8.10; database=beeshop; user=" + user + "; Password=" + password)
    End Sub
    Sub New(user As String, password As String, host As String)
        connexion = New MySqlConnection
        If host = "" Then
            MsgBox("La machine host n'a pas été configurer, La configuration par defaut sera chargée.")
            host = "192.168.8.10"
        End If
        connexion.ConnectionString = ("server=" + host + "; database=beeshop; user=" + user + "; Password=" + password)
    End Sub
    Sub New()

    End Sub
    Public Function getConnexion()
        Return connexion
    End Function

    Public Function establishConnexion()
        Try
            connexion.Open()
            MainController.BAR_ETAT.Text = "Connecter"
        Catch ex As Exception
            MsgBox("Impossible de se connecter à la base de donnée. Verifiez que:  " &
                 Chr(13) & "1-> Le nom d'utilisateur et le mote de passe sont correctes" &
                 Chr(13) & "2-> Vous avez accès au réseau qui héberge le système de donné" &
                 Chr(13) & "3-> Contactez votre administrateur réseau")
        End Try
        Return Me.getStat()
    End Function
    Function getStat()
        Dim result As Boolean
        If connexion.State = ConnectionState.Closed Or connexion.State = ConnectionState.Broken Or connexion.State = ConnectionState.Executing Then
            result = False
        Else
            result = True
        End If
        Return result
    End Function

    Function closeConnexion()
        connexion.Close()
        MainController.BAR_ETAT.Text = "Déconnecter"
        Return Me.getStat
    End Function

End Class
