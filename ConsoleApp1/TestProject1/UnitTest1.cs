namespace myClassTests
{
    
    public class basictests
    {
        [Fact]
        public void addTest1()
        {
            myClass myClass = new myClass();
            var myPass = myClass.add(2, 2);
            Assert.Equal(4, myPass);
        }

        [Fact]
        public void subtract()
        {
            myClass myClass = new myClass();
            var myPass = myClass.subtract(2,1);
            Assert.Equal(4, myPass);
        }
    }
}