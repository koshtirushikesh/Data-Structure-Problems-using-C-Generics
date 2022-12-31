namespace LInkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<int> linkdlist = new LinkedList<int>(); 

            linkdlist.AddFirst(56);
            linkdlist.AddLast(30);
            linkdlist.AddLast(70);
            
            foreach (int i in linkdlist)
            {
                Console.WriteLine(i);
            }
        }
    }
}