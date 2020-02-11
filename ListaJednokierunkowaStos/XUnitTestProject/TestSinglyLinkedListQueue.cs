using SinglyLinkedListStack;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class TestSinglyLinkedListQueue
    {
        [Fact]
        public void TestIsEmpty()
        {
            IQueue<int> sut = new SinglyLinkedListQueue<int>();
            Assert.True(sut.IsEmpty());

            sut.Push(5);
            Assert.False(sut.IsEmpty());
        }

        [Fact]
        public void TestPush()
        {
            IQueue<int> sut = new SinglyLinkedListQueue<int>();
            Assert.Throws<IndexOutOfRangeException>(() => sut.Front());
            sut.Push(3);
            Assert.Equal(3, sut.Front());
            sut.Push(4);
            sut.Push(5);
            Assert.Equal(3, sut.Front());
        }
    }
}
