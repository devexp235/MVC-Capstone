﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace User_Login.Models
{
    public class LoginUser
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(20, ErrorMessage = "The {0} must be {2} - {1} characters long", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "E-Mail Address")]
        public string Email { get; set; }

        [Display(Name = "Remember me on this computer")]
        public bool RememberMe { get; set; }

        public bool IsValid(string email, string password)
        {
            //using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\wesley\documents\visual studio 2013\Projects\User Login\User Login\App_Data\Database1.mdf';Integrated Security=True"))
            // using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\Login.mdf';Integrated Security=True"))
            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='|DataDirectory|\Job_Candidate_Application.mdf';Integrated Security=True"))
            {
                string _sql = @"SELECT [Email_Id] FROM [Tbl_Users] WHERE [Email_Id] = @u AND [Password] = @p";
                //    string _sql = @"SELECT [EmailId] 
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.NVarChar)).Value = email;
                cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.NVarChar)).Value = Helpers.SHA1.Encode(password);
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
    }
}