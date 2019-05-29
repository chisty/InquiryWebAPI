﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InquiryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InquiryWebAPI.CustomAttribute
{
    public class ValidateInquiryAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("payload"))
            {
                if (context.ActionArguments["payload"] is CustomerPayload payload)
                {
                    if (payload.CustomerId.Equals(decimal.MinValue))
                    {
                        if (string.IsNullOrWhiteSpace(payload.Email))
                        {
                            context.Result = new BadRequestObjectResult("No inquiry criteria.");
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(payload.Email) == false && new EmailAddressAttribute().IsValid(payload.Email) == false)
                        {
                            context.Result = new BadRequestObjectResult("Invalid Email.");
                            return;
                        }
                    }

                    if (string.IsNullOrWhiteSpace(payload.Email) && payload.CustomerId > decimal.MinValue && payload.CustomerId <= 0M)
                    {
                        context.Result = new BadRequestObjectResult("Invalid Customer ID.");
                        return;
                    }

                }
            }
            base.OnActionExecuting(context);
        }
    }
}