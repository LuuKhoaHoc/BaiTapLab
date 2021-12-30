using System;

namespace Bài_2
{
    public class Product
    {        
        public string TenSanPham;
        public int Soluong;
        public int Giaban;
        public void Nhap(){
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("Nhập tên sán phẩm: ");
            TenSanPham = Console.ReadLine();
        }
        public  Product(int Soluong, int Giaban){
            this.Soluong = Soluong;
            this.Giaban = Giaban;
        }
        public void Xuat(){
            System.Console.WriteLine("Danh mục sản phẩm");
            
        }
    }
}
