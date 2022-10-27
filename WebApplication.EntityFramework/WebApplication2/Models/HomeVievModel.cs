namespace WebApplication2.Models
{
    public class HomeVievModel
    {
        public List<Catigorie> Catigories { get; set; }=new List<Catigorie>();
        public List<Slider> Sliders { get; set; } = new List<Slider>();
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();
        public List<Featured> Featureds { get; set; } = new List<Featured>();   
    }
}
