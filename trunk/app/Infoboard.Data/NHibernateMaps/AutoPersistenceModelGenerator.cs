using System;
using System.Linq;
using FluentNHibernate;
using FluentNHibernate.AutoMap;
using FluentNHibernate.Conventions;
using SharpArch.Core.DomainModel;
using SharpArch.Data.NHibernate.FluentNHibernate;
using Infoboard.Core;
using Infoboard.Data.NHibernateMaps.Conventions;

namespace Infoboard.Data.NHibernateMaps
{
    public class AutoPersistenceModelGenerator : IAutoPersistenceModelGenerator
    {
        public AutoPersistenceModel Generate()
        {
            AutoPersistenceModel mappings = AutoPersistenceModel
                // If you delete the default class, simply point the following line to an entity within the .Core layer
                .MapEntitiesFromAssemblyOf<Board>()
                .Where(GetAutoMappingFilter)
                .ConventionDiscovery.Setup(GetConventions())
                .WithSetup(GetSetup())
                .UseOverridesFromAssemblyOf<AutoPersistenceModelGenerator>();

            return mappings;
        }

        private static Action<AutoMappingExpressions> GetSetup()
        {
            return c => {
                c.FindIdentity = type => type.Name == "Id";
                c.IsBaseType = IsBaseTypeConvention;
            };
        }

        private static Action<IConventionFinder> GetConventions()
        {
            return c =>
            {
                c.Add<PrimaryKeyConvention>();
                c.Add<ReferenceConvention>();
                c.Add<HasManyConvention>();
                c.Add<TableNameConvention>();
                c.Add<HasManyToManyTableConvention>();
            };
        }

        /// <summary>
        /// Provides a filter for only including types which inherit from the IEntityWithTypedId interface.
        /// </summary>
        private static bool GetAutoMappingFilter(Type t)
        {
            return t.GetInterfaces()
                .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IEntityWithTypedId<>));
        }

        private static bool IsBaseTypeConvention(Type arg)
        {
            bool derivesFromEntity = arg == typeof(Entity);
            bool derivesFromEntityWithTypedId = arg.IsGenericType 
                && (arg.GetGenericTypeDefinition() == typeof(EntityWithTypedId<>));

            return derivesFromEntity || derivesFromEntityWithTypedId;
        }
    }
}
