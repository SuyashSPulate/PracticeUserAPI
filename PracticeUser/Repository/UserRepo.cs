using Microsoft.EntityFrameworkCore;
using PracticeUser.Data;
using PracticeUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeUser.Repository
{
    public class UserRepo:IUser
    {
        private PracticeUserDbContext _PracticeUserDb;


        #region UserRepo
        
        public UserRepo(PracticeUserDbContext PracticeUserDb)
        {
            _PracticeUserDb = PracticeUserDb;
        }
        #endregion


        #region DeleteUserDetails
       
        public string DeleteUserDetails(int UserId)
        {
            string msg = "";
            UserDetails deleteUser = _PracticeUserDb.UserDetails.Find(UserId);
            try
            {
                if (deleteUser != null)
                {
                    _PracticeUserDb.UserDetails.Remove(deleteUser);
                    _PracticeUserDb.SaveChanges();
                    msg = "Deleted";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return msg;
        }
        #endregion



        #region GetAllUserDetails
       
        public List<UserDetails> GetAllUserDetails()
        {
            try
            {
                List<UserDetails> user = _PracticeUserDb.UserDetails.ToList();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion



        #region GetuserDetails
       
        public UserDetails GetUserDetails(int UserId)
        {
            try
            {
                UserDetails user = _PracticeUserDb.UserDetails.Find(UserId);
                return user;
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion



        #region SaveUserDetails
       
        public string SaveUserDetails(UserDetails userDetails)
        {
            string result = string.Empty;
            try
            {
                _PracticeUserDb.UserDetails.Add(userDetails);
                _PracticeUserDb.SaveChanges();
                result = "Saved";
            }
            catch (Exception e) { }

            finally { }
            return result;
        }
        #endregion



        #region UpdateUserDetails
      
        public string UpdateUserDetails(UserDetails userDetails)
        {
            try
            {
                _PracticeUserDb.Entry(userDetails).State = EntityState.Modified;
                _PracticeUserDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return "Updated";
        }
        #endregion



        #region GetUserByEmail
       
        public UserDetails GetUserbyEmail(string EmailId)
        {
            UserDetails user = null;
            try
            {
                user = _PracticeUserDb.UserDetails.FirstOrDefault(q => q.EmailId == EmailId);

            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
        #endregion
    }
}
