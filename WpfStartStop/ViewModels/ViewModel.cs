using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Example2.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool _isStopped = false;
        private RelayCommand _playCommand;

        public ViewModel()
        {
            isPlaying = true;
        }

        public bool isPlaying
        {
            get => _isStopped;
            set
            {
                _isStopped = value;
                OnPropertyChanged();
            }
        }

        public ICommand PlayCommand
        {
            get
            {
                return _playCommand ?? new RelayCommand((x) =>
                {
                    var buttonType = x.ToString();

                    if (null != buttonType)
                    {
                        if (buttonType.Contains("Start"))
                        {
                            isPlaying = false;
                        }
                        else if (buttonType.Contains("Stop"))
                        {
                            isPlaying = true;
                        }
                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}