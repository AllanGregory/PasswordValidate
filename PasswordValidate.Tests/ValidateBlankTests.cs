using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateBlank
    /// </summary>
    public class ValidateBlankTests
    {
        /// <summary>
        /// Método responsável por testar a regra de espaço em branco na senha digitada, retornando true, pois há espaço em branco
        /// </summary>
        [Fact]
        public void Has_Blank_Space_Return_True()
        {
            Business.ValidateBlank passwordValidate = new Business.ValidateBlank();

            bool result = passwordValidate.HasBlankSpace("te st");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de espaço em branco na senha digitada, retornando falso, pois não há espaço em branco
        /// </summary>
        [Fact]
        public void Has_Not_Blank_Space_Return_False()
        {
            Business.ValidateBlank passwordValidate = new Business.ValidateBlank();

            bool result = passwordValidate.HasBlankSpace("test");

            Assert.False(result);
        }
    }
}