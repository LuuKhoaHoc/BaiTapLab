using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_4
{
    public class Student{
    String s_code;
    String s_name;
    int s_age;
    float s_mark;
      public void input_student() //Nhập tên 1 sinh viên
    {
        Console.OutputEncoding=Encoding.UTF8;
        System.Console.Write("Mời bạn nhập mã sinh viên: ");
        s_code = Console.ReadLine();
        System.Console.Write("Mời bạn nhập tên sinh viên: ");
        s_name = Console.ReadLine();
        System.Console.Write("Mời bạn nhập tuổi sinh viên: ");
        s_age = int.Parse(Console.ReadLine());
        System.Console.Write("Mời bạn nhập điểm của sinh viên: ");
        s_mark = float.Parse(Console.ReadLine());    
    }
     public void output_student(){
         System.Console.Write("Mã sinh viên: {0}\n", s_code);
         System.Console.Write("Tên sinh viên: {0}\n", s_name);
         System.Console.Write("Tuổi sinh viên: {0}\n", s_age);
         System.Console.Write("Điểm sinh viên: {0}\n", s_mark);
         Console.WriteLine("---------------");
     }
     public bool check_scholarship(){
            if (s_mark > 8) return true;
            return false;
    }
    public string get_name(){
            return s_name;
        }
    public string get_code(){
            return s_code;
        }
     public int get_age()
        {
            return s_age;
        }
     public float get_mark(){
            return s_mark;
        }
     public void set_mark(float newMark){
            this.s_mark = newMark; 
        }
    }
}