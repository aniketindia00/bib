﻿#region < References >
using System;
using System.Xml;
using FluentNHibernate;
using FluentNHibernate.AutoMap;
using FluentNHibernate.AutoMap.Alterations;
using FluentNHibernate.Mapping;
using Infoboard.Core;
using SharpArch.Data.NHibernate.FluentNHibernate;

#endregion

namespace Infoboard.Data.NHibernateMaps
{
    public class UserMap : IAutoMappingOverride<User>
    {
        public void Override(AutoMap<User> mapping) {
            mapping.Id(x => x.Id)
                .WithUnsavedValue(0)
                .GeneratedBy
                .Identity();

            mapping.Map(x => x.Username);

            mapping.HasMany(x => x.Charts)
                .Inverse()
                .KeyColumnNames.Add("UserID")
                .LazyLoad()
                .AsBag();

            mapping.HasMany(x => x.Boards)
                .Inverse()
                .KeyColumnNames.Add("UserID")
                .LazyLoad()
                .AsBag();

            mapping.HasManyToMany<Board>(x => x.Rotation)
                .WithTableName("Rotations").Inverse()
                .WithParentKeyColumn("UserID")
                .WithChildKeyColumn("ChartID")
                .LazyLoad()
                .AsBag();
        }
    }
}