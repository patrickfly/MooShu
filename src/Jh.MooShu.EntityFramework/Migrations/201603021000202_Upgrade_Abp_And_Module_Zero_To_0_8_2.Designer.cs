// <auto-generated />
namespace Jh.MooShu.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Upgrade_Abp_And_Module_Zero_To_0_8_2 : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Upgrade_Abp_And_Module_Zero_To_0_8_2));
        
        string IMigrationMetadata.Id
        {
            get { return "201603021000202_Upgrade_Abp_And_Module_Zero_To_0_8_2"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
