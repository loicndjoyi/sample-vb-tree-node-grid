''' <summary>
''' Classe Personne dont le but est de créer une personne à l'aide des attributs
''' qui la composent.
''' </summary>
Public Class Personne
    Private m_strNom As String
    Private m_strID As String
    Private m_lstCompagnies As List(Of Compagnie)

#Region "Get/Set"
    Public Property LstCompagnies() As List(Of Compagnie)
        Get
            Return m_lstCompagnies
        End Get
        Set(ByVal value As List(Of Compagnie))
            m_lstCompagnies = value
        End Set
    End Property

    Public Property ID() As String
        Get
            Return m_strID
        End Get
        Set(ByVal value As String)
            m_strID = value
        End Set
    End Property

    Public Property Nom() As String
        Get
            Return m_strNom
        End Get
        Set(ByVal value As String)
            m_strNom = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' Constructeur paramétré qui va recevoir le nom et l'identifiant de la personne
    ''' qui sera créé, et qui va aussi permettre de créer la liste de compagnie de la
    ''' personne.
    ''' </summary>
    '''  <param name="pId">L'identifiant de la personne.</param>
    ''' <param name="pNom">Nom de la personne.</param>
    Public Sub New(pId As String, pNom As String)
        Nom = pNom
        ID = pId
        LstCompagnies = New List(Of Compagnie)
    End Sub

    ''' <summary>
    ''' Permet d'afficher l'ID et le nom de la personne.
    ''' </summary>
    ''' <returns>L</returns>
    Public Overrides Function ToString() As String
        Return "ID : " & ID & "  Nom : " & Nom
    End Function
End Class
