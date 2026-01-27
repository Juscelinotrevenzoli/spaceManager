# 🚀 SpaceManager - Fleet Control System

O **SpaceManager** é um sistema de gerenciamento de frotas espaciais desenvolvido em C# para demonstrar a aplicação prática dos pilares da **Programação Orientada a Objetos (POO)**. 

Este projeto simula o comportamento de diferentes naves espaciais, lidando com movimentação, consumo de combustível e capacidades de combate.

## 🧠 Conceitos Aplicados

Neste projeto, utilizei conceitos fundamentais de engenharia de software:

* **Abstração**: Criação da classe base `Veiculo` que define o contrato para qualquer tipo de transporte espacial.
* **Herança**: A `NaveCaca` herda comportamentos e propriedades da classe `Veiculo`.
* **Polimorfismo**: Sobrescrita (`override`) do método `Mover` para que cada nave tenha seu próprio cálculo de consumo.
* **Interfaces**: Implementação da `ICombativel` para permitir que apenas naves específicas tenham capacidade de fogo.
* **Encapsulamento**: Uso de modificadores de acesso (`protected`, `private`) para proteger o estado interno (combustível).

## 📂 Estrutura do Projeto

O projeto segue uma estrutura de pastas organizada por responsabilidades:

```text
SpaceManager/
├── Interfaces/     # Contratos e habilidades (ex: ICombativel)
├── Models/         # Classes base e especializações (ex: Veiculo, NaveCaca)
├── Program.cs      # Ponto de entrada e testes do sistema
└── SpaceManager.csproj