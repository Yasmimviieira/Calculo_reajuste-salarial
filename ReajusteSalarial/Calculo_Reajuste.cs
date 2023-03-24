namespace ReajusteSalarial;

public class Calculo_Reajuste
{
    public double Calcule_Reajuste (double salario) {
        
        if (salario > 1700) {
            double salarioMaior = (salario + 200);
            return salarioMaior;
        }
        else {
            double salarioMenor = (salario + 300);
            return salarioMenor;
        }
    }
}
