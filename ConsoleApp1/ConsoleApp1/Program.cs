using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int numberPerson;
        Person[] persons;
        public void inputPerson()
        {           
            Console.WriteLine("Nhap so sinh vien:");
            numberPerson = Convert.ToInt32(Console.ReadLine());
            persons = new Person[numberPerson];
            for (int i = 0; i < numberPerson; i++)
            {
                Console.WriteLine("Nhap du lieu cua ban sinh vien thu " + (i + 1));
                persons[i] = new Person();
                persons[i].input();
            }
        }

        public void displayPerson()
        {
            Console.WriteLine("\nDanh sach sinh vien da nhap:");
            for (int i = 0; i < numberPerson; i++)
            {
                persons[i].display();
            }
        }

        public void sortListByDTB()
        {
            for(int i = 0; i < persons.Length-1; i++)
            {
                for(int j= persons.Length - 1; j > i; j--)
                {
                    if(persons[j].DTB> persons[j - 1].DTB)
                    {
                        Person temp = persons[j];
                        persons[j] = persons[j - 1];
                        persons[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nDanh sach giam dan theo diem trung binh");
            for (int i = 0; i < numberPerson; i++)
            {
                persons[i].display();
            }
        }

        public void searchByPersonName()
        {
            String personName;
            Console.WriteLine("\nNhap ten sinh vien can tim kiem:");
            personName = Convert.ToString(Console.ReadLine());
            int found = 0;
            Console.WriteLine("\nKet qua tim kiem:");
            for(int i = 0; i < numberPerson; i++)
            {
                if (persons[i].Name.Equals(personName))
                {
                    found++;
                    Console.WriteLine("");
                    persons[i].display();
                }
            }
            if (found == 0)
            {
                Console.WriteLine("\nKhong tim thay thong tin nao");
            }
            else
                Console.WriteLine("\nCo " + found + " ket qua duoc tim thay");
        }

        public void selectLinQ()
        {
            var personQuery = from per in persons
                              where per.DTB>7 
                              select per;
            Console.WriteLine("Danh sach cac ban co DTB >7:");
            foreach (Person per in personQuery)
            {
                Console.WriteLine(per.Name);
            }
        }

        public void selectByNameLinQ()
        {
            string NamePerson;
            Console.WriteLine("Nhap ten sinh vien can tim:");
            NamePerson = Convert.ToString(Console.ReadLine());
            var selectbyName = from detail in persons
                             where detail.Name == NamePerson
                             select detail;
            foreach(var detail in selectbyName)
            {
                Console.WriteLine("Sinh vien can tim:");
                Console.WriteLine("\tMa sinh vien :"+detail.ID);
                Console.WriteLine("\tTen sinh vien: "+detail.Name);
                Console.WriteLine("\tSo dien thoai: "+detail.SDT);
                Console.WriteLine("\tDiem Trung Binh: "+detail.DTB);
                Console.WriteLine("\tXep loai: "+detail.XL);
            }

        }
        public void searchIdLinQ()
        {
            string IdPerson;
            Console.WriteLine("Nhap ma sinh vien can tim:");
            IdPerson = Convert.ToString(Console.ReadLine());
            var id = from d in persons
                         where d.ID== IdPerson
                         select d;
            Console.WriteLine("Thong tin sinh vien can tim:");
            foreach (var d in id)
            {   
                Console.WriteLine("\tMa sinh vien :" + d.ID);
                Console.WriteLine("\tTen sinh vien: " + d.Name);
                Console.WriteLine("\tSo dien thoai: " + d.SDT);
                Console.WriteLine("\tDiem Trung Binh: " + d.DTB);
                Console.WriteLine("\tXep loai: " + d.XL);
            }
        }

            static void Main(String[] args)
        {
            int choice;
            Program objects = new Program();
            while (true)
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1. Input a list of Person.");
                Console.WriteLine("2. Display the information of this list.");
                Console.WriteLine("3. Sort list descending by DTB and display");
                Console.WriteLine("4. Search information by input person name.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("6. LinQ.");
                Console.WriteLine("7. Search By LinQ.");
                Console.WriteLine("8. Delete.");
                Console.WriteLine("Your choice ?");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        objects.inputPerson();
                        break;
                    case 2:
                        objects.displayPerson();
                        break;
                    case 3:
                        objects.sortListByDTB();
                        break;
                    case 4:
                        objects.searchByPersonName();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    case 6:
                        objects.selectLinQ();
                        break;
                    case 7:
                        objects.selectByNameLinQ();
                        break;
                    case 8:
                        objects.searchIdLinQ();
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
