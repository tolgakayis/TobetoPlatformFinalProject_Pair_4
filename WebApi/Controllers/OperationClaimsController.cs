﻿using Business.Abstracts;
using Business.Dtos.OperationClaim.Requests;
using Business.Dtos.UserOperationClaim.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimsController : ControllerBase
    {
        private readonly IOperationClaimService _operationClaimService;
        public OperationClaimsController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync([FromBody] CreateOperationClaimRequest operationClaimRequest)
        {
            var result = await _operationClaimService.AddAsync(operationClaimRequest);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            var result = await _operationClaimService.UpdateAsync(updateOperationClaimRequest);
            return Ok(result);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteOperationClaimRequest deleteOperationClaimRequest)
        {
            var result = await _operationClaimService.DeleteAsync(deleteOperationClaimRequest);
            return Ok(result);
        }

        [HttpGet("GetList")]
        public async Task<IActionResult> GetListAsync()
        {
            var result = await _operationClaimService.GetListAsync();
            return Ok(result);
        }

        [HttpPost("AssignToUser")]
        public async Task<IActionResult> AssigntToUser([FromBody] CreateUserOperationClaimRequest createUserOperationClaimRequest)
        {
            var result = await _operationClaimService.AssignOperationClaimAsync(createUserOperationClaimRequest);
            return Ok(result);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync([FromQuery] GetOperationClaimRequest getOperationClaimRequest)
        {
            var result = await _operationClaimService.GetByIdAsync(getOperationClaimRequest);
            return Ok(result);
        }
    }
}
