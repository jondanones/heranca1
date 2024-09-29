namespace exercHeranca.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() => Price + CustomsFee;

        public override string PriceTag() => Name + " $ " + TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
    }
}
