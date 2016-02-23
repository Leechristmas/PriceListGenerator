namespace PriceListGenerator.Model
{
    /// <summary>
    /// Реквизитный состав "ценника"
    /// </summary>
    public class PriceRequisite: BaseModel
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string ManufacturerName { get; set; }

        /// <summary>
        /// Страна-производитель
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Стоимость
        /// </summary>
        public string Price { get; set; }
    }
}