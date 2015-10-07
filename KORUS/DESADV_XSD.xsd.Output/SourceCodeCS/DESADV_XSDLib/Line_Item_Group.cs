using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2015 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  : by Liquid XML Data Binder 13.0.6.5773
 * Using Schema: C:\BTS\XSD\KORUS\DESADV_XSD.xsd
 **********************************************************************************************/

namespace DESADV_XSDLib
{
	/// <summary>
	/// This class represents the Element Line-Item_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Line-Item_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Line_Item_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Line_Item_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Line_Item_Group()
		{
			_elementName = "Line-Item_Group";
			Init();
		}
		public Line_Item_Group(string elementName)
		{
			_elementName = elementName;
			Init();
		}
		#endregion

		#region Initialization methods for the class
		/// <summary>
		/// Initializes the class
		/// </summary>
		/// <remarks>
		/// This creates all the mandatory fields (populated with the default data) 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd.
		/// </remarks>
		protected override void Init()
		{
			DESADV_XSDLib.Registration.iRegistrationIndicator = 0; // causes registration to take place
			m_LineNumber = 0F;
			m_IsValidLineNumber = false;
			m_OrderLineNumber = 0F;
			m_IsValidOrderLineNumber = false;
			m_EAN = "";
			m_IsValidEAN = false;
			m_BuyerItemCode = "";
			m_IsValidBuyerItemCode = false;
			m_SupplierItemCode = "";
			m_IsValidSupplierItemCode = false;
			m_ManufacturerItemCode = "";
			m_IsValidManufacturerItemCode = false;
			m_PackageEAN = "";
			m_IsValidPackageEAN = false;
			m_DiscrepancyNatureCode = "";
			m_IsValidDiscrepancyNatureCode = false;
			m_DespatchedQuantity = 0F;
			m_IsValidDespatchedQuantity = false;
			m_OrderedQuantity = 0F;
			m_IsValidOrderedQuantity = false;
			m_MinimumOrderQuantity = 0F;
			m_IsValidMinimumOrderQuantity = false;
			m_InvoicedQuantity = 0F;
			m_IsValidInvoicedQuantity = false;
			m_DespatchedPackageQuantity = 0F;
			m_IsValidDespatchedPackageQuantity = false;
			m_OrderedPackageQuantity = 0F;
			m_IsValidOrderedPackageQuantity = false;
			m_DespatchedUnitPacksize = 0F;
			m_IsValidDespatchedUnitPacksize = false;
			m_OrderedUnitPacksize = 0F;
			m_IsValidOrderedUnitPacksize = false;
			m_ConsumerUnitPacksize = 0F;
			m_IsValidConsumerUnitPacksize = false;
			m_UnitOfMeasure = "";
			m_IsValidUnitOfMeasure = false;
			m_ItemDescription = "";
			m_IsValidItemDescription = false;
			m_AdditionalItemDescription = "";
			m_IsValidAdditionalItemDescription = false;
			m_UnitNetPrice = 0F;
			m_IsValidUnitNetPrice = false;
			m_UnitGrossPrice = "";
			m_IsValidUnitGrossPrice = false;
			m_TaxAmount = 0F;
			m_IsValidTaxAmount = false;
			m_NetAmount = 0F;
			m_IsValidNetAmount = false;
			m_GrossAmount = 0F;
			m_IsValidGrossAmount = false;
			m_OriginalAmount = 0F;
			m_IsValidOriginalAmount = false;
			m_TaxRate = 0F;
			m_IsValidTaxRate = false;
			m_TaxCategoryCode = DESADV_XSDLib.Enumerations.TaxCategoryCode.S;
			m_IsValidTaxCategoryCode = false;
			m_BatchNumber = "";
			m_IsValidBatchNumber = false;
			m_ExpiryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidExpiryDate = false;
			m_BestBeforeDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBestBeforeDate = false;
			m_ProductionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidProductionDate = false;
			m_CountryOfOriginCode = "";
			m_IsValidCountryOfOriginCode = false;
			m_CustomsDeclarationNumber = "";
			m_IsValidCustomsDeclarationNumber = false;
			m_ContractNumber = "";
			m_IsValidContractNumber = false;
			m_CertificateNumber = "";
			m_IsValidCertificateNumber = false;
			m_SupplierLicenceNumber = "";
			m_IsValidSupplierLicenceNumber = false;
			m_SupplierLicenceValidityPeriod = "";
			m_IsValidSupplierLicenceValidityPeriod = false;
			m_SupplierLicenceIssuer = "";
			m_IsValidSupplierLicenceIssuer = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_LineNumber = 0F;
			m_IsValidLineNumber = false;
			m_OrderLineNumber = 0F;
			m_IsValidOrderLineNumber = false;
			m_EAN = "";
			m_IsValidEAN = false;
			m_BuyerItemCode = "";
			m_IsValidBuyerItemCode = false;
			m_SupplierItemCode = "";
			m_IsValidSupplierItemCode = false;
			m_ManufacturerItemCode = "";
			m_IsValidManufacturerItemCode = false;
			m_PackageEAN = "";
			m_IsValidPackageEAN = false;
			m_DiscrepancyNatureCode = "";
			m_IsValidDiscrepancyNatureCode = false;
			m_DespatchedQuantity = 0F;
			m_IsValidDespatchedQuantity = false;
			m_OrderedQuantity = 0F;
			m_IsValidOrderedQuantity = false;
			m_MinimumOrderQuantity = 0F;
			m_IsValidMinimumOrderQuantity = false;
			m_InvoicedQuantity = 0F;
			m_IsValidInvoicedQuantity = false;
			m_DespatchedPackageQuantity = 0F;
			m_IsValidDespatchedPackageQuantity = false;
			m_OrderedPackageQuantity = 0F;
			m_IsValidOrderedPackageQuantity = false;
			m_DespatchedUnitPacksize = 0F;
			m_IsValidDespatchedUnitPacksize = false;
			m_OrderedUnitPacksize = 0F;
			m_IsValidOrderedUnitPacksize = false;
			m_ConsumerUnitPacksize = 0F;
			m_IsValidConsumerUnitPacksize = false;
			m_UnitOfMeasure = "";
			m_IsValidUnitOfMeasure = false;
			m_ItemDescription = "";
			m_IsValidItemDescription = false;
			m_AdditionalItemDescription = "";
			m_IsValidAdditionalItemDescription = false;
			m_UnitNetPrice = 0F;
			m_IsValidUnitNetPrice = false;
			m_UnitGrossPrice = "";
			m_IsValidUnitGrossPrice = false;
			m_TaxAmount = 0F;
			m_IsValidTaxAmount = false;
			m_NetAmount = 0F;
			m_IsValidNetAmount = false;
			m_GrossAmount = 0F;
			m_IsValidGrossAmount = false;
			m_OriginalAmount = 0F;
			m_IsValidOriginalAmount = false;
			m_TaxRate = 0F;
			m_IsValidTaxRate = false;
			m_TaxCategoryCode = DESADV_XSDLib.Enumerations.TaxCategoryCode.S;
			m_IsValidTaxCategoryCode = false;
			m_BatchNumber = "";
			m_IsValidBatchNumber = false;
			m_ExpiryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidExpiryDate = false;
			m_BestBeforeDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBestBeforeDate = false;
			m_ProductionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidProductionDate = false;
			m_CountryOfOriginCode = "";
			m_IsValidCountryOfOriginCode = false;
			m_CustomsDeclarationNumber = "";
			m_IsValidCustomsDeclarationNumber = false;
			m_ContractNumber = "";
			m_IsValidContractNumber = false;
			m_CertificateNumber = "";
			m_IsValidCertificateNumber = false;
			m_SupplierLicenceNumber = "";
			m_IsValidSupplierLicenceNumber = false;
			m_SupplierLicenceValidityPeriod = "";
			m_IsValidSupplierLicenceValidityPeriod = false;
			m_SupplierLicenceIssuer = "";
			m_IsValidSupplierLicenceIssuer = false;
			_validElement = selectedElement;
		}
		#endregion

		#region ICloneable Interface
		/// <summary>
		/// Allows the class to be copied
		/// </summary>
		/// <remarks>
		/// Performs a 'deep copy' of all the data in the class (and its children)
		/// </remarks>
		public override object Clone()
		{
			DESADV_XSDLib.Line_Item_Group newObject = new DESADV_XSDLib.Line_Item_Group(_elementName);
			newObject.m_LineNumber = m_LineNumber;
			newObject.m_IsValidLineNumber = m_IsValidLineNumber;
			newObject.m_OrderLineNumber = m_OrderLineNumber;
			newObject.m_IsValidOrderLineNumber = m_IsValidOrderLineNumber;
			newObject.m_EAN = m_EAN;
			newObject.m_IsValidEAN = m_IsValidEAN;
			newObject.m_BuyerItemCode = m_BuyerItemCode;
			newObject.m_IsValidBuyerItemCode = m_IsValidBuyerItemCode;
			newObject.m_SupplierItemCode = m_SupplierItemCode;
			newObject.m_IsValidSupplierItemCode = m_IsValidSupplierItemCode;
			newObject.m_ManufacturerItemCode = m_ManufacturerItemCode;
			newObject.m_IsValidManufacturerItemCode = m_IsValidManufacturerItemCode;
			newObject.m_PackageEAN = m_PackageEAN;
			newObject.m_IsValidPackageEAN = m_IsValidPackageEAN;
			newObject.m_DiscrepancyNatureCode = m_DiscrepancyNatureCode;
			newObject.m_IsValidDiscrepancyNatureCode = m_IsValidDiscrepancyNatureCode;
			newObject.m_DespatchedQuantity = m_DespatchedQuantity;
			newObject.m_IsValidDespatchedQuantity = m_IsValidDespatchedQuantity;
			newObject.m_OrderedQuantity = m_OrderedQuantity;
			newObject.m_IsValidOrderedQuantity = m_IsValidOrderedQuantity;
			newObject.m_MinimumOrderQuantity = m_MinimumOrderQuantity;
			newObject.m_IsValidMinimumOrderQuantity = m_IsValidMinimumOrderQuantity;
			newObject.m_InvoicedQuantity = m_InvoicedQuantity;
			newObject.m_IsValidInvoicedQuantity = m_IsValidInvoicedQuantity;
			newObject.m_DespatchedPackageQuantity = m_DespatchedPackageQuantity;
			newObject.m_IsValidDespatchedPackageQuantity = m_IsValidDespatchedPackageQuantity;
			newObject.m_OrderedPackageQuantity = m_OrderedPackageQuantity;
			newObject.m_IsValidOrderedPackageQuantity = m_IsValidOrderedPackageQuantity;
			newObject.m_DespatchedUnitPacksize = m_DespatchedUnitPacksize;
			newObject.m_IsValidDespatchedUnitPacksize = m_IsValidDespatchedUnitPacksize;
			newObject.m_OrderedUnitPacksize = m_OrderedUnitPacksize;
			newObject.m_IsValidOrderedUnitPacksize = m_IsValidOrderedUnitPacksize;
			newObject.m_ConsumerUnitPacksize = m_ConsumerUnitPacksize;
			newObject.m_IsValidConsumerUnitPacksize = m_IsValidConsumerUnitPacksize;
			newObject.m_UnitOfMeasure = m_UnitOfMeasure;
			newObject.m_IsValidUnitOfMeasure = m_IsValidUnitOfMeasure;
			newObject.m_ItemDescription = m_ItemDescription;
			newObject.m_IsValidItemDescription = m_IsValidItemDescription;
			newObject.m_AdditionalItemDescription = m_AdditionalItemDescription;
			newObject.m_IsValidAdditionalItemDescription = m_IsValidAdditionalItemDescription;
			newObject.m_UnitNetPrice = m_UnitNetPrice;
			newObject.m_IsValidUnitNetPrice = m_IsValidUnitNetPrice;
			newObject.m_UnitGrossPrice = m_UnitGrossPrice;
			newObject.m_IsValidUnitGrossPrice = m_IsValidUnitGrossPrice;
			newObject.m_TaxAmount = m_TaxAmount;
			newObject.m_IsValidTaxAmount = m_IsValidTaxAmount;
			newObject.m_NetAmount = m_NetAmount;
			newObject.m_IsValidNetAmount = m_IsValidNetAmount;
			newObject.m_GrossAmount = m_GrossAmount;
			newObject.m_IsValidGrossAmount = m_IsValidGrossAmount;
			newObject.m_OriginalAmount = m_OriginalAmount;
			newObject.m_IsValidOriginalAmount = m_IsValidOriginalAmount;
			newObject.m_TaxRate = m_TaxRate;
			newObject.m_IsValidTaxRate = m_IsValidTaxRate;
			newObject.m_TaxCategoryCode = m_TaxCategoryCode;
			newObject.m_IsValidTaxCategoryCode = m_IsValidTaxCategoryCode;
			newObject.m_BatchNumber = m_BatchNumber;
			newObject.m_IsValidBatchNumber = m_IsValidBatchNumber;
			newObject.m_ExpiryDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_ExpiryDate.Clone();
			newObject.m_IsValidExpiryDate = m_IsValidExpiryDate;
			newObject.m_BestBeforeDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_BestBeforeDate.Clone();
			newObject.m_IsValidBestBeforeDate = m_IsValidBestBeforeDate;
			newObject.m_ProductionDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_ProductionDate.Clone();
			newObject.m_IsValidProductionDate = m_IsValidProductionDate;
			newObject.m_CountryOfOriginCode = m_CountryOfOriginCode;
			newObject.m_IsValidCountryOfOriginCode = m_IsValidCountryOfOriginCode;
			newObject.m_CustomsDeclarationNumber = m_CustomsDeclarationNumber;
			newObject.m_IsValidCustomsDeclarationNumber = m_IsValidCustomsDeclarationNumber;
			newObject.m_ContractNumber = m_ContractNumber;
			newObject.m_IsValidContractNumber = m_IsValidContractNumber;
			newObject.m_CertificateNumber = m_CertificateNumber;
			newObject.m_IsValidCertificateNumber = m_IsValidCertificateNumber;
			newObject.m_SupplierLicenceNumber = m_SupplierLicenceNumber;
			newObject.m_IsValidSupplierLicenceNumber = m_IsValidSupplierLicenceNumber;
			newObject.m_SupplierLicenceValidityPeriod = m_SupplierLicenceValidityPeriod;
			newObject.m_IsValidSupplierLicenceValidityPeriod = m_IsValidSupplierLicenceValidityPeriod;
			newObject.m_SupplierLicenceIssuer = m_SupplierLicenceIssuer;
			newObject.m_IsValidSupplierLicenceIssuer = m_IsValidSupplierLicenceIssuer;

			newObject._validElement = _validElement;
// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override string TargetNamespace
		{
			get { return ""; }
		}

		#region Attribute - LineNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("LineNumber", "", "IsValidLineNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "([0-9]|\\+|\\-|E|e|\\.){0,6}", "-1", "-1", "", "", "", "", "-1")]
		public float LineNumber
		{
			get 
			{ 
				if (m_IsValidLineNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property LineNumber is not valid. Set LineNumberValid = true");
				return m_LineNumber;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("LineNumber"); // remove selection
				m_IsValidLineNumber = true;
				m_LineNumber = value;
			}
		}
		/// <summary>
		/// Indicates if LineNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for LineNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get LineNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidLineNumber
		{
			get
			{
				return m_IsValidLineNumber;
			}
			set 
			{ 
				if (value != m_IsValidLineNumber)
				{
					LineNumber = 0F;
					m_IsValidLineNumber = value;
				}
			}
		}
		protected bool m_IsValidLineNumber;
		protected float m_LineNumber;
		#endregion

		#region Attribute - OrderLineNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("OrderLineNumber", "", "IsValidOrderLineNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float OrderLineNumber
		{
			get 
			{ 
				if (m_IsValidOrderLineNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property OrderLineNumber is not valid. Set OrderLineNumberValid = true");
				return m_OrderLineNumber;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("OrderLineNumber"); // remove selection
				m_IsValidOrderLineNumber = true;
				m_OrderLineNumber = value;
			}
		}
		/// <summary>
		/// Indicates if OrderLineNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for OrderLineNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get OrderLineNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidOrderLineNumber
		{
			get
			{
				return m_IsValidOrderLineNumber;
			}
			set 
			{ 
				if (value != m_IsValidOrderLineNumber)
				{
					OrderLineNumber = 0F;
					m_IsValidOrderLineNumber = value;
				}
			}
		}
		protected bool m_IsValidOrderLineNumber;
		protected float m_OrderLineNumber;
		#endregion

		#region Attribute - EAN
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("EAN", "", "IsValidEAN", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "14", "", "", "", "", "-1")]
		public string EAN
		{
			get 
			{ 
				if (m_IsValidEAN == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property EAN is not valid. Set EANValid = true");
				return m_EAN;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("EAN"); // remove selection
				m_IsValidEAN = true;
				m_EAN = value;
			}
		}
		/// <summary>
		/// Indicates if EAN contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for EAN is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get EAN
		/// will raise an exception.
		/// </remarks>
		public bool IsValidEAN
		{
			get
			{
				return m_IsValidEAN;
			}
			set 
			{ 
				if (value != m_IsValidEAN)
				{
					EAN = "";
					m_IsValidEAN = value;
				}
			}
		}
		protected bool m_IsValidEAN;
		protected string m_EAN;
		#endregion

		#region Attribute - BuyerItemCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BuyerItemCode", "", "IsValidBuyerItemCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "40", "", "", "", "", "-1")]
		public string BuyerItemCode
		{
			get 
			{ 
				if (m_IsValidBuyerItemCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BuyerItemCode is not valid. Set BuyerItemCodeValid = true");
				return m_BuyerItemCode;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BuyerItemCode"); // remove selection
				m_IsValidBuyerItemCode = true;
				m_BuyerItemCode = value;
			}
		}
		/// <summary>
		/// Indicates if BuyerItemCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BuyerItemCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get BuyerItemCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBuyerItemCode
		{
			get
			{
				return m_IsValidBuyerItemCode;
			}
			set 
			{ 
				if (value != m_IsValidBuyerItemCode)
				{
					BuyerItemCode = "";
					m_IsValidBuyerItemCode = value;
				}
			}
		}
		protected bool m_IsValidBuyerItemCode;
		protected string m_BuyerItemCode;
		#endregion

		#region Attribute - SupplierItemCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierItemCode", "", "IsValidSupplierItemCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "40", "", "", "", "", "-1")]
		public string SupplierItemCode
		{
			get 
			{ 
				if (m_IsValidSupplierItemCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierItemCode is not valid. Set SupplierItemCodeValid = true");
				return m_SupplierItemCode;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierItemCode"); // remove selection
				m_IsValidSupplierItemCode = true;
				m_SupplierItemCode = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierItemCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierItemCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierItemCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierItemCode
		{
			get
			{
				return m_IsValidSupplierItemCode;
			}
			set 
			{ 
				if (value != m_IsValidSupplierItemCode)
				{
					SupplierItemCode = "";
					m_IsValidSupplierItemCode = value;
				}
			}
		}
		protected bool m_IsValidSupplierItemCode;
		protected string m_SupplierItemCode;
		#endregion

		#region Attribute - ManufacturerItemCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ManufacturerItemCode", "", "IsValidManufacturerItemCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "70", "", "", "", "", "-1")]
		public string ManufacturerItemCode
		{
			get 
			{ 
				if (m_IsValidManufacturerItemCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ManufacturerItemCode is not valid. Set ManufacturerItemCodeValid = true");
				return m_ManufacturerItemCode;  
			}
			set 
			{ 
				CheckElementRestriction(5, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ManufacturerItemCode"); // remove selection
				m_IsValidManufacturerItemCode = true;
				m_ManufacturerItemCode = value;
			}
		}
		/// <summary>
		/// Indicates if ManufacturerItemCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ManufacturerItemCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ManufacturerItemCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidManufacturerItemCode
		{
			get
			{
				return m_IsValidManufacturerItemCode;
			}
			set 
			{ 
				if (value != m_IsValidManufacturerItemCode)
				{
					ManufacturerItemCode = "";
					m_IsValidManufacturerItemCode = value;
				}
			}
		}
		protected bool m_IsValidManufacturerItemCode;
		protected string m_ManufacturerItemCode;
		#endregion

		#region Attribute - PackageEAN
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageEAN", "", "IsValidPackageEAN", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "14", "", "", "", "", "-1")]
		public string PackageEAN
		{
			get 
			{ 
				if (m_IsValidPackageEAN == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageEAN is not valid. Set PackageEANValid = true");
				return m_PackageEAN;  
			}
			set 
			{ 
				CheckElementRestriction(6, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageEAN"); // remove selection
				m_IsValidPackageEAN = true;
				m_PackageEAN = value;
			}
		}
		/// <summary>
		/// Indicates if PackageEAN contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageEAN is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PackageEAN
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageEAN
		{
			get
			{
				return m_IsValidPackageEAN;
			}
			set 
			{ 
				if (value != m_IsValidPackageEAN)
				{
					PackageEAN = "";
					m_IsValidPackageEAN = value;
				}
			}
		}
		protected bool m_IsValidPackageEAN;
		protected string m_PackageEAN;
		#endregion

		#region Attribute - DiscrepancyNatureCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DiscrepancyNatureCode", "", "IsValidDiscrepancyNatureCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string DiscrepancyNatureCode
		{
			get 
			{ 
				if (m_IsValidDiscrepancyNatureCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DiscrepancyNatureCode is not valid. Set DiscrepancyNatureCodeValid = true");
				return m_DiscrepancyNatureCode;  
			}
			set 
			{ 
				CheckElementRestriction(7, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DiscrepancyNatureCode"); // remove selection
				m_IsValidDiscrepancyNatureCode = true;
				m_DiscrepancyNatureCode = value;
			}
		}
		/// <summary>
		/// Indicates if DiscrepancyNatureCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DiscrepancyNatureCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DiscrepancyNatureCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDiscrepancyNatureCode
		{
			get
			{
				return m_IsValidDiscrepancyNatureCode;
			}
			set 
			{ 
				if (value != m_IsValidDiscrepancyNatureCode)
				{
					DiscrepancyNatureCode = "";
					m_IsValidDiscrepancyNatureCode = value;
				}
			}
		}
		protected bool m_IsValidDiscrepancyNatureCode;
		protected string m_DiscrepancyNatureCode;
		#endregion

		#region Attribute - DespatchedQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchedQuantity", "", "IsValidDespatchedQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float DespatchedQuantity
		{
			get 
			{ 
				if (m_IsValidDespatchedQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchedQuantity is not valid. Set DespatchedQuantityValid = true");
				return m_DespatchedQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(8, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchedQuantity"); // remove selection
				m_IsValidDespatchedQuantity = true;
				m_DespatchedQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if DespatchedQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchedQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchedQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchedQuantity
		{
			get
			{
				return m_IsValidDespatchedQuantity;
			}
			set 
			{ 
				if (value != m_IsValidDespatchedQuantity)
				{
					DespatchedQuantity = 0F;
					m_IsValidDespatchedQuantity = value;
				}
			}
		}
		protected bool m_IsValidDespatchedQuantity;
		protected float m_DespatchedQuantity;
		#endregion

		#region Attribute - OrderedQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("OrderedQuantity", "", "IsValidOrderedQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float OrderedQuantity
		{
			get 
			{ 
				if (m_IsValidOrderedQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property OrderedQuantity is not valid. Set OrderedQuantityValid = true");
				return m_OrderedQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(9, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("OrderedQuantity"); // remove selection
				m_IsValidOrderedQuantity = true;
				m_OrderedQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if OrderedQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for OrderedQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get OrderedQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidOrderedQuantity
		{
			get
			{
				return m_IsValidOrderedQuantity;
			}
			set 
			{ 
				if (value != m_IsValidOrderedQuantity)
				{
					OrderedQuantity = 0F;
					m_IsValidOrderedQuantity = value;
				}
			}
		}
		protected bool m_IsValidOrderedQuantity;
		protected float m_OrderedQuantity;
		#endregion

		#region Attribute - MinimumOrderQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("MinimumOrderQuantity", "", "IsValidMinimumOrderQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float MinimumOrderQuantity
		{
			get 
			{ 
				if (m_IsValidMinimumOrderQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property MinimumOrderQuantity is not valid. Set MinimumOrderQuantityValid = true");
				return m_MinimumOrderQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(10, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("MinimumOrderQuantity"); // remove selection
				m_IsValidMinimumOrderQuantity = true;
				m_MinimumOrderQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if MinimumOrderQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for MinimumOrderQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get MinimumOrderQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidMinimumOrderQuantity
		{
			get
			{
				return m_IsValidMinimumOrderQuantity;
			}
			set 
			{ 
				if (value != m_IsValidMinimumOrderQuantity)
				{
					MinimumOrderQuantity = 0F;
					m_IsValidMinimumOrderQuantity = value;
				}
			}
		}
		protected bool m_IsValidMinimumOrderQuantity;
		protected float m_MinimumOrderQuantity;
		#endregion

		#region Attribute - InvoicedQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("InvoicedQuantity", "", "IsValidInvoicedQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float InvoicedQuantity
		{
			get 
			{ 
				if (m_IsValidInvoicedQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property InvoicedQuantity is not valid. Set InvoicedQuantityValid = true");
				return m_InvoicedQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(11, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("InvoicedQuantity"); // remove selection
				m_IsValidInvoicedQuantity = true;
				m_InvoicedQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if InvoicedQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for InvoicedQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get InvoicedQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidInvoicedQuantity
		{
			get
			{
				return m_IsValidInvoicedQuantity;
			}
			set 
			{ 
				if (value != m_IsValidInvoicedQuantity)
				{
					InvoicedQuantity = 0F;
					m_IsValidInvoicedQuantity = value;
				}
			}
		}
		protected bool m_IsValidInvoicedQuantity;
		protected float m_InvoicedQuantity;
		#endregion

		#region Attribute - DespatchedPackageQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchedPackageQuantity", "", "IsValidDespatchedPackageQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float DespatchedPackageQuantity
		{
			get 
			{ 
				if (m_IsValidDespatchedPackageQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchedPackageQuantity is not valid. Set DespatchedPackageQuantityValid = true");
				return m_DespatchedPackageQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(12, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchedPackageQuantity"); // remove selection
				m_IsValidDespatchedPackageQuantity = true;
				m_DespatchedPackageQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if DespatchedPackageQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchedPackageQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchedPackageQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchedPackageQuantity
		{
			get
			{
				return m_IsValidDespatchedPackageQuantity;
			}
			set 
			{ 
				if (value != m_IsValidDespatchedPackageQuantity)
				{
					DespatchedPackageQuantity = 0F;
					m_IsValidDespatchedPackageQuantity = value;
				}
			}
		}
		protected bool m_IsValidDespatchedPackageQuantity;
		protected float m_DespatchedPackageQuantity;
		#endregion

		#region Attribute - OrderedPackageQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("OrderedPackageQuantity", "", "IsValidOrderedPackageQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float OrderedPackageQuantity
		{
			get 
			{ 
				if (m_IsValidOrderedPackageQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property OrderedPackageQuantity is not valid. Set OrderedPackageQuantityValid = true");
				return m_OrderedPackageQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(13, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("OrderedPackageQuantity"); // remove selection
				m_IsValidOrderedPackageQuantity = true;
				m_OrderedPackageQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if OrderedPackageQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for OrderedPackageQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get OrderedPackageQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidOrderedPackageQuantity
		{
			get
			{
				return m_IsValidOrderedPackageQuantity;
			}
			set 
			{ 
				if (value != m_IsValidOrderedPackageQuantity)
				{
					OrderedPackageQuantity = 0F;
					m_IsValidOrderedPackageQuantity = value;
				}
			}
		}
		protected bool m_IsValidOrderedPackageQuantity;
		protected float m_OrderedPackageQuantity;
		#endregion

		#region Attribute - DespatchedUnitPacksize
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DespatchedUnitPacksize", "", "IsValidDespatchedUnitPacksize", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float DespatchedUnitPacksize
		{
			get 
			{ 
				if (m_IsValidDespatchedUnitPacksize == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DespatchedUnitPacksize is not valid. Set DespatchedUnitPacksizeValid = true");
				return m_DespatchedUnitPacksize;  
			}
			set 
			{ 
				CheckElementRestriction(14, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DespatchedUnitPacksize"); // remove selection
				m_IsValidDespatchedUnitPacksize = true;
				m_DespatchedUnitPacksize = value;
			}
		}
		/// <summary>
		/// Indicates if DespatchedUnitPacksize contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DespatchedUnitPacksize is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get DespatchedUnitPacksize
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDespatchedUnitPacksize
		{
			get
			{
				return m_IsValidDespatchedUnitPacksize;
			}
			set 
			{ 
				if (value != m_IsValidDespatchedUnitPacksize)
				{
					DespatchedUnitPacksize = 0F;
					m_IsValidDespatchedUnitPacksize = value;
				}
			}
		}
		protected bool m_IsValidDespatchedUnitPacksize;
		protected float m_DespatchedUnitPacksize;
		#endregion

		#region Attribute - OrderedUnitPacksize
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("OrderedUnitPacksize", "", "IsValidOrderedUnitPacksize", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float OrderedUnitPacksize
		{
			get 
			{ 
				if (m_IsValidOrderedUnitPacksize == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property OrderedUnitPacksize is not valid. Set OrderedUnitPacksizeValid = true");
				return m_OrderedUnitPacksize;  
			}
			set 
			{ 
				CheckElementRestriction(15, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("OrderedUnitPacksize"); // remove selection
				m_IsValidOrderedUnitPacksize = true;
				m_OrderedUnitPacksize = value;
			}
		}
		/// <summary>
		/// Indicates if OrderedUnitPacksize contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for OrderedUnitPacksize is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get OrderedUnitPacksize
		/// will raise an exception.
		/// </remarks>
		public bool IsValidOrderedUnitPacksize
		{
			get
			{
				return m_IsValidOrderedUnitPacksize;
			}
			set 
			{ 
				if (value != m_IsValidOrderedUnitPacksize)
				{
					OrderedUnitPacksize = 0F;
					m_IsValidOrderedUnitPacksize = value;
				}
			}
		}
		protected bool m_IsValidOrderedUnitPacksize;
		protected float m_OrderedUnitPacksize;
		#endregion

		#region Attribute - ConsumerUnitPacksize
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ConsumerUnitPacksize", "", "IsValidConsumerUnitPacksize", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float ConsumerUnitPacksize
		{
			get 
			{ 
				if (m_IsValidConsumerUnitPacksize == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ConsumerUnitPacksize is not valid. Set ConsumerUnitPacksizeValid = true");
				return m_ConsumerUnitPacksize;  
			}
			set 
			{ 
				CheckElementRestriction(16, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ConsumerUnitPacksize"); // remove selection
				m_IsValidConsumerUnitPacksize = true;
				m_ConsumerUnitPacksize = value;
			}
		}
		/// <summary>
		/// Indicates if ConsumerUnitPacksize contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ConsumerUnitPacksize is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get ConsumerUnitPacksize
		/// will raise an exception.
		/// </remarks>
		public bool IsValidConsumerUnitPacksize
		{
			get
			{
				return m_IsValidConsumerUnitPacksize;
			}
			set 
			{ 
				if (value != m_IsValidConsumerUnitPacksize)
				{
					ConsumerUnitPacksize = 0F;
					m_IsValidConsumerUnitPacksize = value;
				}
			}
		}
		protected bool m_IsValidConsumerUnitPacksize;
		protected float m_ConsumerUnitPacksize;
		#endregion

		#region Attribute - UnitOfMeasure
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("UnitOfMeasure", "", "IsValidUnitOfMeasure", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "3", "", "", "", "", "-1")]
		public string UnitOfMeasure
		{
			get 
			{ 
				if (m_IsValidUnitOfMeasure == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property UnitOfMeasure is not valid. Set UnitOfMeasureValid = true");
				return m_UnitOfMeasure;  
			}
			set 
			{ 
				CheckElementRestriction(17, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("UnitOfMeasure"); // remove selection
				m_IsValidUnitOfMeasure = true;
				m_UnitOfMeasure = value;
			}
		}
		/// <summary>
		/// Indicates if UnitOfMeasure contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for UnitOfMeasure is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get UnitOfMeasure
		/// will raise an exception.
		/// </remarks>
		public bool IsValidUnitOfMeasure
		{
			get
			{
				return m_IsValidUnitOfMeasure;
			}
			set 
			{ 
				if (value != m_IsValidUnitOfMeasure)
				{
					UnitOfMeasure = "";
					m_IsValidUnitOfMeasure = value;
				}
			}
		}
		protected bool m_IsValidUnitOfMeasure;
		protected string m_UnitOfMeasure;
		#endregion

		#region Attribute - ItemDescription
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ItemDescription", "", "IsValidItemDescription", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "512", "", "", "", "", "-1")]
		public string ItemDescription
		{
			get 
			{ 
				if (m_IsValidItemDescription == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ItemDescription is not valid. Set ItemDescriptionValid = true");
				return m_ItemDescription;  
			}
			set 
			{ 
				CheckElementRestriction(18, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ItemDescription"); // remove selection
				m_IsValidItemDescription = true;
				m_ItemDescription = value;
			}
		}
		/// <summary>
		/// Indicates if ItemDescription contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ItemDescription is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ItemDescription
		/// will raise an exception.
		/// </remarks>
		public bool IsValidItemDescription
		{
			get
			{
				return m_IsValidItemDescription;
			}
			set 
			{ 
				if (value != m_IsValidItemDescription)
				{
					ItemDescription = "";
					m_IsValidItemDescription = value;
				}
			}
		}
		protected bool m_IsValidItemDescription;
		protected string m_ItemDescription;
		#endregion

		#region Attribute - AdditionalItemDescription
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AdditionalItemDescription", "", "IsValidAdditionalItemDescription", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "256", "", "", "", "", "-1")]
		public string AdditionalItemDescription
		{
			get 
			{ 
				if (m_IsValidAdditionalItemDescription == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AdditionalItemDescription is not valid. Set AdditionalItemDescriptionValid = true");
				return m_AdditionalItemDescription;  
			}
			set 
			{ 
				CheckElementRestriction(19, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AdditionalItemDescription"); // remove selection
				m_IsValidAdditionalItemDescription = true;
				m_AdditionalItemDescription = value;
			}
		}
		/// <summary>
		/// Indicates if AdditionalItemDescription contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AdditionalItemDescription is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AdditionalItemDescription
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAdditionalItemDescription
		{
			get
			{
				return m_IsValidAdditionalItemDescription;
			}
			set 
			{ 
				if (value != m_IsValidAdditionalItemDescription)
				{
					AdditionalItemDescription = "";
					m_IsValidAdditionalItemDescription = value;
				}
			}
		}
		protected bool m_IsValidAdditionalItemDescription;
		protected string m_AdditionalItemDescription;
		#endregion

		#region Attribute - UnitNetPrice
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("UnitNetPrice", "", "IsValidUnitNetPrice", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float UnitNetPrice
		{
			get 
			{ 
				if (m_IsValidUnitNetPrice == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property UnitNetPrice is not valid. Set UnitNetPriceValid = true");
				return m_UnitNetPrice;  
			}
			set 
			{ 
				CheckElementRestriction(20, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("UnitNetPrice"); // remove selection
				m_IsValidUnitNetPrice = true;
				m_UnitNetPrice = value;
			}
		}
		/// <summary>
		/// Indicates if UnitNetPrice contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for UnitNetPrice is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get UnitNetPrice
		/// will raise an exception.
		/// </remarks>
		public bool IsValidUnitNetPrice
		{
			get
			{
				return m_IsValidUnitNetPrice;
			}
			set 
			{ 
				if (value != m_IsValidUnitNetPrice)
				{
					UnitNetPrice = 0F;
					m_IsValidUnitNetPrice = value;
				}
			}
		}
		protected bool m_IsValidUnitNetPrice;
		protected float m_UnitNetPrice;
		#endregion

		#region Attribute - UnitGrossPrice
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("UnitGrossPrice", "", "IsValidUnitGrossPrice", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string UnitGrossPrice
		{
			get 
			{ 
				if (m_IsValidUnitGrossPrice == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property UnitGrossPrice is not valid. Set UnitGrossPriceValid = true");
				return m_UnitGrossPrice;  
			}
			set 
			{ 
				CheckElementRestriction(21, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("UnitGrossPrice"); // remove selection
				m_IsValidUnitGrossPrice = true;
				m_UnitGrossPrice = value;
			}
		}
		/// <summary>
		/// Indicates if UnitGrossPrice contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for UnitGrossPrice is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get UnitGrossPrice
		/// will raise an exception.
		/// </remarks>
		public bool IsValidUnitGrossPrice
		{
			get
			{
				return m_IsValidUnitGrossPrice;
			}
			set 
			{ 
				if (value != m_IsValidUnitGrossPrice)
				{
					UnitGrossPrice = "";
					m_IsValidUnitGrossPrice = value;
				}
			}
		}
		protected bool m_IsValidUnitGrossPrice;
		protected string m_UnitGrossPrice;
		#endregion

		#region Attribute - TaxAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TaxAmount", "", "IsValidTaxAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TaxAmount
		{
			get 
			{ 
				if (m_IsValidTaxAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TaxAmount is not valid. Set TaxAmountValid = true");
				return m_TaxAmount;  
			}
			set 
			{ 
				CheckElementRestriction(22, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TaxAmount"); // remove selection
				m_IsValidTaxAmount = true;
				m_TaxAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TaxAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TaxAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TaxAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTaxAmount
		{
			get
			{
				return m_IsValidTaxAmount;
			}
			set 
			{ 
				if (value != m_IsValidTaxAmount)
				{
					TaxAmount = 0F;
					m_IsValidTaxAmount = value;
				}
			}
		}
		protected bool m_IsValidTaxAmount;
		protected float m_TaxAmount;
		#endregion

		#region Attribute - NetAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("NetAmount", "", "IsValidNetAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float NetAmount
		{
			get 
			{ 
				if (m_IsValidNetAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property NetAmount is not valid. Set NetAmountValid = true");
				return m_NetAmount;  
			}
			set 
			{ 
				CheckElementRestriction(23, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("NetAmount"); // remove selection
				m_IsValidNetAmount = true;
				m_NetAmount = value;
			}
		}
		/// <summary>
		/// Indicates if NetAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for NetAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get NetAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidNetAmount
		{
			get
			{
				return m_IsValidNetAmount;
			}
			set 
			{ 
				if (value != m_IsValidNetAmount)
				{
					NetAmount = 0F;
					m_IsValidNetAmount = value;
				}
			}
		}
		protected bool m_IsValidNetAmount;
		protected float m_NetAmount;
		#endregion

		#region Attribute - GrossAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("GrossAmount", "", "IsValidGrossAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float GrossAmount
		{
			get 
			{ 
				if (m_IsValidGrossAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property GrossAmount is not valid. Set GrossAmountValid = true");
				return m_GrossAmount;  
			}
			set 
			{ 
				CheckElementRestriction(24, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("GrossAmount"); // remove selection
				m_IsValidGrossAmount = true;
				m_GrossAmount = value;
			}
		}
		/// <summary>
		/// Indicates if GrossAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for GrossAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get GrossAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidGrossAmount
		{
			get
			{
				return m_IsValidGrossAmount;
			}
			set 
			{ 
				if (value != m_IsValidGrossAmount)
				{
					GrossAmount = 0F;
					m_IsValidGrossAmount = value;
				}
			}
		}
		protected bool m_IsValidGrossAmount;
		protected float m_GrossAmount;
		#endregion

		#region Attribute - OriginalAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("OriginalAmount", "", "IsValidOriginalAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float OriginalAmount
		{
			get 
			{ 
				if (m_IsValidOriginalAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property OriginalAmount is not valid. Set OriginalAmountValid = true");
				return m_OriginalAmount;  
			}
			set 
			{ 
				CheckElementRestriction(25, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("OriginalAmount"); // remove selection
				m_IsValidOriginalAmount = true;
				m_OriginalAmount = value;
			}
		}
		/// <summary>
		/// Indicates if OriginalAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for OriginalAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get OriginalAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidOriginalAmount
		{
			get
			{
				return m_IsValidOriginalAmount;
			}
			set 
			{ 
				if (value != m_IsValidOriginalAmount)
				{
					OriginalAmount = 0F;
					m_IsValidOriginalAmount = value;
				}
			}
		}
		protected bool m_IsValidOriginalAmount;
		protected float m_OriginalAmount;
		#endregion

		#region Attribute - TaxRate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TaxRate", "", "IsValidTaxRate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TaxRate
		{
			get 
			{ 
				if (m_IsValidTaxRate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TaxRate is not valid. Set TaxRateValid = true");
				return m_TaxRate;  
			}
			set 
			{ 
				CheckElementRestriction(26, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TaxRate"); // remove selection
				m_IsValidTaxRate = true;
				m_TaxRate = value;
			}
		}
		/// <summary>
		/// Indicates if TaxRate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TaxRate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TaxRate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTaxRate
		{
			get
			{
				return m_IsValidTaxRate;
			}
			set 
			{ 
				if (value != m_IsValidTaxRate)
				{
					TaxRate = 0F;
					m_IsValidTaxRate = value;
				}
			}
		}
		protected bool m_IsValidTaxRate;
		protected float m_TaxRate;
		#endregion

		#region Attribute - TaxCategoryCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. Set TaxCategoryCodeValid = false to de-select this element
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceEnumOpt("TaxCategoryCode", "", "IsValidTaxCategoryCode", null, typeof(DESADV_XSDLib.Enumerations), "TaxCategoryCodeFromString", "TaxCategoryCodeToString")]
		public DESADV_XSDLib.Enumerations.TaxCategoryCode TaxCategoryCode
		{
			get
			{
				if (m_IsValidTaxCategoryCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TaxCategoryCode is not valid. Set TaxCategoryCodeValid = true");
				return m_TaxCategoryCode;
			}
			set
			{
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TaxCategoryCode"); // remove selection
				m_TaxCategoryCode = value;
				m_IsValidTaxCategoryCode = true;
			}
		}
		/// <summary>
		/// Indicates if TaxCategoryCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TaxCategoryCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (DESADV_XSDLib.Enumerations.TaxCategoryCode.S).
		/// If its set to false then its made invalid, and subsequent calls to get TaxCategoryCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTaxCategoryCode
		{
			get { return m_IsValidTaxCategoryCode;  }
			set 
			{ 
				if (value != m_IsValidTaxCategoryCode)
				{
					// Ensure only one element at a time is populated
					Choice_SetElementValid(value, "TaxCategoryCode", ref _validElement);
					TaxCategoryCode = DESADV_XSDLib.Enumerations.TaxCategoryCode.S;
					m_IsValidTaxCategoryCode = value;
				}
			}
		}
		protected DESADV_XSDLib.Enumerations.TaxCategoryCode m_TaxCategoryCode;
		protected bool m_IsValidTaxCategoryCode;

		#endregion

		#region Attribute - BatchNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BatchNumber", "", "IsValidBatchNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string BatchNumber
		{
			get 
			{ 
				if (m_IsValidBatchNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BatchNumber is not valid. Set BatchNumberValid = true");
				return m_BatchNumber;  
			}
			set 
			{ 
				CheckElementRestriction(28, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BatchNumber"); // remove selection
				m_IsValidBatchNumber = true;
				m_BatchNumber = value;
			}
		}
		/// <summary>
		/// Indicates if BatchNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BatchNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get BatchNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBatchNumber
		{
			get
			{
				return m_IsValidBatchNumber;
			}
			set 
			{ 
				if (value != m_IsValidBatchNumber)
				{
					BatchNumber = "";
					m_IsValidBatchNumber = value;
				}
			}
		}
		protected bool m_IsValidBatchNumber;
		protected string m_BatchNumber;
		#endregion

		#region Attribute - ExpiryDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ExpiryDate", "", "IsValidExpiryDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime ExpiryDate
		{
			get 
			{ 
				if (m_IsValidExpiryDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ExpiryDate is not valid. Set ExpiryDateValid = true");
				return m_ExpiryDate;  
			}
			set 
			{ 
				CheckElementRestriction(29, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ExpiryDate"); // remove selection
				m_IsValidExpiryDate = true;
				m_ExpiryDate.SetDateTime(value, m_ExpiryDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if ExpiryDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ExpiryDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get ExpiryDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidExpiryDate
		{
			get
			{
				return m_IsValidExpiryDate;
			}
			set 
			{ 
				if (value != m_IsValidExpiryDate)
				{
					ExpiryDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidExpiryDate = value;
				}
			}
		}
		protected bool m_IsValidExpiryDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_ExpiryDate;
		#endregion

		#region Attribute - BestBeforeDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BestBeforeDate", "", "IsValidBestBeforeDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime BestBeforeDate
		{
			get 
			{ 
				if (m_IsValidBestBeforeDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BestBeforeDate is not valid. Set BestBeforeDateValid = true");
				return m_BestBeforeDate;  
			}
			set 
			{ 
				CheckElementRestriction(30, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BestBeforeDate"); // remove selection
				m_IsValidBestBeforeDate = true;
				m_BestBeforeDate.SetDateTime(value, m_BestBeforeDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if BestBeforeDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BestBeforeDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get BestBeforeDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBestBeforeDate
		{
			get
			{
				return m_IsValidBestBeforeDate;
			}
			set 
			{ 
				if (value != m_IsValidBestBeforeDate)
				{
					BestBeforeDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidBestBeforeDate = value;
				}
			}
		}
		protected bool m_IsValidBestBeforeDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_BestBeforeDate;
		#endregion

		#region Attribute - ProductionDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ProductionDate", "", "IsValidProductionDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime ProductionDate
		{
			get 
			{ 
				if (m_IsValidProductionDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ProductionDate is not valid. Set ProductionDateValid = true");
				return m_ProductionDate;  
			}
			set 
			{ 
				CheckElementRestriction(31, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ProductionDate"); // remove selection
				m_IsValidProductionDate = true;
				m_ProductionDate.SetDateTime(value, m_ProductionDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if ProductionDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ProductionDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get ProductionDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidProductionDate
		{
			get
			{
				return m_IsValidProductionDate;
			}
			set 
			{ 
				if (value != m_IsValidProductionDate)
				{
					ProductionDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidProductionDate = value;
				}
			}
		}
		protected bool m_IsValidProductionDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_ProductionDate;
		#endregion

		#region Attribute - CountryOfOriginCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CountryOfOriginCode", "", "IsValidCountryOfOriginCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string CountryOfOriginCode
		{
			get 
			{ 
				if (m_IsValidCountryOfOriginCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CountryOfOriginCode is not valid. Set CountryOfOriginCodeValid = true");
				return m_CountryOfOriginCode;  
			}
			set 
			{ 
				CheckElementRestriction(32, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CountryOfOriginCode"); // remove selection
				m_IsValidCountryOfOriginCode = true;
				m_CountryOfOriginCode = value;
			}
		}
		/// <summary>
		/// Indicates if CountryOfOriginCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CountryOfOriginCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get CountryOfOriginCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCountryOfOriginCode
		{
			get
			{
				return m_IsValidCountryOfOriginCode;
			}
			set 
			{ 
				if (value != m_IsValidCountryOfOriginCode)
				{
					CountryOfOriginCode = "";
					m_IsValidCountryOfOriginCode = value;
				}
			}
		}
		protected bool m_IsValidCountryOfOriginCode;
		protected string m_CountryOfOriginCode;
		#endregion

		#region Attribute - CustomsDeclarationNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CustomsDeclarationNumber", "", "IsValidCustomsDeclarationNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "70", "", "", "", "", "-1")]
		public string CustomsDeclarationNumber
		{
			get 
			{ 
				if (m_IsValidCustomsDeclarationNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CustomsDeclarationNumber is not valid. Set CustomsDeclarationNumberValid = true");
				return m_CustomsDeclarationNumber;  
			}
			set 
			{ 
				CheckElementRestriction(33, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CustomsDeclarationNumber"); // remove selection
				m_IsValidCustomsDeclarationNumber = true;
				m_CustomsDeclarationNumber = value;
			}
		}
		/// <summary>
		/// Indicates if CustomsDeclarationNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CustomsDeclarationNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get CustomsDeclarationNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCustomsDeclarationNumber
		{
			get
			{
				return m_IsValidCustomsDeclarationNumber;
			}
			set 
			{ 
				if (value != m_IsValidCustomsDeclarationNumber)
				{
					CustomsDeclarationNumber = "";
					m_IsValidCustomsDeclarationNumber = value;
				}
			}
		}
		protected bool m_IsValidCustomsDeclarationNumber;
		protected string m_CustomsDeclarationNumber;
		#endregion

		#region Attribute - ContractNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ContractNumber", "", "IsValidContractNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "70", "", "", "", "", "-1")]
		public string ContractNumber
		{
			get 
			{ 
				if (m_IsValidContractNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ContractNumber is not valid. Set ContractNumberValid = true");
				return m_ContractNumber;  
			}
			set 
			{ 
				CheckElementRestriction(34, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ContractNumber"); // remove selection
				m_IsValidContractNumber = true;
				m_ContractNumber = value;
			}
		}
		/// <summary>
		/// Indicates if ContractNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ContractNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ContractNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidContractNumber
		{
			get
			{
				return m_IsValidContractNumber;
			}
			set 
			{ 
				if (value != m_IsValidContractNumber)
				{
					ContractNumber = "";
					m_IsValidContractNumber = value;
				}
			}
		}
		protected bool m_IsValidContractNumber;
		protected string m_ContractNumber;
		#endregion

		#region Attribute - CertificateNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CertificateNumber", "", "IsValidCertificateNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string CertificateNumber
		{
			get 
			{ 
				if (m_IsValidCertificateNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CertificateNumber is not valid. Set CertificateNumberValid = true");
				return m_CertificateNumber;  
			}
			set 
			{ 
				CheckElementRestriction(35, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CertificateNumber"); // remove selection
				m_IsValidCertificateNumber = true;
				m_CertificateNumber = value;
			}
		}
		/// <summary>
		/// Indicates if CertificateNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CertificateNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get CertificateNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCertificateNumber
		{
			get
			{
				return m_IsValidCertificateNumber;
			}
			set 
			{ 
				if (value != m_IsValidCertificateNumber)
				{
					CertificateNumber = "";
					m_IsValidCertificateNumber = value;
				}
			}
		}
		protected bool m_IsValidCertificateNumber;
		protected string m_CertificateNumber;
		#endregion

		#region Attribute - SupplierLicenceNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierLicenceNumber", "", "IsValidSupplierLicenceNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string SupplierLicenceNumber
		{
			get 
			{ 
				if (m_IsValidSupplierLicenceNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierLicenceNumber is not valid. Set SupplierLicenceNumberValid = true");
				return m_SupplierLicenceNumber;  
			}
			set 
			{ 
				CheckElementRestriction(36, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierLicenceNumber"); // remove selection
				m_IsValidSupplierLicenceNumber = true;
				m_SupplierLicenceNumber = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierLicenceNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierLicenceNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierLicenceNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierLicenceNumber
		{
			get
			{
				return m_IsValidSupplierLicenceNumber;
			}
			set 
			{ 
				if (value != m_IsValidSupplierLicenceNumber)
				{
					SupplierLicenceNumber = "";
					m_IsValidSupplierLicenceNumber = value;
				}
			}
		}
		protected bool m_IsValidSupplierLicenceNumber;
		protected string m_SupplierLicenceNumber;
		#endregion

		#region Attribute - SupplierLicenceValidityPeriod
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierLicenceValidityPeriod", "", "IsValidSupplierLicenceValidityPeriod", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string SupplierLicenceValidityPeriod
		{
			get 
			{ 
				if (m_IsValidSupplierLicenceValidityPeriod == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierLicenceValidityPeriod is not valid. Set SupplierLicenceValidityPeriodValid = true");
				return m_SupplierLicenceValidityPeriod;  
			}
			set 
			{ 
				CheckElementRestriction(37, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierLicenceValidityPeriod"); // remove selection
				m_IsValidSupplierLicenceValidityPeriod = true;
				m_SupplierLicenceValidityPeriod = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierLicenceValidityPeriod contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierLicenceValidityPeriod is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierLicenceValidityPeriod
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierLicenceValidityPeriod
		{
			get
			{
				return m_IsValidSupplierLicenceValidityPeriod;
			}
			set 
			{ 
				if (value != m_IsValidSupplierLicenceValidityPeriod)
				{
					SupplierLicenceValidityPeriod = "";
					m_IsValidSupplierLicenceValidityPeriod = value;
				}
			}
		}
		protected bool m_IsValidSupplierLicenceValidityPeriod;
		protected string m_SupplierLicenceValidityPeriod;
		#endregion

		#region Attribute - SupplierLicenceIssuer
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierLicenceIssuer", "", "IsValidSupplierLicenceIssuer", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string SupplierLicenceIssuer
		{
			get 
			{ 
				if (m_IsValidSupplierLicenceIssuer == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierLicenceIssuer is not valid. Set SupplierLicenceIssuerValid = true");
				return m_SupplierLicenceIssuer;  
			}
			set 
			{ 
				CheckElementRestriction(38, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierLicenceIssuer"); // remove selection
				m_IsValidSupplierLicenceIssuer = true;
				m_SupplierLicenceIssuer = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierLicenceIssuer contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierLicenceIssuer is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierLicenceIssuer
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierLicenceIssuer
		{
			get
			{
				return m_IsValidSupplierLicenceIssuer;
			}
			set 
			{ 
				if (value != m_IsValidSupplierLicenceIssuer)
				{
					SupplierLicenceIssuer = "";
					m_IsValidSupplierLicenceIssuer = value;
				}
			}
		}
		protected bool m_IsValidSupplierLicenceIssuer;
		protected string m_SupplierLicenceIssuer;
		#endregion

		public string ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected string _validElement;
		#region Attribute - Namespace
		public override string Namespace
		{
			get { return ""; }
		}	
		#endregion	

		#region Attribute - GetBase
		public override LiquidTechnologies.Runtime.Net45.XmlObjectBase GetBase()
		{
			return this;
		}
		#endregion
		#endregion


// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}


