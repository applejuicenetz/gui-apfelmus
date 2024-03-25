//-----------------------------------------------------------------------
// <copyright file="SettingsShare.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
namespace ApfelmusFramework.Classes.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class SettingsShare
    {
        [XmlElementAttribute(ElementName = "directory")]
        public List<SettingsDirectory> Directory
        {
            get;
            set;
        }
    }
}
