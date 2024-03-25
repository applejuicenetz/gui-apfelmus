//-----------------------------------------------------------------------
// <copyright file="FileSystem.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
namespace ApfelmusFramework.Classes.Allgemein
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class FileSystem
    {
        [XmlAttribute(AttributeName = "seperator")]
        public string Seperator
        {
            get;
            set;
        }
    }
}
