using RepoDb.Attributes;
using System.ComponentModel.DataAnnotations;

namespace LoanworksBackend.Modules.Management.Core.BankTransactionType;

public class BankTransactionTypes
{
    [Key]
    [Map("id")]
    public int Id { get; set; }
    [Map("bankTransactionTypeDescription")]
    public string? BankTransactionTypeDescription { get; set; }
}

