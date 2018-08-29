using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("UserLoginLog")]
   public partial class UserLoginLogEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid UserId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string LoginIp { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public DateTime LastLoginTime { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public int? State { get; set; }
		 
    }

    [NotMapped]
    public partial class UserLoginLogEntityExt:UserLoginLogEntity
    { 

    }
}
