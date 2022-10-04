using System;
using System.ComponentModel.DataAnnotations;
using API_Folha.Validations;

namespace API.Models
{
    public class FolhaPagamento : Funcionario 
    {
        public FolhaPagamento () => CriadoEm = DateTime.Now;
         
         // [IdEmUso]
        [Required(ErrorMessage = "O campo valor hora é obrigatório!")]
        public int funcionarioid { get; set; }

        [Required(ErrorMessage = "O campo valor hora é obrigatório!")]
        public double valorhora { get; set; }

        [Required(ErrorMessage = "O campo valor hora é obrigatório!")]
        public int quantidadedehoras { get; set; }


        public DateTime CriadoEm { get; set; }


        public List<Post> Id { get; set; }

         Console.WriteLine("Calculo do salário bruto");

         double horastrab;
         double valorhora;
         double salarioBruto = horastrab * valorhora
         Console.WriteLine(salarioBruto);

        Console.WriteLine("Calculo Desconto do Imposto de Renda");
         
         double sariofinal; 

            if (salarioBruto < 1903.98)
            {
                salarioFinal = salarioBruto-(0.0*(salarioBruto/100));
                Console.WriteLine(salarioFinal);
            }

            else{

            if(salarioBruto >= 1903.99 && salarioBruto <= 2826.65)
            {

                salarioFinal = salarioBruto-(7.5*(salarioBruto/100));
                Console.WriteLine(salarioFinal);
            }
          
            
                if(salarioBruto >= 2826.65 && salarioBruto <= 3751.05)
                {

                    salarioFinal = salarioBruto - (15.00 * (salarioBruto / 100));
                    Console.WriteLine(salarioFinal);
                }

                if (salarioBruto > 3751.06 && salarioBruto <= 4664.68 )
                {
                    salarioFinal = salarioBruto - (22.50 * (salarioBruto / 100));
                    Console.WriteLine(salarioFinal);

                }

                if (salarioBruto > 4664.68)
                {
                    salarioFinal = salarioBruto - (27.50 * (salarioBruto / 100));
                    Console.WriteLine(salarioFinal);
                }

                  

                  

                Console.WriteLine("Calculo INSS");

                double desconto; 

                if (salarioBruto < 1639.72)
            {
                desconto = salarioBruto-(8.0*(salarioBruto/100));
                Console.WriteLine(desconto);
            }

            else{

            if(salarioBruto >= 1639.72 && salarioBruto <= 2822.90)
            {

                desconto = salarioBruto-(9.0*(salarioBruto/100));
                Console.WriteLine(desconto);
            }
          
            
                if(salarioBruto >= 2.822,91 && salarioBruto <= 5645.80)
                {

                desconto = salarioBruto-(11.0*(salarioBruto/100));
                Console.WriteLine(desconto);
                }

                if (salarioBruto >  5.645,81)
                {
                    desconto = salarioBruto-(661.03);
                    Console.WriteLine(desconto);
                }


            Console.WriteLine("Calculo FGTS");

             double taxafgts = 0.08; 
             doble fgts; 

             fgts = salarioBruto * 0.08; 


              


                






    }

}
