using System;
using AutoMapper;
using NUnit.Framework;
using ShoeStore.Controllers.Resources;
using ShoeStore.Mapping;
using System.Collections.Generic;
using DeepEqual.Syntax;
using ShoeStore.Core.Models;

namespace ShoeStore.Tests.MappingProfile
{
    [TestFixture]
    class MappingProfileShoeTests
    {
        private static object _isInitialized = false;
        private Shoe _shoe;
        private ShoeResource _shoeResource;
        private SaveShoeResource _saveShoeResource;

        public MappingProfileShoeTests()
        {
            lock (_isInitialized)
            {
                if ((bool)_isInitialized) return;

                Mapper.Reset();
                Mapper.Initialize(m => m.AddProfile<ShoeStore.Mapping.MappingProfile>());
                _isInitialized = true;
            }
            
        }

        [SetUp]
        public void SetUp()
        {
            var black = new Color { Id = 1, Name = "Black" };
            var brown = new Color { Id = 2, Name = "Brown" };
            var size10 = new Size { Id = 1, Name = 10 };
            var size11 = new Size { Id = 2, Name = 11 };
            var size12 = new Size { Id = 3, Name = 12 };

            _shoe = new Shoe
            {
                Name = "New Shoe",
                BrandId = 1,
                Brand = new Brand { Id = 1, Name = "Brand1" },
                ShoeStyles = new List<ShoeStyle> {
                    new ShoeStyle{Style = new Style{Id = 1, Name = "Style1"}},
                    new ShoeStyle{Style = new Style{Id = 2, Name = "Style2"}}
                },
                Inventory = new List<Inventory>{
                    new Inventory{ShoeId = 1, Size = size10, Color = black},
                    new Inventory{ShoeId = 1, Size = size11, Color= black},
                    new Inventory{ShoeId = 1, Size = size12, Color = black},
                    new Inventory{ShoeId = 1, Size = size10, Color = brown},
                    new Inventory{ShoeId = 1, Size = size11, Color= brown},
                    new Inventory{ShoeId = 1, Size = size12, Color = brown}
                }
            };

            _shoeResource = new ShoeResource
            {
                Name = "New Shoe",
                Brand = new KeyValuePairResource { Id = 1, Name = "Brand1" },
                Styles = new List<KeyValuePairResource>{
                    new KeyValuePairResource { Id = 1, Name = "Style1" },
                    new KeyValuePairResource { Id = 2, Name = "Style2" }
                },
                Colors = new List<KeyValuePairResource>{
                    new KeyValuePairResource { Id = 1, Name = "Black" },
                    new KeyValuePairResource { Id = 2, Name = "Brown" }
                },
                Sizes = new List<KeyValuePairResource>{
                    new KeyValuePairResource { Id = 1, Name = "10" },
                    new KeyValuePairResource { Id = 2, Name = "11" },
                    new KeyValuePairResource { Id = 3, Name = "12" },
                },
            };

            _saveShoeResource = new SaveShoeResource
            {
                BrandId = 1,
                Name = "New Shoe",
                Styles = new List<int> { 1, 2},
                Colors = new List<int> { 1, 2},
                Sizes = new List<int> { 1, 2, 3}
            };
        }

        [Test]
        public void ShoeToShoeResource_IsProperlyMapped_ReturnsTrue()
        {
            var shoeResource = Mapper.Map<Shoe, ShoeResource>(_shoe);

            Assert.IsTrue(shoeResource.IsDeepEqual(_shoeResource));
        }

        [Test]
        public void SaveShoeResourceToShoe_IsProperlyMapped_ReturnsTrue()
        {
            var expectedShoe = new Shoe
            {
                Name = "New Shoe",
                BrandId = 1,
                ShoeStyles = new List<ShoeStyle> {
                    new ShoeStyle{StyleId = 1},
                    new ShoeStyle{StyleId = 2}
                },
                Inventory = new List<Inventory>{
                    new Inventory{ SizeId = 1, ColorId = 1},
                    new Inventory{ SizeId = 2, ColorId = 1},
                    new Inventory{ SizeId = 3, ColorId = 1},
                    new Inventory{ SizeId = 1, ColorId = 2},
                    new Inventory{ SizeId = 2, ColorId = 2},
                    new Inventory{ SizeId = 3, ColorId = 2}
                }
            };

            var shoe = Mapper.Map<SaveShoeResource, Shoe>(_saveShoeResource);

            Assert.IsTrue(expectedShoe.IsDeepEqual(shoe));
        }

        [Test]
        public void ShoeToSaveShoeResource_IsProperlyMapped_ReturnsTrue()
        {
            var expectedSaveShoeResource = new SaveShoeResource
            {
                BrandId = 1,
                Name = "New Shoe",
                Styles = new List<int> { 1, 2 },
                Colors = new List<int> { 1, 2 },
                Sizes = new List<int> { 1, 2, 3 }
            };

            var shoe = new Shoe
            {
                Name = "New Shoe",
                BrandId = 1,
                ShoeStyles = new List<ShoeStyle> {
                    new ShoeStyle{StyleId = 1},
                    new ShoeStyle{StyleId = 2}
                },
                Inventory = new List<Inventory>{
                    new Inventory{ShoeId = 1, SizeId = 1, ColorId = 1},
                    new Inventory{ShoeId = 1, SizeId = 2, ColorId = 1},
                    new Inventory{ShoeId = 1, SizeId = 3, ColorId = 1},
                    new Inventory{ShoeId = 1, SizeId = 1, ColorId = 2},
                    new Inventory{ShoeId = 1, SizeId = 2, ColorId = 2},
                    new Inventory{ShoeId = 1, SizeId = 3, ColorId = 2}
                }
            };

            var saveShoeResource = Mapper.Map<Shoe, SaveShoeResource>(shoe);

            Assert.IsTrue(expectedSaveShoeResource.IsDeepEqual(saveShoeResource));
        }

        [Test]
        public void SaveShoeResourceToShoe_IsUpdated_ReturnsTrue()
        {
            var saveShoeResource = new SaveShoeResource
            {
                BrandId = 2,
                Name = "Updated Shoe",
                Styles = new List<int> { 1 },
                Colors = new List<int> { 1, 3 },
                Sizes = new List<int> { 1, 2, 3 }
            };

            var expectedShoe = new Shoe
            {
                Name = "Updated Shoe",
                BrandId = 2,
                ShoeStyles = new List<ShoeStyle> {
                    new ShoeStyle{StyleId = 1}
                },
                Inventory = new List<Inventory>{
                    new Inventory{ SizeId = 1, ColorId = 1},
                    new Inventory{ SizeId = 2, ColorId = 1},
                    new Inventory{ SizeId = 3, ColorId = 1},
                    new Inventory{ SizeId = 1, ColorId = 2, IsDeleted = true},
                    new Inventory{ SizeId = 2, ColorId = 2, IsDeleted = true},
                    new Inventory{ SizeId = 3, ColorId = 2, IsDeleted = true},
                    new Inventory{ SizeId = 1, ColorId = 3},
                    new Inventory{ SizeId = 2, ColorId = 3},
                    new Inventory{ SizeId = 3, ColorId = 3},
                }
            };

            var ShoeFromDb = new Shoe
            {
                Name = "New Shoe",
                BrandId = 1,
                ShoeStyles = new List<ShoeStyle> {
                    new ShoeStyle{Style = new Style{Id = 1, Name = "Style1"}}
                },
                Inventory = new List<Inventory>{
                    new Inventory{ SizeId = 1, ColorId = 1},
                    new Inventory{ SizeId = 2, ColorId = 1},
                    new Inventory{ SizeId = 3, ColorId = 1},
                    new Inventory{ SizeId = 1, ColorId = 2},
                    new Inventory{ SizeId = 2, ColorId = 2},
                    new Inventory{ SizeId = 3, ColorId = 2}
                }
            };

            var shoe = Mapper.Map<SaveShoeResource, Shoe>(saveShoeResource, ShoeFromDb);

            Assert.IsTrue(expectedShoe.IsDeepEqual(shoe));
        }
    }
}
