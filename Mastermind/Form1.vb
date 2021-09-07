Public Class Form1
    '****************************************************************************************
    '*Travail : Programme de jeu Mastermind
    '*Programmeuse : Staisha Neville
    '*Date : février 2021
    '*But : Utilisation des énoncés If...Then...Else
    '****************************************************************************************

    Private Sub btnVerifier_Click(sender As Object, e As EventArgs) Handles btnVerifier.Click
        '************************************************************************************
        '*Procédure : btnVerifier_Click
        '*But : Affiché le nombre de couleurs devinés correctement et combien sont dans le bon 
        '      ordre
        '************************************************************************************

        'Partie 1 : afficher combien de couleurs sont dans le bon ordre.

        'Déclaration des variables
        Dim ordrecorrect1 As Integer
        Dim ordrecorrect2 As Integer
        Dim ordrecorrect3 As Integer

        Dim strReponse1 As String = txtDevinette1.Text
        Dim strReponse2 As String = txtDevinette2.Text
        Dim strReponse3 As String = txtDevinette3.Text

        'Structure décisionnelle imbriquée
        If strReponse1 = "R" Then
            ordrecorrect1 = 1

        Else ordrecorrect1 = 0
        End If

        If strReponse2 = "J" Then
            ordrecorrect2 = 1

        Else ordrecorrect2 = 0
        End If

        If strReponse3 = "B" Then
            ordrecorrect3 = 1

        Else ordrecorrect3 = 0
        End If

        'Calcul du nombre de couleurs au bon endroit

        Me.lblEndroit.Text = ordrecorrect1 + ordrecorrect2 + ordrecorrect3


        '************************************************************************************
        'Partie 2 : afficher combien de couleurs ont été devinés correctement

        'Déclaration des variables
        Dim couleurcorrect1 As Integer
        Dim couleurcorrect2 As Integer
        Dim couleurcorrect3 As Integer

        'Structure décisionnelle imbriquée
        If strReponse1 = "R" And strReponse2 = "R" And strReponse3 = "R" Then
            couleurcorrect1 = 3
        ElseIf strReponse1 = "R" And strReponse2 = "R" Then
            couleurcorrect1 = 2
        ElseIf strReponse1 = "R" And strReponse3 = "R" Then
            couleurcorrect1 = 2
        ElseIf strReponse2 = "R" And strReponse3 = "R" Then
            couleurcorrect1 = 2
        ElseIf strReponse1 = "R" Or strReponse2 = "R" Or strReponse3 = "R" Then
            couleurcorrect1 = 1
        End If

        If strReponse1 = "J" And strReponse2 = "J" And strReponse3 = "J" Then
            couleurcorrect2 = 3
        ElseIf strReponse1 = "J" And strReponse2 = "J" Then
            couleurcorrect2 = 2
        ElseIf strReponse1 = "J" And strReponse3 = "J" Then
            couleurcorrect2 = 2
        ElseIf strReponse2 = "J" And strReponse3 = "J" Then
            couleurcorrect2 = 2
        ElseIf strReponse1 = "J" Or strReponse2 = "J" Or strReponse3 = "J" Then
            couleurcorrect2 = 1
        End If

        If strReponse1 = "B" And strReponse2 = "B" And strReponse3 = "B" Then
            couleurcorrect3 = 3
        ElseIf strReponse1 = "B" And strReponse2 = "B" Then
            couleurcorrect3 = 2
        ElseIf strReponse1 = "B" And strReponse3 = "B" Then
            couleurcorrect3 = 2
        ElseIf strReponse2 = "B" And strReponse3 = "B" Then
            couleurcorrect3 = 2
        ElseIf strReponse1 = "B" Or strReponse2 = "B" Or strReponse3 = "B" Then
            couleurcorrect3 = 1
        End If

        'Calcul du nombre de couleurs devinés correctement
        Me.lblCouleur.Text = couleurcorrect1 + couleurcorrect2 + couleurcorrect3

    End Sub
End Class
