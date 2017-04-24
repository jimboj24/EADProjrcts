using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProStatClassLib
{
    public class Grades
    {
        private int studentId;

        private string firstName;
        private string lastName;

        private string programme;
        private int semister;
        private int year;
        private string acYear1;
        private int acYear2;
        private string courseCode;
        private string course;
        private double ew;
        private double cw;
        private double grade;
        private double moduleAvg;
        private double gradeAvg;
        private double gpa;
        private DateTime created = DateTime.Now;

        //Default constructor
        public Grades()
        {

            studentId = 1234567890;
            firstName = "Angella";
            lastName = "Williams";
            programme = "Information and Communication Technology";
            semister = 1;
            year = 2;
            acYear1 = "2016-2017";
           // acYear2 = acYear2;
            courseCode = "CS220";
            course = "Introduction to OOP 2";
            ew = 85;
            cw = 89;
            //grade = grade;
            //moduleAvg = moduleAvg;
            
        }
        public Grades(int studentId, string programme, int semister, int year, string acYear1, int acYear2,
                        string courseCode, string course, double ew, double cw, double grade, double moduleAvg, double gradeAvg, double gpa)//Primary constructor
        {
            this.studentId = studentId;
            this.programme = programme;
            this.semister = semister;
            this.year = year;
            this.acYear1 = acYear1;
            this.acYear2 = acYear2;
            this.courseCode = courseCode;
            this.course = course;
            this.ew = ew;
            this.cw = cw;
            this.grade = grade;
            this.moduleAvg = moduleAvg;
            this.gradeAvg = gradeAvg;
            this.gpa = gpa;
        }
        //Getters and setters
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Programme
        {
            get { return programme; }
            set { programme = value; }
        }
        public int Semister
        {
            get { return semister; }
            set { semister = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string AcademicYear1
        {
            get { return acYear1; }
            set { acYear1 = value; }
        }
        public int AcademicYear2
        {
            get { return acYear2; }
            set { acYear2 = value; }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public double Ew
        {
            get { return ew; }
            set { ew = value; }
        }
        public double Cw
        {
            get { return cw; }
            set { cw = value; }
        }
        public double ModuleAvg //Calculate module average
        {
            get
            {
                return ((ew + cw) / 2);
            }
            set { moduleAvg = value; }
            
        }
        //Read only property
        public DateTime Created
        {
            get
            {
                return created;
            }
        }
        public double Gpa
        {
            get
            {
                return gpa;
            }
        }

        //Calculate GPA
        private void CalculateGpa()
        {
            
            if((grade >= 90) && (grade <= 100))
            {
                gpa = 4.0;
            }
            if ((grade >= 80) && (grade <= 89))
            {
                gpa = 3.7;
            }

            if ((grade >= 75) && (grade <= 79))
            {
                gpa = 3.3;
            }
            if ((grade >= 70) && (grade <= 74))
            {
                gpa = 3.0;
            }

            if (grade == 69)
            {
                gpa = 2.7;
            }
            if ((grade >= 60) && (grade <= 64)){
                gpa = 2.3;
            }
            if ((grade >= 55) && (grade <= 59)){
                gpa = 2.0;
            }
            if ((grade >= 50) && (grade <= 54)){
                gpa = 1.7;
            }
            if ((grade >= 45) && (grade <= 49)){
                gpa = 1.3;
            }
            if ((grade >= 36) && (grade <= 44)){
                gpa = 1.0;
            }
            if ((grade >= 0) && (grade < 35)){
                gpa = 0.35;
            }
            

        }
    }
}
