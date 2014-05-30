using SharpDox.Sdk.Local;

namespace CSVExporter
{
    public class CSVStrings : ILocalStrings
    {
        // Strings with a default translation
        private string _csv = "CSV";
        private string _divider = "Divider";

        // Create a property for the strings.
        // Do not use auto-properties. 
        // Otherwise your default translation will not work!

        public string CSV
        {
            get { return _csv; }
            set { _csv = value; }
        }

        public string Divider
        {
            get { return _divider; }
            set { _divider = value; }
        }

        // Set the name of the language file
        public string DisplayName { get { return "CSV"; } }
    }
}
