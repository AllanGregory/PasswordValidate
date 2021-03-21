using System;

namespace PasswordValidate.Business
{
    /// <summary>
    /// Classe responsável por validar se o password digitado possui caracteres repetidos
    /// </summary>
    public class ValidateRepeated
    {
        #region "Methods"
        /// <summary>
        /// Método responsável por validar se a senha digitada possui algum caractere repetido
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada com caractere repetido</returns>
        public bool HasRepeated(string pPassword)
        {
            try
            {
                char[] passwordCharArray = pPassword.ToCharArray();

                for(int xIndex = 0; xIndex < passwordCharArray.Length; xIndex++)
                {
                    for(int yIndex = xIndex + 1; yIndex < passwordCharArray.Length; yIndex++)
                    {
                        if (passwordCharArray[xIndex] == passwordCharArray[yIndex])
                        {
                            return true;
                        }
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