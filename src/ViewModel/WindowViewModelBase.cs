using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace PriceListGenerator.ViewModel
{
    /// <summary>
    /// Базовый для view models, которые привязываются к окну
    /// </summary>
    public class WindowViewModelBase : ViewModelBase
    {
        /// <summary>
        /// true - закрыть окно
        /// </summary>
        private bool _windowsClosed;

        public bool WindowsClosed
        {
            get { return _windowsClosed; }
            set
            {
                if (_windowsClosed == value)
                    return;
                _windowsClosed = value;
                RaisePropertyChanged("WindowsClosed");
            }
        }

        #region CloseCommand

        private RelayCommand _closeWindowCommand;

        public RelayCommand CloseWindowCommand
            => _closeWindowCommand ?? (_closeWindowCommand = new RelayCommand(CloseWindow));

        private void CloseWindow()
        {
            WindowsClosed = true;
        }

        #endregion
    }
}