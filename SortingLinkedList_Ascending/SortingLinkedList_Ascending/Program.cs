using SortingLinkedList_Ascending;

var list = new LinkedList();

list.Insert(44);
list.Insert(2000);
list.Insert(550);
list.Insert(3);
list.Insert(1);

list.SortByAscending();

list.Print();

Console.ReadKey();