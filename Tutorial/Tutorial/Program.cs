using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
                
        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Student Id can't be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be Null or Empty");
                }
                this._Name = value;
            }
            get
            {
                return this._Name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
        //Auto implemented properties
        public string EmailId { set; get; }
                
    }

    public class Program
    {
        public static void Main()
        {
            //Student C1 = new Student();
            //C1.Id = 101;
            //C1.Name = "Test Name";
            //C1.EmailId = "Tester@testcompany.com";

            //Console.WriteLine("Student Id = {0}", C1.Id);
            //Console.WriteLine("Student Name = {0}", C1.Name);
            //Console.WriteLine("Passmark = {0}", C1.PassMark);
            //Console.WriteLine("Passmark = " + C1.PassMark);
            //Console.WriteLine("EmailId = " + C1.EmailId);

            ArrayList Members = new ArrayList(3);

            Members.Add(101);
            Members.Add(102);
            Members.Add(103);
            Members.Add("Shiva");

            foreach (var i in Members)
            {
                Console.WriteLine(i);
            }


        }
    }
}
