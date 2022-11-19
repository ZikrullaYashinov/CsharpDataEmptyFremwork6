namespace z.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopdbV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        units = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.products");
        }
    }
}
