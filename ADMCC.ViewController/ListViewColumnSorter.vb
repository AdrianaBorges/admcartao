Imports System.Collections
Imports System.Windows.Forms

''' <summary>
''' This class is an implementation of the 'IComparer' interface.
''' </summary>
Public Class ListViewColumnSorter
    Implements IComparer
    ''' <summary>
    ''' Specifies the column to be sorted
    ''' </summary>
    Private ColumnToSort As Integer
    ''' <summary>
    ''' Specifies the order in which to sort (i.e. 'Ascending').
    ''' </summary>
    Private OrderOfSort As SortOrder
    ''' <summary>
    ''' Case insensitive comparer object
    ''' </summary>
    Private ObjectCompare As CaseInsensitiveComparer

    ''' <summary>
    ''' Class constructor.  Initializes various elements
    ''' </summary>
    Public Sub New()
        ' Initialize the column to '0'
        ColumnToSort = 0

        ' Initialize the sort order to 'none'
        OrderOfSort = SortOrder.None

        ' Initialize the CaseInsensitiveComparer object
        ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    ''' <summary>
    ''' This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
    ''' </summary>
    ''' <paramname="x">First object to be compared</param>
    ''' <paramname="y">Second object to be compared</param>
    ''' <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim compareResult As Integer
        Dim listviewX, listviewY As ListViewItem

        ' Cast the objects to be compared to ListViewItem objects
        listviewX = CType(x, ListViewItem)
        listviewY = CType(y, ListViewItem)

        ' Compare the two items
        compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text, listviewY.SubItems(ColumnToSort).Text)

        ' Calculate correct return value based on object comparison
        If OrderOfSort = SortOrder.Ascending Then
            ' Ascending sort is selected, return normal result of compare operation
            Return compareResult
        ElseIf OrderOfSort = SortOrder.Descending Then
            ' Descending sort is selected, return negative result of compare operation
            Return -compareResult
        Else
            ' Return '0' to indicate they are equal
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
    ''' </summary>
    Public Property SortColumn As Integer
        Set(value As Integer)
            ColumnToSort = value
        End Set
        Get
            Return ColumnToSort
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
    ''' </summary>
    Public Property Order As SortOrder
        Set(value As SortOrder)
            OrderOfSort = value
        End Set
        Get
            Return OrderOfSort
        End Get
    End Property

End Class
