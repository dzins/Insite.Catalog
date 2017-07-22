namespace Insite.Catalog.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Product // : EntityBase , IArchivable<Product>
	{
		public virtual int Id { get; set; }

		public virtual string ErpNumber { get; set; }

		public virtual string ShortDescription { get; set; }

		/*
		/// <summary>Gets or sets the activate on.</summary>
		public virtual DateTimeOffset ActivateOn { get; set; } // = DateTimeProvider.Current.Now;

		/// <summary>Gets or sets a value indicating whether allow any gift card amount.</summary>
		public virtual bool AllowAnyGiftCardAmount { get; set; }

		/// <summary>Gets or sets the attribute values.</summary>
		// public virtual ICollection<AttributeValue> AttributeValues { get; set; } = new HashSet<AttributeValue>();

		/// <summary>Gets or sets the basic list price.</summary>
		public virtual decimal BasicListPrice { get; set; }

		/// <summary>Gets or sets the basic sale end date.</summary>
		public virtual DateTimeOffset? BasicSaleEndDate { get; set; }

		/// <summary>Gets or sets the basic sale price.</summary>
		public virtual decimal BasicSalePrice { get; set; }

		/// <summary>Gets or sets the basic sale start date.</summary>
		public virtual DateTimeOffset? BasicSaleStartDate { get; set; }

		/// <summary>Gets or sets the category products.</summary>
		// public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();

		/// <summary>Gets or sets the product kit sections.</summary>
		// public virtual ICollection<ProductKitSection> ProductKitSections { get; set; } = new HashSet<ProductKitSection>();

		/// <summary>Gets or sets the configuration id.</summary>
		public virtual Guid? ConfigurationObjectId { get; set; }

		/// <summary>Gets or sets the configuration object/entity.</summary>
		// public virtual Configuration ConfigurationObject { get; set; }

		/// <summary>Gets or sets the content manager id.</summary>
		public virtual Guid? ContentManagerId { get; set; }

		/// <summary>Gets or sets custom availability message.</summary>
		// [AllowTranslation]
		public virtual string CustomAvailabilityMessage { get; set; } = string.Empty;

		/// <summary>Gets or sets the deactivate on.</summary>
		public virtual DateTimeOffset? DeactivateOn { get; set; }

		/// <summary>Gets or sets the dealers.</summary>
		// public virtual ICollection<Dealer> Dealers { get; set; } = new HashSet<Dealer>();

		/// <summary>Gets or sets a value indicating whether display price per piece.</summary>
		public virtual bool DisplayPricePerPiece { get; set; }

		/// <summary>Gets or sets the documents.</summary>
		// public virtual ICollection<Document> Documents { get; set; } = new HashSet<Document>();

		/// <summary>Gets or sets the erp description.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(2048)]
		public virtual string ErpDescription { get; set; } = string.Empty;

		/// <summary>Gets or sets a value indicating whether erp managed.</summary>
		public virtual bool ErpManaged { get; set; }

		/// <summary>Gets or sets the erp number.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		// [NaturalKeyField]
		public virtual string ErpNumber { get; set; } = string.Empty;

		/// <summary>Gets or sets the handling amount override.</summary>
		public virtual decimal? HandlingAmountOverride { get; set; }

		/// <summary>Gets or sets a value indicating whether has msds.</summary>
		public virtual bool HasMsds { get; set; }

		/// <summary>This field indicates the search index status for this Product (valid values are <see cref="IndexStatusType"/> enum). </summary>
		public virtual int IndexStatus { get; set; } = (int)IndexStatusType.Indexed;

		/// <summary>Gets or sets a value indicating whether is configured.</summary>
		public virtual bool IsConfigured { get; set; }

		/// <summary>Gets or sets a value indicating whether is discontinued.</summary>
		public virtual bool IsDiscontinued { get; set; }

		/// <summary>Gets or sets a value indicating whether is fixed configuration.</summary>
		public virtual bool IsFixedConfiguration { get; set; }

		/// <summary>Gets or sets a value indicating whether is gift card.</summary>
		public virtual bool IsGiftCard { get; set; }

		/// <summary>Gets or sets a value indicating whether is hazardous good.</summary>
		public virtual bool IsHazardousGood { get; set; }

		/// <summary>Gets or sets a value indicating whether is special order.</summary>
		public virtual bool IsSpecialOrder { get; set; }

		/// <summary>Gets or sets a value indicating whether is sponsored (featured in product list).</summary>
		public virtual bool IsSponsored { get; set; }

		/// <summary>Gets or sets a value indicating whether is subscription.</summary>
		public virtual bool IsSubscription { get; set; }

		/// <summary>Gets or sets the low stock level.</summary>
		public virtual decimal LowStockLevel { get; set; }

		/// <summary>Gets or sets the manufacturer item.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(100)]
		public virtual string ManufacturerItem { get; set; } = string.Empty;

		/// <summary>Gets or sets the meta description.</summary>
		[Required(AllowEmptyStrings = true)]
		// [AllowTranslation]
		public virtual string MetaDescription { get; set; } = string.Empty;

		/// <summary>Gets or sets the meta keywords.</summary>
		[Required(AllowEmptyStrings = true)]
		// [AllowTranslation]
		public virtual string MetaKeywords { get; set; } = string.Empty;

		/// <summary>Gets or sets the model number.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string ModelNumber { get; set; } = string.Empty;

		/// <summary>Gets or sets the multiple sale qty.</summary>
		public virtual int MultipleSaleQty { get; set; }

		/// <summary>Gets or sets the name.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(255)]
		public virtual string Name { get; set; } = string.Empty;

		/// <summary>Gets or sets the pack description.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(255)]
		public virtual string PackDescription { get; set; } = string.Empty;

		/// <summary>Gets or sets the page title.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(1024)]
		// [AllowTranslation]
		public virtual string PageTitle { get; set; } = string.Empty;

		/// <summary>Gets or sets the price basis.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string PriceBasis { get; set; } = string.Empty;

		/// <summary>Gets or sets the price code.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string PriceCode { get; set; } = string.Empty;

		/// <summary>Gets or sets the product code.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string ProductCode { get; set; } = string.Empty;

		/// <summary>Gets or sets the product related products.</summary>
		// public virtual ICollection<ProductRelatedProduct> ProductRelatedProducts { get; set; } = new HashSet<ProductRelatedProduct>();

		/// <summary>Gets or sets the product related products.</summary>
		// public virtual ICollection<ProductRelatedProduct> ParentRelatedProducts { get; set; } = new HashSet<ProductRelatedProduct>();

		/// <summary>Gets or sets the product related products.</summary>
		// public virtual ICollection<CategoryRelatedProduct> ParentRelatedCategories { get; set; } = new HashSet<CategoryRelatedProduct>();

		/// <summary>Gets or sets the product warehouses.</summary>
		// public virtual ICollection<ProductWarehouse> ProductWarehouses { get; set; } = new HashSet<ProductWarehouse>();

		/// <summary>Gets or sets the product images.</summary>
		// public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();

		/// <summary>Gets the primary image.</summary>
		// [NotMapped]
		// public virtual ProductImage PrimaryImage => this.ProductImages.OrderBy(i => i.SortOrder).FirstOrDefault();

		/// <summary>Gets or sets the qty per shipping package.</summary>
		public virtual int QtyPerShippingPackage { get; set; }

		/// <summary>Gets or sets the quote option.</summary>
		public virtual bool IsQuoteRequired { get; set; }

		/// <summary>Gets or sets the product 2.</summary>
		public virtual Product ReplacementProduct { get; set; }

		/// <summary>Gets or sets the replacement product id.</summary>
		public virtual Guid? ReplacementProductId { get; set; }

		/// <summary>Gets or sets the rounding rule.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string RoundingRule { get; set; } = string.Empty;

		/// <summary>Gets or sets the sale price label.</summary>
		[StringLength(255)]
		public virtual string SalePriceLabel { get; set; } = string.Empty;

		public virtual bool ShipSeparately { get; set; }

		/// <summary>Gets or sets the shipping amount override.</summary>
		public virtual decimal? ShippingAmountOverride { get; set; }

		/// <summary>Gets or sets the shipping classification.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(100)]
		public virtual string ShippingClassification { get; set; } = string.Empty;

		/// <summary>Gets or sets the shipping height.</summary>
		public virtual decimal ShippingHeight { get; set; }

		/// <summary>Gets or sets the shipping length.</summary>
		public virtual decimal ShippingLength { get; set; }

		/// <summary>Gets or sets the shipping weight.</summary>
		public virtual decimal ShippingWeight { get; set; }

		/// <summary>Gets or sets the shipping width.</summary>
		public virtual decimal ShippingWidth { get; set; }

		/// <summary>Gets or sets the ship via.</summary>
		// public virtual ShipVia SubscriptionShipVia { get; set; }

		/// <summary>Gets or sets the short description.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(2048)]
		// [AllowTranslation]
		public virtual string ShortDescription { get; set; } = string.Empty;

		/// <summary>Gets or sets the sku.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(100)]
		public virtual string Sku { get; set; } = string.Empty;

		/// <summary>Gets or sets the sort order.</summary>
		public virtual int SortOrder { get; set; }

		/// <summary>Gets or sets the index time search boost value (-100 to +100)</summary>
		public virtual int SearchBoost { get; set; }

		/// <summary>Gets or sets the specifications.</summary>
		// public virtual ICollection<Specification> Specifications { get; set; } = new HashSet<Specification>();

		/// <summary>Gets or sets the style class.</summary>
		// public virtual StyleClass StyleClass { get; set; }

		/// <summary>Gets or sets the style class id.</summary>
		public virtual Guid? StyleClassId { get; set; }

		/// <summary>Gets or sets the style parent.</summary>
		public virtual Product StyleParent { get; set; }

		/// <summary>Gets or sets the style parent id.</summary>
		public virtual Guid? StyleParentId { get; set; }

		/// <summary>Gets or sets the style children.</summary>
		[InverseProperty("StyleParent")]
		public ICollection<Product> StyleChildren { get; set; } = new HashSet<Product>();

		/// <summary>Gets or sets the style trait values.</summary>
		// public virtual ICollection<StyleTraitValue> StyleTraitValues { get; set; } = new HashSet<StyleTraitValue>();

		/// <summary>Gets or sets a value indicating whether subscription add to initial order.</summary>
		public virtual bool SubscriptionAddToInitialOrder { get; set; }

		/// <summary>Gets or sets a value indicating whether subscription all months.</summary>
		public virtual bool SubscriptionAllMonths { get; set; }

		/// <summary>Gets or sets a value indicating whether subscription april.</summary>
		public virtual bool SubscriptionApril { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription august.</summary>
		public virtual bool SubscriptionAugust { get; set; } = true;

		/// <summary>Gets or sets the subscription cycle period.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string SubscriptionCyclePeriod { get; set; } = string.Empty;

		/// <summary>Gets or sets a value indicating whether subscription december.</summary>
		public virtual bool SubscriptionDecember { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription february.</summary>
		public virtual bool SubscriptionFebruary { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription fixed price.</summary>
		public virtual bool SubscriptionFixedPrice { get; set; }

		/// <summary>Gets or sets a value indicating whether subscription january.</summary>
		public virtual bool SubscriptionJanuary { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription july.</summary>
		public virtual bool SubscriptionJuly { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription june.</summary>
		public virtual bool SubscriptionJune { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription march.</summary>
		public virtual bool SubscriptionMarch { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription may.</summary>
		public virtual bool SubscriptionMay { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription november.</summary>
		public virtual bool SubscriptionNovember { get; set; } = true;

		/// <summary>Gets or sets a value indicating whether subscription october.</summary>
		public virtual bool SubscriptionOctober { get; set; } = true;

		/// <summary>Gets or sets the subscription periods per cycle.</summary>
		public virtual int SubscriptionPeriodsPerCycle { get; set; }

		/// <summary>Gets or sets the subscription products.</summary>
		// public virtual ICollection<SubscriptionProduct> SubscriptionProducts { get; set; } = new HashSet<SubscriptionProduct>();

		/// <summary>Gets or sets a value indicating whether subscription september.</summary>
		public virtual bool SubscriptionSeptember { get; set; } = true;

		/// <summary>Gets or sets the subscription ship via id.</summary>
		public virtual Guid? SubscriptionShipViaId { get; set; }

		/// <summary>Gets or sets the subscription total cycles.</summary>
		public virtual int SubscriptionTotalCycles { get; set; }

		/// <summary>Gets or sets the tax category.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string TaxCategory { get; set; } = string.Empty;

		/// <summary>Gets or sets the tax code 1.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string TaxCode1 { get; set; } = string.Empty;

		/// <summary>Gets or sets the tax code 2.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string TaxCode2 { get; set; } = string.Empty;

		/// <summary>Gets or sets the tax exemptions.</summary>
		// public virtual ICollection<TaxExemption> TaxExemptions { get; set; } = new HashSet<TaxExemption>();

		/// <summary>Gets or sets a value indicating whether track inventory.</summary>
		public virtual bool TrackInventory { get; set; }

		/// <summary>Gets or sets the unit cost.</summary>
		public virtual decimal UnitCost { get; set; }

		/// <summary>Gets or sets the unit of measure.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string UnitOfMeasure { get; set; } = string.Empty;

		/// <summary>Gets or sets the unit of measure description.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(100)]
		public virtual string UnitOfMeasureDescription { get; set; } = string.Empty;

		/// <summary>Gets or sets the unspsc.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(100)]
		public virtual string Unspsc { get; set; } = string.Empty;

		/// <summary>Gets or sets the upc code.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(50)]
		public virtual string UpcCode { get; set; } = string.Empty;

		/// <summary>Gets or sets the url segment.</summary>
		[Required(AllowEmptyStrings = true)]
		[StringLength(255)]
		public virtual string UrlSegment { get; set; } = string.Empty;

		/// <summary>Gets or sets the vendor.</summary>
		// public virtual Vendor Vendor { get; set; }

		/// <summary>Gets or sets the vendor id.</summary>
		public virtual Guid? VendorId { get; set; }

		/// <summary>Gets or sets the product units of measure</summary>
		// public virtual ICollection<ProductUnitOfMeasure> ProductUnitOfMeasures { get; set; } = new HashSet<ProductUnitOfMeasure>();

		/// <summary>Gets or sets the wish list products.</summary>
		// public virtual ICollection<WishListProduct> WishListProducts { get; set; } = new HashSet<WishListProduct>();

		/// <summary>Gets or sets the content manager.</summary>
		// public virtual ContentManager ContentManager { get; set; }

		/// <summary>Gets or sets the customer product sets.</summary>
		// public virtual ICollection<CustomerProductSet> CustomerProductSets { get; set; } = new HashSet<CustomerProductSet>();

		/// <summary>Gets or sets the restriction groups.</summary>
		// public virtual ICollection<RestrictionGroup> RestrictionGroups { get; set; } = new HashSet<RestrictionGroup>();

		/// <summary>Gets or sets the restriction group exceptions.</summary>
		// public virtual ICollection<RestrictionGroup> RestrictionGroupExceptions { get; set; } = new HashSet<RestrictionGroup>();

		/// <summary>Gets or sets the restriction group additions.</summary>
		// public virtual ICollection<RestrictionGroup> RestrictionGroupAdditions { get; set; } = new HashSet<RestrictionGroup>();

		/// <summary>Gets or sets the default visibility.</summary>
		[StringLength(50)]
		[Required(AllowEmptyStrings = true)]
		public virtual string DefaultVisibility { get; set; } = ProductDefaultVisibility.Show.ToString();

		/// <summary>Gets or sets the websites.</summary>
		// public virtual ICollection<Website> Websites { get; set; } = new HashSet<Website>();

		/// <summary>The archive.</summary>
		public void Archive()
		{
			this.DeactivateOn = DateTimeProvider.Current.Now;
		}

		/// <summary>The archived.</summary>
		/// <returns>The <see cref="Expression"/>.</returns>
		public Expression<Func<Product, bool>> Archived()
		{
			var current = DateTimeProvider.Current.Now;
			return o => o.DeactivateOn != null && current > o.DeactivateOn.Value;
		}

		/// <summary>The restore.</summary>
		public void Restore()
		{
			this.DeactivateOn = null;
		}

		/// <summary>enum used for the <see cref="Product"/> IndexStatus field</summary>
		public enum IndexStatusType
		{
			Indexed = 0,
			NeedsIndexing = 1,
			NeverIndex = 2
		}

		public enum ProductDefaultVisibility
		{
			Show,
			Hide
		}
		*/
	}
}
