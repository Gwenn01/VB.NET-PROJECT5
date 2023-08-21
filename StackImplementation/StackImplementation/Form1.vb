Imports System.Reflection.Emit

Public Class Form1
    Dim stack = New Stack
    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        If stack.isFull() Then
            MsgBox("Stack is Full")
        Else
            Dim push As String
            push = txtPush.Text
            stack.push(push)
            display(push)
            txtPush.Text = ""
        End If
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        If stack.isEmpty() Then
            MsgBox("Stack is Empty")
            txtPop.Text = stack.pop()
        Else
            Dim pop As String
            display("")
            pop = stack.pop()
            txtPop.Text = pop
        End If
    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        If stack.isEmpty() Then
            MsgBox("Stack is Empty")
            txtPeek.Text = stack.peek()
        Else
            Dim peek As String
            peek = stack.peek()
            txtPeek.Text = peek
        End If
    End Sub

    Private Sub btnIsEmpty_Click(sender As Object, e As EventArgs) Handles btnIsEmpty.Click
        Dim isEmpty As Boolean
        isEmpty = stack.isEmpty()
        txtIsEmpty.Text = isEmpty
    End Sub
    Private Sub display(output As String)
        If stack.top = 0 Then
            lbl1.Text = output
        ElseIf stack.top = 1 Then
            lbl2.Text = output
        ElseIf stack.top = 2 Then
            lbl3.Text = output
        ElseIf stack.top = 3 Then
            lbl4.Text = output
        ElseIf stack.top = 4 Then
            lbl5.Text = output
        End If
    End Sub

End Class

Public Class Stack
    Dim stack(5) As String
    Public top = -1
    Dim size = 0

    Public Sub push(data As String)
        'base condition to check if out of stack or full
        If size = 5 Then
            Return
        End If
        top += 1
        stack(top) = data
        size += 1
    End Sub
    Public Function pop() As String
        'base condition to check if the stack is empty and we cant pop
        If top = -1 Then
            Return "Stack is empty"
        End If
        Dim data As String
        data = stack(top)
        stack(top) = ""
        top -= 1
        size -= 1
        Return data
    End Function
    Public Function peek() As String
        If top = -1 Then
            Return "Stack is empty"
        End If
        Return stack(top)
    End Function
    Public Function isEmpty() As Boolean
        Return size = 0
    End Function

    Public Function isFull() As Boolean
        Return size = 5
    End Function

End Class
