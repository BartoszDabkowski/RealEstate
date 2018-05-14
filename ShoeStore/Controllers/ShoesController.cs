using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Core;
using ShoeStore.Controllers.Resources;
using ShoeStore.Core;
using ShoeStore.Core.Models;
using ShoeStore.Persistence;

namespace ShoeStore.Controllers
{
    [Route("api/shoes")]    
    public class ShoesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ShoesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? 
                throw new System.ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ??
                throw new System.ArgumentNullException(nameof(mapper));
        }

    //    [HttpGet]
    //    public async Task<QueryResultResource<ShoeResource>> GetShoesAsync(ShoeQueryResource shoeQueryResource)
    //    {
    //        var filter = _mapper.Map<ShoeQueryResource, ShoeQuery>(shoeQueryResource);

    //        var queryResult = await _unitOfWork.Shoes.GetShoesAsync(filter);

    //        return _mapper.Map<QueryResult<Shoe>, QueryResultResource<ShoeResource>>(queryResult);
    //    }

    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> GetShoeAsync(int id)
    //    {
    //        var shoe = await _unitOfWork.Shoes.GetShoeAsync(id);

    //        if(shoe == null)
    //            return NotFound();
    //        // TODO: filter in repo
    //        shoe.Inventory = shoe.Inventory.Where(x => !x.IsDeleted).ToList();

    //        return Ok(_mapper.Map<Shoe, ShoeResource>(shoe));
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> PostShoesAsync([FromBody] SaveShoeResource saveShoeResource)
    //    {
    //        if (saveShoeResource == null)
    //            return BadRequest("null value passed");

    //        if(!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        var shoe = _mapper.Map<SaveShoeResource, Shoe>(saveShoeResource);
    //        _unitOfWork.Shoes.Add(shoe);

    //        foreach (var invent in shoe.Inventory)
    //        {
    //            _unitOfWork.Inventory.Add(invent);
    //        }

    //        await _unitOfWork.CompleteAsync();

    //        shoe = await _unitOfWork.Shoes.GetShoeAsync(shoe.Id);

    //        var result = _mapper.Map<Shoe, SaveShoeResource>(shoe);
            
    //        return Ok(result);
    //    }

    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> UpdateShoesAsync(int id, [FromBody] SaveShoeResource shoeUploadResource)
    //    {
    //        if (shoeUploadResource == null)
    //            return BadRequest("null value passed");

    //        if (!ModelState.IsValid)
    //            return BadRequest(ModelState);

    //        var shoe = await _unitOfWork.Shoes.GetShoeAsync(id);

    //        if(shoe == null)
    //            return NotFound();

    //        _mapper.Map<SaveShoeResource, Shoe>(shoeUploadResource, shoe);

    //        await _unitOfWork.CompleteAsync();

    //        shoe = await _unitOfWork.Shoes.GetShoeAsync(shoe.Id);

    //        var result = _mapper.Map<Shoe, SaveShoeResource>(shoe);
            
    //        return Ok(result);
    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> DeleteShoeAsync(int id){
    //        var shoe = await _unitOfWork.Shoes.GetShoeAsync(id, false);

    //        if(shoe == null)
    //            return NotFound();

    //        shoe.IsDeleted = true;

    //        await _unitOfWork.CompleteAsync();

    //        return Ok(id);
    //    }

    //    [HttpGet("styles")]
    //    public async Task<IEnumerable<KeyValuePairResource>> GetStylesAsync()
    //    {
    //        var styles = await _unitOfWork.Styles.GetStylesAsync();

    //        return _mapper.Map<IEnumerable<Style>,IEnumerable<KeyValuePairResource>>(styles);
    //    }

    //    [HttpGet("colors")]
    //    public async Task<IEnumerable<KeyValuePairResource>> GetColorsAsync()
    //    {
    //        var colors = await _unitOfWork.Colors.GetColorsAsync();

    //        return _mapper.Map<IEnumerable<Color>,IEnumerable<KeyValuePairResource>>(colors);
    //    }

    //    [HttpGet("sizes")]
    //    public async Task<IEnumerable<KeyValuePairResource>> GetSizesAsync()
    //    {
    //        var sizes = await _unitOfWork.Sizes.GetSizesAsync();

    //        return _mapper.Map<IEnumerable<Size>,IEnumerable<KeyValuePairResource>>(sizes);
    //    }
    }
}