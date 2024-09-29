namespace exercHeranca.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string Name, double Price, DateTime manufactureDate) : base(Name, Price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag() => Name + " (used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";

    }
}
