<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtDevinette1 = New System.Windows.Forms.TextBox()
        Me.txtDevinette2 = New System.Windows.Forms.TextBox()
        Me.txtDevinette3 = New System.Windows.Forms.TextBox()
        Me.btnVerifier = New System.Windows.Forms.Button()
        Me.lblCouleur = New System.Windows.Forms.Label()
        Me.lblEndroit = New System.Windows.Forms.Label()
        Me.lblMessage2 = New System.Windows.Forms.Label()
        Me.lblMessage1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstruction.Location = New System.Drawing.Point(13, 23)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(277, 40)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Inscrire une couleur dans chacune des " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cases (R, V, B ou J - en majuscules):"
        '
        'txtDevinette1
        '
        Me.txtDevinette1.Location = New System.Drawing.Point(309, 36)
        Me.txtDevinette1.Name = "txtDevinette1"
        Me.txtDevinette1.Size = New System.Drawing.Size(54, 27)
        Me.txtDevinette1.TabIndex = 1
        '
        'txtDevinette2
        '
        Me.txtDevinette2.Location = New System.Drawing.Point(369, 36)
        Me.txtDevinette2.Name = "txtDevinette2"
        Me.txtDevinette2.Size = New System.Drawing.Size(53, 27)
        Me.txtDevinette2.TabIndex = 2
        '
        'txtDevinette3
        '
        Me.txtDevinette3.Location = New System.Drawing.Point(428, 36)
        Me.txtDevinette3.Name = "txtDevinette3"
        Me.txtDevinette3.Size = New System.Drawing.Size(51, 27)
        Me.txtDevinette3.TabIndex = 3
        '
        'btnVerifier
        '
        Me.btnVerifier.Location = New System.Drawing.Point(67, 87)
        Me.btnVerifier.Name = "btnVerifier"
        Me.btnVerifier.Size = New System.Drawing.Size(322, 27)
        Me.btnVerifier.TabIndex = 4
        Me.btnVerifier.Text = "Vérifier ma prévision"
        Me.btnVerifier.UseVisualStyleBackColor = True
        '
        'lblCouleur
        '
        Me.lblCouleur.AutoSize = True
        Me.lblCouleur.Location = New System.Drawing.Point(346, 136)
        Me.lblCouleur.Name = "lblCouleur"
        Me.lblCouleur.Size = New System.Drawing.Size(0, 20)
        Me.lblCouleur.TabIndex = 5
        '
        'lblEndroit
        '
        Me.lblEndroit.AutoSize = True
        Me.lblEndroit.Location = New System.Drawing.Point(294, 168)
        Me.lblEndroit.Name = "lblEndroit"
        Me.lblEndroit.Size = New System.Drawing.Size(0, 20)
        Me.lblEndroit.TabIndex = 6
        '
        'lblMessage2
        '
        Me.lblMessage2.AutoSize = True
        Me.lblMessage2.Location = New System.Drawing.Point(39, 168)
        Me.lblMessage2.Name = "lblMessage2"
        Me.lblMessage2.Size = New System.Drawing.Size(249, 20)
        Me.lblMessage2.TabIndex = 7
        Me.lblMessage2.Text = "Nombre de couleurs au bon endroit:"
        '
        'lblMessage1
        '
        Me.lblMessage1.AutoSize = True
        Me.lblMessage1.Location = New System.Drawing.Point(39, 136)
        Me.lblMessage1.Name = "lblMessage1"
        Me.lblMessage1.Size = New System.Drawing.Size(301, 20)
        Me.lblMessage1.TabIndex = 8
        Me.lblMessage1.Text = "Nombre de couleurs devinées correctement:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 279)
        Me.Controls.Add(Me.lblMessage1)
        Me.Controls.Add(Me.lblMessage2)
        Me.Controls.Add(Me.lblEndroit)
        Me.Controls.Add(Me.lblCouleur)
        Me.Controls.Add(Me.btnVerifier)
        Me.Controls.Add(Me.txtDevinette3)
        Me.Controls.Add(Me.txtDevinette2)
        Me.Controls.Add(Me.txtDevinette1)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "Form1"
        Me.Text = "Le jeu Mastermind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtDevinette1 As TextBox
    Friend WithEvents txtDevinette2 As TextBox
    Friend WithEvents txtDevinette3 As TextBox
    Friend WithEvents btnVerifier As Button
    Friend WithEvents lblCouleur As Label
    Friend WithEvents lblEndroit As Label
    Friend WithEvents lblMessage2 As Label
    Friend WithEvents lblMessage1 As Label
End Class
