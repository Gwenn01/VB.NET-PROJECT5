<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTittle = New Label()
        txtAdd = New TextBox()
        lbl1 = New TextBox()
        lbl2 = New TextBox()
        lbl3 = New TextBox()
        lbl4 = New TextBox()
        lbl5 = New TextBox()
        txtRemove = New TextBox()
        txtPeek = New TextBox()
        txtIsEmpty = New TextBox()
        btnAdd = New Button()
        btnRemove = New Button()
        btnPeek = New Button()
        btnIsEmpty = New Button()
        SuspendLayout()
        ' 
        ' lblTittle
        ' 
        lblTittle.AutoSize = True
        lblTittle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblTittle.Location = New Point(315, 9)
        lblTittle.Name = "lblTittle"
        lblTittle.Size = New Size(174, 65)
        lblTittle.TabIndex = 0
        lblTittle.Text = "Queue"
        ' 
        ' txtAdd
        ' 
        txtAdd.Location = New Point(129, 118)
        txtAdd.Name = "txtAdd"
        txtAdd.Size = New Size(150, 31)
        txtAdd.TabIndex = 2
        txtAdd.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl1
        ' 
        lbl1.BackColor = SystemColors.Info
        lbl1.Location = New Point(502, 300)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(189, 31)
        lbl1.TabIndex = 3
        lbl1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl2
        ' 
        lbl2.BackColor = SystemColors.Info
        lbl2.Location = New Point(502, 252)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(189, 31)
        lbl2.TabIndex = 4
        lbl2.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl3
        ' 
        lbl3.BackColor = SystemColors.Info
        lbl3.Location = New Point(502, 205)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(189, 31)
        lbl3.TabIndex = 5
        lbl3.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl4
        ' 
        lbl4.BackColor = SystemColors.Info
        lbl4.Location = New Point(502, 155)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(189, 31)
        lbl4.TabIndex = 6
        lbl4.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl5
        ' 
        lbl5.BackColor = SystemColors.Info
        lbl5.Location = New Point(502, 110)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(189, 31)
        lbl5.TabIndex = 7
        lbl5.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtRemove
        ' 
        txtRemove.Location = New Point(129, 178)
        txtRemove.Name = "txtRemove"
        txtRemove.Size = New Size(150, 31)
        txtRemove.TabIndex = 9
        txtRemove.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPeek
        ' 
        txtPeek.Location = New Point(129, 229)
        txtPeek.Name = "txtPeek"
        txtPeek.Size = New Size(150, 31)
        txtPeek.TabIndex = 11
        txtPeek.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtIsEmpty
        ' 
        txtIsEmpty.Location = New Point(129, 281)
        txtIsEmpty.Name = "txtIsEmpty"
        txtIsEmpty.Size = New Size(150, 31)
        txtIsEmpty.TabIndex = 13
        txtIsEmpty.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.Location = New Point(304, 110)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 42)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemove.Location = New Point(304, 167)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(112, 42)
        btnRemove.TabIndex = 15
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnPeek
        ' 
        btnPeek.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnPeek.Location = New Point(304, 218)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(112, 42)
        btnPeek.TabIndex = 16
        btnPeek.Text = "Peek"
        btnPeek.UseVisualStyleBackColor = True
        ' 
        ' btnIsEmpty
        ' 
        btnIsEmpty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnIsEmpty.Location = New Point(294, 273)
        btnIsEmpty.Name = "btnIsEmpty"
        btnIsEmpty.Size = New Size(137, 42)
        btnIsEmpty.TabIndex = 17
        btnIsEmpty.Text = "Is Empty"
        btnIsEmpty.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnIsEmpty)
        Controls.Add(btnPeek)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(txtIsEmpty)
        Controls.Add(txtPeek)
        Controls.Add(txtRemove)
        Controls.Add(lbl5)
        Controls.Add(lbl4)
        Controls.Add(lbl3)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Controls.Add(txtAdd)
        Controls.Add(lblTittle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents lbl1 As TextBox
    Friend WithEvents lbl2 As TextBox
    Friend WithEvents lbl3 As TextBox
    Friend WithEvents lbl4 As TextBox
    Friend WithEvents lbl5 As TextBox
    Friend WithEvents txtRemove As TextBox
    Friend WithEvents txtPeek As TextBox
    Friend WithEvents txtIsEmpty As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnPeek As Button
    Friend WithEvents btnIsEmpty As Button
End Class
