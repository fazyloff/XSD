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
	/// This class represents the Element Order-Measurement_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Order-Measurement_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Order_Measurement_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Order_Measurement_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Order_Measurement_Group()
		{
			_elementName = "Order-Measurement_Group";
			Init();
		}
		public Order_Measurement_Group(string elementName)
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
			m_AdditionalQuantity = "";
			m_IsValidAdditionalQuantity = false;
			m_AdditionalUnitOfMeasure = "";
			m_IsValidAdditionalUnitOfMeasure = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_AdditionalQuantity = "";
			m_IsValidAdditionalQuantity = false;
			m_AdditionalUnitOfMeasure = "";
			m_IsValidAdditionalUnitOfMeasure = false;
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
			DESADV_XSDLib.Order_Measurement_Group newObject = new DESADV_XSDLib.Order_Measurement_Group(_elementName);
			newObject.m_AdditionalQuantity = m_AdditionalQuantity;
			newObject.m_IsValidAdditionalQuantity = m_IsValidAdditionalQuantity;
			newObject.m_AdditionalUnitOfMeasure = m_AdditionalUnitOfMeasure;
			newObject.m_IsValidAdditionalUnitOfMeasure = m_IsValidAdditionalUnitOfMeasure;

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

		#region Attribute - AdditionalQuantity
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AdditionalQuantity", "", "IsValidAdditionalQuantity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string AdditionalQuantity
		{
			get 
			{ 
				if (m_IsValidAdditionalQuantity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AdditionalQuantity is not valid. Set AdditionalQuantityValid = true");
				return m_AdditionalQuantity;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AdditionalQuantity"); // remove selection
				m_IsValidAdditionalQuantity = true;
				m_AdditionalQuantity = value;
			}
		}
		/// <summary>
		/// Indicates if AdditionalQuantity contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AdditionalQuantity is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AdditionalQuantity
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAdditionalQuantity
		{
			get
			{
				return m_IsValidAdditionalQuantity;
			}
			set 
			{ 
				if (value != m_IsValidAdditionalQuantity)
				{
					AdditionalQuantity = "";
					m_IsValidAdditionalQuantity = value;
				}
			}
		}
		protected bool m_IsValidAdditionalQuantity;
		protected string m_AdditionalQuantity;
		#endregion

		#region Attribute - AdditionalUnitOfMeasure
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("AdditionalUnitOfMeasure", "", "IsValidAdditionalUnitOfMeasure", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", "-1", "-1", "", "", "", "", "-1")]
		public string AdditionalUnitOfMeasure
		{
			get 
			{ 
				if (m_IsValidAdditionalUnitOfMeasure == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AdditionalUnitOfMeasure is not valid. Set AdditionalUnitOfMeasureValid = true");
				return m_AdditionalUnitOfMeasure;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("AdditionalUnitOfMeasure"); // remove selection
				m_IsValidAdditionalUnitOfMeasure = true;
				m_AdditionalUnitOfMeasure = value;
			}
		}
		/// <summary>
		/// Indicates if AdditionalUnitOfMeasure contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for AdditionalUnitOfMeasure is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value ("").
		/// If its set to false then its made invalid, and subsequent calls to get AdditionalUnitOfMeasure
		/// will raise an exception.
		/// </remarks>
		public bool IsValidAdditionalUnitOfMeasure
		{
			get
			{
				return m_IsValidAdditionalUnitOfMeasure;
			}
			set 
			{ 
				if (value != m_IsValidAdditionalUnitOfMeasure)
				{
					AdditionalUnitOfMeasure = "";
					m_IsValidAdditionalUnitOfMeasure = value;
				}
			}
		}
		protected bool m_IsValidAdditionalUnitOfMeasure;
		protected string m_AdditionalUnitOfMeasure;
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


