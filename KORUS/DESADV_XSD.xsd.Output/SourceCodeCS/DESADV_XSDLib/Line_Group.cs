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
	/// This class represents the Element Line_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"Line_Group", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Line_Group : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Line_Group
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Line_Group()
		{
			_elementName = "Line_Group";
			Init();
		}
		public Line_Group(string elementName)
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
			m_Line_Item = null;
			m_Line_Parties = null;
			m_Line_Measurements = null;
			m_Line_Order = null;
			m_Package_Reference = new DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Package_Reference>("Package-Reference", "", 0, -1, false);
			m_Package_Reference.OnCollectionChange += new DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Package_Reference>.OnCollectionChangeEvent(this.Package_Reference_OnChange);

			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Line_Item = null;
			m_Line_Parties = null;
			m_Line_Measurements = null;
			m_Line_Order = null;
			if (m_Package_Reference != null)
			{
				if ("Package_Reference" != selectedElement)
					m_Package_Reference.Clear();
			}
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
			DESADV_XSDLib.Line_Group newObject = new DESADV_XSDLib.Line_Group(_elementName);
			newObject.m_Line_Item = null;
			if (m_Line_Item != null)
				newObject.m_Line_Item = (DESADV_XSDLib.Line_Item)m_Line_Item.Clone();
			newObject.m_Line_Parties = null;
			if (m_Line_Parties != null)
				newObject.m_Line_Parties = (DESADV_XSDLib.Line_Parties)m_Line_Parties.Clone();
			newObject.m_Line_Measurements = null;
			if (m_Line_Measurements != null)
				newObject.m_Line_Measurements = (DESADV_XSDLib.Line_Measurements)m_Line_Measurements.Clone();
			newObject.m_Line_Order = null;
			if (m_Line_Order != null)
				newObject.m_Line_Order = (DESADV_XSDLib.Line_Order)m_Line_Order.Clone();
			foreach (DESADV_XSDLib.Package_Reference o in m_Package_Reference)
				newObject.m_Package_Reference.Add((DESADV_XSDLib.Package_Reference)o.Clone());

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

		#region Attribute - Line-Item
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Line-Item", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Line_Item))]
		public DESADV_XSDLib.Line_Item Line_Item
		{
			get
			{ 
				return m_Line_Item;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Line_Item"); // remove selection
				if (value == null)
					m_Line_Item = null;
				else
				{
					m_Line_Item = value; 
				}
			}
		}
		protected DESADV_XSDLib.Line_Item m_Line_Item;
		
		#endregion

		#region Attribute - Line-Parties
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Line-Parties", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Line_Parties))]
		public DESADV_XSDLib.Line_Parties Line_Parties
		{
			get
			{ 
				return m_Line_Parties;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Line_Parties"); // remove selection
				if (value == null)
					m_Line_Parties = null;
				else
				{
					m_Line_Parties = value; 
				}
			}
		}
		protected DESADV_XSDLib.Line_Parties m_Line_Parties;
		
		#endregion

		#region Attribute - Line-Measurements
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Line-Measurements", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Line_Measurements))]
		public DESADV_XSDLib.Line_Measurements Line_Measurements
		{
			get
			{ 
				return m_Line_Measurements;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Line_Measurements"); // remove selection
				if (value == null)
					m_Line_Measurements = null;
				else
				{
					m_Line_Measurements = value; 
				}
			}
		}
		protected DESADV_XSDLib.Line_Measurements m_Line_Measurements;
		
		#endregion

		#region Attribute - Line-Order
		/// <summary>
		/// Represents an optional Element in the XML document
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// It is optional, initially it is null.
		/// Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Line-Order", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(DESADV_XSDLib.Line_Order))]
		public DESADV_XSDLib.Line_Order Line_Order
		{
			get
			{ 
				return m_Line_Order;
			}
			set
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Line_Order"); // remove selection
				if (value == null)
					m_Line_Order = null;
				else
				{
					m_Line_Order = value; 
				}
			}
		}
		protected DESADV_XSDLib.Line_Order m_Line_Order;
		
		#endregion

		#region Attribute - Package-Reference
		/// <summary>
		/// A collection of Package_References
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// This collection may contain 0 to Many objects.
		/// Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 0 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("Package-Reference", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Package_Reference> Package_Reference
		{
			get { return m_Package_Reference; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void Package_Reference_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "Package_Reference")
			{
				ClearChoice(m_Package_Reference.Count == 0?"":"Package_Reference"); // remove selection
			}
		}
		protected DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Package_Reference> m_Package_Reference;

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


