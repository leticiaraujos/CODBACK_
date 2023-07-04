using System;
using System.Collections.Generic;

// Classe base para representar um cliente
public abstract class Cliente
   

{
public int Id { get; set; }
    
   
public string Nome { get; set; }
    
   
public abstract void ImprimirDados(); // Método abstrato para imprimir os dados do cliente
}
