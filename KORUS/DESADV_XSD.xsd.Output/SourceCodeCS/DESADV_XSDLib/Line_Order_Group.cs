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
	/// This class represents the Element Line-Order_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Line-Order_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Line_Order_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Line_Order_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Line_Order_Group()
		{
			_elementName = "Line-Order_Group";
			Init();
		}
		public Line_Order_Group(string elementName)
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
			m_BuyerOrderNumber = "";
			m_IsValidBuyerOrderNumber = false;
			m_BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBuyerOrderDate = false;
			m_SupplierOrderNumber = "";
			m_IsValidSupplierOrderNumber = false;
			m_SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidSupplierOrderDate = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_BuyerOrderNumber = "";
			m_IsValidBuyerOrderNumber = false;
			m_BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidBuyerOrderDate = false;
			m_SupplierOrderNumber = "";
			m_IsValidSupplierOrderNumber = false;
			m_SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidSupplierOrderDate = false;
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
			DESADV_XSDLib.Line_Order_Group newObject = new DESADV_XSDLib.Line_Order_Group(_elementName);
			newObject.m_BuyerOrderNumber = m_BuyerOrderNumber;
			newObject.m_IsValidBuyerOrderNumber = m_IsValidBuyerOrderNumber;
			newObject.m_BuyerOrderDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_BuyerOrderDate.Clone();
			newObject.m_IsValidBuyerOrderDate = m_IsValidBuyerOrderDate;
			newObject.m_SupplierOrderNumber = m_SupplierOrderNumber;
			newObject.m_IsValidSupplierOrderNumber = m_IsValidSupplierOrderNumber;
			newObject.m_SupplierOrderDate = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_SupplierOrderDate.Clone();
			newObject.m_IsValidSupplierOrderDate = m_IsValidSupplierOrderDate;

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

		#region Attribute - BuyerOrderNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BuyerOrderNumber", "", "IsValidBuyerOrderNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string BuyerOrderNumber
		{
			get 
			{ 
				if (m_IsValidBuyerOrderNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BuyerOrderNumber is not valid. Set BuyerOrderNumberValid = true");
				return m_BuyerOrderNumber;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BuyerOrderNumber"); // remove selection
				m_IsValidBuyerOrderNumber = true;
				m_BuyerOrderNumber = value;
			}
		}
		/// <summary>
		/// Indicates if BuyerOrderNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BuyerOrderNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get BuyerOrderNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBuyerOrderNumber
		{
			get
			{
				return m_IsValidBuyerOrderNumber;
			}
			set 
			{ 
				if (value != m_IsValidBuyerOrderNumber)
				{
					BuyerOrderNumber = "";
					m_IsValidBuyerOrderNumber = value;
				}
			}
		}
		protected bool m_IsValidBuyerOrderNumber;
		protected string m_BuyerOrderNumber;
		#endregion

		#region Attribute - BuyerOrderDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("BuyerOrderDate", "", "IsValidBuyerOrderDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime BuyerOrderDate
		{
			get 
			{ 
				if (m_IsValidBuyerOrderDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property BuyerOrderDate is not valid. Set BuyerOrderDateValid = true");
				return m_BuyerOrderDate;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("BuyerOrderDate"); // remove selection
				m_IsValidBuyerOrderDate = true;
				m_BuyerOrderDate.SetDateTime(value, m_BuyerOrderDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if BuyerOrderDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for BuyerOrderDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get BuyerOrderDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidBuyerOrderDate
		{
			get
			{
				return m_IsValidBuyerOrderDate;
			}
			set 
			{ 
				if (value != m_IsValidBuyerOrderDate)
				{
					BuyerOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidBuyerOrderDate = value;
				}
			}
		}
		protected bool m_IsValidBuyerOrderDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_BuyerOrderDate;
		#endregion

		#region Attribute - SupplierOrderNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierOrderNumber", "", "IsValidSupplierOrderNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string SupplierOrderNumber
		{
			get 
			{ 
				if (m_IsValidSupplierOrderNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierOrderNumber is not valid. Set SupplierOrderNumberValid = true");
				return m_SupplierOrderNumber;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierOrderNumber"); // remove selection
				m_IsValidSupplierOrderNumber = true;
				m_SupplierOrderNumber = value;
			}
		}
		/// <summary>
		/// Indicates if SupplierOrderNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierOrderNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SupplierOrderNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierOrderNumber
		{
			get
			{
				return m_IsValidSupplierOrderNumber;
			}
			set 
			{ 
				if (value != m_IsValidSupplierOrderNumber)
				{
					SupplierOrderNumber = "";
					m_IsValidSupplierOrderNumber = value;
				}
			}
		}
		protected bool m_IsValidSupplierOrderNumber;
		protected string m_SupplierOrderNumber;
		#endregion

		#region Attribute - SupplierOrderDate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SupplierOrderDate", "", "IsValidSupplierOrderDate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "\\d*-\\d\\d-\\d\\d", "-1", "-1", "", "", "", "", "-1")]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime SupplierOrderDate
		{
			get 
			{ 
				if (m_IsValidSupplierOrderDate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SupplierOrderDate is not valid. Set SupplierOrderDateValid = true");
				return m_SupplierOrderDate;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SupplierOrderDate"); // remove selection
				m_IsValidSupplierOrderDate = true;
				m_SupplierOrderDate.SetDateTime(value, m_SupplierOrderDate.Type); 
			}
		}
		/// <summary>
		/// Indicates if SupplierOrderDate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SupplierOrderDate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).
		/// If its set to false then its made invalid, and subsequent calls to get SupplierOrderDate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSupplierOrderDate
		{
			get
			{
				return m_IsValidSupplierOrderDate;
			}
			set 
			{ 
				if (value != m_IsValidSupplierOrderDate)
				{
					SupplierOrderDate = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidSupplierOrderDate = value;
				}
			}
		}
		protected bool m_IsValidSupplierOrderDate;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_SupplierOrderDate;
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


