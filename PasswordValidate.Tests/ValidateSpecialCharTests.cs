using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateSpecialChar
    /// </summary>
    public class ValidateSpecialCharTests
    {
        /// <summary>
        /// Método responsável por testar a regra de conter caracteres especiais na senha digitada, retornando true, pois contém
        /// </summary>
        [Fact]
        public void Has_Special_Char_Return_True()
        {
            Business.ValidateSpecialChar passwordValidate = new Business.ValidateSpecialChar();

            bool result = passwordValidate.HasSpecialChar("Testt@");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de conter caracteres especiais da senha digitada, retornando falso, pois não contém
        /// </summary>
        [Fact]
        public void Has_Not_Special_Char_Return_False()
        {
            Business.ValidateSpecialChar passwordValidate = new Business.ValidateSpecialChar();

            bool result = passwordValidate.HasSpecialChar("test");

            Assert.False(result);
        }
    }
}