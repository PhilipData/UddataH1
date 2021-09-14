namespace UddataH1.Models
{
    public enum CourseType { Danish, Matmatics, English, German, Religion, Sports}
    class Course : BaseClass
    {
        public Teacher Teacher { get; set; }
        public string ClassRoom { get; set; }
        public CourseType CourseType{ get; set; }

        
    }
}