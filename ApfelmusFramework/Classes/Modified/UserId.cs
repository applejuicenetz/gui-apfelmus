﻿//-----------------------------------------------------------------------
// <copyright file="UserId.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
namespace ApfelmusFramework.Classes.Modified
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class UserId
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id
        {
            get;
            set;
        }
    }
}
