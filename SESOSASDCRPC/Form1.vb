Imports DiscordRPC
Imports DiscordRPC.Logging
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.IO

Namespace SESOSASDCRPC
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub label7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label7.Click

		End Sub

		Private Sub textBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox7.TextChanged

		End Sub

		Public client As DiscordRpcClient

		Public started As Boolean = False

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If started Then
				Update()
			Else
				Initialize()
				textBox1.Enabled = False
				textBox5.Enabled = False
				textBox7.Enabled = False
				button2.Enabled = True
				button1.Text = "Update"
			End If
			SaveAndLoad(True)
		End Sub

		'Called when your application first starts.
		'For example, just before your main loop, on OnEnable for unity.
		Private Sub Initialize()
'            
'            Create a Discord client
'            NOTE: 	If you are using Unity3D, you must use the full constructor and define
'                     the pipe connection.
'            
			client = New DiscordRpcClient(textBox1.Text)

			'Set the logger
			client.Logger = New ConsoleLogger() With {.Level = LogLevel.Warning}

			'Subscribe to events
'            
'            client.OnReady += (sender, e) =>
'            {
'                listBox1.Items.Add("Received Ready from user " + e.User.Username);
'            };
'
'            client.OnPresenceUpdate += (sender, e) =>
'            {
'                listBox1.Items.Add("Received Update! " + e.Presence);
'            };
'            
			'Connect to the RPC
			client.Initialize()

			'Set the rich presence
			'Call this as many times as you want and anywhere in your code.
			client.SetPresence(New RichPresence() With {.Details = textBox2.Text, .State = textBox3.Text, .Assets = New Assets() With {.LargeImageKey = textBox4.Text, .LargeImageText = textBox5.Text, .SmallImageKey = textBox6.Text, .SmallImageText = textBox7.Text}, .Timestamps = Timestamps.Now})

			started = Not started
		End Sub

		Private Overloads Sub Update()
			client.UpdateDetails(textBox2.Text)
			client.UpdateState(textBox3.Text)
			client.UpdateLargeAsset(textBox4.Text)
			client.UpdateSmallAsset(textBox6.Text)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			SaveAndLoad(False)
			button2.Enabled = False
			button1.Text = "Start"
		End Sub

		Private Sub SaveAndLoad(ByVal save As Boolean)
			Dim path As String = Directory.GetCurrentDirectory() & "/config.cfg"
			Try
				If save Then
					File.WriteAllText(path, $"{textBox1.Text}" & ControlChars.Lf & $"{textBox2.Text}" & ControlChars.Lf & $"{textBox3.Text}" & ControlChars.Lf & $"{textBox6.Text}" & ControlChars.Lf & $"{textBox5.Text}" & ControlChars.Lf & $"{textBox4.Text}" & ControlChars.Lf & $"{textBox7.Text}")
				Else
					If File.Exists(path) Then
						If File.ReadAllText(path) IsNot Nothing Then
							Dim cfg() As String = File.ReadAllLines(path)
							textBox1.Text = cfg(0)
							textBox2.Text = cfg(1)
							textBox3.Text = cfg(2)
							textBox6.Text = cfg(3)
							textBox5.Text = cfg(4)
							textBox4.Text = cfg(5)
							textBox7.Text = cfg(6)
						End If
					Else
						File.WriteAllText(Directory.GetCurrentDirectory() & "/config.cfg", "")
					End If
				End If
			Catch

			End Try
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			client.ClearPresence()
			button2.Enabled = False
			button1.Text = "Start"
			started = Not started
		End Sub
	End Class
End Namespace
