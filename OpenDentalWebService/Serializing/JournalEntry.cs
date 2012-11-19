using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Drawing;

namespace OpenDentalWebService {
	///<summary>This file is generated automatically by the crud, do not make any changes to this file because they will get overwritten.</summary>
	public class JournalEntry {

		///<summary></summary>
		public static string Serialize(OpenDentBusiness.JournalEntry journalentry) {
			StringBuilder sb=new StringBuilder();
			sb.Append("<JournalEntry>");
			sb.Append("<JournalEntryNum>").Append(journalentry.JournalEntryNum).Append("</JournalEntryNum>");
			sb.Append("<TransactionNum>").Append(journalentry.TransactionNum).Append("</TransactionNum>");
			sb.Append("<AccountNum>").Append(journalentry.AccountNum).Append("</AccountNum>");
			sb.Append("<DateDisplayed>").Append(journalentry.DateDisplayed.ToString("yyyyMMddHHmmss")).Append("</DateDisplayed>");
			sb.Append("<DebitAmt>").Append(journalentry.DebitAmt).Append("</DebitAmt>");
			sb.Append("<CreditAmt>").Append(journalentry.CreditAmt).Append("</CreditAmt>");
			sb.Append("<Memo>").Append(SerializeStringEscapes.EscapeForXml(journalentry.Memo)).Append("</Memo>");
			sb.Append("<Splits>").Append(SerializeStringEscapes.EscapeForXml(journalentry.Splits)).Append("</Splits>");
			sb.Append("<CheckNumber>").Append(SerializeStringEscapes.EscapeForXml(journalentry.CheckNumber)).Append("</CheckNumber>");
			sb.Append("<ReconcileNum>").Append(journalentry.ReconcileNum).Append("</ReconcileNum>");
			sb.Append("</JournalEntry>");
			return sb.ToString();
		}

		///<summary></summary>
		public static OpenDentBusiness.JournalEntry Deserialize(string xml) {
			OpenDentBusiness.JournalEntry journalentry=new OpenDentBusiness.JournalEntry();
			using(XmlReader reader=XmlReader.Create(new StringReader(xml))) {
				reader.MoveToContent();
				while(reader.Read()) {
					//Only detect start elements.
					if(!reader.IsStartElement()) {
						continue;
					}
					switch(reader.Name) {
						case "JournalEntryNum":
							journalentry.JournalEntryNum=System.Convert.ToInt64(reader.ReadContentAsString());
							break;
						case "TransactionNum":
							journalentry.TransactionNum=System.Convert.ToInt64(reader.ReadContentAsString());
							break;
						case "AccountNum":
							journalentry.AccountNum=System.Convert.ToInt64(reader.ReadContentAsString());
							break;
						case "DateDisplayed":
							journalentry.DateDisplayed=DateTime.ParseExact(reader.ReadContentAsString(),"yyyyMMddHHmmss",null);
							break;
						case "DebitAmt":
							journalentry.DebitAmt=System.Convert.ToDouble(reader.ReadContentAsString());
							break;
						case "CreditAmt":
							journalentry.CreditAmt=System.Convert.ToDouble(reader.ReadContentAsString());
							break;
						case "Memo":
							journalentry.Memo=reader.ReadContentAsString();
							break;
						case "Splits":
							journalentry.Splits=reader.ReadContentAsString();
							break;
						case "CheckNumber":
							journalentry.CheckNumber=reader.ReadContentAsString();
							break;
						case "ReconcileNum":
							journalentry.ReconcileNum=System.Convert.ToInt64(reader.ReadContentAsString());
							break;
					}
				}
			}
			return journalentry;
		}


	}
}