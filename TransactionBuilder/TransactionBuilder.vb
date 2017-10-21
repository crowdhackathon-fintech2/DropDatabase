Imports newtonsoft.json


Module Module1

    Sub Main()

        Dim SandboxBuilder As New SandboxBuilder
        SandboxBuilder.CreateTransactionList()

    End Sub

End Module


Public Class SandboxBuilder
    Dim InitialSandbox As String = My.Computer.FileSystem.ReadAllText("..\..\sandbox.json")
    Dim TransactionTemplate As String = My.Computer.FileSystem.ReadAllText("..\..\transactionTemplate.json")


    Public Function CreateTransactionList() As Transaction()
        'Dim TransactionList As Transaction()
        Dim Transaction As Transaction
        Dim Transactions As New List(Of Transaction)

        Transaction = CreateTransaction("XXX", "2017-10-21", 9999)
        Transactions.Add(Transaction)

        Return Nothing
    End Function

    ' executionDate in form: '2017-10-21'
    Public Function CreateTransaction(description As String, executionDate As String, amount As Decimal) As Transaction
        Dim Transaction = JsonConvert.DeserializeObject(Of Transaction)(TransactionTemplate)
        Transaction.id = New Guid().ToString
        Transaction.details.description = description
        Transaction.details.value.amount = amount
        Transaction.details.posted = CType(executionDate + "T10:08:54.753Z", DateTime)
        Transaction.details.completed = CType(executionDate + "T10:08:54.753Z", DateTime)
        Return Transaction
    End Function


End Class