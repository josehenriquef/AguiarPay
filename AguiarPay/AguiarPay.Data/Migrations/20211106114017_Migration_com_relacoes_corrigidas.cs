using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AguiarPay.Data.Migrations
{
    public partial class Migration_com_relacoes_corrigidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_PedidosIndividuais_PedidoIndividualId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoIndividualId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_PedidosIndividuais_ComandaIndividualId",
                table: "PedidosIndividuais");

            migrationBuilder.DropIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos");

            migrationBuilder.DropColumn(
                name: "PedidoColetivoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoIndividualId",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "varchar(1000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Produtos",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "PedidosIndividuais",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "PedidosColetivos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PedidosIndividuais_ComandaIndividualId",
                table: "PedidosIndividuais",
                column: "ComandaIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosIndividuais_ProdutoId",
                table: "PedidosIndividuais",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos",
                column: "ComandaColetivaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ProdutoId",
                table: "PedidosColetivos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosColetivos_Produtos_ProdutoId",
                table: "PedidosColetivos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosIndividuais_Produtos_ProdutoId",
                table: "PedidosIndividuais",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidosColetivos_Produtos_ProdutoId",
                table: "PedidosColetivos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosIndividuais_Produtos_ProdutoId",
                table: "PedidosIndividuais");

            migrationBuilder.DropIndex(
                name: "IX_PedidosIndividuais_ComandaIndividualId",
                table: "PedidosIndividuais");

            migrationBuilder.DropIndex(
                name: "IX_PedidosIndividuais_ProdutoId",
                table: "PedidosIndividuais");

            migrationBuilder.DropIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos");

            migrationBuilder.DropIndex(
                name: "IX_PedidosColetivos_ProdutoId",
                table: "PedidosColetivos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "PedidosIndividuais");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "PedidosColetivos");

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoColetivoId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoIndividualId",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoColetivoId",
                table: "Produtos",
                column: "PedidoColetivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoIndividualId",
                table: "Produtos",
                column: "PedidoIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosIndividuais_ComandaIndividualId",
                table: "PedidosIndividuais",
                column: "ComandaIndividualId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidosColetivos_ComandaColetivaId",
                table: "PedidosColetivos",
                column: "ComandaColetivaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_PedidosColetivos_PedidoColetivoId",
                table: "Produtos",
                column: "PedidoColetivoId",
                principalTable: "PedidosColetivos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_PedidosIndividuais_PedidoIndividualId",
                table: "Produtos",
                column: "PedidoIndividualId",
                principalTable: "PedidosIndividuais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
