using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class VendasController : ControllerBase
{
    private static List<VendaModel> vendas = new List<VendaModel>();

    [HttpPost]
    public IActionResult RegistrarVenda([FromBody] VendaModel venda)
    {
        venda.Status = "Aguardando pagamento";
        venda.Id = vendas.Count + 1;
        vendas.Add(venda);
        return Ok(venda);
    }

    [HttpGet("{id}")]
    public IActionResult BuscarVenda(int id)
    {
        var venda = vendas.FirstOrDefault(v => v.Id == id);
        if (venda == null)
            return NotFound();
        return Ok(venda);
    }

[HttpPatch("{id}/status")]
public IActionResult AtualizarStatusVenda(int id, [FromBody] string novoStatus)
{
    var venda = vendas.FirstOrDefault(v => v.Id == id);
    if (venda == null)
        return NotFound();

    switch (venda.Status)
    {
        case "Aguardando pagamento":
            if (novoStatus == "Pagamento Aprovado" || novoStatus == "Cancelada")
                venda.Status = novoStatus;
            else
                return BadRequest("Transição de status inválida.");
            break;
        case "Pagamento Aprovado":
            if (novoStatus == "Enviado para Transportadora" || novoStatus == "Cancelada")
                venda.Status = novoStatus;
            else
                return BadRequest("Transição de status inválida.");
            break;
        case "Enviado para Transportadora":
            if (novoStatus == "Entregue")
                venda.Status = novoStatus;
            else
                return BadRequest("Transição de status inválida.");
            break;
        default:
            return BadRequest("Status inválido.");
    }

    return Ok(venda);
}

    [HttpDelete("{id}")]
    public IActionResult DeletarVenda(int id)
    {
        var venda = vendas.FirstOrDefault(v => v.Id == id);
        if (venda == null)
            return NotFound();

        vendas.Remove(venda);

        return Ok($"Venda com ID {id} removida com sucesso.");
    }
}
