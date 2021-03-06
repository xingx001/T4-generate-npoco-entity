using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_PolicyType.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(PolicyTypeMetadata))]
	[PrimaryKey("PolicyTypeID")]
	[TableName("[dbo].[T_PolicyType]")]
    public class T_PolicyType 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class PolicyTypeMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PolicyTypeID")]
			public int Id { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("PolicyTypeName")]
			public string PolicyTypeName { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Rank")]
			public int Rank { get; set; }

    }
  }      
}
