using Microsoft.AspNetCore.Mvc;
using PracticeUser.Models;
using PracticeUser.Services;
using System.Collections.Generic;

namespace PracticeUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController:Controller
    {
        private UserDetailsServices _userDetailsServices;



        #region UserdetailsController
        
        public UserDetailsController(UserDetailsServices userDetailsServices)
        {
            _userDetailsServices = userDetailsServices;
        }
        #endregion

        #region GetUserbyEmail
        [HttpGet("GetUserbyEmail")]
        public IActionResult GetUserbyEmail(string EmailId)
        {
            return Ok(_userDetailsServices.GetUserbyEmail(EmailId));
        }
        #endregion

        #region GetallUserDetails
        
        [HttpGet("GetAllUserDetails()")]
        public List<UserDetails> GetAllUserDetails()
        {
            return _userDetailsServices.GetAllUserDetails();
        }
        #endregion

        #region DeleteUseretails
        
        [HttpDelete("DeleteUserDetails")]
        public IActionResult DeleteUserDetails(int UserId)
        {
            return Ok(_userDetailsServices.DeleteUserDetails(UserId));
        }
        #endregion

        #region GetUserDetails
        
        [HttpGet("GetUserDetails")]
        public IActionResult GetUserDetails(int UserId)
        {
            return Ok(_userDetailsServices.GetUserDetails(UserId));
        }
        #endregion

        #region SaveUserDetails
        
        [HttpPost("SaveUserDetails")]
        public IActionResult SaveUserDetails(UserDetails userDetails)
        {
            return Ok(_userDetailsServices.SaveUserDetails(userDetails));
        }
        #endregion

        #region UpdateUserDetails
       
        [HttpPut("UpdateUserDetails")]
        public IActionResult UpdateUserDetails(UserDetails userDetails)
        {
            return Ok(_userDetailsServices.UpdateUserDetails(userDetails));
        }
        #endregion
    }
}
