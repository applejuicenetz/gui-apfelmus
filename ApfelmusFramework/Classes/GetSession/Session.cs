//-----------------------------------------------------------------------
// <copyright file="Session.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
using System.Xml.Serialization;

namespace ApfelmusFramework.Classes.GetSession
{

    public class Session
    {
        [XmlAttribute(AttributeName = "id")]
        public int id
        {
            get;
            set;
        }
    }
}
