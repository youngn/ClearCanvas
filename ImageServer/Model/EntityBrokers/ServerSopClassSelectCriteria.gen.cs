#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class ServerSopClassSelectCriteria : EntitySelectCriteria
    {
        public ServerSopClassSelectCriteria()
        : base("ServerSopClass")
        {}
        public ServerSopClassSelectCriteria(ServerSopClassSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new ServerSopClassSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerSopClass", ColumnName="SopClassUid")]
        public ISearchCondition<String> SopClassUid
        {
            get
            {
              if (!SubCriteria.ContainsKey("SopClassUid"))
              {
                 SubCriteria["SopClassUid"] = new SearchCondition<String>("SopClassUid");
              }
              return (ISearchCondition<String>)SubCriteria["SopClassUid"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerSopClass", ColumnName="Description")]
        public ISearchCondition<String> Description
        {
            get
            {
              if (!SubCriteria.ContainsKey("Description"))
              {
                 SubCriteria["Description"] = new SearchCondition<String>("Description");
              }
              return (ISearchCondition<String>)SubCriteria["Description"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="ServerSopClass", ColumnName="NonImage")]
        public ISearchCondition<Boolean> NonImage
        {
            get
            {
              if (!SubCriteria.ContainsKey("NonImage"))
              {
                 SubCriteria["NonImage"] = new SearchCondition<Boolean>("NonImage");
              }
              return (ISearchCondition<Boolean>)SubCriteria["NonImage"];
            } 
        }
    }
}