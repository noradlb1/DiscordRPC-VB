Namespace SESOSASDCRPC
	Partial Public Class Form1
		''' <summary>
		''' Erforderliche Designervariable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Verwendete Ressourcen bereinigen.
		''' </summary>
		''' <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Vom Windows Form-Designer generierter Code"

		''' <summary>
		''' Erforderliche Methode für die Designerunterstützung.
		''' Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.textBox6 = New System.Windows.Forms.TextBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.textBox5 = New System.Windows.Forms.TextBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.textBox4 = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.textBox7 = New System.Windows.Forms.TextBox()
			Me.button2 = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.textBox3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.textBox2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.groupBox1.Location = New System.Drawing.Point(12, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(200, 139)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(12, 310)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(90, 27)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Update"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label7)
			Me.groupBox2.Controls.Add(Me.textBox7)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.textBox4)
			Me.groupBox2.Controls.Add(Me.textBox6)
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.textBox5)
			Me.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.groupBox2.Location = New System.Drawing.Point(12, 157)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(200, 139)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(81, 38)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(113, 20)
			Me.textBox1.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(16, 41)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(21, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "ID:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(16, 67)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(42, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Details:"
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(81, 64)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(113, 20)
			Me.textBox2.TabIndex = 4
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(16, 93)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(35, 13)
			Me.label3.TabIndex = 7
			Me.label3.Text = "State:"
			' 
			' textBox3
			' 
			Me.textBox3.Location = New System.Drawing.Point(81, 90)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(113, 20)
			Me.textBox3.TabIndex = 6
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(16, 79)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(82, 13)
			Me.label4.TabIndex = 13
			Me.label4.Text = "SmallImageKey:"
			' 
			' textBox6
			' 
			Me.textBox6.Location = New System.Drawing.Point(106, 76)
			Me.textBox6.Name = "textBox6"
			Me.textBox6.Size = New System.Drawing.Size(88, 20)
			Me.textBox6.TabIndex = 12
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(16, 53)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(87, 13)
			Me.label5.TabIndex = 11
			Me.label5.Text = "LargeImageText:"
			' 
			' textBox5
			' 
			Me.textBox5.Location = New System.Drawing.Point(106, 50)
			Me.textBox5.Name = "textBox5"
			Me.textBox5.Size = New System.Drawing.Size(88, 20)
			Me.textBox5.TabIndex = 10
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(16, 27)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(84, 13)
			Me.label6.TabIndex = 9
			Me.label6.Text = "LargeImageKey:"
			' 
			' textBox4
			' 
			Me.textBox4.Location = New System.Drawing.Point(106, 24)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New System.Drawing.Size(88, 20)
			Me.textBox4.TabIndex = 8
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(16, 105)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(85, 13)
			Me.label7.TabIndex = 15
			Me.label7.Text = "SmallImageText:"
'			Me.label7.Click += New System.EventHandler(Me.label7_Click)
			' 
			' textBox7
			' 
			Me.textBox7.Location = New System.Drawing.Point(106, 102)
			Me.textBox7.Name = "textBox7"
			Me.textBox7.Size = New System.Drawing.Size(88, 20)
			Me.textBox7.TabIndex = 14
'			Me.textBox7.TextChanged += New System.EventHandler(Me.textBox7_TextChanged)
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(122, 310)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(90, 27)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Stop"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			Me.ClientSize = New System.Drawing.Size(223, 349)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.groupBox1)
			Me.Cursor = System.Windows.Forms.Cursors.Default
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "DiscordRpc"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private textBox3 As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private textBox2 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents label7 As System.Windows.Forms.Label
		Private WithEvents textBox7 As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private textBox4 As System.Windows.Forms.TextBox
		Private textBox6 As System.Windows.Forms.TextBox
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private textBox5 As System.Windows.Forms.TextBox
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace

