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
	/// BY - nabywca
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Buyer_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Buyer_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Buyer_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Buyer_Group()
		{
			_elementName = "Buyer_Group";
			Init();
		}
		public Buyer_Group(string elementName)
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
			m_TaxID = "";
			m_IsValidTaxID = false;
			m_AccountNumber = "";
			m_IsValidAccountNumber = false;
			m_AdditionalAccountNumber = "";
			m_IsValidAdditionalAccountNumber = false;
			m_FinancialInstitutionName = "";
			m_IsValidFinancialInstitutionName = false;
			m_FinancialInstitutionID = "";
			m_IsValidFinancialInstitutionID = false;
			m_UtilizationRegisterNumber = "";
			m_IsValidUtilizationRegisterNumber = false;
			m_Name = "";
			m_IsValidName = false;
			m_ManagingPerson = "";
			m_IsValidManagingPerson = false;
			m_AccountingContact = "";
			m_IsValidAccountingContact = false;
			m_StreetAndNumber = "";
			m_IsValidStreetAndNumber = false;
			m_District = "";
			m_IsValidDistrict = false;
			m_CityName = "";
			m_IsValidCityName = false;
			m_ProvinceCode = "";
			m_IsValidProvinceCode = false;
			m_Province = "";
			m_IsValidProvince = false;
			m_PostalCode = "";
			m_IsValidPostalCode = false;
			m_PhoneNumber = "";
			m_IsValidPhoneNumber = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ILN = "";
			m_IsValidILN = false;
			m_TaxID = "";
			m_IsValidTaxID = false;
			m_AccountNumber = "";
			m_IsValidAccountNumber = false;
			m_AdditionalAccountNumber = "";
			m_IsValidAdditionalAccountNumber = false;
			m_FinancialInstitutionName = "";
			m_IsValidFinancialInstitutionName = false;
			m_FinancialInstitutionID = "";
			m_IsValidFinancialInstitutionID = false;
			m_UtilizationRegisterNumber = "";
			m_IsValidUtilizationRegisterNumber = false;
			m_Name = "";
			m_IsValidName = false;
			m_ManagingPerson = "";
			m_IsValidManagingPerson = false;
			m_AccountingContact = "";
			m_IsValidAccountingContact = false;
			m_StreetAndNumber = "";
			m_IsValidStreetAndNumber = false;
			m_District = "";
			m_IsValidDistrict = false;
			m_CityName = "";
			m_IsValidCityName = false;
			m_ProvinceCode = "";
			m_IsValidProvinceCode = false;
			m_Province = "";
			m_IsValidProvince = false;
			m_PostalCode = "";
			m_IsValidPostalCode = false;
			m_PhoneNumber = "";
			m_IsValidPhoneNumber = false;
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
			DESADV_XSDLib.Buyer_Group newObject = new DESADV_XSDLib.Buyer_Group(_elementName);
			newObject.m_ILN = m_ILN;
			newObject.m_IsValidILN = m_IsValidILN;
			newObject.m_TaxID = m_TaxID;
			newObject.m_IsValidTaxID = m_IsValidTaxID;
			newObject.m_AccountNumber = m_AccountNumber;
			newObject.m_IsValidAccountNumber = m_IsValidAccountNumber;
			newObject.m_AdditionalAccountNumber = m_AdditionalAccountNumber;
			newObject.m_IsValidAdditionalAccountNumber = m_IsValidAdditionalAccountNumber;
			newObject.m_FinancialInstitutionName = m_FinancialInstitutionName;
			newObject.m_IsValidFinancialInstitutionName = m_IsValidFinancialInstitutionName;
			newObject.m_FinancialInstitutionID = m_FinancialInstitutionID;
			newObject.m_IsValidFinancialInstitutionID = m_IsValidFinancialInstitutionID;
			newObject.m_UtilizationRegisterNumber = m_UtilizationRegisterNumber;
			newObject.m_IsValidUtilizationRegisterNumber = m_IsValidUtilizationRegisterNumber;
			newObject.m_Name = m_Name;
			newObject.m_IsValidName = m_IsValidName;
			newObject.m_ManagingPerson = m_ManagingPerson;
			newObject.m_IsValidManagingPerson = m_IsValidManagingPerson;
			newObject.m_AccountingContact = m_AccountingContact;
			newObject.m_IsValidAccountingContact = m_IsValidAccountingContact;
			newObject.m_StreetAndNumber = m_StreetAndNumber;
			newObject.m_IsValidStreetAndNumber = m_IsValidStreetAndNumber;
			newObject.m_District = m_District;
			newObject.m_IsValidDistrict = m_IsValidDistrict;
			newObject.m_CityName = m_CityName;
			newObject.m_IsValidCityName = m_IsValidCityName;
			newObject.m_ProvinceCode = m_ProvinceCode;
			newObject.m_IsValidProvinceCode = m_IsValidProvinceCode;
			newObject.m_Province = m_Province;
			newObject.m_IsValidProvince = m_IsValidProvince;
			newObject.m_PostalCode = m_PostalCode;
			newObject.m_IsValidPostalCode = m_IsValidPostalCode;
			newObject.m_PhoneNumber = m_PhoneNumber;
			newObject.m_IsValidPhoneNumber = m_IsValidPhoneNumber;

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

		#region Attribute - TaxID
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TaxID", "", "IsValidTaxID", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "35", "", "", "", "", "-1")]
		public string TaxID
		{
			get 
			{ 
				if (m_IsValidTaxID == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TaxID is not valid. Set TaxIDValid = true");
				return m_TaxID;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TaxID"); // remove selection
				m_IsValidTaxID = true;
				m_TaxID = value;
			}
		}
		/// <summary>
		/// Indicates if TaxID contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TaxID is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get TaxID
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTaxID
		{
			get
			{
				return m_IsValidTaxID;
			}
			set 
			{ 
				if (value != m_IsValidTaxID)
				{
					TaxID = "";
					m_IsValidTaxID = value;
				}
			}
		}
		protected bool m_IsValidTaxID;
		protected string m_TaxID;
		#endregion

		#region Attribute - AccountNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AccountNumber", "", "IsValidAccountNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "35", "", "", "", "", "-1")]
		public string AccountNumber
		{
			get 
			{ 
				if (m_IsValidAccountNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AccountNumber is not valid. Set AccountNumberValid = true");
				return m_AccountNumber;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AccountNumber"); // remove selection
				m_IsValidAccountNumber = true;
				m_AccountNumber = value;
			}
		}
		/// <summary>
		/// Indicates if AccountNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AccountNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AccountNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAccountNumber
		{
			get
			{
				return m_IsValidAccountNumber;
			}
			set 
			{ 
				if (value != m_IsValidAccountNumber)
				{
					AccountNumber = "";
					m_IsValidAccountNumber = value;
				}
			}
		}
		protected bool m_IsValidAccountNumber;
		protected string m_AccountNumber;
		#endregion

		#region Attribute - AdditionalAccountNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AdditionalAccountNumber", "", "IsValidAdditionalAccountNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "35", "", "", "", "", "-1")]
		public string AdditionalAccountNumber
		{
			get 
			{ 
				if (m_IsValidAdditionalAccountNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AdditionalAccountNumber is not valid. Set AdditionalAccountNumberValid = true");
				return m_AdditionalAccountNumber;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AdditionalAccountNumber"); // remove selection
				m_IsValidAdditionalAccountNumber = true;
				m_AdditionalAccountNumber = value;
			}
		}
		/// <summary>
		/// Indicates if AdditionalAccountNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AdditionalAccountNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AdditionalAccountNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAdditionalAccountNumber
		{
			get
			{
				return m_IsValidAdditionalAccountNumber;
			}
			set 
			{ 
				if (value != m_IsValidAdditionalAccountNumber)
				{
					AdditionalAccountNumber = "";
					m_IsValidAdditionalAccountNumber = value;
				}
			}
		}
		protected bool m_IsValidAdditionalAccountNumber;
		protected string m_AdditionalAccountNumber;
		#endregion

		#region Attribute - FinancialInstitutionName
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("FinancialInstitutionName", "", "IsValidFinancialInstitutionName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "70", "", "", "", "", "-1")]
		public string FinancialInstitutionName
		{
			get 
			{ 
				if (m_IsValidFinancialInstitutionName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property FinancialInstitutionName is not valid. Set FinancialInstitutionNameValid = true");
				return m_FinancialInstitutionName;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("FinancialInstitutionName"); // remove selection
				m_IsValidFinancialInstitutionName = true;
				m_FinancialInstitutionName = value;
			}
		}
		/// <summary>
		/// Indicates if FinancialInstitutionName contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for FinancialInstitutionName is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get FinancialInstitutionName
		/// will raise an exception.
		/// </remarks>
		public bool IsValidFinancialInstitutionName
		{
			get
			{
				return m_IsValidFinancialInstitutionName;
			}
			set 
			{ 
				if (value != m_IsValidFinancialInstitutionName)
				{
					FinancialInstitutionName = "";
					m_IsValidFinancialInstitutionName = value;
				}
			}
		}
		protected bool m_IsValidFinancialInstitutionName;
		protected string m_FinancialInstitutionName;
		#endregion

		#region Attribute - FinancialInstitutionID
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("FinancialInstitutionID", "", "IsValidFinancialInstitutionID", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string FinancialInstitutionID
		{
			get 
			{ 
				if (m_IsValidFinancialInstitutionID == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property FinancialInstitutionID is not valid. Set FinancialInstitutionIDValid = true");
				return m_FinancialInstitutionID;  
			}
			set 
			{ 
				CheckElementRestriction(5, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("FinancialInstitutionID"); // remove selection
				m_IsValidFinancialInstitutionID = true;
				m_FinancialInstitutionID = value;
			}
		}
		/// <summary>
		/// Indicates if FinancialInstitutionID contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for FinancialInstitutionID is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get FinancialInstitutionID
		/// will raise an exception.
		/// </remarks>
		public bool IsValidFinancialInstitutionID
		{
			get
			{
				return m_IsValidFinancialInstitutionID;
			}
			set 
			{ 
				if (value != m_IsValidFinancialInstitutionID)
				{
					FinancialInstitutionID = "";
					m_IsValidFinancialInstitutionID = value;
				}
			}
		}
		protected bool m_IsValidFinancialInstitutionID;
		protected string m_FinancialInstitutionID;
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
				CheckElementRestriction(6, value);
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
				CheckElementRestriction(7, value);
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

		#region Attribute - ManagingPerson
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ManagingPerson", "", "IsValidManagingPerson", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "175", "", "", "", "", "-1")]
		public string ManagingPerson
		{
			get 
			{ 
				if (m_IsValidManagingPerson == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ManagingPerson is not valid. Set ManagingPersonValid = true");
				return m_ManagingPerson;  
			}
			set 
			{ 
				CheckElementRestriction(8, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ManagingPerson"); // remove selection
				m_IsValidManagingPerson = true;
				m_ManagingPerson = value;
			}
		}
		/// <summary>
		/// Indicates if ManagingPerson contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ManagingPerson is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ManagingPerson
		/// will raise an exception.
		/// </remarks>
		public bool IsValidManagingPerson
		{
			get
			{
				return m_IsValidManagingPerson;
			}
			set 
			{ 
				if (value != m_IsValidManagingPerson)
				{
					ManagingPerson = "";
					m_IsValidManagingPerson = value;
				}
			}
		}
		protected bool m_IsValidManagingPerson;
		protected string m_ManagingPerson;
		#endregion

		#region Attribute - AccountingContact
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AccountingContact", "", "IsValidAccountingContact", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string AccountingContact
		{
			get 
			{ 
				if (m_IsValidAccountingContact == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AccountingContact is not valid. Set AccountingContactValid = true");
				return m_AccountingContact;  
			}
			set 
			{ 
				CheckElementRestriction(9, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AccountingContact"); // remove selection
				m_IsValidAccountingContact = true;
				m_AccountingContact = value;
			}
		}
		/// <summary>
		/// Indicates if AccountingContact contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AccountingContact is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AccountingContact
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAccountingContact
		{
			get
			{
				return m_IsValidAccountingContact;
			}
			set 
			{ 
				if (value != m_IsValidAccountingContact)
				{
					AccountingContact = "";
					m_IsValidAccountingContact = value;
				}
			}
		}
		protected bool m_IsValidAccountingContact;
		protected string m_AccountingContact;
		#endregion

		#region Attribute - StreetAndNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("StreetAndNumber", "", "IsValidStreetAndNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "140", "", "", "", "", "-1")]
		public string StreetAndNumber
		{
			get 
			{ 
				if (m_IsValidStreetAndNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property StreetAndNumber is not valid. Set StreetAndNumberValid = true");
				return m_StreetAndNumber;  
			}
			set 
			{ 
				CheckElementRestriction(10, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("StreetAndNumber"); // remove selection
				m_IsValidStreetAndNumber = true;
				m_StreetAndNumber = value;
			}
		}
		/// <summary>
		/// Indicates if StreetAndNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for StreetAndNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get StreetAndNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidStreetAndNumber
		{
			get
			{
				return m_IsValidStreetAndNumber;
			}
			set 
			{ 
				if (value != m_IsValidStreetAndNumber)
				{
					StreetAndNumber = "";
					m_IsValidStreetAndNumber = value;
				}
			}
		}
		protected bool m_IsValidStreetAndNumber;
		protected string m_StreetAndNumber;
		#endregion

		#region Attribute - District
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("District", "", "IsValidDistrict", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string District
		{
			get 
			{ 
				if (m_IsValidDistrict == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property District is not valid. Set DistrictValid = true");
				return m_District;  
			}
			set 
			{ 
				CheckElementRestriction(11, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("District"); // remove selection
				m_IsValidDistrict = true;
				m_District = value;
			}
		}
		/// <summary>
		/// Indicates if District contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for District is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get District
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDistrict
		{
			get
			{
				return m_IsValidDistrict;
			}
			set 
			{ 
				if (value != m_IsValidDistrict)
				{
					District = "";
					m_IsValidDistrict = value;
				}
			}
		}
		protected bool m_IsValidDistrict;
		protected string m_District;
		#endregion

		#region Attribute - CityName
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CityName", "", "IsValidCityName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string CityName
		{
			get 
			{ 
				if (m_IsValidCityName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CityName is not valid. Set CityNameValid = true");
				return m_CityName;  
			}
			set 
			{ 
				CheckElementRestriction(12, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CityName"); // remove selection
				m_IsValidCityName = true;
				m_CityName = value;
			}
		}
		/// <summary>
		/// Indicates if CityName contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CityName is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get CityName
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCityName
		{
			get
			{
				return m_IsValidCityName;
			}
			set 
			{ 
				if (value != m_IsValidCityName)
				{
					CityName = "";
					m_IsValidCityName = value;
				}
			}
		}
		protected bool m_IsValidCityName;
		protected string m_CityName;
		#endregion

		#region Attribute - ProvinceCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ProvinceCode", "", "IsValidProvinceCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string ProvinceCode
		{
			get 
			{ 
				if (m_IsValidProvinceCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ProvinceCode is not valid. Set ProvinceCodeValid = true");
				return m_ProvinceCode;  
			}
			set 
			{ 
				CheckElementRestriction(13, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ProvinceCode"); // remove selection
				m_IsValidProvinceCode = true;
				m_ProvinceCode = value;
			}
		}
		/// <summary>
		/// Indicates if ProvinceCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ProvinceCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ProvinceCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidProvinceCode
		{
			get
			{
				return m_IsValidProvinceCode;
			}
			set 
			{ 
				if (value != m_IsValidProvinceCode)
				{
					ProvinceCode = "";
					m_IsValidProvinceCode = value;
				}
			}
		}
		protected bool m_IsValidProvinceCode;
		protected string m_ProvinceCode;
		#endregion

		#region Attribute - Province
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Province", "", "IsValidProvince", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "70", "", "", "", "", "-1")]
		public string Province
		{
			get 
			{ 
				if (m_IsValidProvince == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Province is not valid. Set ProvinceValid = true");
				return m_Province;  
			}
			set 
			{ 
				CheckElementRestriction(14, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("Province"); // remove selection
				m_IsValidProvince = true;
				m_Province = value;
			}
		}
		/// <summary>
		/// Indicates if Province contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for Province is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get Province
		/// will raise an exception.
		/// </remarks>
		public bool IsValidProvince
		{
			get
			{
				return m_IsValidProvince;
			}
			set 
			{ 
				if (value != m_IsValidProvince)
				{
					Province = "";
					m_IsValidProvince = value;
				}
			}
		}
		protected bool m_IsValidProvince;
		protected string m_Province;
		#endregion

		#region Attribute - PostalCode
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PostalCode", "", "IsValidPostalCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "17", "", "", "", "", "-1")]
		public string PostalCode
		{
			get 
			{ 
				if (m_IsValidPostalCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PostalCode is not valid. Set PostalCodeValid = true");
				return m_PostalCode;  
			}
			set 
			{ 
				CheckElementRestriction(15, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PostalCode"); // remove selection
				m_IsValidPostalCode = true;
				m_PostalCode = value;
			}
		}
		/// <summary>
		/// Indicates if PostalCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PostalCode is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PostalCode
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPostalCode
		{
			get
			{
				return m_IsValidPostalCode;
			}
			set 
			{ 
				if (value != m_IsValidPostalCode)
				{
					PostalCode = "";
					m_IsValidPostalCode = value;
				}
			}
		}
		protected bool m_IsValidPostalCode;
		protected string m_PostalCode;
		#endregion

		#region Attribute - PhoneNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PhoneNumber", "", "IsValidPhoneNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "512", "", "", "", "", "-1")]
		public string PhoneNumber
		{
			get 
			{ 
				if (m_IsValidPhoneNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PhoneNumber is not valid. Set PhoneNumberValid = true");
				return m_PhoneNumber;  
			}
			set 
			{ 
				CheckElementRestriction(16, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PhoneNumber"); // remove selection
				m_IsValidPhoneNumber = true;
				m_PhoneNumber = value;
			}
		}
		/// <summary>
		/// Indicates if PhoneNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PhoneNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PhoneNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPhoneNumber
		{
			get
			{
				return m_IsValidPhoneNumber;
			}
			set 
			{ 
				if (value != m_IsValidPhoneNumber)
				{
					PhoneNumber = "";
					m_IsValidPhoneNumber = value;
				}
			}
		}
		protected bool m_IsValidPhoneNumber;
		protected string m_PhoneNumber;
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


