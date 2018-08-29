using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("Menu")]
   public partial class MenuEntity
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
		public string Url { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Icon { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? ParentId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public bool? Enable { get; set; }
		 
    }

    [NotMapped]
    public partial class MenuEntityExt:MenuEntity
    { 

    }
}
