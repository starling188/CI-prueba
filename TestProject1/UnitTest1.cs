using Cosa;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Class1 cosa = new Class1();
            string expected = "hello word";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                cosa.HelloWord();
                string output = sw.ToString().Trim();

                // Assert
                Assert.Equal(expected, output);
            }
        }
    }
}