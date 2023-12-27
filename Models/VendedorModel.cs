public class VendedorModel
{
    /// <summary>
    /// Identificador único do vendedor.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// CPF do vendedor.
    /// </summary>
    public string Cpf { get; set; }

    /// <summary>
    /// Nome do vendedor.
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Endereço de e-mail do vendedor.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Número de telefone do vendedor.
    /// </summary>
    public string Telefone { get; set; }
}

public class ItemVendaModel
{
    /// <summary>
    /// Nome do produto.
    /// </summary>
    public string Produto { get; set; }

    /// <summary>
    /// Quantidade do produto na venda.
    /// </summary>
    public int Quantidade { get; set; }
}
