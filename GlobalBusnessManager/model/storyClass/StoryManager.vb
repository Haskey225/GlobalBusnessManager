Imports MySql.Data.MySqlClient

Public Class StoryManager
    Private mConnexion As MySqlConnection
    Private mCmd As MySqlCommand
    Private mReader As MySqlDataReader
    Private mQuery As String

    Sub New(connexion As Connexion)
        mConnexion = connexion.getConnexion
    End Sub
End Class
