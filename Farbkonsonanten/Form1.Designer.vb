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
        Me.lblFarbe = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btncyanforeground = New System.Windows.Forms.Button()
        Me.btnwhiteforeground = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnschwarz = New System.Windows.Forms.Button()
        Me.btnrot = New System.Windows.Forms.Button()
        Me.btngrün = New System.Windows.Forms.Button()
        Me.btngelb = New System.Windows.Forms.Button()
        Me.btnblau = New System.Windows.Forms.Button()
        Me.magenta = New System.Windows.Forms.Button()
        Me.btncyan = New System.Windows.Forms.Button()
        Me.btnweiß = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFarbe
        '
        Me.lblFarbe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFarbe.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarbe.Location = New System.Drawing.Point(110, 133)
        Me.lblFarbe.Name = "lblFarbe"
        Me.lblFarbe.Size = New System.Drawing.Size(476, 23)
        Me.lblFarbe.TabIndex = 8
        Me.lblFarbe.Text = "Hier steht dein Text!"
        Me.lblFarbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(511, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "schwarz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(511, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "rot"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(511, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "grün"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(511, 179)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "gelb"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(391, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "blau"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(391, 237)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "magenta"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btncyanforeground
        '
        Me.btncyanforeground.Location = New System.Drawing.Point(391, 208)
        Me.btncyanforeground.Name = "btncyanforeground"
        Me.btncyanforeground.Size = New System.Drawing.Size(75, 23)
        Me.btncyanforeground.TabIndex = 10
        Me.btncyanforeground.Text = "cyan"
        Me.btncyanforeground.UseVisualStyleBackColor = True
        '
        'btnwhiteforeground
        '
        Me.btnwhiteforeground.Location = New System.Drawing.Point(391, 179)
        Me.btnwhiteforeground.Name = "btnwhiteforeground"
        Me.btnwhiteforeground.Size = New System.Drawing.Size(75, 23)
        Me.btnwhiteforeground.TabIndex = 9
        Me.btnwhiteforeground.Text = "weiß"
        Me.btnwhiteforeground.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnschwarz)
        Me.GroupBox1.Controls.Add(Me.btnrot)
        Me.GroupBox1.Controls.Add(Me.btngrün)
        Me.GroupBox1.Controls.Add(Me.btngelb)
        Me.GroupBox1.Controls.Add(Me.btnblau)
        Me.GroupBox1.Controls.Add(Me.magenta)
        Me.GroupBox1.Controls.Add(Me.btncyan)
        Me.GroupBox1.Controls.Add(Me.btnweiß)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 173)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hintergrund"
        '
        'btnschwarz
        '
        Me.btnschwarz.Location = New System.Drawing.Point(126, 116)
        Me.btnschwarz.Name = "btnschwarz"
        Me.btnschwarz.Size = New System.Drawing.Size(75, 23)
        Me.btnschwarz.TabIndex = 15
        Me.btnschwarz.Text = "schwarz"
        Me.btnschwarz.UseVisualStyleBackColor = True
        '
        'btnrot
        '
        Me.btnrot.Location = New System.Drawing.Point(126, 87)
        Me.btnrot.Name = "btnrot"
        Me.btnrot.Size = New System.Drawing.Size(75, 23)
        Me.btnrot.TabIndex = 14
        Me.btnrot.Text = "rot"
        Me.btnrot.UseVisualStyleBackColor = True
        '
        'btngrün
        '
        Me.btngrün.Location = New System.Drawing.Point(126, 58)
        Me.btngrün.Name = "btngrün"
        Me.btngrün.Size = New System.Drawing.Size(75, 23)
        Me.btngrün.TabIndex = 13
        Me.btngrün.Text = "grün"
        Me.btngrün.UseVisualStyleBackColor = True
        '
        'btngelb
        '
        Me.btngelb.Location = New System.Drawing.Point(126, 29)
        Me.btngelb.Name = "btngelb"
        Me.btngelb.Size = New System.Drawing.Size(75, 23)
        Me.btngelb.TabIndex = 12
        Me.btngelb.Text = "gelb"
        Me.btngelb.UseVisualStyleBackColor = True
        '
        'btnblau
        '
        Me.btnblau.Location = New System.Drawing.Point(6, 116)
        Me.btnblau.Name = "btnblau"
        Me.btnblau.Size = New System.Drawing.Size(75, 23)
        Me.btnblau.TabIndex = 11
        Me.btnblau.Text = "blau"
        Me.btnblau.UseVisualStyleBackColor = True
        '
        'magenta
        '
        Me.magenta.Location = New System.Drawing.Point(6, 87)
        Me.magenta.Name = "magenta"
        Me.magenta.Size = New System.Drawing.Size(75, 23)
        Me.magenta.TabIndex = 10
        Me.magenta.Text = "magenta"
        Me.magenta.UseVisualStyleBackColor = True
        '
        'btncyan
        '
        Me.btncyan.Location = New System.Drawing.Point(6, 58)
        Me.btncyan.Name = "btncyan"
        Me.btncyan.Size = New System.Drawing.Size(75, 23)
        Me.btncyan.TabIndex = 9
        Me.btncyan.Text = "cyan"
        Me.btncyan.UseVisualStyleBackColor = True
        '
        'btnweiß
        '
        Me.btnweiß.Location = New System.Drawing.Point(6, 29)
        Me.btnweiß.Name = "btnweiß"
        Me.btnweiß.Size = New System.Drawing.Size(75, 23)
        Me.btnweiß.TabIndex = 8
        Me.btnweiß.Text = "weiß"
        Me.btnweiß.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btncyanforeground)
        Me.Controls.Add(Me.btnwhiteforeground)
        Me.Controls.Add(Me.lblFarbe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFarbe As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btncyanforeground As Button
    Friend WithEvents btnwhiteforeground As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnschwarz As Button
    Friend WithEvents btnrot As Button
    Friend WithEvents btngrün As Button
    Friend WithEvents btngelb As Button
    Friend WithEvents btnblau As Button
    Friend WithEvents magenta As Button
    Friend WithEvents btncyan As Button
    Friend WithEvents btnweiß As Button
End Class
