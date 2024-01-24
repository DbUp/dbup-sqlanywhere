using DbUp.Tests.Common;

namespace DbUp.SqlAnywhere.Tests;

public class NoPublicApiChanges : NoPublicApiChangesBase
{
    public NoPublicApiChanges()
        : base(typeof(SqlAnywhereExtensions).Assembly)
    {
    }
}
