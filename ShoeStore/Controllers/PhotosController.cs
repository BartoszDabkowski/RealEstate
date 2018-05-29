using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RealEstate.Controllers.Resources;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Controllers
{[Route("/api/photos")]
    public class PhotosController : Controller
    {
        private readonly IHostingEnvironment _host;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly PhotoSettings _photoSettings;

        public PhotosController(IHostingEnvironment host, IUnitOfWork unitOfWork, IMapper mapper, IOptionsSnapshot<PhotoSettings> options)
        {
            _host = host;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _photoSettings = options.Value;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<PhotoResource>> GetPhotos(int id)
        {
            var photos = await _unitOfWork.Photos.GetPhotosAsync(id);

            return _mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoResource>>(photos);
        }

    }
}