using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Text;

namespace SerializationProject
{
   
    public class Person:ISerializable
    {
        private string _FirstName;
        private string _LastName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public Person()
        { 
        }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        void ISerializable.GetObjectData(SerializationInfo oInfo, StreamingContext oContext)
        {
            oInfo.AddValue("FirstName", this.FirstName);
            oInfo.AddValue("LastName", this.LastName);
        }
    }
}
