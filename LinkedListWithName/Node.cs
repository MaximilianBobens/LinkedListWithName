namespace LinkedListWithName;

public class Node
{
    public string Name { get; set; }
    public Node Next { get; set; }

    public Node(string name)
    {
        Name = name;
        Next = null;
    }
}