Module Utilitaires
    Public sessionLogin As String
    Public Function CreateFolder(ByVal Path As String, ByVal FolderName As String, _
                                 Optional ByVal Attributes As System.IO.FileAttributes = IO.FileAttributes.Normal)
        If My.Computer.FileSystem.DirectoryExists(Path) = False Then
            Throw New Exception("The specified path does not exist. Make sure the specified path has been spelled correctly.")
        ElseIf My.Computer.FileSystem.DirectoryExists(Path & FolderName) Then
            Throw New Exception("Could not create the folder because it already exists.")
        Else
            My.Computer.FileSystem.CreateDirectory(Path & FolderName)
            If Not Attributes = IO.FileAttributes.Normal Then
                My.Computer.FileSystem.GetDirectoryInfo(Path & FolderName).Attributes = Attributes
            End If
        End If
    End Function
  
End Module
