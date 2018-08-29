using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("UserMenu")]
   public partial class UserMenuEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? UserId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? MenuId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? UserButtonId { get; set; }
		 
    }

    [NotMapped]
    public partial class UserMenuEntityExt:UserMenuEntity
    { 

    }
}
