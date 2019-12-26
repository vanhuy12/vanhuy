using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { value = id; }
        }
        private string name;
        public string Name
        {
             get { return name; }
             set { value = name; }
        }
        private double sdt;
        public double SDT
        {
            get { return sdt; }
            set { value = sdt; }
        }
        private double dtb;
        public double DTB
        {
            get { return dtb; }
            set { value = dtb; }
        }
        private string xl;
        public string XL
        {
            get { return xl; }
            set { value = xl; }
        }

        public void input()
        {
            Console.WriteLine("Nhap ma so sinh vien:");
            id = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap so dien thoai:");
            sdt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem trung binh:");
            dtb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap xep loai:");
            xl = Convert.ToString(Console.ReadLine());           
        }
        public void display()
        {
            Console.WriteLine("SINH VIEN:");
            Console.WriteLine("\tMa sinh vien: "+id);
            Console.WriteLine("\tTen sinh vien: "+name);
            Console.WriteLine("\tSo dien thoai: "+sdt);
            Console.WriteLine("\tDiem Trung Binh: "+dtb);
            Console.WriteLine("\tXep loai: " + xl);
        }


    }
}
