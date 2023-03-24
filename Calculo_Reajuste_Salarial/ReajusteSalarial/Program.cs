using ReajusteSalarial;

Calculo_Reajuste _Salario = new Calculo_Reajuste();
double salario;

Console.WriteLine("Digite o seu salário atual: ");
salario = Convert.ToDouble(Console.ReadLine());

// Receber o salário do usuário

double salarioMaior = _Salario.Calcule_Reajuste(salario);

//Chamar método criado

Console.WriteLine("Seu salário novo é: " + salarioMaior);
Console.ReadLine();

// Salário final