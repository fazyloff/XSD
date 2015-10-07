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
	/// This class represents the Element DespatchAdvice-Transport_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DespatchAdvice-Transport_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DespatchAdvice_Transport_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for DespatchAdvice_Transport_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public DespatchAdvice_Transport_Group()
		{
			_elementName = "DespatchAdvice-Transport_Group";
			Init();
		}
		public DespatchAdvice_Transport_Group(string elementName)
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
			m_DeliveryType = "";
			m_IsValidDeliveryType = false;
			m_DeliveryInstructions = "";
			m_IsValidDeliveryInstructions = false;
			m_TransportsNumber = "";
			m_IsValidTransportsNumber = false;
			m_TransportationInformation = "";
			m_IsValidTransportationInformation = false;
			m_Transports = null;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DeliveryType = "";
			m_IsValidDeliveryType = false;
			m_DeliveryInstructions = "";
			m_IsValidDeliveryInstructions = false;
			m_TransportsNumber = "";
			m_IsValidTransportsNumber = false;
			m_TransportationInformation = "";
			m_IsValidTransportationInformation = false;
			m_Transports = null;
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
			DESADV_XSDLib.DespatchAdvice_Transport_Group newObject = new DESADV_XSDLib.DespatchAdvice_Transport_Group(_elementName);
			newObject.m_DeliveryType = m_DeliveryType;
			newObject.m_IsValidDeliveryType = m_IsValidDeliveryType;
			newObject.m_DeliveryInstructions = m_DeliveryInstructions;
			newObject.m_IsValidDeliveryInstructions = m_IsValidDeliveryInstructions;
			newObject.m_TransportsNumber = m_TransportsNumber;
			newObject.m_IsValidTransportsNumber = m_IsValidTransportsNumber;
			newObject.m_TransportationInformation = m_TransportationInformation;
			newObject.m_IsValidTransportationInformation = m_IsValidTransportationInformation;
			newObject.m_Transports = null;
			if (m_Transports != null)
				newObject.m_Transports = (DESADV_XSDLib.Transports)m_Transports.Clone();

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

		#region Attribute - DeliveryType
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DeliveryType", "", "IsValidDeliveryType", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string DeliveryType
		{
			get 
			{ 
				if (m_IsValidDeliveryType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DeliveryType is not valid. Set DeliveryTypeValid = true");
				return m_DeliveryType;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DeliveryType"); // remove selection
				m_IsValidDeliveryType = true;
				m_DeliveryType = value;
			}
		}
		/// <summary>
		/// Indicates if DeliveryType contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DeliveryType is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DeliveryType
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDeliveryType
		{
			get
			{
				return m_IsValidDeliveryType;
			}
			set 
			{ 
				if (value != m_IsValidDeliveryType)
				{
					DeliveryType = "";
					m_IsValidDeliveryType = value;
				}
			}
		}
		protected bool m_IsValidDeliveryType;
		protected string m_DeliveryType;
		#endregion

		#region Attribute - DeliveryInstructions
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DeliveryInstructions", "", "IsValidDeliveryInstructions", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string DeliveryInstructions
		{
			get 
			{ 
				if (m_IsValidDeliveryInstructions == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DeliveryInstructions is not valid. Set DeliveryInstructionsValid = true");
				return m_DeliveryInstructions;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DeliveryInstructions"); // remove selection
				m_IsValidDeliveryInstructions = true;
				m_DeliveryInstructions = value;
			}
		}
		/// <summary>
		/// Indicates if DeliveryInstructions contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DeliveryInstructions is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DeliveryInstructions
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDeliveryInstructions
		{
			get
			{
				return m_IsValidDeliveryInstructions;
			}
			set 
			{ 
				if (value != m_IsValidDeliveryInstructions)
				{
					DeliveryInstructions = "";
					m_IsValidDeliveryInstructions = value;
				}
			}
		}
		protected bool m_IsValidDeliveryInstructions;
		protected string m_DeliveryInstructions;
		#endregion

		#region Attribute - TransportsNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TransportsNumber", "", "IsValidTransportsNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "1", "17", "", "", "", "", "-1")]
		public string TransportsNumber
		{
			get 
			{ 
				if (m_IsValidTransportsNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TransportsNumber is not valid. Set TransportsNumberValid = true");
				return m_TransportsNumber;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TransportsNumber"); // remove selection
				m_IsValidTransportsNumber = true;
				m_TransportsNumber = value;
			}
		}
		/// <summary>
		/// Indicates if TransportsNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TransportsNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get TransportsNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTransportsNumber
		{
			get
			{
				return m_IsValidTransportsNumber;
			}
			set 
			{ 
				if (value != m_IsValidTransportsNumber)
				{
					TransportsNumber = "";
					m_IsValidTransportsNumber = value;
				}
			}
		}
		protected bool m_IsValidTransportsNumber;
		protected string m_TransportsNumber;
		#endregion

		#region Attribute - TransportationInformation
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("TransportationInformation", "", "IsValidTransportationInformation", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string TransportationInformation
		{
			get 
			{ 
				if (m_IsValidTransportationInformation == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property TransportationInformation is not valid. Set TransportationInformationValid = true");
				return m_TransportationInformation;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("TransportationInformation"); // remove selection
				m_IsValidTransportationInformation = true;
				m_TransportationInformation = value;
			}
		}
		/// <summary>
		/// Indicates if TransportationInformation contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for TransportationInformation is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get TransportationInformation
		/// will raise an exception.
		/// </remarks>
		public bool IsValidTransportationInformation
		{
			get
			{
				return m_IsValidTransportationInformation;
			}
			set 
			{ 
				if (value != m_IsValidTransportationInformation)
				{
					TransportationInformation = "";
					m_IsValidTransportationInformation = value;
				}
			}
		}
		protected bool m_IsValidTransportationInformation;
		protected string m_TransportationInformation;
		#endregion

		#region Attribute - Transports
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Transports", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Transports))]
		public DESADV_XSDLib.Transports Transports
		{
			get
			{ 
				return m_Transports;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Transports"); // remove selection
				if (value == null)
					m_Transports = null;
				else
				{
					m_Transports = value; 
				}
			}
		}
		protected DESADV_XSDLib.Transports m_Transports;
		
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


