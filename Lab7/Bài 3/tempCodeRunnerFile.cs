using System;

namespace Lab7
{
    class Mark{
        private string name;
        private float DLT;
        private float DTH;
        public TenMonHoc (string name, float DLT, float DTH){
            this.name = name;
            this.DLT = DLT;
            this.DTH = DTH;
        }
        public double DTB(){
            return (DLT+DTH)/2;
        }
        public void Xuat(){
            System.Console.WriteLine("Tên môn học: {0}", name);
            System.Console.WriteLine("Điểm lý thuyết: {0}", DLT);
            System.Console.WriteLine("Điểm thực hành: {0}", DTH);
        }
          public void Print()
        {

            String st = String.Format("|{0}|", centeredString($" {STT} ", -10))
          + String.Format("{0}|", centeredString($"{TenMonHoc}  ", 20))
          + String.Format("{0}|", centeredString($"{DiemLT}", 16))
          + String.Format("{0}|", centeredString($"{DiemTH}", 17))
          + String.Format("{0}|", centeredString($"{TinhDTB(DiemLT,DiemTH)}", 17));

            Console.WriteLine(st);
            
            static string centeredString(string s, int width)
            {
                if (s.Length >= width)
                {
                    return s;
                }

                int leftPadding = (width - s.Length) / 2;
                int rightPadding = width - s.Length - leftPadding;

                return new string(' ', leftPadding) + s + new string(' ', rightPadding);
            }
        }
    }
}