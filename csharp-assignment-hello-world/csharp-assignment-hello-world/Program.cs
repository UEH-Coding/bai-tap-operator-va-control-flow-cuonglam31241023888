using System;
using System.Text;

class Program
{
    static void Main()
    {
        Trang9Cau1();
        Trang9Cau2();
        Trang9Cau3();
        Trang9Cau4();
        Trang9Cau5();
        Trang21Cau1();
        Trang21Cau2();
        Trang21Cau3();
        Trang22Cau1();
        Trang22Cau2();
        Trang22Cau3();
        Trang22Cau4();
        Trang22Cau5();
        Trang22Cau6();
        Trang22Cau7();
        Trang22Cau8();

    }
    static void Trang9Cau1()
    {
        Console.WriteLine("Trang 9 Câu 1");
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập số thứ nhất
        Console.Write("Nhập số thứ nhất: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Nhập số thứ hai
        Console.Write("Nhập số thứ hai: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Nhập phép toán
        Console.Write("Nhập phép toán (+, -, *, x, /): ");
        string op = Console.ReadLine();

        double result;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Kết quả: {num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Kết quả: {num1} - {num2} = {result}");
                break;
            case "*":
            case "x":   // chấp nhận cả dấu * và chữ x
                result = num1 * num2;
                Console.WriteLine($"Kết quả: {num1} * {num2} = {result}");
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Kết quả: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Lỗi: Không thể chia cho 0!");
                }
                break;
            default:
                Console.WriteLine("Phép toán không hợp lệ!");
                break;
        }
    }
    static void Trang9Cau2()
    {
        Console.WriteLine("Trang 9 Câu 2");
        Console.WriteLine("Bảng giá trị của hàm x = y^2 + 2y + 1 (với y từ -5 đến 5):\n");

        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;  // công thức x = y^2 + 2y + 1
            Console.WriteLine($"y = {y,3}  -->  x = {x,3}");
        }
    }
    static void Trang9Cau3()
    {
        Console.WriteLine("Trang 9 Câu 3");
        // Nhập dữ liệu
        Console.Write("Nhập quãng đường (km): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số giờ: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số phút: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số giây: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Đổi thời gian ra giờ
        double timeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

        // Tính vận tốc
        double speedKmH = distance / timeHours;
        double speedMilesH = (distance / 1.609) / timeHours;

        // Xuất kết quả
        Console.WriteLine($"\nVận tốc: {speedKmH:F2} km/h");
        Console.WriteLine($"Vận tốc: {speedMilesH:F2} miles/h");
    }
    static void Trang9Cau4()
    {
        Console.WriteLine("Trang 9 Câu 4");
        Console.Write("Nhập bán kính hình cầu (r): ");
        double r = Convert.ToDouble(Console.ReadLine());

        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

        Console.WriteLine($"\nDiện tích bề mặt hình cầu: {surface:F2}");
        Console.WriteLine($"Thể tích hình cầu: {volume:F2}");
    }
    static void Trang9Cau5()
    {
        Console.WriteLine("Trang 9 Câu 5");
        Console.Write("Nhập một ký tự: ");
        char ch = Convert.ToChar(Console.ReadLine());  // đọc 1 ký tự
        Console.WriteLine();

        // Kiểm tra nguyên âm
        if ("aeiouAEIOU".Contains(ch))
        {
            Console.WriteLine($"{ch} là nguyên âm.");
        }
        // Kiểm tra chữ số
        else if (Char.IsDigit(ch))
        {
            Console.WriteLine($"{ch} là chữ số.");
        }
        // Còn lại là ký hiệu khác
        else
        {
            Console.WriteLine($"{ch} là ký hiệu khác.");
        }
    }
    static void Trang21Cau1()
    {
        Console.WriteLine("Trang 21 Câu 1");
        Console.Write("Nhập một số nguyên: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{num} là số lẻ.");
        }
    }
    static void Trang21Cau2()
    {
        Console.WriteLine("Trang 21 Câu 2");
        Console.Write("Nhập số thứ nhất: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập số thứ ba: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine($"\nSố lớn nhất trong ba số là: {max}");
    }
    static void Trang21Cau3()
    {
        Console.WriteLine("Trang 21 Câu 3");
        Console.Write("Nhập hoành độ (x): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập tung độ (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư III.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm ở góc phần tư IV.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Điểm nằm tại gốc tọa độ (0,0).");
        }
        else if (x == 0)
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục tung (Oy).");
        }
        else // y == 0
        {
            Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục hoành (Ox).");
        }
    }
    static void Trang22Cau1()
    {
        Console.WriteLine("Trang 22 Câu 1");
        Console.Write("Nhập cạnh a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập cạnh b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhập cạnh c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Kiểm tra điều kiện tam giác
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều (Equilateral).");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là tam giác cân (Isosceles).");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường (Scalene).");
            }
        }
        else
        {
            Console.WriteLine("Ba cạnh đã nhập không tạo thành tam giác!");
        }
    }
    static void Trang22Cau2()
    {
        Console.WriteLine("Trang 22 Câu 2");
        int n = 10;
        double sum = 0;

        Console.WriteLine("Chương trình tính tổng và trung bình của 10 số.");

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");
            double num = Convert.ToDouble(Console.ReadLine());
            sum += num;
        }

        double average = sum / n;

        Console.WriteLine($"\nTổng của 10 số là: {sum}");
        Console.WriteLine($"Trung bình cộng của 10 số là: {average}");
    }
    static void Trang22Cau3()
    {
        Console.WriteLine("Trang 22 Câu 3");
        Console.Write("Nhập số nguyên: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nBảng cửu chương của {num}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
    static void Trang22Cau4()
    {
        Console.WriteLine("Trang 22 Câu 4");
        Console.Write("Nhập số dòng của tam giác: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nMẫu tam giác số:\n");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    static void Trang22Cau5()
    {
        Console.WriteLine("Trang 22 Câu 5");
        // ---------------- Pattern 1 ----------------
        Console.WriteLine("Pattern 1:");
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // ---------------- Pattern 2 ----------------
        Console.WriteLine("Pattern 2:");
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // ---------------- Pattern 3 (chuẩn chỉnh) ----------------
        Console.WriteLine("Pattern 3:");
        num = 1; // reset lại số
        int rows = 4;

        for (int i = 1; i <= rows; i++)
        {
            // In khoảng trắng để căn giữa
            Console.Write(new string(' ', (rows - i) * 3));

            // In số, mỗi số chiếm 3 ký tự (căn lề phải)
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{num,3}");
                num++;
            }
            Console.WriteLine();
        }
    }
    static void Trang22Cau6()
    {
        Console.WriteLine("Trang 22 Câu 6");
        Console.Write("Nhập số lượng số hạng n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = 0;

        Console.WriteLine($"\n{n} số hạng đầu tiên của dãy điều hòa là:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write("1/{0} ", i);
            if (i < n)
                Console.Write("+ ");

            sum += 1.0 / i;
        }

        Console.WriteLine($"\n\nTổng của dãy = {sum}");
    }
    static void Trang22Cau7()
    {
        Console.WriteLine("Trang 22 Câu 7");
        Console.Write("Nhập số bắt đầu của khoảng: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số kết thúc của khoảng: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nCác số hoàn hảo trong khoảng [{start}, {end}]:");

        for (int num = start; num <= end; num++)
        {
            if (IsPerfect(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    // Hàm kiểm tra số hoàn hảo
    static bool IsPerfect(int number)
    {
        if (number < 2) return false;

        int sum = 1; // luôn có ước số 1
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum == number;
    }
    static void Trang22Cau8()
    {
        Console.WriteLine("Trang 22 Câu 8");
        Console.Write("Nhập một số nguyên: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine($"{num} là số nguyên tố.");
        else
            Console.WriteLine($"{num} không phải là số nguyên tố.");
        Console.ReadKey();
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
       
    }
}
