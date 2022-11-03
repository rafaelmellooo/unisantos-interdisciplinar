﻿// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata;
using Unisantos.TI.Domain.Entities.Address;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Unisantos.TI.Infrastructure.CompiledModels
{
    internal partial class StateEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Unisantos.TI.Domain.Entities.Address.StateEntity",
                typeof(StateEntity),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(string),
                propertyInfo: typeof(StateEntity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(StateEntity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 2);
            id.AddAnnotation("Relational:IsFixedLength", true);

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(StateEntity).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(StateEntity).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "States");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
