using Microsoft.Extensions.Configuration;
using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui pelo menos um caracter especial
    /// </summary>
    public class ValidateSpecialChar
    {
        #region "Attributes"
        //Utilizo o arquivo de configuração para setar por fora caso precise, sem precisar alterar o código toda vez que desejar mudar o parâmetro de validação
        private string specialCharSequence = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("PasswordSpecialCharacters").Value;
        #endregion "Attributes"

        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui algum caractere especial
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com caractere especial</returns>
        public bool HasSpecialChar(string pPassword)
        {
            try
            {
                foreach (var specialChar in specialCharSequence)
                {
                    if (pPassword.Contains(specialChar))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + ". " + ex.StackTrace);
            }

            return false;
        }
        #endregion "Methods"
    }
}