namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 取得當前時間
            DateTime currentDateTime = DateTime.Now;

            // 格式化時間並打印
            //yyyy 是四位數的年份。
            // MM 是兩位數的月份。
            //dd 是兩位數的日期。
            //HH 是兩位數的24小時制小時。
            //mm 是兩位數的分鐘。
            //ss 是兩位數的秒數。
            //fff 是三位數的毫秒數。
            string formattedTime = currentDateTime.ToString("yyyyMMdd HH:mm:ss.fff");
            Console.WriteLine(formattedTime);
        }
    }
}

