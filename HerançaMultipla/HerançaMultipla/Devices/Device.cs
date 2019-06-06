namespace HerançaMultipla.Devices
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void PrecessDoc(string document);    
    }
}