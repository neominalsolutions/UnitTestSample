using Xunit;

namespace UnitTestSample
{
    public class UnitTest1
    {
        [Fact] // Fact Attribute ile bunu otomatik olarak test solutionda ��kt� alabiliyoruz.
        public void Test1()
        {
            // Arrange // test etmek i�in gerekli olan servis ba�lant�lar� veya nesnelerin instance tan�mlar�

            // Act  ilgili servis methodunu tan�ml�yoruz. Test eylemini uygulad���m�z k�s�m.

            // Assert => e�itlik var m� bu tipte mi i�eriyormu beklenen sonucuya uyuyor mu k�sm�

        }
    }
}