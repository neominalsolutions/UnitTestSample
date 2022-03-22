using Xunit;

namespace UnitTestSample
{
    public class UnitTest1
    {
        [Fact] // Fact Attribute ile bunu otomatik olarak test solutionda çýktý alabiliyoruz.
        public void Test1()
        {
            // Arrange // test etmek için gerekli olan servis baðlantýlarý veya nesnelerin instance tanýmlarý

            // Act  ilgili servis methodunu tanýmlýyoruz. Test eylemini uyguladýðýmýz kýsým.

            // Assert => eþitlik var mý bu tipte mi içeriyormu beklenen sonucuya uyuyor mu kýsmý

        }
    }
}