<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZufallszeichnung
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
        Me.lblrandomnumber = New System.Windows.Forms.Label()
        Me.btnrandomnumber = New System.Windows.Forms.Button()
        Me.hsbUGrenze = New System.Windows.Forms.HScrollBar()
        Me.HsbOGrenze = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUGrenze = New System.Windows.Forms.Label()
        Me.lblOGrenze = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblrandomnumber
        '
        Me.lblrandomnumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblrandomnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrandomnumber.Location = New System.Drawing.Point(309, 147)
        Me.lblrandomnumber.Name = "lblrandomnumber"
        Me.lblrandomnumber.Size = New System.Drawing.Size(163, 54)
        Me.lblrandomnumber.TabIndex = 0
        Me.lblrandomnumber.Text = "?"
        Me.lblrandomnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnrandomnumber
        '
        Me.btnrandomnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrandomnumber.Location = New System.Drawing.Point(352, 247)
        Me.btnrandomnumber.Name = "btnrandomnumber"
        Me.btnrandomnumber.Size = New System.Drawing.Size(87, 23)
        Me.btnrandomnumber.TabIndex = 1
        Me.btnrandomnumber.Text = "Zufallszahl"
        Me.btnrandomnumber.UseVisualStyleBackColor = True
        '
        'hsbUGrenze
        '
        Me.hsbUGrenze.Location = New System.Drawing.Point(309, 72)
        Me.hsbUGrenze.Maximum = 109
        Me.hsbUGrenze.Name = "hsbUGrenze"
        Me.hsbUGrenze.Size = New System.Drawing.Size(163, 17)
        Me.hsbUGrenze.TabIndex = 2
        '
        'HsbOGrenze
        '
        Me.HsbOGrenze.Location = New System.Drawing.Point(309, 109)
        Me.HsbOGrenze.Maximum = 109
        Me.HsbOGrenze.Name = "HsbOGrenze"
        Me.HsbOGrenze.Size = New System.Drawing.Size(163, 17)
        Me.HsbOGrenze.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "untere Grenze"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Obere Grenze"
        '
        'lblUGrenze
        '
        Me.lblUGrenze.AutoSize = True
        Me.lblUGrenze.Location = New System.Drawing.Point(490, 72)
        Me.lblUGrenze.Name = "lblUGrenze"
        Me.lblUGrenze.Size = New System.Drawing.Size(0, 13)
        Me.lblUGrenze.TabIndex = 6
        '
        'lblOGrenze
        '
        Me.lblOGrenze.AutoSize = True
        Me.lblOGrenze.Location = New System.Drawing.Point(490, 113)
        Me.lblOGrenze.Name = "lblOGrenze"
        Me.lblOGrenze.Size = New System.Drawing.Size(0, 13)
        Me.lblOGrenze.TabIndex = 7
        '
        'frmZufallszeichnung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOGrenze)
        Me.Controls.Add(Me.lblUGrenze)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HsbOGrenze)
        Me.Controls.Add(Me.hsbUGrenze)
        Me.Controls.Add(Me.btnrandomnumber)
        Me.Controls.Add(Me.lblrandomnumber)
        Me.Name = "frmZufallszeichnung"
        Me.Text = "Zufallszahlen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblrandomnumber As Label
    Friend WithEvents btnrandomnumber As Button
    Friend WithEvents hsbUGrenze As HScrollBar
    Friend WithEvents HsbOGrenze As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUGrenze As Label
    Friend WithEvents lblOGrenze As Label
End Class
