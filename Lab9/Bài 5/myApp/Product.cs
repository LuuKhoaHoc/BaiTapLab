using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bài_5
{
    public class Product{
    String prod_name;
    String prod_dec;
    int prod_price;
      public void input_prod() //Nhập tên 1 sinh viên
    {
        Console.OutputEncoding=Encoding.UTF8;        
        System.Console.Write("Mời bạn nhập tên sản phẩm: ");
        prod_name = Console.ReadLine();
        System.Console.Write("Mời bạn nhập mô tả sản phẩm: ");
        prod_dec = Console.ReadLine();
        System.Console.Write("Mời bạn nhập giá bán của sản phẩm: ");
        prod_price = int.Parse(Console.ReadLine());
        
    }
     public void output_prod(){
         System.Console.Write("Tên sản phẩm: {0}\n", prod_name);
         System.Console.Write("Mô tả sản phẩm: {0}\n", prod_dec);
         System.Console.Write("Giá bán: {0}\n", prod_price);        
         Console.WriteLine("---------------");
     }
    public string get_name(){
            return prod_name;
        }
    public string get_dec(){
            return prod_dec;
        }
     public int get_price(){
            return prod_price;
        }
    }
}