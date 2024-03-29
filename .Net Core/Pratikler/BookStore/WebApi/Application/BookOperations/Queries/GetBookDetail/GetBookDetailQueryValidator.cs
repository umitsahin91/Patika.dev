﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQueryValidator:AbstractValidator<GetBookDetailQuery>
    {
        public GetBookDetailQueryValidator()
        {
            RuleFor(query => query.BookId).GreaterThan(0);
        }
    }
}
