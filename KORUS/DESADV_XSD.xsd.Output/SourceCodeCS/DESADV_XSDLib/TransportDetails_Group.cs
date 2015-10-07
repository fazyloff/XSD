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
	/// This class represents the Element TransportDetails_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"TransportDetails_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TransportDetails_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for TransportDetails_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public TransportDetails_Group()
		{
			_elementName = "TransportDetails_Group";
			Init();
		}
		public TransportDetails_Group(string elementName)
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
			m_CarrierName = "";
			m_IsValidCarrierName = false;
			m_VehicleType = "";
			m_IsValidVehicleType = false;
			m_LicencePlate = "";
			m_IsValidLicencePlate = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_CarrierName = "";
			m_IsValidCarrierName = false;
			m_VehicleType = "";
			m_IsValidVehicleType = false;
			m_LicencePlate = "";
			m_IsValidLicencePlate = false;
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
			DESADV_XSDLib.TransportDetails_Group newObject = new DESADV_XSDLib.TransportDetails_Group(_elementName);
			newObject.m_CarrierName = m_CarrierName;
			newObject.m_IsValidCarrierName = m_IsValidCarrierName;
			newObject.m_VehicleType = m_VehicleType;
			newObject.m_IsValidVehicleType = m_IsValidVehicleType;
			newObject.m_LicencePlate = m_LicencePlate;
			newObject.m_IsValidLicencePlate = m_IsValidLicencePlate;

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

		#region Attribute - CarrierName
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("CarrierName", "", "IsValidCarrierName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string CarrierName
		{
			get 
			{ 
				if (m_IsValidCarrierName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property CarrierName is not valid. Set CarrierNameValid = true");
				return m_CarrierName;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("CarrierName"); // remove selection
				m_IsValidCarrierName = true;
				m_CarrierName = value;
			}
		}
		/// <summary>
		/// Indicates if CarrierName contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for CarrierName is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get CarrierName
		/// will raise an exception.
		/// </remarks>
		public bool IsValidCarrierName
		{
			get
			{
				return m_IsValidCarrierName;
			}
			set 
			{ 
				if (value != m_IsValidCarrierName)
				{
					CarrierName = "";
					m_IsValidCarrierName = value;
				}
			}
		}
		protected bool m_IsValidCarrierName;
		protected string m_CarrierName;
		#endregion

		#region Attribute - VehicleType
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("VehicleType", "", "IsValidVehicleType", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "9", "", "", "", "", "-1")]
		public string VehicleType
		{
			get 
			{ 
				if (m_IsValidVehicleType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property VehicleType is not valid. Set VehicleTypeValid = true");
				return m_VehicleType;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("VehicleType"); // remove selection
				m_IsValidVehicleType = true;
				m_VehicleType = value;
			}
		}
		/// <summary>
		/// Indicates if VehicleType contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for VehicleType is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get VehicleType
		/// will raise an exception.
		/// </remarks>
		public bool IsValidVehicleType
		{
			get
			{
				return m_IsValidVehicleType;
			}
			set 
			{ 
				if (value != m_IsValidVehicleType)
				{
					VehicleType = "";
					m_IsValidVehicleType = value;
				}
			}
		}
		protected bool m_IsValidVehicleType;
		protected string m_VehicleType;
		#endregion

		#region Attribute - LicencePlate
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("LicencePlate", "", "IsValidLicencePlate", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string LicencePlate
		{
			get 
			{ 
				if (m_IsValidLicencePlate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property LicencePlate is not valid. Set LicencePlateValid = true");
				return m_LicencePlate;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("LicencePlate"); // remove selection
				m_IsValidLicencePlate = true;
				m_LicencePlate = value;
			}
		}
		/// <summary>
		/// Indicates if LicencePlate contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for LicencePlate is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get LicencePlate
		/// will raise an exception.
		/// </remarks>
		public bool IsValidLicencePlate
		{
			get
			{
				return m_IsValidLicencePlate;
			}
			set 
			{ 
				if (value != m_IsValidLicencePlate)
				{
					LicencePlate = "";
					m_IsValidLicencePlate = value;
				}
			}
		}
		protected bool m_IsValidLicencePlate;
		protected string m_LicencePlate;
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


