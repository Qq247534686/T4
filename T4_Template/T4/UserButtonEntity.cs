using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("UserButton")]
   public partial class UserButtonEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid ButtonId { get; set; }
		 
    }

    [NotMapped]
    public partial class UserButtonEntityExt:UserButtonEntity
    { 

    }
}
