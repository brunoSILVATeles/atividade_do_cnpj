using System;

namespace calculo_do_cnpj
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Clear();

                        string clientecnpj , cnpj1 ,cnpj2 , cnpjfinal;
            int contagem1=12 ,contagem2=13,resto ,rs1=0 ,rs2=0;
            int[] mult1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
            int[] mult2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
             
            
            Console.WriteLine("Por Favor Digite o Numero do Seu CNPJ");
            clientecnpj = (Console.ReadLine());
            cnpj1 = clientecnpj.Substring(0,12);

            for(int i=0; i < cnpj1.Length;i++)
            {
                rs1 += int.Parse(cnpj1[i].ToString())*mult1[i];
                contagem1--;                     
            }
            resto = rs1 % 11;
            if(resto < 2 )
            cnpj2 = cnpj1+0;
            else 
            cnpj2 =cnpj1+(11-resto);


            for(int i=0; i < cnpj2.Length;i++)
            {
                rs2 += int.Parse(cnpj2[i].ToString())*mult2[i];
                contagem2--;                     
            }
            resto = rs2 % 11;
            if(resto < 2 )
            cnpjfinal = cnpj2+0;
            else 
            cnpjfinal=cnpj2+(11-resto);

            if(cnpjfinal==clientecnpj)
            {
                Console.WriteLine("O Seu CNPJ é Verdadeiro, Obrigado. ");
            }
            else if(cnpjfinal!=clientecnpj)
            {
                Console.WriteLine("Me Desculpe O Seu CNPJ é Inválido, Por Favor Digite Um CNPJ Valido. ");
            }
        }
    }
}
