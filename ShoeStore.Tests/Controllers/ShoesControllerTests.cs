using AutoMapper;
using Moq;
using NUnit.Framework;
using ShoeStore.Controllers;
using ShoeStore.Controllers.Resources;
using ShoeStore.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DeepEqual.Syntax;
using Microsoft.AspNetCore.Mvc;
using ShoeStore.Core;
using ShoeStore.Core.Models;
using ShoeStore.Mapping;

namespace ShoeStore.Tests.Controllers
{
    [TestFixture]
    public class ShoesControllerTests
    {
        //private readonly Mapper _mapper;

        //public ShoesControllerTests()
        //{
        //    Mapper.Reset();
        //    Mapper.Initialize(m => m.AddProfile<ShoeStore.Mapping.MappingProfile>());

        //    _mapper = new Mapper(new MapperConfiguration(config =>
        //    {
        //        config.AddProfile<ShoeStore.Mapping.MappingProfile>();
        //    }));
        //}

        //#region PostShoeAsync Tests
        //[Test]
        //public async Task PostShoeAsync_WhenCalled_AddShoeAndInventoryToDatabase()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    unitOfWork.Setup(u => u.Shoes.Add(It.IsAny<Shoe>())).Verifiable();
        //    unitOfWork.Setup(u => u.Inventory.Add(It.IsAny<Inventory>())).Verifiable();
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var saveShoeResource = new SaveShoeResource
        //    {
        //        BrandId = 1,
        //        Name = "New Shoe",
        //        Styles = new List<int> { 1, 2 },
        //        Colors = new List<int> { 1, 2 },
        //        Sizes = new List<int> { 1, 2, 3 }
        //    };

        //    await controller.PostShoesAsync(saveShoeResource);

        //    unitOfWork.Verify(s => s.Shoes.Add(It.IsAny<Shoe>()));
        //    unitOfWork.Verify(s => s.Inventory.Add(It.IsAny<Inventory>()));
        //}

        //[Test]
        //public async Task PostShoeAsync_WhenCalled_ReturnsOk()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    unitOfWork.Setup(u => u.Shoes.Add(It.IsAny<Shoe>())).Verifiable();
        //    unitOfWork.Setup(u => u.Inventory.Add(It.IsAny<Inventory>())).Verifiable();
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var saveShoeResource = new SaveShoeResource
        //    {
        //        BrandId = 1,
        //        Name = "New Shoe",
        //        Styles = new List<int> { 1, 2 },
        //        Colors = new List<int> { 1, 2 },
        //        Sizes = new List<int> { 1, 2, 3 }
        //    };

        //    var result = await controller.PostShoesAsync(saveShoeResource) as OkObjectResult;

        //    Assert.IsInstanceOf<OkObjectResult>(result);
        //}

        //[Test]
        //public async Task PostShoeAsync_NullPassed_ReturnsBadRequest()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var result = await controller.PostShoesAsync(null);

        //    Assert.IsInstanceOf<BadRequestObjectResult>(result);
        //}
        //#endregion

        //#region UpdateShoesAsync Tests

        //[Test]
        //public async Task UpdateShoesAsync_ShoeNotInDatabase_ReturnsNotFound()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    unitOfWork.Setup(u => u.Shoes.GetShoeAsync(It.IsAny<int>(), true)).Returns(Task.FromResult<Shoe>(null));
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var result = await controller.UpdateShoesAsync(It.IsAny<int>(), new SaveShoeResource());

        //    Assert.IsInstanceOf<NotFoundResult>(result);
        //}
        //#endregion

        //#region DeleteShoeAsync Tests
        //[Test]
        //public async Task DeleteShoeAsync_ShoeInDatabase_ReturnsOk()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    unitOfWork.Setup(u => u.Shoes.GetShoeAsync(It.IsAny<int>(), false)).Returns(Task.FromResult(new Shoe()));
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var result = await controller.DeleteShoeAsync(It.IsAny<int>());

        //    Assert.IsInstanceOf<OkObjectResult>(result);
        //}

        //[Test]
        //public async Task DeleteShoeAsync_ShoeNotInDatabase_ReturnsNotFound()
        //{
        //    var unitOfWork = new Mock<IUnitOfWork>();
        //    unitOfWork.Setup(u => u.Shoes.GetShoeAsync(It.IsAny<int>(), false)).Returns(Task.FromResult<Shoe>(null));
        //    var controller = new ShoesController(unitOfWork.Object, _mapper);

        //    var result = await controller.DeleteShoeAsync(It.IsAny<int>());

        //    Assert.IsInstanceOf<NotFoundResult>(result);
        //}
        //#endregion
    }
}
