using System.Collections;

namespace Library;

public interface ICompuerta {
    string Name { get; set; }
    ArrayList Entradas { get; set; }
    double Calcular { get; }
    string GetName();
    void AddEntrada(Entrada entrada);
    void RemoveEntrada(Entrada entrada);
}
