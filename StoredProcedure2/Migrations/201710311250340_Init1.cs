namespace StoredProcedure2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PermanentAddress = c.String(),
                        StateId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Id)
                .Index(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.CustomerViewModel_Insert",
                p => new
                    {
                        Name = p.String(),
                        Email = p.String(),
                        PermanentAddress = p.String(),
                        StateId = p.Int(),
                        CityId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Address]([PermanentAddress], [StateId], [CityId])
                      VALUES (@PermanentAddress, @StateId, @CityId)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Address]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      INSERT [dbo].[Customers]([Id], [Name], [Email])
                      VALUES (@Id, @Name, @Email)
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Address] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.CustomerViewModel_Update",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Email = p.String(),
                        PermanentAddress = p.String(),
                        StateId = p.Int(),
                        CityId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Address]
                      SET [PermanentAddress] = @PermanentAddress, [StateId] = @StateId, [CityId] = @CityId
                      WHERE ([Id] = @Id)
                      
                      UPDATE [dbo].[Customers]
                      SET [Name] = @Name, [Email] = @Email
                      WHERE ([Id] = @Id)
                      AND @@ROWCOUNT > 0"
            );
            
            CreateStoredProcedure(
                "dbo.CustomerViewModel_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Customers]
                      WHERE ([Id] = @Id)
                      
                      DELETE [dbo].[Address]
                      WHERE ([Id] = @Id)
                      AND @@ROWCOUNT > 0"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.CustomerViewModel_Delete");
            DropStoredProcedure("dbo.CustomerViewModel_Update");
            DropStoredProcedure("dbo.CustomerViewModel_Insert");
            DropForeignKey("dbo.Customers", "Id", "dbo.Address");
            DropIndex("dbo.Customers", new[] { "Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Address");
        }
    }
}
