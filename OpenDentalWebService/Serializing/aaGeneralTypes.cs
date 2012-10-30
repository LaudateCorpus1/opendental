﻿using System;

namespace OpenDentalWebService {
	///<summary>This file is NOT generated automatically by the crud, you must manually make changes to this file.  However, the methods in this class will most likely get called from classes generated by the crud.  Make sure the necessary changes to the crud have been made.  The "Primitive and General Types" region of Remoting.DtoMethods.CallClassDeserializer() is an example where a crud enhancement would need to take place if adding a type to this file.</summary>
	public static class aaGeneralTypes {

		///<summary>Goes through all the possible types of objects and returns the object serialized for Java.</summary>
		public static string Serialize(string typeName,Object obj) {
			if(obj==null) {
				//TODO: Throw an exception here?
				return "";//Or don't do anything?
			}
			//Primitives--------------------------------------------------------------------
			if(typeName=="int") {
				return "<int>"+((int)obj).ToString()+"</int>";
			}
			if(typeName=="long") {//Web app does not use longs.
				//Convert to an integer or handle longs differently.  
				return "<int>"+Convert.ToInt32(((long)obj)).ToString()+"</int>";//If converting fails, throw an exception?
			}
			if(typeName=="bool") {
				return "<boolean>"+(((bool)obj)?"1":"0")+"</boolean>";
			}
			if(typeName=="string") {
				return "<String>"+((string)obj).ToString()+"</String>";
			}
			if(typeName=="char") {
				return "<char>"+((char)obj).ToString()+"</char>";
			}
			if(typeName=="float") {
				return "<float>"+((float)obj).ToString()+"</float>";
			}
			if(typeName=="byte") {
				return "<byte>"+((byte)obj).ToString()+"</byte>";
			}
			if(typeName=="double") {
				return "<double>"+((double)obj).ToString()+"</double>";
			}
			//DataTable---------------------------------------------------------------------
			if(typeName=="DataTable") {
				return "";//Not used just yet.
			}
			//List<?>-----------------------------------------------------------------------
			if(typeName.StartsWith("List<")) {
				return"";//Not sure how to handle lists of objects without reflection just yet...
			}
			//Arrays------------------------------------------------------------------------
			if(typeName.Contains("")){
				return "";//TODO: This will need to be enhanced to handle simple and possibly multidimensional arrays.
			}
			return "";//TODO: Throw an exception for unknown type.
		}

		///<summary>Returns the primitive or general object deserialized.</summary>
		public static object Deserialize(string typeName,string xml) {
			if(typeName=="long") {
				//TODO: Use xmlreader to deserialize the xml and return and object of the desired type.
			}
			return null;//TODO: Throw an exception for unknown type.
		}



	}
}