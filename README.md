# Sistema de Abstração de Celular (POO)

Este repositório contém uma aplicação em C# (.NET Console Application) desenvolvida para aplicar os princípios da Programação Orientada a Objetos, com foco específico em abstração, herança e polimorfismo.

O projeto simula o sistema de um celular, onde uma classe abstrata define o comportamento padrão e classes específicas (como Samsung) implementam as regras de negócio para instalação de aplicativos.

## Visão Geral

O sistema permite o cadastro de um aparelho e executa ações básicas como ligar, receber chamadas e instalar aplicativos. A arquitetura foi desenhada para garantir que diferentes marcas de celulares possam ser adicionadas no futuro reutilizando a estrutura base.

### Conceitos Técnicos Aplicados

* **Abstração:** Criação da classe base `Smartphone` que define o contrato que todos os celulares devem seguir.
* **Herança:** A classe `Samsung` herda as características da classe base, reutilizando código.
* **Polimorfismo:** O método `InstalarAplicativo` é sobrescrito (`override`) para comportar-se de maneira diferente dependendo da implementação específica da marca.
* **Encapsulamento:** Uso de propriedades e construtores para garantir a integridade dos dados do objeto (IMEI, Modelo, Memória).

## Estrutura do Código

A solução está organizada da seguinte forma:

**1. Classe Abstrata (Smartphone)**
Define as propriedades comuns (`Numero`, `Modelo`, `IMEI`, `Memoria`) e o método abstrato `InstalarAplicativo`, que obriga as classes filhas a implementarem sua própria lógica.

```csharp
public abstract class Smartphone
{
    public string Numero { get; set; }
    // ... Outras propriedades

    public void Ligar()
    {
        Console.WriteLine("Ligando o Smartphone...");
    }

    public abstract void InstalarAplicativo(string nomeDoApp);
}
