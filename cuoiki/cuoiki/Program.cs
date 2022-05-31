using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cuoiki
{
    public class Nguoi
    {
        public string Name;
        public ushort Age;
        public string Job;
        public int Cccd;

        public Nguoi()
        {

        }
        public Nguoi(String name, ushort age, string job, int cccd)
        {
            this.Name = name;
            this.Age = age;
            this.Job = job;
            this.Cccd = cccd;
        }
        public void nhapThongTin()
        {
            Console.WriteLine("Nhap so nha1: ");
            String name = Console.ReadLine();
            Console.WriteLine("Nhap so nha2: ");
            ushort age = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha3: ");
            String job = Console.ReadLine();
            Console.WriteLine("Nhap so nha4: ");
            int cccd = int.Parse(Console.ReadLine());
        }
        public void inThongTin()
        {
            Console.WriteLine("Ho va ten: " + this.Name);
            Console.WriteLine("Tuoi: " + this.Age);
            Console.WriteLine("Nghe nghiep: " + this.Job);
            Console.WriteLine("Can cuoc cong dan: " + this.Cccd);
        }
    }

    //Lớp khu phố
    public class HoDan : Nguoi
    {
        private int soThanhVien;
        private int soNha;
        private Nguoi[] thanhVien = new Nguoi[10];// bat buoc phai khoi tao
        public HoDan()
        {

        }
        public HoDan(int soThanhVien, int soNha, Nguoi[] thanhVien)
        {
            this.soThanhVien = soThanhVien;
            this.soNha = soNha;
            this.thanhVien = thanhVien;
        }
        public void nhapThongTin()
        {

            Console.WriteLine("Nhap so thanh vien trong gia dinh: ");
            int soThanhVien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            int soNha = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin ve tung thanh vien:");
            for (int i = 0; i < this.soThanhVien; i++)
            {
                Console.WriteLine("Nhap thanh vien thu " + (i + 1) + " :");
                this.thanhVien[i] = new Nguoi();
                this.thanhVien[i].nhapThongTin();
            }
        }

        public void inThongTin()
        {
            Console.WriteLine("So thanh vien: " + this.soThanhVien);
            Console.WriteLine("So nha: " + this.soNha);
            Console.WriteLine("Cac thanh vien trong gia dinh: ");
            try
            {
                for (int i = 0; i < this.soThanhVien; i++)
                {
                    this.thanhVien[i].inThongTin();
                }
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine();
            }
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            Nguoi[] tv2 = new Nguoi[4];
            for (int i = 0; i < 3; i++)
            {
                tv2[i] = new Nguoi();
                tv2[i].nhapThongTin();
            }
            HoDan hd = new HoDan(4, 4, tv2);
            Console.WriteLine("Cac ho da nhap: ");
            hd.inThongTin();
            Console.WriteLine("---***************---");
            Console.ReadKey();
        }
    }
}
