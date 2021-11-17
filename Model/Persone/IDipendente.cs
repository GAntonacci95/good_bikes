using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Persone
{
    public interface IDipendente : IEquatable<IDipendente>
    {
        string NomeUtente { get; }
        string Password { get; }
        bool Attivo { get; set; }
    }
}
