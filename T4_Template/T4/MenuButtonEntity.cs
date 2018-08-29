using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace T4_Template.T4
{	
   [Table("MenuButton")]
   public partial class MenuButtonEntity
    {
		/// <summary>
        /// 
        /// </summary>		
		public Guid Id { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public Guid? MenuId { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Name { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string ClickEvent { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public bool? Enable { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public int? Sort { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public string Icon { get; set; }
		/// <summary>
        /// 
        /// </summary>		
		public int? IsChecked { get; set; }
		 
    }

    [NotMapped]
    public partial class MenuButtonEntityExt:MenuButtonEntity
    { 

    }
}
