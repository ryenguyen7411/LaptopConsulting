namespace Laptop_Resuilt.Laptop
{
    public class m_laptop
    {
        public string _name;
        public outside _outside;
        public GPU _gpu;
        public CPU _cpu;
        public Screen _screen;
        public Batttery _battery;
        public string _detail_decription;
        public string _pros;
        public string _cons;
        public string storage;
        public m_laptop()
        {
            _outside = new outside();
            _gpu = new GPU();
            _cpu = new CPU();
            _screen = new Screen();
            _battery = new Batttery();
        }
    }
}