// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using API.Models;

// namespace API_Folha.Validations
// {
//     public class IdEmUso : ValidationAttribute
//     {
//         // public IdEmUso(string id) { }
//         protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//         {
//             string cpf = (string)value;

//             DataContext context =
//                 (DataContext)validationContext.GetService(typeof(DataContext));

//             Funcionario funcionario = context.Funcionarios.FirstOrDefault
//                 (f => f.Id.Equals(Id));
                
//             if (funcionario == null)
//             {
//                 //Caso de sucesso
//                 return ValidationResult.Success;
//             }
//             //Caso de erro
//             return new ValidationResult("404 Not Found");
//         }
//     }
// }