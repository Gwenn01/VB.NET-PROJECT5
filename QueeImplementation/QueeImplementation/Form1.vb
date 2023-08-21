Public Class Form1
    Dim q = New Queue
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If q.isFull() Then
            MsgBox("Queue over flow")
        End If
        Dim data As String
        data = txtAdd.Text
        q.add(data)
        display()
        txtAdd.Text = ""
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If q.isEmpty() Then
            MsgBox("Queue exception")
        End If
        txtRemove.Text = q.remove()
        display()
    End Sub
    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        If q.isEmpty() Then
            MsgBox("Queue exception")
        End If
        txtPeek.Text = q.peek()
        display()
    End Sub

    Private Sub btnIsEmpty_Click(sender As Object, e As EventArgs) Handles btnIsEmpty.Click
        txtIsEmpty.Text = q.isEmpty()
    End Sub
    Public Sub display()
        lbl1.Text = q.queuee1()
        lbl2.Text = q.queuee2()
        lbl3.Text = q.queuee3()
        lbl4.Text = q.queuee4()
        lbl5.Text = q.queuee5()
    End Sub


End Class
Public Class Queue
    Dim queue(5) As String
    Dim size = 0
    Dim head = 0
    Dim index = -1

    Public Sub add(data As String)
        If isFull() Then
            Return
        End If
        index += 1
        size += 1
        queue(index) = data
    End Sub
    Public Function remove() As String
        If isEmpty() Then
            Return "Queue is full"
        End If
        Dim data As String
        data = queue(head)
        size -= 1
        For i = 1 To size Step 1
            queue(i - 1) = queue(i)
        Next
        queue(index) = ""
        index -= 1
        Return data
    End Function
    Public Function peek() As String
        If isFull() Then
            Return "Queue is full"
        End If
        Dim data As String
        data = queue(head)
        Return data
    End Function
    Public Function queuee1() As String
        Return queue(0)
    End Function
    Public Function queuee2() As String
        Return queue(1)
    End Function
    Public Function queuee3() As String
        Return queue(2)
    End Function
    Public Function queuee4() As String
        Return queue(3)
    End Function
    Public Function queuee5() As String
        Return queue(4)
    End Function
    Public Function isEmpty() As Boolean
        Return size = 0
    End Function
    Public Function isFull() As Boolean
        Return size = 5
    End Function
    Public Function indexx() As Integer
        Return index
    End Function
End Class
