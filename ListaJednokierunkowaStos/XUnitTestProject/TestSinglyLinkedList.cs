using System;
using Xunit;
using SinglyLinkedListStack;

namespace XUnitTestProject
{
    public class TestSinglyLinkedList
    {
        [Fact]
        public void TestAddAtTheFront()
        {
            SinglyLinkedList<char> sut = new SinglyLinkedList<char>();
            sut.AddAtTheFront('c');
            Assert.Equal('c', sut.DeleteFirstNode());
        }

        [Fact]
        public void TestGetNode()
        {
            SinglyLinkedList<char> sut = new SinglyLinkedList<char>();
            sut.AddAtTheFront('c');
            sut.AddAtTheFront('b');
            sut.AddAtTheFront('a');
            sut.AddAtTheEnd('d');
            
            Assert.Equal('a', sut.GetNode(0));
            Assert.Equal('b', sut.GetNode(1));
            Assert.Equal('c', sut.GetNode(2));
            Assert.Equal('d', sut.GetNode(3));
            Assert.Throws<IndexOutOfRangeException>(() => sut.GetNode(4));
        }
    }
}
