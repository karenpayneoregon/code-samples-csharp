using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RadioButtonBinding.Classes
{
    public class Person : INotifyPropertyChanged
    {
        private string _sex;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Sex
        {
            get => _sex;
            set { _sex = value; OnPropertyChanged(); }
        }

        public SuffixType SuffixType { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}