﻿//-----------------------------------------------------------------------
// <copyright file="Information.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
namespace Apfelmus.Classes.Information
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    
    public class Information
    {
        [XmlElementAttribute(ElementName = "generalinformation")]
        public GeneralInformation GeneralInformation
        {
            get;
            set;
        }
    }
}
