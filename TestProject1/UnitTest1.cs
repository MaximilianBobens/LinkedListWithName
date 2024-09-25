using LinkedListWithName;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [TestFixture]
    public class NamingLinkedListTests
    {
        [Test]
        public void Test_Append_String()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            Assert.AreEqual("Alice", list.GetList());
        }

        [Test]
        public void Test_Append_Node()
        {
            INamingList list = new NamingLinkedList();
            Node n = new Node("Bob");
            list.Append(n);
            Assert.AreEqual("Bob", list.GetList());
        }

        [Test]
        public void Test_InsertFront_String()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            list.InsertFront("Bob");
            Assert.AreEqual("Bob Alice", list.GetList());
        }

        [Test]
        public void Test_InsertFront_Node()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            Node n = new Node("Bob");
            list.InsertFront(n);
            Assert.AreEqual("Bob Alice", list.GetList());
        }

        [Test]
        public void Test_FindName_Exists()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            list.Append("Bob");
            Node result = list.FindName("Bob");
            Assert.IsNotNull(result);
            Assert.AreEqual("Bob", result.Name);
        }

        [Test]
        public void Test_FindName_NotExists()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            Node result = list.FindName("Charlie");
            Assert.IsNull(result);
        }

        [Test]
        public void Test_PrintList()
        {
            INamingList list = new NamingLinkedList();
            list.Append("Alice");
            list.Append("Bob");
            list.InsertFront("Charlie");
            Assert.AreEqual("Charlie Alice Bob", list.GetList());
        }
    }
}