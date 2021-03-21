using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui pelo menos uma letra maiúscula
    /// </summary>
    public class ValidateUpper
    {
        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui algum caractere maiúsculo
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com caractere maiúsculo</returns>
        public bool HasUpper(string pPassword)
        {
            try
            {
                foreach (char passwordChar in pPassword)
                {
                    if (char.IsUpper(passwordChar))
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