using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class VendaModel
{

    public int Id { get; set; }

    public VendedorModel Vendedor { get; set; }

    public DateTime Data { get; set; }


    public int PedidoId { get; set; }

    public List<ItemVendaModel> Itens { get; set; }


    /// Status da venda.
    /// As únicas opções possíveis são:
    /// "Aguardando pagamento"
    /// "Pagamento Aprovado"
    /// "Enviado para Transportadora"
    /// "Entregue" e
    /// "Cancelada"

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
