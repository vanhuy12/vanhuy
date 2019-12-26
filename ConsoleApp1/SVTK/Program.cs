using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVTK
{
    class Program
    {
        public void loadDB()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DBPersonDataContext db = new DBPersonDataContext();
            var name = from table in db.KETQUAs
                       select table;
            Console.WriteLine("DANH SACH SINH VIEN");
            foreach (var a in name)
            {
                Console.WriteLine("Sinh Viên:");
                Console.WriteLine("\tMa so sinh vien: " + a.MaSV);
                Console.WriteLine("\tHo sinh vien: " + a.HoSV);
                Console.WriteLine("\tTen sinh vien: " + a.TenSV);
                Console.WriteLine("\tNgay sinh: " + a.NgaySinh);
                Console.WriteLine("\tDiem: " + a.Diem);
                Console.WriteLine("\tMa mon hoc: " + a.MaMH);
            }
        }

        public void SearchDB()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DBPersonDataContext db = new DBPersonDataContext();
            string IdSubject;
            Console.WriteLine("Nhap ma mon hoc:");
            IdSubject = Convert.ToString(Console.ReadLine());
            var id = from d in db.KETQUAs
                     where d.MaMH == IdSubject
                     select d;
            int found = 0;
            Console.WriteLine("Thong tin cac sinh vien can tim:");
            foreach (var d in id)
            {
                found++;
                Console.WriteLine("Sinh Viên:");
                Console.WriteLine("\tMa so sinh vien: " + d.MaSV);
                Console.WriteLine("\tHo sinh vien: " + d.HoSV);
                Console.WriteLine("\tTen sinh vien: " + d.TenSV);
                Console.WriteLine("\tNgay sinh: " + d.NgaySinh);
                Console.WriteLine("\tDiem: " + d.Diem);
                Console.WriteLine("\tMa mon hoc: " + d.MaMH);
            }
            if (found == 0)
            {
                Console.WriteLine("\nKhong tim thay thong tin nao");
            }
            else
                Console.WriteLine("\nCo " + found + " ket qua duoc tim thay");
        }

        static void Main(string[] args)
        {
            int choice;
            Program objects = new Program();
            while (true)
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1. Load Database.");
                Console.WriteLine("2. Search Database.");
                Console.WriteLine("3. Delete.");
                Console.WriteLine("Your choice ?");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        objects.loadDB();
                        break;
                    case 2:
                        objects.SearchDB();
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You must enter 1 to 3");
                        break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
