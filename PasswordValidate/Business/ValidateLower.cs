using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui pelo menos uma letra minúscula
    /// </summary>
    public class ValidateLower
    {
        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui algum caractere minúsculo
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com caractere minúsculo</returns>
        public bool HasLower(string pPassword)
        {
            try
            {
                foreach (char passwordChar in pPassword)
                {
                    if (char.IsLower(passwordChar))
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