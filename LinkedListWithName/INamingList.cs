namespace LinkedListWithName;

public interface INamingList
{
    Node Head { get;}
    void Append(string Name);
    void Append(Node n);
    void InsertFront(string Name);
    void InsertFront(Node n);
    void PrintList();
    string GetList();
    Node FindName(string name);
}