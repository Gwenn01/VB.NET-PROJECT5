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
        lbl5 = New Label()
        txtPush = New TextBox()
        txtPop = New TextBox()
        btnPush = New Button()
        btnPop = New Button()
        btnPeek = New Button()
        txtPeek = New TextBox()
        btnIsEmpty = New Button()
        txtIsEmpty = New TextBox()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lbl4 = New Label()
        SuspendLayout()
        ' 
        ' lblTittle
        ' 
        lblTittle.AutoSize = True
        lblTittle.BackColor = SystemColors.AppWorkspace
        lblTittle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lblTittle.Location = New Point(317, 9)
        lblTittle.Name = "lblTittle"
        lblTittle.Size = New Size(123, 54)
        lblTittle.TabIndex = 0
        lblTittle.Text = "Stack"
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.BackColor = SystemColors.ButtonHighlight
        lbl5.BorderStyle = BorderStyle.Fixed3D
        lbl5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl5.Location = New Point(422, 168)
        lbl5.MaximumSize = New Size(200, 430)
        lbl5.MinimumSize = New Size(200, 30)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(200, 30)
        lbl5.TabIndex = 1
        lbl5.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' txtPush
        ' 
        txtPush.Location = New Point(49, 152)
        txtPush.Name = "txtPush"
        txtPush.Size = New Size(150, 31)
        txtPush.TabIndex = 6
        txtPush.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPop
        ' 
        txtPop.Location = New Point(49, 226)
        txtPop.Name = "txtPop"
        txtPop.Size = New Size(150, 31)
        txtPop.TabIndex = 7
        txtPop.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPush
        ' 
        btnPush.BackColor = SystemColors.ActiveCaption
        btnPush.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnPush.Location = New Point(205, 146)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(112, 40)
        btnPush.TabIndex = 8
        btnPush.Text = "Push"
        btnPush.UseVisualStyleBackColor = False
        ' 
        ' btnPop
        ' 
        btnPop.BackColor = SystemColors.ActiveCaption
        btnPop.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnPop.Location = New Point(205, 222)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(112, 35)
        btnPop.TabIndex = 9
        btnPop.Text = "Pop"
        btnPop.UseVisualStyleBackColor = False
        ' 
        ' btnPeek
        ' 
        btnPeek.BackColor = SystemColors.ActiveCaption
        btnPeek.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnPeek.Location = New Point(205, 295)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(112, 35)
        btnPeek.TabIndex = 11
        btnPeek.Text = "Peek"
        btnPeek.UseVisualStyleBackColor = False
        ' 
        ' txtPeek
        ' 
        txtPeek.Location = New Point(49, 295)
        txtPeek.Name = "txtPeek"
        txtPeek.Size = New Size(150, 31)
        txtPeek.TabIndex = 10
        txtPeek.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnIsEmpty
        ' 
        btnIsEmpty.BackColor = SystemColors.ActiveCaption
        btnIsEmpty.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btnIsEmpty.Location = New Point(205, 359)
        btnIsEmpty.Name = "btnIsEmpty"
        btnIsEmpty.Size = New Size(112, 35)
        btnIsEmpty.TabIndex = 13
        btnIsEmpty.Text = "Is Empty"
        btnIsEmpty.UseVisualStyleBackColor = False
        ' 
        ' txtIsEmpty
        ' 
        txtIsEmpty.Location = New Point(49, 363)
        txtIsEmpty.Name = "txtIsEmpty"
        txtIsEmpty.Size = New Size(150, 31)
        txtIsEmpty.TabIndex = 12
        txtIsEmpty.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = SystemColors.ButtonHighlight
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl1.Location = New Point(422, 336)
        lbl1.MaximumSize = New Size(200, 430)
        lbl1.MinimumSize = New Size(200, 30)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(200, 30)
        lbl1.TabIndex = 14
        lbl1.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = SystemColors.ButtonHighlight
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl2.Location = New Point(422, 295)
        lbl2.MaximumSize = New Size(200, 430)
        lbl2.MinimumSize = New Size(200, 30)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(200, 30)
        lbl2.TabIndex = 15
        lbl2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = SystemColors.ButtonHighlight
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl3.Location = New Point(422, 248)
        lbl3.MaximumSize = New Size(200, 430)
        lbl3.MinimumSize = New Size(200, 30)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(200, 30)
        lbl3.TabIndex = 16
        lbl3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = SystemColors.ButtonHighlight
        lbl4.BorderStyle = BorderStyle.Fixed3D
        lbl4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lbl4.Location = New Point(422, 208)
        lbl4.MaximumSize = New Size(200, 430)
        lbl4.MinimumSize = New Size(200, 30)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(200, 30)
        lbl4.TabIndex = 17
        lbl4.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(lbl4)
        Controls.Add(lbl3)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Controls.Add(btnIsEmpty)
        Controls.Add(txtIsEmpty)
        Controls.Add(btnPeek)
        Controls.Add(txtPeek)
        Controls.Add(btnPop)
        Controls.Add(btnPush)
        Controls.Add(txtPop)
        Controls.Add(txtPush)
        Controls.Add(lbl5)
        Controls.Add(lblTittle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtPush As TextBox
    Friend WithEvents txtPop As TextBox
    Friend WithEvents btnPush As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnPeek As Button
    Friend WithEvents txtPeek As TextBox
    Friend WithEvents btnIsEmpty As Button
    Friend WithEvents txtIsEmpty As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
End Class
