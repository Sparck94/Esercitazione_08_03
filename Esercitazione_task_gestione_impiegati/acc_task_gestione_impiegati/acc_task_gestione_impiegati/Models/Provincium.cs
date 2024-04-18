using System;
using System.Collections.Generic;

namespace acc_task_gestione_impiegati.Models;

public partial class Provincium
{
    public int ProvinciaId { get; set; }

    public string NomeProvincia { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public virtual ICollection<Cittum> Citta { get; set; } = new List<Cittum>();
}
