using AS2223_4G_INF_CangiottiFederico_Statistiche;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_MediaAritmetica()
        {
            Statistiche s = new Statistiche();

            s.AddValue(15);
            s.AddValue(6);
            s.AddValue(7);
            s.AddValue(18);
            s.AddValue(9);
            s.AddValue(100);
            s.AddValue(114);
            s.AddValue(121);

            Assert.IsTrue(s.MediaAritmetica() == 48.75);
        }

        [Test]
        public void Test_MediaPonderata()
        {
            Assert.Pass();
        }
    }
}