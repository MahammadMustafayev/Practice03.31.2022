using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_.Models
{
    class Group
    {
       
        public int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }   
            
            set 
            {
                if (StudentLimit>5 || StudentLimit<18)
                {
                    _studentLimit = value;
                }
            }
        }
        public Group(string  groupNo,int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public Student[] _students = new Student[0];

        public bool CheckGroupNo(string groupNo)
        {
            bool IsUpper = false;
            bool IsDigit = false;
            if (!String.IsNullOrEmpty(groupNo) || !String.IsNullOrWhiteSpace(groupNo))
            {
                for (int i = 0; i < groupNo.Length; i++)
                {
                    if (char.IsUpper(groupNo[i])) IsUpper = true;
                    else if (char.IsDigit(groupNo[i])) IsDigit = true;
                    if (IsDigit == true || IsUpper == true) return true;
                }
            }
          return false;
        }
        public void AddStudents(Student student)
        {
           
            Array.Resize(ref _students,_students.Length+1);
            _students[_students.Length - 1] = student;
            Console.WriteLine(student);
        }
        public bool GetStudent(int ? Id)
        {
            //for (int i = 0; i < length; i++)
            //{

            //}
            return true;
        }
        public void GetAllStudents(Student _student)
        {
            for (int i =  _students.Length- 1; i >= 0; i--)
            {
                Console.WriteLine(_students);
            }
        }
    }
}
