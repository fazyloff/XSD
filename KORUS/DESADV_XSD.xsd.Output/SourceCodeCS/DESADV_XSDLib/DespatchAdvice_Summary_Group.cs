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
	/// This class represents the Element DespatchAdvice-Summary_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DespatchAdvice-Summary_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DespatchAdvice_Summary_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for DespatchAdvice_Summary_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public DespatchAdvice_Summary_Group()
		{
			_elementName = "DespatchAdvice-Summary_Group";
			Init();
		}
		public DespatchAdvice_Summary_Group(string elementName)
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
			m_TotalAmount = 0F;
			m_IsValidTotalAmount = false;
			m_TotalQuantity = 0F;
			m_IsValidTotalQuantity = false;
			m_TotalPackageNumber = "";
			m_IsValidTotalPackageNumber = false;
			m_TotalLines = "";
			m_IsValidTotalLines = false;
			m_TotalGrossAmount = 0F;
			m_IsValidTotalGrossAmount = false;
			m_TotalTaxAmount = 0F;
			m_IsValidTotalTaxAmount = false;
			m_TotalDiscountAmount = 0F;
			m_IsValidTotalDiscountAmount = false;
			m_TotalFinalAmount = 0F;
			m_IsValidTotalFinalAmount = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_TotalAmount = 0F;
			m_IsValidTotalAmount = false;
			m_TotalQuantity = 0F;
			m_IsValidTotalQuantity = false;
			m_TotalPackageNumber = "";
			m_IsValidTotalPackageNumber = false;
			m_TotalLines = "";
			m_IsValidTotalLines = false;
			m_TotalGrossAmount = 0F;
			m_IsValidTotalGrossAmount = false;
			m_TotalTaxAmount = 0F;
			m_IsValidTotalTaxAmount = false;
			m_TotalDiscountAmount = 0F;
			m_IsValidTotalDiscountAmount = false;
			m_TotalFinalAmount = 0F;
			m_IsValidTotalFinalAmount = false;
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
			DESADV_XSDLib.DespatchAdvice_Summary_Group newObject = new DESADV_XSDLib.DespatchAdvice_Summary_Group(_elementName);
			newObject.m_TotalAmount = m_TotalAmount;
			newObject.m_IsValidTotalAmount = m_IsValidTotalAmount;
			newObject.m_TotalQuantity = m_TotalQuantity;
			newObject.m_IsValidTotalQuantity = m_IsValidTotalQuantity;
			newObject.m_TotalPackageNumber = m_TotalPackageNumber;
			newObject.m_IsValidTotalPackageNumber = m_IsValidTotalPackageNumber;
			newObject.m_TotalLines = m_TotalLines;
			newObject.m_IsValidTotalLines = m_IsValidTotalLines;
			newObject.m_TotalGrossAmount = m_TotalGrossAmount;
			newObject.m_IsValidTotalGrossAmount = m_IsValidTotalGrossAmount;
			newObject.m_TotalTaxAmount = m_TotalTaxAmount;
			newObject.m_IsValidTotalTaxAmount = m_IsValidTotalTaxAmount;
			newObject.m_TotalDiscountAmount = m_TotalDiscountAmount;
			newObject.m_IsValidTotalDiscountAmount = m_IsValidTotalDiscountAmount;
			newObject.m_TotalFinalAmount = m_TotalFinalAmount;
			newObject.m_IsValidTotalFinalAmount = m_IsValidTotalFinalAmount;

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

		#region Attribute - TotalAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalAmount", "", "IsValidTotalAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalAmount
		{
			get 
			{ 
				if (m_IsValidTotalAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalAmount is not valid. Set TotalAmountValid = true");
				return m_TotalAmount;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalAmount"); // remove selection
				m_IsValidTotalAmount = true;
				m_TotalAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TotalAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalAmount
		{
			get
			{
				return m_IsValidTotalAmount;
			}
			set 
			{ 
				if (value != m_IsValidTotalAmount)
				{
					TotalAmount = 0F;
					m_IsValidTotalAmount = value;
				}
			}
		}
		protected bool m_IsValidTotalAmount;
		protected float m_TotalAmount;
		#endregion

		#region Attribute - TotalQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalQuantity", "", "IsValidTotalQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalQuantity
		{
			get 
			{ 
				if (m_IsValidTotalQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalQuantity is not valid. Set TotalQuantityValid = true");
				return m_TotalQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalQuantity"); // remove selection
				m_IsValidTotalQuantity = true;
				m_TotalQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if TotalQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalQuantity
		{
			get
			{
				return m_IsValidTotalQuantity;
			}
			set 
			{ 
				if (value != m_IsValidTotalQuantity)
				{
					TotalQuantity = 0F;
					m_IsValidTotalQuantity = value;
				}
			}
		}
		protected bool m_IsValidTotalQuantity;
		protected float m_TotalQuantity;
		#endregion

		#region Attribute - TotalPackageNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalPackageNumber", "", "IsValidTotalPackageNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string TotalPackageNumber
		{
			get 
			{ 
				if (m_IsValidTotalPackageNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalPackageNumber is not valid. Set TotalPackageNumberValid = true");
				return m_TotalPackageNumber;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalPackageNumber"); // remove selection
				m_IsValidTotalPackageNumber = true;
				m_TotalPackageNumber = value;
			}
		}
		/// <summary>
		/// Indicates if TotalPackageNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalPackageNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get TotalPackageNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalPackageNumber
		{
			get
			{
				return m_IsValidTotalPackageNumber;
			}
			set 
			{ 
				if (value != m_IsValidTotalPackageNumber)
				{
					TotalPackageNumber = "";
					m_IsValidTotalPackageNumber = value;
				}
			}
		}
		protected bool m_IsValidTotalPackageNumber;
		protected string m_TotalPackageNumber;
		#endregion

		#region Attribute - TotalLines
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalLines", "", "IsValidTotalLines", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string TotalLines
		{
			get 
			{ 
				if (m_IsValidTotalLines == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalLines is not valid. Set TotalLinesValid = true");
				return m_TotalLines;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalLines"); // remove selection
				m_IsValidTotalLines = true;
				m_TotalLines = value;
			}
		}
		/// <summary>
		/// Indicates if TotalLines contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalLines is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get TotalLines
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalLines
		{
			get
			{
				return m_IsValidTotalLines;
			}
			set 
			{ 
				if (value != m_IsValidTotalLines)
				{
					TotalLines = "";
					m_IsValidTotalLines = value;
				}
			}
		}
		protected bool m_IsValidTotalLines;
		protected string m_TotalLines;
		#endregion

		#region Attribute - TotalGrossAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalGrossAmount", "", "IsValidTotalGrossAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalGrossAmount
		{
			get 
			{ 
				if (m_IsValidTotalGrossAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalGrossAmount is not valid. Set TotalGrossAmountValid = true");
				return m_TotalGrossAmount;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalGrossAmount"); // remove selection
				m_IsValidTotalGrossAmount = true;
				m_TotalGrossAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TotalGrossAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalGrossAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalGrossAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalGrossAmount
		{
			get
			{
				return m_IsValidTotalGrossAmount;
			}
			set 
			{ 
				if (value != m_IsValidTotalGrossAmount)
				{
					TotalGrossAmount = 0F;
					m_IsValidTotalGrossAmount = value;
				}
			}
		}
		protected bool m_IsValidTotalGrossAmount;
		protected float m_TotalGrossAmount;
		#endregion

		#region Attribute - TotalTaxAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalTaxAmount", "", "IsValidTotalTaxAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalTaxAmount
		{
			get 
			{ 
				if (m_IsValidTotalTaxAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalTaxAmount is not valid. Set TotalTaxAmountValid = true");
				return m_TotalTaxAmount;  
			}
			set 
			{ 
				CheckElementRestriction(5, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalTaxAmount"); // remove selection
				m_IsValidTotalTaxAmount = true;
				m_TotalTaxAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TotalTaxAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalTaxAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalTaxAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalTaxAmount
		{
			get
			{
				return m_IsValidTotalTaxAmount;
			}
			set 
			{ 
				if (value != m_IsValidTotalTaxAmount)
				{
					TotalTaxAmount = 0F;
					m_IsValidTotalTaxAmount = value;
				}
			}
		}
		protected bool m_IsValidTotalTaxAmount;
		protected float m_TotalTaxAmount;
		#endregion

		#region Attribute - TotalDiscountAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalDiscountAmount", "", "IsValidTotalDiscountAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalDiscountAmount
		{
			get 
			{ 
				if (m_IsValidTotalDiscountAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalDiscountAmount is not valid. Set TotalDiscountAmountValid = true");
				return m_TotalDiscountAmount;  
			}
			set 
			{ 
				CheckElementRestriction(6, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalDiscountAmount"); // remove selection
				m_IsValidTotalDiscountAmount = true;
				m_TotalDiscountAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TotalDiscountAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalDiscountAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalDiscountAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalDiscountAmount
		{
			get
			{
				return m_IsValidTotalDiscountAmount;
			}
			set 
			{ 
				if (value != m_IsValidTotalDiscountAmount)
				{
					TotalDiscountAmount = 0F;
					m_IsValidTotalDiscountAmount = value;
				}
			}
		}
		protected bool m_IsValidTotalDiscountAmount;
		protected float m_TotalDiscountAmount;
		#endregion

		#region Attribute - TotalFinalAmount
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TotalFinalAmount", "", "IsValidTotalFinalAmount", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float TotalFinalAmount
		{
			get 
			{ 
				if (m_IsValidTotalFinalAmount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TotalFinalAmount is not valid. Set TotalFinalAmountValid = true");
				return m_TotalFinalAmount;  
			}
			set 
			{ 
				CheckElementRestriction(7, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TotalFinalAmount"); // remove selection
				m_IsValidTotalFinalAmount = true;
				m_TotalFinalAmount = value;
			}
		}
		/// <summary>
		/// Indicates if TotalFinalAmount contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TotalFinalAmount is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get TotalFinalAmount
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTotalFinalAmount
		{
			get
			{
				return m_IsValidTotalFinalAmount;
			}
			set 
			{ 
				if (value != m_IsValidTotalFinalAmount)
				{
					TotalFinalAmount = 0F;
					m_IsValidTotalFinalAmount = value;
				}
			}
		}
		protected bool m_IsValidTotalFinalAmount;
		protected float m_TotalFinalAmount;
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


