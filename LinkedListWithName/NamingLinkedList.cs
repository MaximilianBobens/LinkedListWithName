using System.Text;

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
            // Überprüfe, ob die Liste leer ist (d.h. ob Head null ist).
            if (Head == null)
            {
                // Wenn die Liste leer ist, setze den neuen Knoten n als Head.
                Head = n;
            }
            else
            {
                // Wenn die Liste nicht leer ist, beginne bei Head und gehe durch die Liste.
                Node temp = Head;
        
                // Durchlaufe die Liste, bis der letzte Knoten erreicht ist (d.h. ein Knoten,
                // dessen Next-Referenz null ist).
                while (temp.Next != null)
                {
                    temp = temp.Next; // Gehe zum nächsten Knoten.
                }
        
                // Füge den neuen Knoten n am Ende der Liste hinzu, indem du die Next-Referenz
                // des letzten Knotens auf n setzt.
                temp.Next = n;
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
            // Setze eine Referenz auf den ersten Knoten (Head) der Liste.
            Node temp = Head;
    
            // Solange temp(Head) nicht null ist, durchlaufe die Liste.
            while (temp != null)
            {
                // Gib den Namen des aktuellen Knotens auf der Konsole aus.
                Console.WriteLine(temp.Name);
        
                // Gehe zum nächsten Knoten, indem die Next-Referenz des aktuellen Knotens verwendet wird.
                temp = temp.Next;
            }
        }

      

        // Gibt die Namen in der Liste als String zurück
        public string GetList()
        {
            Node temp = Head;
            StringBuilder result = new StringBuilder();
    
            while (temp != null)
            {
                result.Append(temp.Name).Append(" ");
                temp = temp.Next;
            }

            return result.ToString();
        }

       

        // Findet einen Knoten anhand des Namens
        public Node FindName(string name)
        {
            // Setze eine Referenz auf den ersten Knoten (Head) der Liste.
            Node temp = Head;
    
            // Solange current nicht null ist, durchlaufe die Liste.
            while (temp != null)
            {
                // Überprüfe, ob der Name des aktuellen Knotens mit dem gesuchten Namen übereinstimmt.
                if (temp.Name == name)
                {
                    // Wenn der Name gefunden wurde, gib den aktuellen Knoten zurück.
                    return temp;
                }
        
                // Gehe zum nächsten Knoten über.
                temp = temp.Next;
            }
    
            // Wenn kein Knoten mit dem gesuchten Namen gefunden wurde, gib null zurück.
            return null;
        }

    }
}
