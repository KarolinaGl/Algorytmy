using SinglyLinkedListStack;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class TestListStack
    {
        [Fact]
        public void TestIsEmpty()
        {
            IStack<int> sut = new ListStack<int>();
            Assert.True(sut.IsEmpty());

            sut.Push(5);
            Assert.False(sut.IsEmpty());
        }

        [Fact]
        public void TestPush()
        {
            IStack<int> sut = new ListStack<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.Top());
            sut.Push(3);
            Assert.Equal(3, sut.Top());
            sut.Push(4);
            sut.Push(5);
            Assert.Equal(5, sut.Top());
        }

        [Fact]
        public void TestPop()
        {
            IStack<int> sut = new ListStack<int>();
            sut.Push(1);
            sut.Push(2);
            sut.Push(3);
            sut.Push(4);
            Assert.Equal(4, sut.Pop());
            Assert.Equal(3, sut.Top());
            sut.Pop();
            sut.Pop();
            Assert.Equal(1, sut.Pop());
            Assert.True(sut.IsEmpty());
        }
    }
}
