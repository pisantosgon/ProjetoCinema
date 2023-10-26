﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ProjetoCinema.Models.Cadastro;

namespace ProjetoCinema.Models
{
    public class Cadastro
    {
        [Column("CadastroId")]
        [Display(Name = "Codigo do Cadastro")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("EscolhaFilme")]
        [Display(Name = "Filme")]
        public string EscolhaFilme { get; set; } = string.Empty;

        [Column("HrSessao")]
        [Display(Name = "Horário da Sessão")]

        public DateTime HrSessao { get; set; }

        [Column("Lugar")]
        [Display(Name = "Assento")]
        public string Lugar { get; set; } = string.Empty;

        [Column("Pedidos")]
        [Display(Name = "Pedidos")]
        public string Pedidos { get; set; } = string.Empty;

    }
}