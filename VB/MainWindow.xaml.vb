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
			Call New DXTabbedWindow() With {.Content = New UseWizardCustomization()}.ShowDialog()
		End Sub

		Private Sub UseServicesRegistry(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Call New DXTabbedWindow() With {.Content = New UseServicesRegistry()}.ShowDialog()
		End Sub
	End Class
End Namespace
