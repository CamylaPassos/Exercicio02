// See https://aka.ms/new-console-template for more information

int numero;
int resultado;

Console.WriteLine("Informe um número:");
//manda ler uma linha no console

numero = Convert.ToInt32(Console.ReadLine());
//guarda o valor
//O método Convert.ToInt32() converte para número e pode ser usado quando tem certeza que a conversão dará certo. Não é o caso de um dado entrado pelo teclado. O usuário pode digitar algo que não pode ser convertido para número. 

resultado = numero - 1;
//soma

Console.WriteLine("O número que você escolheu foi " + numero + " e seu antecessor é " + resultado);
//mostra o resultado

Console.ReadLine();
//fecha a execução
