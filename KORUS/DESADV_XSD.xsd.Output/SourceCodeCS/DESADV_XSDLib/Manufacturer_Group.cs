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
	/// Manufacturer of goods
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Manufacturer_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Manufacturer_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Manufacturer_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Manufacturer_Group()
		{
			_elementName = "Manufacturer_Group";
			Init();
		}
		public Manufacturer_Group(string elementName)
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
			m_ILN = "";
			m_IsValidILN = false;
			m_Name = "";
			m_IsValidName = false;
			m_FiscalNumber = "";
			m_IsValidFiscalNumber = false;
			m_UtilizationRegisterNumber = "";
			m_IsValidUtilizationRegisterNumber = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ILN = "";
			m_IsValidILN = false;
			m_Name = "";
			m_IsValidName = false;
			m_FiscalNumber = "";
			m_IsValidFiscalNumber = false;
			m_UtilizationRegisterNumber = "";
			m_IsValidUtilizationRegisterNumber = false;
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
			DESADV_XSDLib.Manufacturer_Group newObject = new DESADV_XSDLib.Manufacturer_Group(_elementName);
			newObject.m_ILN = m_ILN;
			newObject.m_IsValidILN = m_IsValidILN;
			newObject.m_Name = m_Name;
			newObject.m_IsValidName = m_IsValidName;
			newObject.m_FiscalNumber = m_FiscalNumber;
			newObject.m_IsValidFiscalNumber = m_IsValidFiscalNumber;
			newObject.m_UtilizationRegisterNumber = m_UtilizationRegisterNumber;
			newObject.m_IsValidUtilizationRegisterNumber = m_IsValidUtilizationRegisterNumber;

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

		#region Attribute - ILN
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ILN", "", "IsValidILN", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "13", "", "", "", "", "-1")]
		public string ILN
		{
			get 
			{ 
				if (m_IsValidILN == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ILN is not valid. Set ILNValid = true");
				return m_ILN;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ILN"); // remove selection
				m_IsValidILN = true;
				m_ILN = value;
			}
		}
		/// <summary>
		/// Indicates if ILN contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ILN is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ILN
		/// will raise an exception.
		/// </remarks>
		public bool IsValidILN
		{
			get
			{
				return m_IsValidILN;
			}
			set 
			{ 
				if (value != m_IsValidILN)
				{
					ILN = "";
					m_IsValidILN = value;
				}
			}
		}
		protected bool m_IsValidILN;
		protected string m_ILN;
		#endregion

		#region Attribute - Name
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Name", "", "IsValidName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "175", "", "", "", "", "-1")]
		public string Name
		{
			get 
			{ 
				if (m_IsValidName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Name is not valid. Set NameValid = true");
				return m_Name;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("Name"); // remove selection
				m_IsValidName = true;
				m_Name = value;
			}
		}
		/// <summary>
		/// Indicates if Name contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for Name is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get Name
		/// will raise an exception.
		/// </remarks>
		public bool IsValidName
		{
			get
			{
				return m_IsValidName;
			}
			set 
			{ 
				if (value != m_IsValidName)
				{
					Name = "";
					m_IsValidName = value;
				}
			}
		}
		protected bool m_IsValidName;
		protected string m_Name;
		#endregion

		#region Attribute - FiscalNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("FiscalNumber", "", "IsValidFiscalNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "70", "", "", "", "", "-1")]
		public string FiscalNumber
		{
			get 
			{ 
				if (m_IsValidFiscalNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property FiscalNumber is not valid. Set FiscalNumberValid = true");
				return m_FiscalNumber;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("FiscalNumber"); // remove selection
				m_IsValidFiscalNumber = true;
				m_FiscalNumber = value;
			}
		}
		/// <summary>
		/// Indicates if FiscalNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for FiscalNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get FiscalNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidFiscalNumber
		{
			get
			{
				return m_IsValidFiscalNumber;
			}
			set 
			{ 
				if (value != m_IsValidFiscalNumber)
				{
					FiscalNumber = "";
					m_IsValidFiscalNumber = value;
				}
			}
		}
		protected bool m_IsValidFiscalNumber;
		protected string m_FiscalNumber;
		#endregion

		#region Attribute - UtilizationRegisterNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("UtilizationRegisterNumber", "", "IsValidUtilizationRegisterNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "70", "", "", "", "", "-1")]
		public string UtilizationRegisterNumber
		{
			get 
			{ 
				if (m_IsValidUtilizationRegisterNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property UtilizationRegisterNumber is not valid. Set UtilizationRegisterNumberValid = true");
				return m_UtilizationRegisterNumber;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("UtilizationRegisterNumber"); // remove selection
				m_IsValidUtilizationRegisterNumber = true;
				m_UtilizationRegisterNumber = value;
			}
		}
		/// <summary>
		/// Indicates if UtilizationRegisterNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for UtilizationRegisterNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get UtilizationRegisterNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidUtilizationRegisterNumber
		{
			get
			{
				return m_IsValidUtilizationRegisterNumber;
			}
			set 
			{ 
				if (value != m_IsValidUtilizationRegisterNumber)
				{
					UtilizationRegisterNumber = "";
					m_IsValidUtilizationRegisterNumber = value;
				}
			}
		}
		protected bool m_IsValidUtilizationRegisterNumber;
		protected string m_UtilizationRegisterNumber;
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


