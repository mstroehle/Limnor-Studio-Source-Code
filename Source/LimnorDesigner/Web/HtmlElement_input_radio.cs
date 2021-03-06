﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Programming Language Implement
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using Limnor.WebBuilder;

namespace LimnorDesigner.Web
{
	public class HtmlElement_input_radio : HtmlElement_input
	{
		public HtmlElement_input_radio(ClassPointer owner)
			: base(owner)
		{
		}
		public HtmlElement_input_radio(ClassPointer owner, string id, Guid guid)
			: base(owner, id, guid)
		{
		}
		public override string type
		{
			get { return "radio"; }
		}

		[Description("Gets and sets the state of a radio button")]
		[Browsable(false)]
		[XmlIgnore]
		[WebClientMember]
		public bool Checked
		{
			get;
			set;
		}
	}
}
