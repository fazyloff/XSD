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
	/// This class represents the Element Packing-Sequence_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Packing-Sequence_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Packing_Sequence_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Packing_Sequence_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Packing_Sequence_Group()
		{
			_elementName = "Packing-Sequence_Group";
			Init();
		}
		public Packing_Sequence_Group(string elementName)
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
			m_PackageId = "";
			m_IsValidPackageId = false;
			m_ParentId = "";
			m_IsValidParentId = false;
			m_PackageType = "";
			m_IsValidPackageType = false;
			m_SerialNumber = "";
			m_IsValidSerialNumber = false;
			m_DeliveryPlace = "";
			m_IsValidDeliveryPlace = false;
			m_PackageWeight = 0F;
			m_IsValidPackageWeight = false;
			m_PackageHeight = 0F;
			m_IsValidPackageHeight = false;
			m_PackageLength = 0F;
			m_IsValidPackageLength = false;
			m_PackageWidth = 0F;
			m_IsValidPackageWidth = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_PackageId = "";
			m_IsValidPackageId = false;
			m_ParentId = "";
			m_IsValidParentId = false;
			m_PackageType = "";
			m_IsValidPackageType = false;
			m_SerialNumber = "";
			m_IsValidSerialNumber = false;
			m_DeliveryPlace = "";
			m_IsValidDeliveryPlace = false;
			m_PackageWeight = 0F;
			m_IsValidPackageWeight = false;
			m_PackageHeight = 0F;
			m_IsValidPackageHeight = false;
			m_PackageLength = 0F;
			m_IsValidPackageLength = false;
			m_PackageWidth = 0F;
			m_IsValidPackageWidth = false;
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
			DESADV_XSDLib.Packing_Sequence_Group newObject = new DESADV_XSDLib.Packing_Sequence_Group(_elementName);
			newObject.m_PackageId = m_PackageId;
			newObject.m_IsValidPackageId = m_IsValidPackageId;
			newObject.m_ParentId = m_ParentId;
			newObject.m_IsValidParentId = m_IsValidParentId;
			newObject.m_PackageType = m_PackageType;
			newObject.m_IsValidPackageType = m_IsValidPackageType;
			newObject.m_SerialNumber = m_SerialNumber;
			newObject.m_IsValidSerialNumber = m_IsValidSerialNumber;
			newObject.m_DeliveryPlace = m_DeliveryPlace;
			newObject.m_IsValidDeliveryPlace = m_IsValidDeliveryPlace;
			newObject.m_PackageWeight = m_PackageWeight;
			newObject.m_IsValidPackageWeight = m_IsValidPackageWeight;
			newObject.m_PackageHeight = m_PackageHeight;
			newObject.m_IsValidPackageHeight = m_IsValidPackageHeight;
			newObject.m_PackageLength = m_PackageLength;
			newObject.m_IsValidPackageLength = m_IsValidPackageLength;
			newObject.m_PackageWidth = m_PackageWidth;
			newObject.m_IsValidPackageWidth = m_IsValidPackageWidth;

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

		#region Attribute - PackageId
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageId", "", "IsValidPackageId", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string PackageId
		{
			get 
			{ 
				if (m_IsValidPackageId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageId is not valid. Set PackageIdValid = true");
				return m_PackageId;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageId"); // remove selection
				m_IsValidPackageId = true;
				m_PackageId = value;
			}
		}
		/// <summary>
		/// Indicates if PackageId contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageId is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PackageId
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageId
		{
			get
			{
				return m_IsValidPackageId;
			}
			set 
			{ 
				if (value != m_IsValidPackageId)
				{
					PackageId = "";
					m_IsValidPackageId = value;
				}
			}
		}
		protected bool m_IsValidPackageId;
		protected string m_PackageId;
		#endregion

		#region Attribute - ParentId
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ParentId", "", "IsValidParentId", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "35", "", "", "", "", "-1")]
		public string ParentId
		{
			get 
			{ 
				if (m_IsValidParentId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ParentId is not valid. Set ParentIdValid = true");
				return m_ParentId;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ParentId"); // remove selection
				m_IsValidParentId = true;
				m_ParentId = value;
			}
		}
		/// <summary>
		/// Indicates if ParentId contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for ParentId is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get ParentId
		/// will raise an exception.
		/// </remarks>
		public bool IsValidParentId
		{
			get
			{
				return m_IsValidParentId;
			}
			set 
			{ 
				if (value != m_IsValidParentId)
				{
					ParentId = "";
					m_IsValidParentId = value;
				}
			}
		}
		protected bool m_IsValidParentId;
		protected string m_ParentId;
		#endregion

		#region Attribute - PackageType
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageType", "", "IsValidPackageType", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "17", "", "", "", "", "-1")]
		public string PackageType
		{
			get 
			{ 
				if (m_IsValidPackageType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageType is not valid. Set PackageTypeValid = true");
				return m_PackageType;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageType"); // remove selection
				m_IsValidPackageType = true;
				m_PackageType = value;
			}
		}
		/// <summary>
		/// Indicates if PackageType contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageType is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get PackageType
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageType
		{
			get
			{
				return m_IsValidPackageType;
			}
			set 
			{ 
				if (value != m_IsValidPackageType)
				{
					PackageType = "";
					m_IsValidPackageType = value;
				}
			}
		}
		protected bool m_IsValidPackageType;
		protected string m_PackageType;
		#endregion

		#region Attribute - SerialNumber
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("SerialNumber", "", "IsValidSerialNumber", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "18", "", "", "", "", "-1")]
		public string SerialNumber
		{
			get 
			{ 
				if (m_IsValidSerialNumber == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SerialNumber is not valid. Set SerialNumberValid = true");
				return m_SerialNumber;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("SerialNumber"); // remove selection
				m_IsValidSerialNumber = true;
				m_SerialNumber = value;
			}
		}
		/// <summary>
		/// Indicates if SerialNumber contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for SerialNumber is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get SerialNumber
		/// will raise an exception.
		/// </remarks>
		public bool IsValidSerialNumber
		{
			get
			{
				return m_IsValidSerialNumber;
			}
			set 
			{ 
				if (value != m_IsValidSerialNumber)
				{
					SerialNumber = "";
					m_IsValidSerialNumber = value;
				}
			}
		}
		protected bool m_IsValidSerialNumber;
		protected string m_SerialNumber;
		#endregion

		#region Attribute - DeliveryPlace
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("DeliveryPlace", "", "IsValidDeliveryPlace", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string DeliveryPlace
		{
			get 
			{ 
				if (m_IsValidDeliveryPlace == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property DeliveryPlace is not valid. Set DeliveryPlaceValid = true");
				return m_DeliveryPlace;  
			}
			set 
			{ 
				CheckElementRestriction(4, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("DeliveryPlace"); // remove selection
				m_IsValidDeliveryPlace = true;
				m_DeliveryPlace = value;
			}
		}
		/// <summary>
		/// Indicates if DeliveryPlace contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for DeliveryPlace is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get DeliveryPlace
		/// will raise an exception.
		/// </remarks>
		public bool IsValidDeliveryPlace
		{
			get
			{
				return m_IsValidDeliveryPlace;
			}
			set 
			{ 
				if (value != m_IsValidDeliveryPlace)
				{
					DeliveryPlace = "";
					m_IsValidDeliveryPlace = value;
				}
			}
		}
		protected bool m_IsValidDeliveryPlace;
		protected string m_DeliveryPlace;
		#endregion

		#region Attribute - PackageWeight
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageWeight", "", "IsValidPackageWeight", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "([0-9]|\\+|\\-|E|e|\\.){0,18}", "-1", "-1", "", "", "", "", "-1")]
		public float PackageWeight
		{
			get 
			{ 
				if (m_IsValidPackageWeight == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageWeight is not valid. Set PackageWeightValid = true");
				return m_PackageWeight;  
			}
			set 
			{ 
				CheckElementRestriction(5, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageWeight"); // remove selection
				m_IsValidPackageWeight = true;
				m_PackageWeight = value;
			}
		}
		/// <summary>
		/// Indicates if PackageWeight contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageWeight is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get PackageWeight
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageWeight
		{
			get
			{
				return m_IsValidPackageWeight;
			}
			set 
			{ 
				if (value != m_IsValidPackageWeight)
				{
					PackageWeight = 0F;
					m_IsValidPackageWeight = value;
				}
			}
		}
		protected bool m_IsValidPackageWeight;
		protected float m_PackageWeight;
		#endregion

		#region Attribute - PackageHeight
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageHeight", "", "IsValidPackageHeight", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "([0-9]|\\+|\\-|E|e|\\.){0,18}", "-1", "-1", "", "", "", "", "-1")]
		public float PackageHeight
		{
			get 
			{ 
				if (m_IsValidPackageHeight == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageHeight is not valid. Set PackageHeightValid = true");
				return m_PackageHeight;  
			}
			set 
			{ 
				CheckElementRestriction(6, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageHeight"); // remove selection
				m_IsValidPackageHeight = true;
				m_PackageHeight = value;
			}
		}
		/// <summary>
		/// Indicates if PackageHeight contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageHeight is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get PackageHeight
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageHeight
		{
			get
			{
				return m_IsValidPackageHeight;
			}
			set 
			{ 
				if (value != m_IsValidPackageHeight)
				{
					PackageHeight = 0F;
					m_IsValidPackageHeight = value;
				}
			}
		}
		protected bool m_IsValidPackageHeight;
		protected float m_PackageHeight;
		#endregion

		#region Attribute - PackageLength
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageLength", "", "IsValidPackageLength", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "([0-9]|\\+|\\-|E|e|\\.){0,18}", "-1", "-1", "", "", "", "", "-1")]
		public float PackageLength
		{
			get 
			{ 
				if (m_IsValidPackageLength == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageLength is not valid. Set PackageLengthValid = true");
				return m_PackageLength;  
			}
			set 
			{ 
				CheckElementRestriction(7, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageLength"); // remove selection
				m_IsValidPackageLength = true;
				m_PackageLength = value;
			}
		}
		/// <summary>
		/// Indicates if PackageLength contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageLength is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get PackageLength
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageLength
		{
			get
			{
				return m_IsValidPackageLength;
			}
			set 
			{ 
				if (value != m_IsValidPackageLength)
				{
					PackageLength = 0F;
					m_IsValidPackageLength = value;
				}
			}
		}
		protected bool m_IsValidPackageLength;
		protected float m_PackageLength;
		#endregion

		#region Attribute - PackageWidth
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PackageWidth", "", "IsValidPackageWidth", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "([0-9]|\\+|\\-|E|e|\\.){0,18}", "-1", "-1", "", "", "", "", "-1")]
		public float PackageWidth
		{
			get 
			{ 
				if (m_IsValidPackageWidth == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PackageWidth is not valid. Set PackageWidthValid = true");
				return m_PackageWidth;  
			}
			set 
			{ 
				CheckElementRestriction(8, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PackageWidth"); // remove selection
				m_IsValidPackageWidth = true;
				m_PackageWidth = value;
			}
		}
		/// <summary>
		/// Indicates if PackageWidth contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for PackageWidth is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get PackageWidth
		/// will raise an exception.
		/// </remarks>
		public bool IsValidPackageWidth
		{
			get
			{
				return m_IsValidPackageWidth;
			}
			set 
			{ 
				if (value != m_IsValidPackageWidth)
				{
					PackageWidth = 0F;
					m_IsValidPackageWidth = value;
				}
			}
		}
		protected bool m_IsValidPackageWidth;
		protected float m_PackageWidth;
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


