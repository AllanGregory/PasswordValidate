using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateDigit
    /// </summary>
    public class ValidateDigitTests
    {
        /// <summary>
        /// Método responsável por testar a regra de conter dígito na senha digitada, retornando true, pois há dígito
        /// </summary>
        [Fact]
        public void Has_Digit_Return_True()
        {
            Business.ValidateDigit passwordValidate = new Business.ValidateDigit();

            bool result = passwordValidate.HasDigit("t3st");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de conter dígito na senha digitada, retornando falso, pois não há dígito
        /// </summary>
        [Fact]
        public void Has_Not_Digit_Return_False()
        {
            Business.ValidateDigit passwordValidate = new Business.ValidateDigit();

            bool result = passwordValidate.HasDigit("test");

            Assert.False(result);
        }
    }
}