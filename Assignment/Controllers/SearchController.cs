using Assignment.Dto;
using Assignment.Helpers;
using Assignment.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace Assignment.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SearchController(IElasticSearchService elasticSearchService) : ControllerBase
{
    [HttpGet("search")]
    public async Task<IActionResult> SearchSubStoresAsync([FromQuery] QueryObjectDto queryObjectDto)
    {
        if (queryObjectDto.PageSize < 1 || queryObjectDto.Page < 0)
        {
            return BadRequest("Page size must be greater than or equal to 1.");
        }

        var data = await elasticSearchService.SearchSubStoresAsync(
            queryObjectDto.Query, queryObjectDto.Page, queryObjectDto.PageSize);

        return Ok(data);
    }

    [HttpGet("suggestions")]
    public async Task<IActionResult> GetSuggestionsAsync([FromQuery] QueryObjectDto queryObjectDto)
    {
        if (queryObjectDto.PageSize < 1 || queryObjectDto.Page < 0)
        {
            return BadRequest("Page size must be greater than or equal to 1.");
        }

        var keywords = await elasticSearchService.SearchSuggestionKeywordsAsync(
            queryObjectDto.Query, queryObjectDto.Page, queryObjectDto.PageSize);
        return Ok(keywords);
    }

    [HttpGet("most-common-search")]
    public async Task<IActionResult> GetMostCommonKeywordsAsync([FromQuery] int pageSize)
    {
        if (pageSize < 1)
        {
            return BadRequest("Page size must be greater than 0.");
        }

        var topWords = await elasticSearchService.GetMostSearchedWordsAsync(pageSize);
        return Ok(topWords);
    }
}