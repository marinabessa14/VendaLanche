using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace VendaLanche.Models
{

    namespace LanchesMac.Models
    {
        [Table("Lanches")]
        public class Lanche
        {
            [Key]
            public int LancheId { get; set; }

           
            public string Nome { get; set; }

            [Required(ErrorMessage = "O nome do lanche deve ser informado")]
            [Display(Name = "Nome do Lanche")]
            [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
            public string DescricaoCurta { get; set; }

            [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
            [Display(Name = "Descrição do Lanche")]
            [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
            [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
            public string DescricaoDetalhada { get; set; }

            [Required(ErrorMessage = "O descrição detalhada do lanche deve ser informada")]
            [Display(Name = "Descrição detalhada do Lanche")]
            [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
            [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
            public decimal Preco { get; set; }

            [Required(ErrorMessage = "Informe o preço do lanche")]
            [Display(Name = "Preço")]
            [Column(TypeName = "decimal(10,2)")]
            [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
            public bool EmEstoque { get; set; }
            [Display(Name = "Estoque")]
            public int CategoriaId { get; set; }
            public virtual Categoria Categoria { get; set; }
        }
    }
    }
