using System.Net.Security;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // answer 1
            #region answer 1
            Book B = new Book();
            //  B. password  مش هيظهر حاجه عشان انت مستخدم  accses  ال  privtr  ف هو مش هيهر غير ف   ال class بتاعه 

           Console.WriteLine(Book.password);     // حلهم اني اعمل ال  accses modefier ل public
            #endregion


        }
    }
}
