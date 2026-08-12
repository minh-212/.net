using System;
using System.Reflection;

namespace NetInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập Encoding để hiển thị tiếng Việt có dấu trong Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=========================================================");
            Console.WriteLine("         THÔNG TIN MÔI TRƯỜNG THỰC THI HỆ THỐNG          ");
            Console.WriteLine("=========================================================\n");

            // 1. Lấy phiên bản CLR/.NET Core
            Console.WriteLine("[1] THÔNG TIN PHIÊN BẢN (.NET & ASSEMBLY):");
            Console.WriteLine($"- Phiên bản CLR/.NET đang chạy : {Environment.Version}");

            // Sử dụng System.Reflection để lấy thông tin của ứng dụng (Assembly) hiện tại
            var assemblyInfo = Assembly.GetExecutingAssembly().GetName();
            Console.WriteLine($"- Tên ứng dụng (Reflection)    : {assemblyInfo.Name}");
            Console.WriteLine($"- Phiên bản ứng dụng           : {assemblyInfo.Version}\n");

            // 2. Tên máy tính và tên người dùng đăng nhập hệ thống
            Console.WriteLine("[2] THÔNG TIN MÁY TÍNH & NGƯỜI DÙNG:");
            Console.WriteLine($"- Tên máy tính (Machine Name)  : {Environment.MachineName}");
            Console.WriteLine($"- Người dùng hệ thống (User)   : {Environment.UserName}\n");

            // 3. Hệ điều hành và kiến trúc CPU
            Console.WriteLine("[3] HỆ ĐIỀU HÀNH & KIẾN TRÚC CPU:");
            Console.WriteLine($"- Phiên bản Hệ điều hành       : {Environment.OSVersion}");

            // Kiểm tra kiến trúc 64-bit hay 32-bit
            string osArch = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            string processArch = Environment.Is64BitProcess ? "64-bit" : "32-bit";
            Console.WriteLine($"- Kiến trúc Hệ điều hành       : {osArch}");
            Console.WriteLine($"- Kiến trúc Tiến trình (App)   : {processArch}\n");

            // 4. Dung lượng bộ nhớ RAM đang được Garbage Collector (GC) quản lý
            Console.WriteLine("[4] THÔNG TIN BỘ NHỚ (GARBAGE COLLECTOR):");
            // False: Lấy dung lượng tức thời không ép GC phải dọn rác trước khi tính toán
            long memoryInBytes = GC.GetTotalMemory(false);
            double memoryInMB = memoryInBytes / (1024.0 * 1024.0); // Quy đổi sang Megabytes
            Console.WriteLine($"- Dung lượng RAM GC quản lý    : {memoryInBytes:N0} Bytes (~{memoryInMB:N2} MB)");

            Console.WriteLine("\n=========================================================");
        }
    }
}
