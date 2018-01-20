'Imports System.Threading
'Imports System.Collections.Specialized

'https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/component-that-supports-the-event-based-asynchronous-pattern
' https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/implementing-the-event-based-asynchronous-pattern
'https://docs.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/best-practices-for-implementing-the-event-based-asynchronous-pattern
'https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/await-operator

Public Class BulkResizer

    Public Delegate Sub ProcessFolderCompletedEventHandler(ByVal sender As Object, ByVal e As ProcessFolderCompletedEventArgs)

    Public Delegate Sub ProcessFolderProgressChangedEventHandler(ByVal sender As Object, ByVal e As ProcessFolderProgressChangedEventArgs)

    Public Class ProcessFolderCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private _FilesProcessed As UInteger
        Private _FilesTotal As UInteger

        Public ReadOnly Property FilesProcessed As UInteger
            Get
                Return _FilesProcessed
            End Get
        End Property

        Public ReadOnly Property FilesTotal As UInteger
            Get
                Return _FilesTotal
            End Get
        End Property

        Public Sub New(ByVal [error] As Exception, ByVal cancelled As Boolean, ByVal FilesTotal As UInteger, ByVal FilesProcessed As UInteger)
            MyBase.New([error], cancelled, Nothing)
            _FilesProcessed = FilesProcessed
            _FilesTotal = FilesTotal
        End Sub
    End Class

    Public Class ProcessFolderProgressChangedEventArgs
        Inherits System.ComponentModel.ProgressChangedEventArgs

        Private _FilesProcessed As UInteger
        Private _FilesTotal As UInteger

        Public ReadOnly Property FilesProcessed As UInteger
            Get
                Return _FilesProcessed
            End Get
        End Property

        Public ReadOnly Property FilesTotal As UInteger
            Get
                Return _FilesTotal
            End Get
        End Property

        Public Sub New(ByVal FilesTotal As UInteger, ByVal FilesProcessed As UInteger)
            MyBase.New(CInt(Math.Round(FilesProcessed / FilesTotal * 100, 0)), Nothing)
            _FilesProcessed = FilesProcessed
            _FilesTotal = FilesTotal
        End Sub
    End Class

    Public Event ProcessFolderCompleted As ProcessFolderCompletedEventHandler
    Public Event ProcessFolderProgressChanged As ProcessFolderProgressChangedEventHandler

    Public Sub ProcessFolderAsync()

    End Sub

    Public ReadOnly Property IsBusy As Boolean
        Get

        End Get
    End Property

    Public Sub ProcessFolderAsyncCancel()

    End Sub

End Class
