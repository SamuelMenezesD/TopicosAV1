//Explique o que é herança em orientação a objetos e como ela é implementadaem C#. 
//Dê um exemplo prático de como a herança pode ser utilizada em umsistema de gerenciamento de funcionários.

// Herança é a capacidade de criar abstrações novas a partir de abstrações já exixstentes, para ter reaproveitamento de codigo.
// A herança funciona da seguinte forma: existe uma classe pessoa e outra funcionario, a classe Pessoa tem como atributo nome e rg, 
// ja na funcionario tem salario e cargo. Como um funcionario é uma pessoa ele herda os atributos de pessoa.

public class Pessoa{

    private string nome{get; set;}
    private string rg{get;set;}

}
public class Funcionario : Pessoa{

    private string cargo{get;set;}
    private double salario{get;set;}

}