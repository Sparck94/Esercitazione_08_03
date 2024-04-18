using System;
using System.Collections.Generic;

namespace acc_task_gestione_impiegati.Models;

public partial class Cittum
{
    public int CittaId { get; set; }

    public string NomeCitta { get; set; } = null!;

    public int ProvinciaRif { get; set; }

    public virtual Provincium ProvinciaRifNavigation { get; set; } = null!;
}
