package com.opendental.odweb.client.tabletypes;

import com.google.gwt.xml.client.Document;
import com.google.gwt.xml.client.XMLParser;
import com.opendental.odweb.client.remoting.Serializing;
import com.google.gwt.i18n.client.DateTimeFormat;
import java.util.Date;

public class ICD9 {
		/** Primary key. */
		public int ICD9Num;
		/** Not allowed to edit this column once saved in the database. */
		public String ICD9Code;
		/** Description. */
		public String Description;
		/** The last date and time this row was altered.  Not user editable. */
		public Date DateTStamp;

		/** Deep copy of object. */
		public ICD9 Copy() {
			ICD9 icd9=new ICD9();
			icd9.ICD9Num=this.ICD9Num;
			icd9.ICD9Code=this.ICD9Code;
			icd9.Description=this.Description;
			icd9.DateTStamp=this.DateTStamp;
			return icd9;
		}

		/** Serialize the object into XML. */
		public String SerializeToXml() {
			StringBuilder sb=new StringBuilder();
			sb.append("<ICD9>");
			sb.append("<ICD9Num>").append(ICD9Num).append("</ICD9Num>");
			sb.append("<ICD9Code>").append(Serializing.EscapeForXml(ICD9Code)).append("</ICD9Code>");
			sb.append("<Description>").append(Serializing.EscapeForXml(Description)).append("</Description>");
			sb.append("<DateTStamp>").append(DateTimeFormat.getFormat("yyyyMMddHHmmss").format(DateTStamp)).append("</DateTStamp>");
			sb.append("</ICD9>");
			return sb.toString();
		}

		/** Sets the variables for this object based on the values from the XML.
		 * @param xml The XML passed in must be valid and contain a node for every variable on this object.
		 * @throws Exception Deserialize is encased in a try catch and will pass any thrown exception on. */
		public void DeserializeFromXml(String xml) throws Exception {
			try {
				Document doc=XMLParser.parse(xml);
				if(Serializing.GetXmlNodeValue(doc,"ICD9Num")!=null) {
					ICD9Num=Integer.valueOf(Serializing.GetXmlNodeValue(doc,"ICD9Num"));
				}
				if(Serializing.GetXmlNodeValue(doc,"ICD9Code")!=null) {
					ICD9Code=Serializing.GetXmlNodeValue(doc,"ICD9Code");
				}
				if(Serializing.GetXmlNodeValue(doc,"Description")!=null) {
					Description=Serializing.GetXmlNodeValue(doc,"Description");
				}
				if(Serializing.GetXmlNodeValue(doc,"DateTStamp")!=null) {
					DateTStamp=DateTimeFormat.getFormat("yyyyMMddHHmmss").parseStrict(Serializing.GetXmlNodeValue(doc,"DateTStamp"));
				}
			}
			catch(Exception e) {
				throw e;
			}
		}


}