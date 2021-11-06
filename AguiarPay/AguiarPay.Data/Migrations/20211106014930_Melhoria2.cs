using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AguiarPay.Data.Migrations
{
    public partial class Melhoria2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivolId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoColetivolId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoColetivolId",
                table: "Produtos");

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoColetivoId",
                table: "Produtos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoColetivoId",
                table: "Produtos",
                column: "PedidoColetivoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivoId",
                table: "Produtos",
                column: "PedidoColetivoId",
                principalTable: "PedidosColetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoColetivolId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoColetivolId",
                table: "Produtos",
                column: "PedidoColetivolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivolId",
                table: "Produtos",
                column: "PedidoColetivolId",
                principalTable: "PedidosColetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
