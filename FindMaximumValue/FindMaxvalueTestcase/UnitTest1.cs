using FindMaximumValue;

namespace FindMaxvalueTestcase
{
    public class TestsInteger
    {
        public class TestInt
        {
            [Test]
            public void findMax_MaximumValueAtFirstPosition()
            {
                int A = 30, B = 20, C = 10;
                FindMaximumValue.findMaximumValue<int> findMaximumValue = new FindMaximumValue.findMaximumValue<int>(A, B, C);
                int finalResult = findMaximumValue.findMax();
                Assert.AreEqual(A, finalResult);
            }
            [Test]
            public void findMax_MaximumValueAtSecondPosition()
            {
                int A = 10, B = 30, C = 20;
                FindMaximumValue.findMaximumValue<int> findMaximumValue = new FindMaximumValue.findMaximumValue<int>(A, B, C);
                int finalResult = findMaximumValue.findMax();
                Assert.AreEqual(B, finalResult);
            }
            [Test]
            public void findMax_MaximumValueAtThirdPosition()
            {
                int A = 10, B = 20, C = 30;
                FindMaximumValue.findMaximumValue<int> findMaximumValue = new FindMaximumValue.findMaximumValue<int>(A, B, C);
                int finalResult = findMaximumValue.findMax();
                Assert.AreEqual(C, finalResult);
            }
        }
        public class TestFloat
        {
            [Test]
            public void findMaxFloat_MaximumValueAtFirstPosition()
            {
                float A = 30.5F, B = 20.5F, C = 10.5F;
                FindMaximumValue.findMaximumValue<float> findMaximumValue = new FindMaximumValue.findMaximumValue<float>(A, B, C);
                float finalResult = findMaximumValue.findMax();
                Assert.AreEqual(A, finalResult);
            }
            [Test]
            public void findMaxFloat_MaximumValueAtSecondPosition()
            {
                float A = 10.5F, B = 30.5F, C = 20.5F;
                FindMaximumValue.findMaximumValue<float> findMaximumValue = new FindMaximumValue.findMaximumValue<float>(A, B, C);
                float finalResult = findMaximumValue.findMax();
                Assert.AreEqual(B, finalResult);
            }
            [Test]
            public void findMaxFloat_MaximumValueAtThirdPosition()
            {
                float A = 10.5F, B = 20.5F, C = 30.5F;
                FindMaximumValue.findMaximumValue<float> findMaximumValue = new FindMaximumValue.findMaximumValue<float>(A, B, C);
                float finalResult = findMaximumValue.findMax();
                Assert.AreEqual(C, finalResult);
            }
        }
        public class TestString
        {
            [Test]
            public void findMaxString_MaximumValueAtFirstPosition()
            {
                string A = "Orange", B = "Banana", C = "Apple";
                FindMaximumValue.findMaximumValue<string> findMaximumValue = new FindMaximumValue.findMaximumValue<string>(A, B, C);
                string finalResult = findMaximumValue.findMax();
                Assert.AreEqual(A, finalResult);
            }
            [Test]
            public void findMaxString_MaximumValueAtSecondPosition()
            {
                string A = "Banana", B = "Orange", C = "Apple";
                FindMaximumValue.findMaximumValue<string> findMaximumValue = new FindMaximumValue.findMaximumValue<string>(A, B, C);
                string finalResult = findMaximumValue.findMax();
                Assert.AreEqual(B, finalResult);
            }
            [Test]
            public void findMaxString_MaximumValueAtThirdPosition()
            {
                string A = "Banana", B = "Apple", C = "Orange";
                FindMaximumValue.findMaximumValue<string> findMaximumValue = new FindMaximumValue.findMaximumValue<string>(A, B, C);
                string finalResult = findMaximumValue.findMax();
                Assert.AreEqual(C, finalResult);
            }
        }



    }


}