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
            Assert.Equal('c', sut.GetLastNode());
            sut.AddAtTheFront('b');
            sut.AddAtTheFront('a');
            Assert.Equal('c', sut.GetLastNode());
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

        [Fact]
        public void TestAddAtTheEnd()
        {
            SinglyLinkedList<char> sut = new SinglyLinkedList<char>();
            Assert.Equal(default, sut.GetLastNode());
            sut.AddAtTheEnd('c');
            Assert.Equal('c', sut.GetLastNode());
            sut.AddAtTheEnd('b');
            sut.AddAtTheEnd('a');
            Assert.Equal('a', sut.GetLastNode());
        }

        [Fact]
        public void TestDeleteFirstNode()
        {
            SinglyLinkedList<char> sut = new SinglyLinkedList<char>();
            sut.AddAtTheFront('c');
            Assert.Equal('c',sut.GetLastNode());
            sut.DeleteFirstNode();
            Assert.Equal(default, sut.GetLastNode());
        }

        [Fact]
        public void TestDeleteLastNode()
        {
            SinglyLinkedList<char> sut = new SinglyLinkedList<char>();
            sut.AddAtTheFront('c');
            sut.AddAtTheFront('b');
            sut.AddAtTheFront('a');
            Assert.Equal('c', sut.GetLastNode());
            sut.DeleteLastNode();
            Assert.Equal('b', sut.GetLastNode());
            sut.DeleteLastNode();
            Assert.Equal('a', sut.GetLastNode());
            sut.DeleteLastNode();
            Assert.Equal(default, sut.GetLastNode());
        }
    }
}
