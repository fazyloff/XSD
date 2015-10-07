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
	/// This class represents the Element Line-Measurements_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Line-Measurements_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Line_Measurements_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Line_Measurements_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Line_Measurements_Group()
		{
			_elementName = "Line-Measurements_Group";
			Init();
		}
		public Line_Measurements_Group(string elementName)
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
			m_GrossWeight = 0F;
			m_IsValidGrossWeight = false;
			m_EstimatedGrossWeight = 0F;
			m_IsValidEstimatedGrossWeight = false;
			m_NetVolume = 0F;
			m_IsValidNetVolume = false;

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_GrossWeight = 0F;
			m_IsValidGrossWeight = false;
			m_EstimatedGrossWeight = 0F;
			m_IsValidEstimatedGrossWeight = false;
			m_NetVolume = 0F;
			m_IsValidNetVolume = false;
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
			DESADV_XSDLib.Line_Measurements_Group newObject = new DESADV_XSDLib.Line_Measurements_Group(_elementName);
			newObject.m_GrossWeight = m_GrossWeight;
			newObject.m_IsValidGrossWeight = m_IsValidGrossWeight;
			newObject.m_EstimatedGrossWeight = m_EstimatedGrossWeight;
			newObject.m_IsValidEstimatedGrossWeight = m_IsValidEstimatedGrossWeight;
			newObject.m_NetVolume = m_NetVolume;
			newObject.m_IsValidNetVolume = m_IsValidNetVolume;

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

		#region Attribute - GrossWeight
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("GrossWeight", "", "IsValidGrossWeight", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float GrossWeight
		{
			get 
			{ 
				if (m_IsValidGrossWeight == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property GrossWeight is not valid. Set GrossWeightValid = true");
				return m_GrossWeight;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("GrossWeight"); // remove selection
				m_IsValidGrossWeight = true;
				m_GrossWeight = value;
			}
		}
		/// <summary>
		/// Indicates if GrossWeight contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for GrossWeight is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get GrossWeight
		/// will raise an exception.
		/// </remarks>
		public bool IsValidGrossWeight
		{
			get
			{
				return m_IsValidGrossWeight;
			}
			set 
			{ 
				if (value != m_IsValidGrossWeight)
				{
					GrossWeight = 0F;
					m_IsValidGrossWeight = value;
				}
			}
		}
		protected bool m_IsValidGrossWeight;
		protected float m_GrossWeight;
		#endregion

		#region Attribute - EstimatedGrossWeight
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("EstimatedGrossWeight", "", "IsValidEstimatedGrossWeight", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float EstimatedGrossWeight
		{
			get 
			{ 
				if (m_IsValidEstimatedGrossWeight == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property EstimatedGrossWeight is not valid. Set EstimatedGrossWeightValid = true");
				return m_EstimatedGrossWeight;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("EstimatedGrossWeight"); // remove selection
				m_IsValidEstimatedGrossWeight = true;
				m_EstimatedGrossWeight = value;
			}
		}
		/// <summary>
		/// Indicates if EstimatedGrossWeight contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for EstimatedGrossWeight is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get EstimatedGrossWeight
		/// will raise an exception.
		/// </remarks>
		public bool IsValidEstimatedGrossWeight
		{
			get
			{
				return m_IsValidEstimatedGrossWeight;
			}
			set 
			{ 
				if (value != m_IsValidEstimatedGrossWeight)
				{
					EstimatedGrossWeight = 0F;
					m_IsValidEstimatedGrossWeight = value;
				}
			}
		}
		protected bool m_IsValidEstimatedGrossWeight;
		protected float m_EstimatedGrossWeight;
		#endregion

		#region Attribute - NetVolume
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is not valid.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("NetVolume", "", "IsValidNetVolume", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r4, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", "-1", "-1", "", "", "", "", "-1")]
		public float NetVolume
		{
			get 
			{ 
				if (m_IsValidNetVolume == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property NetVolume is not valid. Set NetVolumeValid = true");
				return m_NetVolume;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("NetVolume"); // remove selection
				m_IsValidNetVolume = true;
				m_NetVolume = value;
			}
		}
		/// <summary>
		/// Indicates if NetVolume contains a valid value.
		/// </summary>
		/// <remarks>
		/// true if the value for NetVolume is valid, false if not.
		/// If this is set to true then the property is considered valid, and assigned its
		/// default value (0F).
		/// If its set to false then its made invalid, and subsequent calls to get NetVolume
		/// will raise an exception.
		/// </remarks>
		public bool IsValidNetVolume
		{
			get
			{
				return m_IsValidNetVolume;
			}
			set 
			{ 
				if (value != m_IsValidNetVolume)
				{
					NetVolume = 0F;
					m_IsValidNetVolume = value;
				}
			}
		}
		protected bool m_IsValidNetVolume;
		protected float m_NetVolume;
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


