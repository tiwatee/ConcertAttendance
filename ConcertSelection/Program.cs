namespace ConcertSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AliAndSon aliAndSon = new AliAndSon();
            aliAndSon.IsJohnnyDrille=true;
            aliAndSon.IsEdsheeran=false;
            aliAndSon.IsAdele=false;
            Console.WriteLine("{0} the Concert by Ali and Son Corporation",aliAndSon.Attend());

            LadyBug ladyBug = new LadyBug();
            ladyBug.IsJohnnyDrille=true;
            ladyBug.IsEdsheeran =true;
            ladyBug.IsAdele = true;
            Console.WriteLine("{0} the Concert by Lady Bug Corporation ", ladyBug.Attend());
        }
    }
}