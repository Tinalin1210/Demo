namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 取得當前時間
            DateTime currentDateTime = DateTime.Now;

            // 計算民國年
            int rocYear = currentDateTime.Year - 1911;

            //D3 表示使用三位數顯示
            string currentTimeROC = $"{rocYear:D3}{currentDateTime:MMdd HH:mm:ss.fff}";

            Console.WriteLine(currentTimeROC);
        }
    }
}

