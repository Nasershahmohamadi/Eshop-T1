﻿using DM.Domain.CustomerAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Mapping
{
    public class CustomerDiscountMapping : IEntityTypeConfiguration<CustomerDiscount>
    {
        public void Configure(EntityTypeBuilder<CustomerDiscount> builder)
        {
            builder.HasKey(x => x.Id);
            
        }
    }
}
