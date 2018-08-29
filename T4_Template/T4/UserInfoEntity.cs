using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("UserInfo")]
   public partial class UserInfoEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Name { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Password { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Email { get; set; }
		/// <summary>
        /// 性别
        /// </summary>		
		public int? Gender { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public int? LoginErrorCount { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public bool? IsAdmin { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public DateTime? CreateDate { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public DateTime? UpdateDate { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? CreateUserId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? UpdateUserId { get; set; }
		 
    }

    [NotMapped]
    public partial class UserInfoEntityExt:UserInfoEntity
    { 

    }
}
