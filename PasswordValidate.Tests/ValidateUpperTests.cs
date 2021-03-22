using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateUpper
    /// </summary>
    public class ValidateUpperTests
    {
        /// <summary>
        /// Método responsável por testar a regra de conter caracter maiúsculo na senha digitada, retornando true, pois contém
        /// </summary>
        [Fact]
        public void Has_Upper_Return_True()
        {
            Business.ValidateUpper passwordValidate = new Business.ValidateUpper();

            bool result = passwordValidate.HasUpper("Test");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de conter caractere maiúsculo na senha digitada, retornando falso, pois não contém
        /// </summary>
        [Fact]
        public void Has_Not_Upper_Return_False()
        {
            Business.ValidateUpper passwordValidate = new Business.ValidateUpper();

            bool result = passwordValidate.HasUpper("test");

            Assert.False(result);
        }
    }
}