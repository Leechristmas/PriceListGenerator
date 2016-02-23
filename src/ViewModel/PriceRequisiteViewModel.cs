using PriceListGenerator.Model;

namespace PriceListGenerator.ViewModel
{
    /// <summary>
    /// view-model для реквизитного состава ценника
    /// </summary>
    public class PriceRequisiteViewModel: WindowViewModelBase
    {
        #region Constructor

        public PriceRequisiteViewModel()
        {

        }

        public PriceRequisiteViewModel(PriceRequisite priceRequisite)
        {
            ProductName = priceRequisite.ProductName;
            ManufacturerName = priceRequisite.ManufacturerName;
            Country = priceRequisite.Country;
            Price = priceRequisite.Price;
        }

        #endregion
        
        #region Fields

        /// <summary>
        /// Наименование товара
        /// </summary>
        private string _productName;

        /// <summary>
        /// Производитель
        /// </summary>
        private string _manufacturerName;

        /// <summary>
        /// Страна производства
        /// </summary>
        private string _country;

        /// <summary>
        /// Стоимость
        /// </summary>
        private string _price;

        #endregion

        #region Properties

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Производитель
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set
            {
                _manufacturerName = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Страна-производитель
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Стоимость
        /// </summary>
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}