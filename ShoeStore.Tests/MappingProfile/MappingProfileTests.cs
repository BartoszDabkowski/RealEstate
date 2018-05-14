using System;
using AutoMapper;
using NUnit.Framework;
using ShoeStore.Controllers.Resources;
using ShoeStore.Mapping;
using System.Collections.Generic;

namespace ShoeStore.Tests.MappingProfile
{
    [TestFixture]
    public class MappingProfileTests
    {
        public MappingProfileTests()
        {
            Mapper.Reset();
            Mapper.Initialize(m => m.AddProfile<ShoeStore.Mapping.MappingProfile>());
        }

        [Test]
        public void MappingProfile_IsProperlyMapped_ReturnsTrue()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
