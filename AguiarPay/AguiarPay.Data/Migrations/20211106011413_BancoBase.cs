using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AguiarPay.Data.Migrations
{
    public partial class BancoBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComandasColetivas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandasColetivas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComandasIndividuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandasIndividuais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidosColetivos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComandaColetivaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosColetivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosColetivos_ComandasColetivas_ComandaColetivaId",
                        column: x => x.ComandaColetivaId,
                        principalTable: "ComandasColetivas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidosIndividuais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComandaIndividualId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosIndividuais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosIndividuais_ComandasIndividuais_ComandaIndividualId",
                        column: x => x.ComandaIndividualId,
                        principalTable: "ComandasIndividuais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    PedidoIndividualId = table.Column<Guid>(nullable: false),
                    PedidoColetivolId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_PedidosColetivos_PedidoColetivolId",
                        column: x => x.PedidoColetivolId,
                        principalTable: "PedidosColetivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_PedidosIndividuais_PedidoIndividualId",
                        column: x => x.PedidoIndividualId,
                        principalTable: "PedidosIndividuais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos",
                column: "ComandaColetivaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidosIndividuais_ComandaIndividualId",
                table: "PedidosIndividuais",
                column: "ComandaIndividualId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoColetivolId",
                table: "Produtos",
                column: "PedidoColetivolId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoIndividualId",
                table: "Produtos",
                column: "PedidoIndividualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "PedidosColetivos");

            migrationBuilder.DropTable(
                name: "PedidosIndividuais");

            migrationBuilder.DropTable(
                name: "ComandasColetivas");

            migrationBuilder.DropTable(
                name: "ComandasIndividuais");
        }
    }
}
