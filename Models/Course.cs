namespace UddataH1.Models
{
    public enum CourseType { Dan, Mat, Eng, Ger, Rel, Spo}
    class Course : BaseClass
    {
        public Teacher Teacher { get; set; }
        public CourseType CourseType{ get; set; }

        
    }
}