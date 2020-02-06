Imports System.IO
Public Class frmRQ
    Private m_DictPersonne As Dictionary(Of String, Personne)
#Region "Méthode(s)"
    ''' <summary>
    ''' Permet de charger les données du fichier reçu en paramètre.
    ''' </summary>
    ''' <param name="pFile">Nom du fichier de données.</param>
    Private Sub ChargerDonneesDuFichier(pFile As String)
        Dim uneCompagnie As Compagnie = Nothing
        Dim uneQueue As New Queue(Of String)
        uneQueue = LireFichier(pFile.ToString())
        If uneQueue.Count = 0 OrElse uneQueue.Peek <> "compagnie>" Then
            ep.SetError(btnRecherche, "C'mon bro, ouvre un fichier valide.")
        Else
            While uneQueue.Count > 0
                uneCompagnie = CreerCompagnie(uneQueue)
                MakeTreeView(uneCompagnie, uneQueue)
                If uneCompagnie IsNot Nothing Then
                    AfficherNoeud(uneCompagnie)
                    ValidationDesCompagnies(uneCompagnie)
                    tvCompagnie.Nodes.Add(uneCompagnie)
                End If
            End While
            ep.SetError(btnRecherche, "")
        End If
    End Sub
    ''' <summary>
    ''' Permet de lire le fichier reçu en paramètre et de récupérer les données
    ''' des compagnies et des personnes qui les composent.
    ''' </summary>
    ''' <param name="pNomFichier">Le nom du fichier reçu en paramètre.</param>
    ''' <returns>Une file.</returns>
    Private Function LireFichier(pNomFichier As String) As Queue(Of String)
        Dim fileRetour = New Queue(Of String)
        Using ficRead As New StreamReader(pNomFichier)
            For Each elem In ficRead.ReadToEnd().Split("<")
                fileRetour.Enqueue(elem.Trim())
            Next
            fileRetour.Dequeue()
        End Using
        Return fileRetour
    End Function
    ''' <summary>
    ''' Permet de créer une compagnie à l'aide des données de la file reçue
    ''' en paramètre.
    ''' </summary>
    ''' <param name="pQueueLu">File contenant les informations du fichier lu.</param>
    ''' <returns>Une compagnie.</returns>
    Public Function CreerCompagnie(pQueueLu As Queue(Of String)) As Compagnie
        Dim compRetour As Compagnie = Nothing
        If pQueueLu.Peek <> "/compagnie>" Then
            Dim strNom, strRevenu As String
            pQueueLu.Dequeue()
            strNom = pQueueLu.Dequeue().Substring(4)
            pQueueLu.Dequeue()
            strRevenu = pQueueLu.Dequeue().Substring(7)
            pQueueLu.Dequeue()
            compRetour = New Compagnie(strNom, strRevenu)
            While pQueueLu.Peek.Contains("personne")
                compRetour.LstPersonnes.Add(CreerPersonne(pQueueLu, compRetour))
                pQueueLu.Dequeue()
            End While
        End If
        Return compRetour
    End Function
    ''' <summary>
    ''' Permet de créer une personne à l'aide des données de la file et de la compagnie reçue
    ''' en paramètres.
    ''' </summary>
    ''' <param name="pQueueLu">File contenant les informations du fichier lu.</param>
    ''' <param name="pComp">Compagnie de la personne.</param>
    ''' <returns>Une personne.</returns>
    Public Function CreerPersonne(pQueueLu As Queue(Of String), pComp As Compagnie) As Personne
        Dim listSplitee As New Queue(Of String)
        Dim strNom, strID As String
        For Each elem In pQueueLu.Peek.Split("""")
            listSplitee.Enqueue(elem)
        Next
        listSplitee.Dequeue()
        strID = listSplitee.Dequeue()
        listSplitee.Dequeue()
        strNom = listSplitee.Dequeue()
        Dim PersRetour As New Personne(strID, strNom)
        PersRetour.LstCompagnies.Add(pComp)
        AjouterBibliotheque(m_DictPersonne, PersRetour)
        Return PersRetour
    End Function
    ''' <summary>
    ''' Permet d'ajouter une personne dans la table de hashage de personne
    ''' pour permettre une recherche par index.
    ''' </summary>
    ''' <param name="pPers">La personne à ajouter</param>
    ''' <returns>Vrai en cas de réussite de l'ajout.</returns>
    Public Function AjouterBibliotheque(pHashTable As Dictionary(Of String, Personne),
                                        pPers As Personne) As Boolean
        If pHashTable.ContainsKey(pPers.ID) Then
            If Not VerifierExistenceCompagnieDansListePersonne(pHashTable(pPers.ID), pPers) Then
                pHashTable(pPers.ID).LstCompagnies.Add(pPers.LstCompagnies(0))
            End If
            Return False
        Else
            pHashTable(pPers.ID) = pPers
            Return True
        End If
    End Function
    ''' <summary>
    ''' Permet de vérifier qu'une compagnie existe déjà dans la liste de compagnie
    ''' </summary>
    ''' <param name="pPersHashtable">La table de hashage.</param>
    ''' <param name="pPers">La personne dans la liste va être parcouru.</param>
    ''' <returns>Vrai si la compagnie existe.</returns>
    Private Function VerifierExistenceCompagnieDansListePersonne(pPersHashtable As Personne, pPers As Personne) As Boolean
        For Each elem In pPersHashtable.LstCompagnies
            For Each elempPers In pPers.LstCompagnies
                If elem.Nom = elempPers.Nom Then
                    elem = elempPers
                    Return True
                End If
            Next
        Next
        Return False
    End Function
    ''' <summary>
    ''' Permet de chercher dans le dictionnaire et d'afficher dans la liste des personnes
    ''' les information de cette personne.
    ''' </summary>
    ''' <param name="pHashTable">La table de hashage.</param>
    ''' <param name="pCle">La clé de recherche.</param>
    ''' <returns>Vrai si la clé existe.</returns>
    Private Function ChercherDansBibliotheque(pHashTable As Dictionary(Of String, Personne),
                                              pCle As String) As Boolean
        If pHashTable.ContainsKey(pCle) Then
            With lstPers.Items
                .Add(pHashTable(pCle))
                .Add("Liste des compagnie de " & pHashTable(pCle).Nom & " :")
                For Each elem In pHashTable(pCle).LstCompagnies
                    .Add(elem)
                Next
            End With
            ep.SetError(btnRecherche, "")
            Return True
        End If
        ep.SetError(btnRecherche, "Pas fort ta recherche de personne. Essaye encore. Tu peux y arriver.")
        Return False
    End Function
    ''' <summary>
    ''' Permet de créer l'arbre dans lequel vont être affichées les compagnies
    ''' du fichier chargé.
    ''' </summary>
    ''' <param name="pComp">La compagnie reçu en paramètre.</param>
    Public Sub MakeTreeView(pComp As Compagnie, pQueueLu As Queue(Of String))
        If Not pQueueLu.Peek.Contains("/compagnie") Then
            Dim compACreer As Compagnie = CreerCompagnie(pQueueLu)
            ValidationDesCompagnies(compACreer)
            pComp.Nodes.Add(compACreer)
            MakeTreeView(compACreer, pQueueLu)
        Else
            pQueueLu.Dequeue()
        End If
    End Sub
    ''' <summary>
    ''' Permet d'Afficher le nom des compagnies et de leurs 
    ''' enfants.
    ''' </summary>
    ''' <param name="pNoeud">La compagnie courante.</param>
    Private Sub AfficherNoeud(pNoeud As Compagnie)
        pNoeud.Text = pNoeud.ToString()
        For Each elem In pNoeud.Nodes
            AfficherNoeud(elem)
        Next
    End Sub
    ''' <summary>
    ''' Permet de vérifier l'existence d'une compagnie dans le TreeView.
    ''' Si la compagnie existe, on la méthode retourne vrai.
    ''' </summary>
    ''' <param name="pCompCree">Compagnie à vérifier</param>
    ''' <returns>Vrai si existence.</returns>
    Private Function VerifierExistenceCompagnieTV(pCompCree As Compagnie, pNodeTv As Compagnie) As Boolean
        If pNodeTv IsNot Nothing Then
            If pNodeTv.Nom = pCompCree.Nom Then
                tvCompagnie.Nodes.Remove(pNodeTv)
                Return True
            Else
                Return VerifierExistenceCompagnieTV(pCompCree, pNodeTv.FirstNode)
            End If
        End If
        Return False
    End Function
    ''' <summary>
    ''' Permet de chercher une compagnie existante dans le TreeView, l'afficher dans le
    ''' listebox prévu à cet effet et de la sélectionner dans l'arbre.
    ''' </summary>
    ''' <param name="pNom">Nom de la compagnie.</param>
    ''' <param name="pComp">Compagnie à comparer.</param>
    ''' <returns>Vrai si la compagnie est trouvée</returns>
    Private Function RechercherCompagnie(pNom As String, pComp As Compagnie) As Boolean
        If pComp IsNot Nothing Then
            If pNom = pComp.Nom Then
                AfficherNoeud(pComp)
                tvCompagnie.SelectedNode = pComp
                tvCompagnie.Focus()
                Return True
            Else
                pComp = pComp.FirstNode
                Return RechercherCompagnie(pNom, pComp)
            End If
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Permet d'afficher le nom de la compagnie et ses différents membres
    ''' dans le listBox prévu à cet effet.
    ''' </summary>
    ''' <param name="pComp"></param>
    Private Sub AfficherLaCompagnieDansLaliste(pComp As Compagnie)
        With lstCompagnies.Items
            .Add("Nom de la compagnie : " & pComp.Nom)
            .Add("Revenu de la compagnie : " & pComp.Revenu)
            .Add("Liste de personnes :")
            For Each elem In pComp.LstPersonnes
                .Add(elem)
            Next
        End With
    End Sub
    ''' <summary>
    ''' Permet de créer la chaîne de données qui va être écrite dans le fichier de sauvegarde.
    ''' </summary>
    ''' <returns>La chaîne.</returns>
    Private Function ChaineDeDonnees(pComp As Compagnie, pUneStr As String) As String
        pUneStr += "<compagnie><nom>" & pComp.Nom & "</nom><revenu>" & pComp.Revenu & "</revenu>"
        For Each elem In pComp.LstPersonnes
            pUneStr += "<personne id=""" & elem.ID & """ nom=""" & elem.Nom & """/>"
        Next
        If pComp.FirstNode IsNot Nothing Then
            Return ChaineDeDonnees(pComp.FirstNode, pUneStr)
        Else
            Return pUneStr
        End If
    End Function
    ''' <summary>
    ''' Permet de valider qu'une compagnie n'existe pas dans le TV avant de l'y ajouter.
    ''' </summary>
    ''' <param name="pCompAValider">La compagnie à valider.</param>
    Private Sub ValidationDesCompagnies(pCompAValider As Compagnie)
        Dim i As Integer = 0
        While tvCompagnie.Nodes.Count > 0 AndAlso i <= tvCompagnie.Nodes.Count - 1 AndAlso
            Not VerifierExistenceCompagnieTV(pCompAValider, tvCompagnie.Nodes(i))
            i += 1
        End While
    End Sub
#End Region
#Region "Évenement(s)"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_DictPersonne = New Dictionary(Of String, Personne)
        If File.Exists("./sauvegarde.txt") Then ChargerDonneesDuFichier("./sauvegarde.txt")
    End Sub
    Private Sub msOuvrir_Click(sender As Object, e As EventArgs) Handles msOuvrir.Click
        Dim dialog As New OpenFileDialog
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then ChargerDonneesDuFichier(dialog.FileName)
    End Sub
    Private Sub tvCompagnie_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvCompagnie.AfterSelect
        lstCompagnies.Items.Clear()
        If tvCompagnie.SelectedNode IsNot Nothing Then AfficherLaCompagnieDansLaliste(tvCompagnie.SelectedNode)
    End Sub
    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
        If tvCompagnie.TopNode IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtRecherche.Text) AndAlso Not String.IsNullOrWhiteSpace(txtRecherche.Text) Then
            If Char.IsLetter(txtRecherche.Text(0)) Then
                lstCompagnies.Items.Clear()
                Dim i As Integer = 0
                While tvCompagnie.Nodes.Count > 0 AndAlso i <= tvCompagnie.Nodes.Count - 1 AndAlso
                    Not RechercherCompagnie(txtRecherche.Text, tvCompagnie.Nodes(i))
                    i += 1
                End While
                If lstCompagnies.Items.Count = 0 Then
                    ep.SetError(btnRecherche, "Est-ce la compagnie à ta blonde ? Le nom " & txtRecherche.Text & " n'existe pas ici.")
                Else
                    ep.SetError(btnRecherche, "")
                End If

            Else
                lstPers.Items.Clear()
                ChercherDansBibliotheque(m_DictPersonne, txtRecherche.Text)
            End If
        Else
            ep.SetError(btnRecherche, "Ça te fait combien de pintes? Pas sûr qu'un champ vide donne des résultats.")
        End If
        txtRecherche.Clear()
    End Sub
    Private Sub SupportEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportEnLigneToolStripMenuItem.Click
        Dim uneImageUrl As Image = Nothing
        Dim reponseHTTP As System.Net.WebResponse = Nothing
        Dim fluxHTTP As System.IO.Stream = Nothing
        Dim uneImage As Image = Nothing
        Dim uneString As String = "https://farm4.staticflickr.com/3429/3980146235_e5c6d4c4c7_m.jpg"
        Try
            Dim requeteHTTP As System.Net.HttpWebRequest = CType(System.Net.HttpWebRequest.Create(uneString), System.Net.HttpWebRequest)
            requeteHTTP.AllowWriteStreamBuffering = True
            requeteHTTP.Timeout = 20000
            reponseHTTP = requeteHTTP.GetResponse()
            fluxHTTP = reponseHTTP.GetResponseStream()
            uneImageUrl = Image.FromStream(fluxHTTP)
            MsgBox("It would work you really believed that?" & vbCrLf, MsgBoxStyle.Question, "Noob Alert!")
            Process.Start(uneString)
        Catch ex As Exception
            MsgBox("Impossible de se connecter à internet.", vbCritical, "ERR_INTERNET_DISCONNECTED")
        Finally
            Try
                fluxHTTP.Close()
            Catch ex As Exception
            End Try
            Try
                reponseHTTP.Close()
            Catch ex As Exception
            End Try
        End Try
    End Sub
    Private Sub frmRQ_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If tvCompagnie.TopNode IsNot Nothing Then
            Dim strChaineSauvegarde As String = ""
            Dim strParam As String = ""
            For i = 0 To tvCompagnie.Nodes.Count - 1
                strChaineSauvegarde += ChaineDeDonnees(tvCompagnie.Nodes(i), strParam)
                strParam = ""
                strChaineSauvegarde += "</compagnie>"
            Next
            Using ficSauvegarde = New StreamWriter("./sauvegarde.txt")
                ficSauvegarde.Write(strChaineSauvegarde)
            End Using
        End If
    End Sub
#End Region
End Class
