Imports System.IO
Module Module1

    Sub Main()
        Dim filesToMove = From f In New DirectoryInfo("c:\Code\WebApps\ProductLoss_2018\ProductLoss2018\UploadedFiles\").EnumerateFiles("*.txt")
        Dim FilePathTo As String = "\\bbidaxapp1\Input"

        For Each f In filesToMove
            f.MoveTo(FilePathTo)
        Next
    End Sub

End Module
