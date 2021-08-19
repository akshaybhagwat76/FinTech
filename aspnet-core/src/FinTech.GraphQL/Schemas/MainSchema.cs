using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using FinTech.Queries.Container;
using System;

namespace FinTech.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}