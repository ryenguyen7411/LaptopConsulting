namespace Laptop_Resuilt.Pc
{
    public class Pc
    {
        public Tier Tier { get; set; }
        public Gpu Gpu { get; set; }
        public Cpu Cpu { get; set; }
        public Hsf Hsf { get; set; }
        public Mobo Mobo { get; set; }
        public Ram Ram { get; set; }
        public Hdd Hdd { get; set; }
        public Ssd Ssd { get; set; }
        public Psu Psu { get; set; }
        public Case Case { get; set; }
        public decimal Total { get; set; }
        //public DateTime LastUpdated { get; set; }
    }
}