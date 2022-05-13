using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class Initialize2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryAddRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAddRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberComp = table.Column<int>(type: "int", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyborad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headphones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monitor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayTime = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDiscount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypePay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryComputer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryComputer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryComputer_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryComputer_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameComputer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameComputer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameComputer_Computer_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Computer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameComputer_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddRate_CatAddRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddRateId = table.Column<int>(type: "int", nullable: false),
                    CategoryAddId = table.Column<int>(type: "int", nullable: false),
                    CategoryAddRateId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    TypeDiscountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddRate_CatAddRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddRate_CatAddRate_AddRate_AddRateId",
                        column: x => x.AddRateId,
                        principalTable: "AddRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddRate_CatAddRate_CategoryAddRate_CategoryAddRateId",
                        column: x => x.CategoryAddRateId,
                        principalTable: "CategoryAddRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddRate_CatAddRate_TypeDiscount_TypeDiscountId",
                        column: x => x.TypeDiscountId,
                        principalTable: "TypeDiscount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatCompId = table.Column<int>(type: "int", nullable: false),
                    CategoryComputerId = table.Column<int>(type: "int", nullable: true),
                    DateTimeBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    IsBusy = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_CategoryComputer_CategoryComputerId",
                        column: x => x.CategoryComputerId,
                        principalTable: "CategoryComputer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormCheck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateId = table.Column<int>(type: "int", nullable: false),
                    PayId = table.Column<int>(type: "int", nullable: false),
                    TypaPayId = table.Column<int>(type: "int", nullable: true),
                    CatCompId = table.Column<int>(type: "int", nullable: false),
                    CategoryComputerId = table.Column<int>(type: "int", nullable: true),
                    AddRateId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    isEarly = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCheck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormCheck_AddRate_AddRateId",
                        column: x => x.AddRateId,
                        principalTable: "AddRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormCheck_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormCheck_CategoryComputer_CategoryComputerId",
                        column: x => x.CategoryComputerId,
                        principalTable: "CategoryComputer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormCheck_Rate_RateId",
                        column: x => x.RateId,
                        principalTable: "Rate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormCheck_TypePay_TypaPayId",
                        column: x => x.TypaPayId,
                        principalTable: "TypePay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormCheck_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddRate_CatAddRate_AddRateId",
                table: "AddRate_CatAddRate",
                column: "AddRateId");

            migrationBuilder.CreateIndex(
                name: "IX_AddRate_CatAddRate_CategoryAddRateId",
                table: "AddRate_CatAddRate",
                column: "CategoryAddRateId");

            migrationBuilder.CreateIndex(
                name: "IX_AddRate_CatAddRate_TypeDiscountId",
                table: "AddRate_CatAddRate",
                column: "TypeDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CategoryComputerId",
                table: "Booking",
                column: "CategoryComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UsersId",
                table: "Booking",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryComputer_CategoryId",
                table: "CategoryComputer",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryComputer_ComputerId",
                table: "CategoryComputer",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_AddRateId",
                table: "FormCheck",
                column: "AddRateId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_BookingId",
                table: "FormCheck",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_CategoryComputerId",
                table: "FormCheck",
                column: "CategoryComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_RateId",
                table: "FormCheck",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_TypaPayId",
                table: "FormCheck",
                column: "TypaPayId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCheck_UsersID",
                table: "FormCheck",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_GameComputer_ComputerId",
                table: "GameComputer",
                column: "ComputerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameComputer_GameId",
                table: "GameComputer",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddRate_CatAddRate");

            migrationBuilder.DropTable(
                name: "FormCheck");

            migrationBuilder.DropTable(
                name: "GameComputer");

            migrationBuilder.DropTable(
                name: "CategoryAddRate");

            migrationBuilder.DropTable(
                name: "TypeDiscount");

            migrationBuilder.DropTable(
                name: "AddRate");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "TypePay");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "CategoryComputer");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Computer");
        }
    }
}
