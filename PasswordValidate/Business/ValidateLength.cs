using Microsoft.Extensions.Configuration;
using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui 9 caracteres ou mais
    /// </summary>
    public class ValidateLength
    {
        #region "Attributes"
        //Utilizo o arquivo de configuração para setar por fora caso precise, sem precisar alterar o código toda vez que desejar mudar o parâmetro de validação
        private int passwordLength = Convert.ToInt32(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("PasswordLength").Value);
        #endregion "Attributes"

        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui o tamanho esperado
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com tamanho esperado</returns>
        public bool HasCorrectLength(string pPassword)
        {
            try
            {
                if (pPassword.Length >= passwordLength)
                {
                    return true;
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