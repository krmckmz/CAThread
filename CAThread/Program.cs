class Program
{
    public static void Main(string[] args)
    {
        Thread thread = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("thread");
    });

        //thread.Priority = ThreadPriority.BelowNormal;
        //var isThreadBackground = thread.IsBackground;

        thread.Start();
        Console.WriteLine(thread.IsAlive);

        //Join komutu async yapı çalışıp işlem bitse dahi tutarlılık sağlamak için
        //thread'den gelecek sonucu beklemek istediğimiz durumlarda kullanılır.
        thread.Join();
        Console.WriteLine("thread");
        Console.WriteLine(thread.IsAlive);
    }
}