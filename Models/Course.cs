namespace UddataH1.Models
{
    class Course : BaseClass
    {
        public Teacher Teacher { get; set; }
        public string ClassRoom { get; set; }
    }
}