using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui pelo menos um dígito
    /// </summary>
    public class ValidateDigit
    {
        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui algum dígito
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com algum dígito</returns>
        public bool HasDigit(string pPassword)
        {
            try
            {
                foreach (char passwordChar in pPassword)
                {
                    if(char.IsDigit(passwordChar))
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