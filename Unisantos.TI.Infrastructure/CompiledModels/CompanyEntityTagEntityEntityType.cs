﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Unisantos.TI.Infrastructure.CompiledModels
{
    internal partial class CompanyEntityTagEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "CompanyEntityTagEntity",
                typeof(Dictionary<string, object>),
                baseEntityType,
                sharedClrType: true,
                indexerPropertyInfo: RuntimeEntityType.FindIndexerProperty(typeof(Dictionary<string, object>)),
                propertyBag: true);

            var companiesId = runtimeEntityType.AddProperty(
                "CompaniesId",
                typeof(Guid),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);

            var tagsId = runtimeEntityType.AddProperty(
                "TagsId",
                typeof(int),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);

            var key = runtimeEntityType.AddKey(
                new[] { companiesId, tagsId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { tagsId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CompaniesId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("TagsId")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "CompanyTag");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}