using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe ValidateRepeated
    /// </summary>
    public class ValidateRepeatedTests
    {
        /// <summary>
        /// Método responsável por testar a regra de conter caracteres repetidos na senha digitada, retornando true, pois contém
        /// </summary>
        [Fact]
        public void Has_Repeated_Return_True()
        {
            Business.ValidateRepeated passwordValidate = new Business.ValidateRepeated();

            bool result = passwordValidate.HasRepeated("Testt");

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar a regra de conter caracteres repetidos da senha digitada, retornando falso, pois não contém
        /// </summary>
        [Fact]
        public void Has_Not_Repeated_Return_False()
        {
            Business.ValidateRepeated passwordValidate = new Business.ValidateRepeated();

            bool result = passwordValidate.HasRepeated("tes7");

            Assert.False(result);
        }
    }
}