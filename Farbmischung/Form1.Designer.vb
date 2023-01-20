<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.lblFafrbeChema1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblfarbeR = New System.Windows.Forms.Label()
        Me.lblFarbeG = New System.Windows.Forms.Label()
        Me.lblFarbeB = New System.Windows.Forms.Label()
        Me.lblEndfarbe = New System.Windows.Forms.Label()
        Me.btnend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "B"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(185, 98)
        Me.HScrollBar1.Maximum = 264
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(282, 17)
        Me.HScrollBar1.TabIndex = 3
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(185, 190)
        Me.HScrollBar2.Maximum = 264
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(282, 17)
        Me.HScrollBar2.TabIndex = 4
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(185, 144)
        Me.HScrollBar3.Maximum = 264
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(282, 17)
        Me.HScrollBar3.TabIndex = 5
        '
        'lblFafrbeChema1
        '
        Me.lblFafrbeChema1.BackColor = System.Drawing.Color.Black
        Me.lblFafrbeChema1.Location = New System.Drawing.Point(492, 98)
        Me.lblFafrbeChema1.Name = "lblFafrbeChema1"
        Me.lblFafrbeChema1.Size = New System.Drawing.Size(73, 23)
        Me.lblFafrbeChema1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(492, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(492, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 23)
        Me.Label6.TabIndex = 8
        '
        'lblfarbeR
        '
        Me.lblfarbeR.AutoSize = True
        Me.lblfarbeR.Location = New System.Drawing.Point(612, 102)
        Me.lblfarbeR.Name = "lblfarbeR"
        Me.lblfarbeR.Size = New System.Drawing.Size(13, 13)
        Me.lblfarbeR.TabIndex = 9
        Me.lblfarbeR.Text = "0"
        '
        'lblFarbeG
        '
        Me.lblFarbeG.AutoSize = True
        Me.lblFarbeG.Location = New System.Drawing.Point(612, 148)
        Me.lblFarbeG.Name = "lblFarbeG"
        Me.lblFarbeG.Size = New System.Drawing.Size(13, 13)
        Me.lblFarbeG.TabIndex = 10
        Me.lblFarbeG.Text = "0"
        '
        'lblFarbeB
        '
        Me.lblFarbeB.AutoSize = True
        Me.lblFarbeB.Location = New System.Drawing.Point(612, 190)
        Me.lblFarbeB.Name = "lblFarbeB"
        Me.lblFarbeB.Size = New System.Drawing.Size(13, 13)
        Me.lblFarbeB.TabIndex = 11
        Me.lblFarbeB.Text = "0"
        '
        'lblEndfarbe
        '
        Me.lblEndfarbe.BackColor = System.Drawing.Color.Black
        Me.lblEndfarbe.Location = New System.Drawing.Point(127, 288)
        Me.lblEndfarbe.Name = "lblEndfarbe"
        Me.lblEndfarbe.Size = New System.Drawing.Size(457, 47)
        Me.lblEndfarbe.TabIndex = 12
        '
        'btnend
        '
        Me.btnend.Location = New System.Drawing.Point(319, 377)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(75, 23)
        Me.btnend.TabIndex = 13
        Me.btnend.Text = "ende"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.lblEndfarbe)
        Me.Controls.Add(Me.lblFarbeB)
        Me.Controls.Add(Me.lblFarbeG)
        Me.Controls.Add(Me.lblfarbeR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFafrbeChema1)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents lblFafrbeChema1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblfarbeR As Label
    Friend WithEvents lblFarbeG As Label
    Friend WithEvents lblFarbeB As Label
    Friend WithEvents lblEndfarbe As Label
    Friend WithEvents btnend As Button
End Class
