using LinkedList.Singly;


var linkedlist = new SinglyLinkedList<String>();
linkedlist.AddFirst("Esat");
linkedlist.AddFirst("İrem");
linkedlist.AddFirst("Rabia");
linkedlist.AddFirst("Yuşa");
linkedlist.AddFirst("İsmail");

var c = linkedlist.Head;

while (c != null)
{
    System.Console.WriteLine(c);
    c = c.Next;
}
// foreach (var item in linkedlist)
// {
//     System.Console.WriteLine(item);
// }
