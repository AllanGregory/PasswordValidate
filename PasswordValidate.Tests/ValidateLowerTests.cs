using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateLower
    /// </summary>
    public class ValidateLowerTests
    {
        /// <summary>
        /// Método responsável por testar a regra de conter caracter minúsculo na senha digitada, retornando true, pois contém
        /// </summary>
        [Fact]
        public void Has_Lower_Return_True()
        {
            Business.ValidateLower passwordValidate = new Business.ValidateLower();

            bool result = passwordValidate.HasLower("test");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de conter caractere minúsculo na senha digitada, retornando falso, pois não contém
        /// </summary>
        [Fact]
        public void Has_Not_Lower_Return_False()
        {
            Business.ValidateLower passwordValidate = new Business.ValidateLower();

            bool result = passwordValidate.HasLower("TEST");

            Assert.False(result);
        }
    }
}