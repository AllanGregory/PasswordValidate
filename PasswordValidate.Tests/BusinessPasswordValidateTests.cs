using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PasswordValidate.Models;
using Xunit;

namespace PasswordValidate.Tests
{
    /// <summary>
    /// Classe responsável por testar a regra da classe BusinessPasswordValidate
    /// </summary>
    public class BusinessPasswordValidateTests
    {
        private string CorrectInputPassword { get; set; }
        private string IncorrectInputPassword { get; set; }

        public BusinessPasswordValidateTests()
        {
            this.CorrectInputPassword = "AbTp9!fok";
            this.IncorrectInputPassword = "test";
        }

        /// <summary>
        /// Método responsável por testar as regras aplicadas no gerenciador de regras, retornando true, pois todas as condições foram atendidas
        /// </summary>
        [Fact]
        public void Is_Valid_Password_Return_True()
        {
            Business.BusinessPasswordValidate passwordValidate = new Business.BusinessPasswordValidate();
            Password password = new Password();
            password.InputPassword = "AbTp9!fok";

            object InputPassword = JsonConvert.SerializeObject(password);

            bool result = passwordValidate.ValidatePassword(InputPassword);

            Assert.True(result);
        }

        /// <summary>
        /// Método responsável por testar as regras aplicadas no gerenciador de regras, retornando false, pois nem todas as condições foram atendidas
        /// </summary>
        [Theory]
        [InlineData("test")] //Length
        [InlineData("123te st89")] //Blank Space
        [InlineData("testtesttest")] //Digit
        [InlineData("TESTTEST123")] //Lower
        [InlineData("testtest123")] //Upper
        [InlineData("Test12345678")] //Special Char
        [InlineData("TesTesT1122")] //Repeated
        public void Is_Not_Valid_Password_Return_False(string pPassword)
        {
            Business.BusinessPasswordValidate passwordValidate = new Business.BusinessPasswordValidate();
            Password password = new Password();
            password.InputPassword = pPassword;

            object InputPassword = JsonConvert.SerializeObject(password);

            bool result = passwordValidate.ValidatePassword(InputPassword);

            Assert.False(result);
        }
    }
}