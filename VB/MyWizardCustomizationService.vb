Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.Xpf.DataAccess.DataSourceWizard
Imports DevExpress.Xpf.Reports.UserDesigner.ReportWizard
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Wizards
Imports System.Drawing
Imports System.Runtime.InteropServices

Namespace DisableMasterDetailWizard

    Public Class MyWizardCustomizationService
        Implements IWizardCustomizationService

        Private Sub CustomizeDataSourceWizard(ByVal customization As DataSourceWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IDataSourceWizardCustomizationService.CustomizeDataSourceWizard
        End Sub

        Private Sub CustomizeReportWizard(ByVal customization As ReportWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IWizardCustomizationService.CustomizeReportWizard
            container.RegisterInstance(New ReportWizardSettings() With {.UseMasterDetailReportWizard = False})
        End Sub

        Private Function TryCreateDataSource(ByVal model As IDataSourceModel, <Out> ByRef dataSource As Object, <Out> ByRef dataMember As String) As Boolean Implements IDataSourceWizardCustomizationService.TryCreateDataSource
            dataSource = Nothing
            dataMember = Nothing
            Return False
        End Function

        Private Function TryCreateReport(ByVal model As XtraReportModel, <Out> ByRef report As XtraReport) As Boolean Implements IWizardCustomizationService.TryCreateReport
            report = Nothing
            Return False
        End Function
    End Class
End Namespace
