using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Context;
using Domain.Models;
using Management.Models.EmployeeDtos;
using Management.Models.ReponseDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Management.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : BaseController
    {
        public EmployeeController(RepositoryContext context) : base(context)
        {
        }
        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)ResponseStatus.OK)]
        [ProducesResponseType((int)ResponseStatus.Fail)]
        public ResponseModel<IEnumerable<Employee>> Get()
        {
            var result = new ResponseModel<IEnumerable<Employee>>
            {
                Status = ResponseStatus.Fail
            };
            Expression<Func<Employee, bool>> exp = a => true;
            var employees = context.Employee.Where(exp).AsEnumerable();

            result.Data = employees;
            result.Status = ResponseStatus.OK;
            return result;
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)ResponseStatus.OK)]
        [ProducesResponseType((int)ResponseStatus.Fail)]
        public ResponseModel<Employee> Get(int id)
        {
            var result = new ResponseModel<Employee>
            {
                Status = ResponseStatus.Fail
            };
            Expression<Func<Employee, bool>> exp = a => a.Id == id;
            var employee = context.Employee.Where(exp).AsEnumerable().FirstOrDefault();

            result.Data = employee;
            result.Status = ResponseStatus.OK;
            return result;
        }

        [HttpPost]
        public ResponseModel<bool> Post([FromBody] EmployeeInputDto employee)
        {
            var result = new ResponseModel<bool>
            {
                Status = ResponseStatus.Fail
            };
            if (!ModelState.IsValid)
            {
                var errors = string.Join(" ", ModelState.Values.Select(x => string.Join(" ", x.Errors.Select(e => e.ErrorMessage))));
                result.Message = errors;
                result.Status = ResponseStatus.Fail;
                return result;
            }

            return result;
        }

    }
}
