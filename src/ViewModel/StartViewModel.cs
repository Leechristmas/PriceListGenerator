using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace PriceListGenerator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class StartViewModel : WindowViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public StartViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        #region Fields

        /// <summary>
        /// Индекс активного таба
        /// </summary>
        private int _selectedTabIndex;

        #endregion

        #region Properties

        /// <summary>
        /// Если первый таб - "назад" видимая, иначе - скрыть
        /// </summary>
        public Visibility BackBtnVisibility => SelectedTabIndex == 0 ? Visibility.Collapsed : Visibility.Visible;

        /// <summary>
        /// Индекс активного таба
        /// </summary>
        public int SelectedTabIndex
        {
            get { return _selectedTabIndex; }
            set
            {
                _selectedTabIndex = value;
                RaisePropertyChanged();
                RaisePropertyChanged("BackBtnVisibility");
            }
        }
        #endregion

        #region Commands
        /// <summary>
        /// Переключение между табами
        /// </summary>
        public RelayCommand TabSwitch
            => _tabSwitch ?? (_tabSwitch = new RelayCommand(TabSwitchExecute));
        private RelayCommand _tabSwitch;

        private void TabSwitchExecute()
        {
            SelectedTabIndex = SelectedTabIndex == 0 ? 1 : 0;
        }
        #endregion
    }
}