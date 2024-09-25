namespace LinkedListWithName
{
    public class NamingLinkedList : INamingList
    {
        public Node Head { get; private set; }

        // Fügt einen Namen als neuen Knoten am Ende der Liste hinzu
        public void Append(string name)
        {
            Node newNode = new Node(name);
            Append(newNode);
        }

        // Fügt einen Knoten am Ende der Liste hinzu
        public void Append(Node n)
        {
            if (Head == null)
            {
                Head = n;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = n;
            }
        }

        // Fügt einen Namen als neuen Knoten am Anfang der Liste hinzu
        public void InsertFront(string name)
        {
            Node newNode = new Node(name);
            InsertFront(newNode);
        }

        // Fügt einen Knoten am Anfang der Liste hinzu
        public void InsertFront(Node n)
        {
            n.Next = Head;
            Head = n;
        }

        // Gibt die Liste aus
        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Name);
                current = current.Next;
            }
        }

        // Gibt die Namen in der Liste als String zurück
        public string GetList()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result += current.Name + " ";
                current = current.Next;
            }
            return result.Trim();
        }

        // Findet einen Knoten anhand des Namens
        public Node FindName(string name)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return current;
                }
                current = current.Next;
            }
            return null; // Name wurde nicht gefunden
        }
    }
}
