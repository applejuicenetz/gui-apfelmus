//-----------------------------------------------------------------------
// <copyright file="FileInformation.cs" company="appleJuiceNETZ">
//     Copyright (c) appleJuiceNETZ.
// </copyright>
// <author>daredevil</author>
//-----------------------------------------------------------------------
namespace Apfelmus.Classes.DownloadPartlist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class FileInformation
    {
        [XmlAttribute(AttributeName = "filesize")]
        public int Filesize
        {
            get;
            set;
        }
    }
}
