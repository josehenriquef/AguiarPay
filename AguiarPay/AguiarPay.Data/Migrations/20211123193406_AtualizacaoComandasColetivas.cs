using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AguiarPay.Data.Migrations
{
    public partial class AtualizacaoComandasColetivas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidosColetivos");

            migrationBuilder.DropTable(
                name: "ComandasColetivas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComandasColetivas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandasColetivas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidosColetivos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComandaColetivaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_PedidosColetivos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos",
                column: "ComandaColetivaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ProdutoId",
                table: "PedidosColetivos",
                column: "ProdutoId");
        }
    }
}
