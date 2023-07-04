internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap ten cua ban: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nhap Msv: ");
        string msv = Console.ReadLine();
        Console.WriteLine("Sinh vien: " + name + " Ma sinh vien la: " + msv);

        int diemtoan, diemvan, diemanh, diemly, diemhoa;

        Console.Write("Nhap diem Toan: ");
        diemtoan = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap diem Van: ");
        diemvan = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap diem Anh: ");
        diemanh = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap diem Ly: ");
        diemly = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Nhap diem Hoa: ");
        diemhoa = Convert.ToInt32(Console.ReadLine());
        
        int result = (diemtoan + diemvan + diemanh + diemly + diemhoa) / 5;
        Console.WriteLine("Diem trung binh cua {0} , {1} , {2} , {3} , {4} la: {5} ", diemtoan, diemvan, diemanh, diemly, diemhoa, result);
    }


}



   

