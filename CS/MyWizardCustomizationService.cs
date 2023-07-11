using DevExpress.DataAccess.Wizard.Model;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using System.Drawing;

namespace DisableMasterDetailWizard {
    public class MyWizardCustomizationService : IWizardCustomizationService {
        void IDataSourceWizardCustomizationService.CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
        }

        void IWizardCustomizationService.CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            container.RegisterInstance(new ReportWizardSettings() { UseMasterDetailReportWizard = false });
        }

        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }

        bool IWizardCustomizationService.TryCreateReport(XtraReportModel model, out XtraReport report) {
            report = null;
            return false;
        }
    }
}
