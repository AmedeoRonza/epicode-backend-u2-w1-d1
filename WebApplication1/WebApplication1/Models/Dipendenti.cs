using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Dipendenti
    {
        public int IdDipendenti { get; set; }

        [Required(ErrorMessage = "Il nome del dipendente è obbligatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Il cognome del dipendente è obbligatorio")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "L'indirizzo del dipendente è obbligatorio")]
        public string Indirizzo { get; set; }

        [Required(ErrorMessage = "Il codice fiscale del dipendente è obbligatorio")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il codice fiscale deve essere di 16 caratteri")]
        public string CodiceFiscale { get; set; }

        public bool Sposato { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Il numero di figli a carico deve essere un numero positivo")]
        public int NumeroFigliACarico { get; set; }

        public string Mansione { get; set; }
    }
}