using System;

namespace SingletonExample1.Classes
{

    public sealed class RuntimeSettings
    {
        private static readonly Lazy<RuntimeSettings> Lazy =
            new Lazy<RuntimeSettings>(() => new RuntimeSettings());


        public static RuntimeSettings Instance => Lazy.Value;
        
        public string DatabasePath
        {
            get => ApplicationSettings.GetDatabasePath();
            set
            {
                ApplicationSettings.SetDatabasePath(value);
                OnDatabasePathChangedEvent?.Invoke();
            }
        }

        public string ConnectionString => ApplicationSettings.DatabaseConnectionString();

        public delegate void OnDataPathChanged();
        public static event OnDataPathChanged OnDatabasePathChangedEvent;

    }
}