using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class VendaModel
{
    /// <summary>
    /// Identificador único da venda.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Informações sobre o vendedor.
    /// </summary>
    public VendedorModel Vendedor { get; set; }

    /// <summary>
    /// Data da venda.
    /// </summary>
    public DateTime Data { get; set; }

    /// <summary>
    /// Identificador do pedido.
    /// </summary>
    public int PedidoId { get; set; }

    /// <summary>
    /// Lista de itens na venda.
    /// </summary>
    /// 

    public List<ItemVendaModel> Itens { get; set; }

    /// <summary>
    /// Status da venda.
    /// As únicas opções possíveis são:
    /// "Aguardando pagamento"
    /// "Pagamento Aprovado"
    /// "Enviado para Transportadora"
    /// "Entregue" e
    /// "Cancelada"
    /// </summary>
    [Display(Name = "Status")]
    public string Status { get; set; }
}

public class VendaModelExample
{
    public int Id { get; set; }
    public VendedorModel Vendedor { get; set; }
    public DateTime Data { get; set; }
    public int PedidoId { get; set; }
    public List<ItemVendaModel> Itens { get; set; }
    public string Status { get; set; }
}
