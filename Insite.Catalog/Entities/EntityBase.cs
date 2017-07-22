namespace Insite.Catalog.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public abstract class EntityBase
	{
		[Key]
		public virtual Guid Id { get; set; }

		/// <summary>Gets or sets the created on.</summary>
		public virtual DateTimeOffset CreatedOn { get; set; }

		/// <summary>Gets or sets the created by.</summary>
		public virtual string CreatedBy { get; set; }

		/// <summary>Gets or sets the modified on.</summary>
		public virtual DateTimeOffset ModifiedOn { get; set; }

		/// <summary>Gets or sets the modified by.</summary>
		public virtual string ModifiedBy { get; set; }
	}
}
