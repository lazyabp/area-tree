using Lazy.Abp.AreaTree.Regions;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    public static class AreaTreeDbContextModelCreatingExtensions
    {
        public static void ConfigureAreaTree(
            this ModelBuilder builder,
            Action<AreaTreeModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AreaTreeModelBuilderConfigurationOptions(
                AreaTreeDbProperties.DbTablePrefix,
                AreaTreeDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */


            builder.Entity<Region>(b =>
            {
                b.ToTable(options.TablePrefix + "Regions", options.Schema);
                b.ConfigureByConvention();

                b.HasIndex(q => q.Code);
                /* Configure more properties here */
            });
        }
    }
}
