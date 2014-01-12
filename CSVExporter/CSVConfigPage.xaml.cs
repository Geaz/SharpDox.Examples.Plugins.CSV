using SharpDox.Sdk.UI;

namespace CSVExporter
{
    public partial class CSVConfigPage : IPage
    {
        public CSVConfigPage(CSVConfig csvConfig)
        {
            DataContext = csvConfig;
            InitializeComponent();
        }

        public string PageName { get { return "CSV"; } }
        public new int Height { get { return int.Parse(mainGrid.Height.ToString()); } }
        public new int Width { get { return int.Parse(mainGrid.Width.ToString()); } }
    }
}
