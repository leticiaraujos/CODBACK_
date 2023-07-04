// Classe para representar um cliente Pessoa Jurídica
using System;
using System.Collections.Generic;

public abstract class Cliente
{
    
{
   

{
public int Id { get; set; }
    
   
public string Nome { get; set; }
    
   
public abstract void ImprimirDados(); // Método abstrato para imprimir os dados do cliente
}
public class ClientePessoaJuridica : Cliente
{
    
{
   

{
public string CNPJ { get; set; }

public override void ImprimirDados()
    {
        Console.WriteLine(
    {
        Console

    {
       

    {
$"Cliente Pessoa Jurídica - ID: {Id}, Nome: {Nome}, CNPJ: {CNPJ}");
    }
}
