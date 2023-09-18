namespace Library;

public class CompuertaOr : ICompuerta {
    public string Name { get; set; }
    public ArrayList Entradas { get; set; }
    public double Calcular { get; }

    public CompuertaOr() {}

    public string GetName() { return this.Name; }

    public void AddEntrada(Entrada entrada) { Entrada.Add(entrada); }
    public void RemoveEntrada(Entrada entrada) { Entrada.Remove(entrada); }

    public double Calcular(Arraylist Entradas){
        double salida = 1
        foreach (Entrada entrada in Entradas){
            if ((Entradas[entrada] == 0) || (Entradas[entrada] == 1)){
                salida = salida * Entradas[entrada]
            }
            else {
                salida = salida * Entradas[entrada].Calcular(Arraylist Entradas)
            }
        }
        return salida
    }
}
