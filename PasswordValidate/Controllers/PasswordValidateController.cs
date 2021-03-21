using Microsoft.AspNetCore.Mvc;
using PasswordValidate.Business;
using System;

namespace PasswordValidate.Controllers
{
    /// <summary>
    /// Classe exposta responsável por receber a chamada externa na API
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordValidateController : ControllerBase
    {
        #region "Attributes"
        BusinessPasswordValidate businessPasswordValidate = new BusinessPasswordValidate();
        #endregion "Attributes"

        #region "Api"
        /// <summary>
        /// Método GET responsável por receber a chamada externa
        /// </summary>
        /// <param name="pPassword">Senha digitada</param>
        /// <returns>True ou false para senha digitada válida</returns>
        [HttpGet]
        public bool GetIsValidPassword(object pPassword)
        {
            try
            {
                if (businessPasswordValidate.ValidatePassword(pPassword)) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ". " + ex.StackTrace);
            }

            return false;
        }
        #endregion "Api"
    }
}