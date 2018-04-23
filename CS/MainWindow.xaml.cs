using DevExpress.Xpf.Core;
using System.Windows;

namespace DisableMasterDetailWizard {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void UseWizardCustomizationService(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseWizardCustomization() }.ShowDialog();
        }

        void UseServicesRegistry(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseServicesRegistry() }.ShowDialog();
        }
    }
}
