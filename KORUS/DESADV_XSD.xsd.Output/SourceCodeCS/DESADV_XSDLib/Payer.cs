﻿using System;
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
	/// This class represents the Element Payer
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Payer", "", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Payer : DESADV_XSDLib.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		/// Constructor for Payer
		/// </summary>
		/// <remarks>
		/// The class is created with all the mandatory fields populated with the
		/// default data. 
		/// All Collection object are created.
		/// However any 1-n relationships (these are represented as collections) are
		/// empty. To comply with the schema these must be populated before the xml
		/// obtained from ToXml is valid against the schema C:\BTS\XSD\KORUS\DESADV_XSD.xsd
		/// </remarks>
		public Payer()
		{
			_elementName = "Payer";
			Init();
		}
		public Payer(string elementName)
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
			m_Payer_Group = new DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Payer_Group>("Payer_Group", "", 0, -1, true);

// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
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
			DESADV_XSDLib.Payer newObject = new DESADV_XSDLib.Payer(_elementName);
			foreach (DESADV_XSDLib.Payer_Group o in m_Payer_Group)
				newObject.m_Payer_Group.Add((DESADV_XSDLib.Payer_Group)o.Clone());

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

		#region Attribute - Payer_Group
		/// <summary>
		/// A collection of Payer_Groups
		/// 
		/// </summary>
		/// <remarks>
		/// This property is represented as an Element in the XML.
		/// This collection may contain 0 to Many objects.
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Payer_Group", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Payer_Group> Payer_Group
		{
			get { return m_Payer_Group; }
		}
		protected DESADV_XSDLib.XmlObjectCollection<DESADV_XSDLib.Payer_Group> m_Payer_Group;

		#endregion

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


