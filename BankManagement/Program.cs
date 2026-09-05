using System;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cấu hình để in được tiếng Việt trên Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("================ DEMO BANK MANAGEMENT ================\n");

            try
            {
                // 1. KHỞI TẠO TÀI KHOẢN (Tính Đa hình: Dùng biến kiểu Account)
                Console.WriteLine("--- 1. KHỞI TẠO TÀI KHOẢN ---");
                Account checking = new CheckingAccount("ACC01", "Nguyen Van A", 1000);
                Account saving = new SavingAccount("ACC02", "Tran Thi B", 2000);

                Console.WriteLine($"[Checking] ID: {checking.ID} | Chủ TK: {checking.Owner} | Số dư: {checking.Balance}");
                Console.WriteLine($"[Saving]   ID: {saving.ID} | Chủ TK: {saving.Owner} | Số dư: {saving.Balance}\n");

                // 2. TEST NẠP TIỀN (DEPOSIT)
                Console.WriteLine("--- 2. TEST NẠP TIỀN (DEPOSIT) ---");
                checking.Deposit(500);
                saving.Deposit(300);
                Console.WriteLine();

                // 3. TEST RÚT TIỀN (WITHDRAW) VỚI CHECKING ACCOUNT
                Console.WriteLine("--- 3. TEST RÚT TIỀN VỚI CHECKING ACCOUNT ---");
                checking.Withdraw(200);
                Console.WriteLine();

                // 4. TEST GIỚI HẠN 3 LẦN RÚT CỦA SAVING ACCOUNT
                Console.WriteLine("--- 4. TEST GIỚI HẠN SỐ LẦN RÚT CỦA SAVING ACCOUNT ---");
                saving.Withdraw(100); // Lần 1
                saving.Withdraw(100); // Lần 2
                saving.Withdraw(100); // Lần 3
                saving.Withdraw(100); // Lần 4 (Sẽ báo lỗi quá số lần rút)
                Console.WriteLine();

                // 5. TEST BẮT LỖI EXCEPTION (RÚT QUÁ SỐ DƯ)
                Console.WriteLine("--- 5. TEST RÚT QUÁ SỐ DƯ (BẮT EXCEPTION) ---");
                checking.Withdraw(5000); // Sẽ ném Exception do vượt số dư
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LỖI CẢNH BÁO]: {ex.Message}");
            }

            Console.WriteLine("\n================ HOÀN THÀNH KIỂM THỬ ================");
        }
    }
}