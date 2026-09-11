using Wpf.Ui.Appearance;

namespace ModernUI
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationThemeManager.Apply(this);
        }
    }
}