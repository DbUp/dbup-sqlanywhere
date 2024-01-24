using DbUp.Builder;
using DbUp.Tests.Common;

namespace DbUp.SqlAnywhere.Tests;

public class DatabaseSupportTests : DatabaseSupportTestsBase
{
    public DatabaseSupportTests() : base()
    {
    }

    protected override UpgradeEngineBuilder DeployTo(SupportedDatabases to)
        => to.SqlAnywhereDatabase("");

    protected override UpgradeEngineBuilder AddCustomNamedJournalToBuilder(UpgradeEngineBuilder builder, string schema, string tableName)
        => builder.JournalTo(
            (connectionManagerFactory, logFactory)
                => new SqlAnywhereTableJournal(connectionManagerFactory, logFactory, schema, tableName)
        );
}
