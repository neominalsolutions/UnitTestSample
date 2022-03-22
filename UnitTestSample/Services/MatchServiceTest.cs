using MathSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestSample.Services
{

    public class MatchServiceTest
    {
        // eğer dışarıdan test methodu parametre almıyorsa [Fact] attribute ile işaretlenebilir. Fakat eğer parametre alacak ise ozaman Teory attribute kullanıyoruz.
        [Fact]
        public void SubtractTest()
        {
            #region Arrange
            //Kaynaklar hazırlanıyor.
            int number1 = 10;
            int number2 = 20;
            int expected = -10;
            MathService mathematics = new MathService();
            #endregion
            #region Act
            //İlgili metot Arrange'de ki kaynaklarla test ediliyor.
            int result = mathematics.Subtract(number1, number2);
            #endregion
            #region Assert
            //Test neticesinde gelen data doğrulanıyor.
            Assert.Equal(expected, result);
           
            #endregion
        }

        // Eğer ki 3 farklı paramtere değeri verildiğinde hepsi expted result veriyorsa bu durumda testen geçmiş oluruz.
        [Theory]
        [InlineData(3, 5,-2)]
        [InlineData(5, 15,-10)]
        [InlineData(20, 22,-2)]
        public void SubtractTestWithParams(int number1,int number2,int expected)
        {
            #region Arrange
            //Kaynaklar hazırlanıyor.
            MathService mathematics = new MathService();
            #endregion
            #region Act
            //İlgili metot Arrange'de ki kaynaklarla test ediliyor.
            int result = mathematics.Subtract(number1, number2);
            #endregion
            #region Assert
            //Test neticesinde gelen data doğrulanıyor.

            
            Assert.Equal(expected, result);

            #endregion
        }

    }
}
