using System.Net.Security;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B = new Book();
            // // answer 1
            #region answer 1
            // Book B = new Book();
            // //  B. password  مش هيظهر حاجه عشان انت مستخدم  accses  ال  privtr  ف هو مش هيهر غير ف   ال class بتاعه 

            //Console.WriteLine(Book.password);     // حلهم اني اعمل ال  accses modefier ل public
            #endregion


            // answer 2
            #region answer 2
            //B.copiesInStock = 5; //  ظهر عادي لان ال  internal  بتخلي الجواها يتشاف لحد نفس ال  project
            //Console.WriteLine(B.copiesInStock); // 5 
            #endregion

            // answer 3 
            #region 

            //B.Title = "C# Programming"; // ظهرت عادي لان public  متاح خلال ال  solutoin  كله 

            //Console.WriteLine(B.Title); //  هتطبع عادي
            #endregion

            // answer 4
            #region answer 4

            //B.Genre = Genre.Science;

            //Console.WriteLine(B.Genre); // بتطلب ال  SCIENCE 
            #endregion

            // answer 5
            #region answer 5
            Console.WriteLine((int)Genre.Fiction); // 1
            Console.WriteLine((int)Genre.NonFiction); // 2
            Console.WriteLine((int)Genre.Science); // 3
            #endregion

        }
    }
}
