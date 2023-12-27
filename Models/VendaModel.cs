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

    [Display(Name = "Status")]
    public string Status { get; set; }
}
