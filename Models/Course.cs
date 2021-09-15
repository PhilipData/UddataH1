namespace UddataH1.Models
{
    public enum CourseType { Dan, Mat, Eng, Ger, Rel, Spo}
    class Course : BaseClass
    {
        public Student Teacher { get; set; }
        public CourseType CourseType{ get; set; }

        
    }
}