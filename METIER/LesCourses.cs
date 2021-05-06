using System.Collections.Generic;

namespace METIER
{
    public class LesCourses
    {
        private List<Course> lesC;
        private int lastID;

        public LesCourses()
        {
            this.lesC = new List<Course>();
            this.lastID = 1;
        }

        public int LastID { get => lastID; set => lastID = value; }

        public void Add(Course uneCourse)
        {
            lesC.Add(uneCourse);
            this.lastID = uneCourse.GetId() + 1;
        }
    }
}
