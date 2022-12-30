namespace LInkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            //linkedList.Add(70);            //uc1
            //linkedList.Add(30);
            //linkedList.Add(56);


            //linkedList.AddFirst(70);        //uc2
            //linkedList.AddFirst(30);
            //linkedList.AddFirst(56);

            linkedList.AddFirst(56);          //uc3
            linkedList.AddFirst(30);
            linkedList.AddFirst(70);


            linkedList.display();
            
        }
    }
}