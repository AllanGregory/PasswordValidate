using Newtonsoft.Json;
using PasswordValidate.Models;
using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por gerenciar as chamadas de validações das regras para a senha digitada
    /// </summary>
    public class BusinessPasswordValidate
    {
        #region "Attributes"
        ValidateBlank validateBlank = new ValidateBlank();
        ValidateLength validateLength = new ValidateLength();
        ValidateDigit validateDigit = new ValidateDigit();
        ValidateLower validateLower = new ValidateLower();
        ValidateUpper validateUpper = new ValidateUpper();
        ValidateSpecialChar validateSpecialChar = new ValidateSpecialChar();
        ValidateRepeated validateRepeated = new ValidateRepeated();
        #endregion "Attributes"

        #region "Methods"
        /// <summary>
        /// Método responsável por gerenciar as chamadas de validações da senha digitada
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada válida</returns>
        public bool ValidatePassword(object pPassword)
        {
            try
            {
                Password password = JsonConvert.DeserializeObject<Password>(pPassword.ToString());

                if (!validateLength.HasCorrectLength(password.InputPassword)) return false; //Length
                if (validateBlank.HasBlankSpace(password.InputPassword)) return false; //Blank Space
                if (!validateDigit.HasDigit(password.InputPassword)) return false; //Digit
                if (!validateLower.HasLower(password.InputPassword)) return false; //Lower
                if (!validateUpper.HasUpper(password.InputPassword)) return false; //Upper
                if (!validateSpecialChar.HasSpecialChar(password.InputPassword)) return false; //Special Char
                if (validateRepeated.HasRepeated(password.InputPassword)) return false; //Repeated
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + ". " + ex.StackTrace);
            }

            return true;
        }
        #endregion "Methods"
    }
}