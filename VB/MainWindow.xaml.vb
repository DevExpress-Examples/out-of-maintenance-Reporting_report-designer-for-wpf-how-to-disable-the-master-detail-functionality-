Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace DisableMasterDetailWizard
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UseWizardCustomizationService(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseWizardCustomization()}, DXTabbedWindow).ShowDialog()
        End Sub

        Private Sub UseServicesRegistry(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseServicesRegistry()}, DXTabbedWindow).ShowDialog()
        End Sub
    End Class
End Namespace
