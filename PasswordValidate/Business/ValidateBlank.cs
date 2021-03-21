using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui espaços em branco
    /// </summary>
    public class ValidateBlank
    {
        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui espaços em branco
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada sem espaço em branco</returns>
        public bool HasBlankSpace(string pPassword)
        {
            try
            {
                foreach (char passwordChar in pPassword)
                {
                    if (passwordChar == ' ')
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