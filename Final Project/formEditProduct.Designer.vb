<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxOldStock = New System.Windows.Forms.TextBox()
        Me.textboxOldPrice = New System.Windows.Forms.TextBox()
        Me.textboxOldName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelErrorPrice = New System.Windows.Forms.Label()
        Me.labelErrorStock = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textboxNewStock = New System.Windows.Forms.TextBox()
        Me.textboxNewPrice = New System.Windows.Forms.TextBox()
        Me.textboxNewName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buttonSubmit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelError = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID"
        '
        'textboxID
        '
        Me.textboxID.Location = New System.Drawing.Point(81, 18)
        Me.textboxID.Name = "textboxID"
        Me.textboxID.Size = New System.Drawing.Size(108, 23)
        Me.textboxID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.textboxOldStock)
        Me.GroupBox1.Controls.Add(Me.textboxOldPrice)
        Me.GroupBox1.Controls.Add(Me.textboxOldName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 121)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Old Product Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Product Stock"
        '
        'textboxOldStock
        '
        Me.textboxOldStock.Location = New System.Drawing.Point(96, 74)
        Me.textboxOldStock.Name = "textboxOldStock"
        Me.textboxOldStock.ReadOnly = True
        Me.textboxOldStock.Size = New System.Drawing.Size(115, 23)
        Me.textboxOldStock.TabIndex = 5
        '
        'textboxOldPrice
        '
        Me.textboxOldPrice.Location = New System.Drawing.Point(96, 45)
        Me.textboxOldPrice.Name = "textboxOldPrice"
        Me.textboxOldPrice.ReadOnly = True
        Me.textboxOldPrice.Size = New System.Drawing.Size(115, 23)
        Me.textboxOldPrice.TabIndex = 4
        '
        'textboxOldName
        '
        Me.textboxOldName.Location = New System.Drawing.Point(96, 16)
        Me.textboxOldName.Name = "textboxOldName"
        Me.textboxOldName.ReadOnly = True
        Me.textboxOldName.Size = New System.Drawing.Size(296, 23)
        Me.textboxOldName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.labelErrorPrice)
        Me.GroupBox2.Controls.Add(Me.labelErrorStock)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.textboxNewStock)
        Me.GroupBox2.Controls.Add(Me.textboxNewPrice)
        Me.GroupBox2.Controls.Add(Me.textboxNewName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 121)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Product Data"
        '
        'labelErrorPrice
        '
        Me.labelErrorPrice.AutoSize = True
        Me.labelErrorPrice.ForeColor = System.Drawing.Color.Red
        Me.labelErrorPrice.Location = New System.Drawing.Point(217, 48)
        Me.labelErrorPrice.Name = "labelErrorPrice"
        Me.labelErrorPrice.Size = New System.Drawing.Size(87, 15)
        Me.labelErrorPrice.TabIndex = 12
        Me.labelErrorPrice.Text = "Numbers Only!"
        '
        'labelErrorStock
        '
        Me.labelErrorStock.AutoSize = True
        Me.labelErrorStock.ForeColor = System.Drawing.Color.Red
        Me.labelErrorStock.Location = New System.Drawing.Point(217, 77)
        Me.labelErrorStock.Name = "labelErrorStock"
        Me.labelErrorStock.Size = New System.Drawing.Size(87, 15)
        Me.labelErrorStock.TabIndex = 11
        Me.labelErrorStock.Text = "Numbers Only!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product Stock"
        '
        'textboxNewStock
        '
        Me.textboxNewStock.Location = New System.Drawing.Point(96, 74)
        Me.textboxNewStock.Name = "textboxNewStock"
        Me.textboxNewStock.Size = New System.Drawing.Size(115, 23)
        Me.textboxNewStock.TabIndex = 5
        '
        'textboxNewPrice
        '
        Me.textboxNewPrice.Location = New System.Drawing.Point(96, 45)
        Me.textboxNewPrice.Name = "textboxNewPrice"
        Me.textboxNewPrice.Size = New System.Drawing.Size(115, 23)
        Me.textboxNewPrice.TabIndex = 4
        '
        'textboxNewName
        '
        Me.textboxNewName.Location = New System.Drawing.Point(96, 16)
        Me.textboxNewName.Name = "textboxNewName"
        Me.textboxNewName.Size = New System.Drawing.Size(296, 23)
        Me.textboxNewName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Product Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Product Name"
        '
        'buttonSubmit
        '
        Me.buttonSubmit.Location = New System.Drawing.Point(335, 301)
        Me.buttonSubmit.Name = "buttonSubmit"
        Me.buttonSubmit.Size = New System.Drawing.Size(75, 23)
        Me.buttonSubmit.TabIndex = 8
        Me.buttonSubmit.Text = "Submit"
        Me.buttonSubmit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Leave the data empty if you don't want to replace the data"
        '
        'labelError
        '
        Me.labelError.AutoSize = True
        Me.labelError.ForeColor = System.Drawing.Color.Red
        Me.labelError.Location = New System.Drawing.Point(195, 21)
        Me.labelError.Name = "labelError"
        Me.labelError.Size = New System.Drawing.Size(158, 15)
        Me.labelError.TabIndex = 10
        Me.labelError.Text = "Product ID Cannot Be Empty"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CHANGE", "ADD", "SUBTRACT"})
        Me.ComboBox1.Location = New System.Drawing.Point(310, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 23)
        Me.ComboBox1.TabIndex = 13
        '
        'formEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 332)
        Me.Controls.Add(Me.labelError)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.buttonSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.textboxID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formEditProduct"
        Me.Text = "Modify Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textboxID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textboxOldStock As TextBox
    Friend WithEvents textboxOldPrice As TextBox
    Friend WithEvents textboxOldName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textboxNewStock As TextBox
    Friend WithEvents textboxNewPrice As TextBox
    Friend WithEvents textboxNewName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents buttonSubmit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents labelError As Label
    Friend WithEvents labelErrorPrice As Label
    Friend WithEvents labelErrorStock As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
