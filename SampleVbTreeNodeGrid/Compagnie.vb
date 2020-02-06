''' <summary>
''' Classe compagnie permettant de créer une compagnie à l'aide
''' des attributs qui la composent.
''' </summary>
Public Class Compagnie : Inherits TreeNode
    Private m_strNom As String
    Private m_strRevenu As String
    Private m_lstPersonnes As List(Of Personne)

#Region "Get/Set"
    Public Property Nom() As String
        Get
            Return m_strNom
        End Get
        Set(ByVal value As String)
            m_strNom = value
        End Set
    End Property

    Public Property Revenu() As String
        Get
            Return m_strRevenu
        End Get
        Set(ByVal value As String)
            m_strRevenu = value
        End Set
    End Property

    Public Property LstPersonnes() As List(Of Personne)
        Get
            Return m_lstPersonnes
        End Get
        Set(ByVal value As List(Of Personne))
            m_lstPersonnes = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' Constructeur paramétré qui permet de créer une compagnie à l'aide
    ''' de son nom et de son revenu, ainsi que de créer sa liste de personne.
    ''' </summary>
    ''' <param name="pNom">Nom de la compagnie.</param>
    ''' <param name="pRevenu">Revenu de la compagnie.</param>
    Public Sub New(pNom As String, pRevenu As String)
        Nom = pNom
        Revenu = pRevenu
        LstPersonnes = New List(Of Personne)
    End Sub

    ''' <summary>
    ''' Permet d'afficher le nom de la compagnie dans le TreeView.
    ''' </summary>
    ''' <returns>Le nom de la compagnie.</returns>
    Public Overrides Function ToString() As String
        Return Nom
    End Function
End Class
