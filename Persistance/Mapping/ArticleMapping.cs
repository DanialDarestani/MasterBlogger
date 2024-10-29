using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.EFCore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            SqlServerPropertyBuilderExtensions.UseIdentityColumn(builder.Property(x => x.Id), 10000, 1);
        }
    }
}
