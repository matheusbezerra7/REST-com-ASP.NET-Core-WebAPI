﻿using DevIO.Api.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.ViewModels
{
   
    [ModelBinder(typeof(JsonWithFilesFormDataModelBinder), Name = "produto")]
    public class ProdutoImagemViewModel
    {
        [Key]

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
       
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]


        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]

        public string Descricao { get; set; }

        public IFormFile ImagemUpload { get; set; }
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
      
        [ScaffoldColumn(false)]

        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }
        
        [ScaffoldColumn(false)]

        public string NomeFornecedor { get; set; }


    }
}
