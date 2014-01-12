using System;
using System.ComponentModel;
using SharpDox.Sdk.Config;

namespace CSVExporter
{
    // The class implements the interface IConfigSection
    public class CSVConfig : IConfigSection
    {
        // The ConfigController will register on this event to get notified
        // about any changes.
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        // This is our new configitem
        private string _divider = string.Empty;
        public string Divider { get { return _divider; } set { _divider = value; OnPropertyChanged("Divider"); } }

        // This guid identifies the configsection in 
        // the config file.
        public Guid Guid { get { return new Guid("463e2a9d-5d26-42ac-8a02-012928988c79"); } }
    }
}