using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateLength
    /// </summary>
    public class ValidateLengthTests
    {
        /// <summary>
        /// Método responsável por testar a regra de tamanho da senha digitada, retornando true, pois o tamanho é o esperado
        /// </summary>
        [Fact]
        public void Has_Correct_Length_Return_True()
        {
            Business.ValidateLength passwordValidate = new Business.ValidateLength();

            bool result = passwordValidate.HasCorrectLength("t3st12345");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de tamanho da senha digitada, retornando falso, pois o tamanho não é o esperado
        /// </summary>
        [Fact]
        public void Has_Incorrect_Length_Return_False()
        {
            Business.ValidateLength passwordValidate = new Business.ValidateLength();

            bool result = passwordValidate.HasCorrectLength("test");

            Assert.False(result);
        }
    }
}