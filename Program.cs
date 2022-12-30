namespace LInkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();


            linkedList.AddFirst(56);          
            linkedList.AddFirst(30);
            linkedList.AddFirst(70);

            linkedList.display();
            
        }
    }
}