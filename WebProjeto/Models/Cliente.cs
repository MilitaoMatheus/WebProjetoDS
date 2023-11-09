using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace WebProjeto.Models
{
    public class Cliente
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Por favor, preencha o campo Código")]
        public int codCliente { get; set; }

        [Display(Name = "Nome de Usuário")]
        [Required(ErrorMessage = "Por favor, preencha o campo Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Por favor, preencha o campo CPF")]
        [StringLength(11)]
        [DisplayFormat(DataFormatString = "{xxx.xxx.xxx-xx}")]
        public int CPF { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por favor, preencha o campo Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]   
        public string email { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Por favor, preencha o campo Endereço")]
        public string endereco { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Por favor, preencha o campo Telefone, incluindo o DDD")]
        [StringLength(11)]
        [DisplayFormat(DataFormatString = "{(xx)xx xxxxx-xxxx}")]
        public string telDDD { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, preencha o campo Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataNasc { get; set; }
    }
}