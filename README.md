# 🏗️ Sistema de Inventário – Loja de Materiais de Construção

📌 **Projeto MVP em 1 Semana**  
Sistema local desenvolvido em ASP.NET Core Web API para controle de estoque e contabilidade básica de uma loja de construção. Foco em simplicidade, agilidade e funcionalidade essencial.

---

## 🎯 Objetivo

Desenvolver um sistema em até **7 dias** que permita:

- Gerenciar produtos em estoque  
- Registrar movimentações de entrada/saída  
- Calcular valores de venda e lucro  
- Gerar relatórios contábeis simples

---

## 🛠️ Tecnologias e Ferramentas

| Categoria            | Ferramenta/Descrição                                                                 |
|----------------------|--------------------------------------------------------------------------------------|
| **Framework**        | .NET 9.0 (SDK 9.0.301)                                                               |
| **Linguagem**        | C#                                                                                   |
| **Projeto**          | ASP.NET Core Web API (com possibilidade futura de Razor Pages ou Blazor)            |
| **Banco de Dados**   | SQLite – leve, simples e ideal para execução local                                  |
| **ORM**              | Entity Framework Core 9                                                              |
| **IDE**              | Visual Studio 2022 ou VS Code                                                        |
| **Versionamento**    | Git + GitHub (opcional, mas recomendado)                                             |
| **Extras**           | Swagger (documentação e testes da API), EF Core Migrations                          |

---

## 📁 Estrutura do Projeto
InventoryApp/
 ├── InventoryApp.Api/          → API ASP.NET Core
 │    ├── Controllers/          → Endpoints (Produtos, Relatórios)
 │    ├── Models/               → Entidades (Produto, Movimentacao)
 │    ├── Data/                 → DbContext (EF Core)
 │    ├── Services/             → Lógica de negócio
 │    └── Program.cs            → Configuração inicial
 └── InventoryApp.sln           → Solução do projeto


---


---

## 🗄️ Modelo de Dados

### 🔹 Produtos

- `Id` (int, PK)  
- `Nome` (string)  
- `Modelo` (string)  
- `Marca` (string)  
- `Quantidade` (int)  
- `ValorCompra` (decimal)  
- `MargemLucro` (decimal)  
- `ValorVenda` (decimal, calculado = ValorCompra + (ValorCompra * MargemLucro / 100))

### 🔹 Movimentações

- `Id` (int, PK)  
- `ProdutoId` (int, FK → Produtos)  
- `Tipo` (string: Entrada ou Saída)  
- `Quantidade` (int)  
- `Data` (datetime)

---

## 🚀 Funcionalidades do MVP

### ✅ Cadastro de Produtos  
- Adicionar, editar, excluir e listar produtos  
- Cálculo automático do valor de venda

### ✅ Movimentações de Estoque  
- Registrar entradas e saídas  
- Atualizar estoque automaticamente

### ✅ Relatórios Contábeis  
- Valor total em estoque (soma dos custos)  
- Valor potencial de venda  
- Lucro estimado (venda - custo)  
- Consulta por marca/categoria  
- Análise por período (com base nas movimentações)

---

## 🕑 Cronograma de Desenvolvimento

| Dia | Atividade                                                                 |
|-----|---------------------------------------------------------------------------|
| 1   | Criar projeto ASP.NET Core + configurar EF Core + banco SQLite            |
| 2   | Modelar entidades (Produto, Movimentação) + configurar DbContext          |
| 3   | Implementar CRUD de produtos + integrar Swagger                           |
| 4   | Criar endpoints de movimentações + lógica de atualização de estoque       |
| 5   | Desenvolver relatórios contábeis (estoque, lucro, análise por período)    |
| 6   | Realizar testes locais e ajustes finais                                   |
| 7   | Entregar versão MVP funcional                                             |

---

## 📈 Possibilidades Futuras

- Cadastro de fornecedores  
- Multiusuário com permissões (admin/funcionário)  
- Exportação de relatórios em PDF/Excel  
- Dashboard gráfico (barras/pizza com dados de estoque e lucro)

---

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

---

## 🙋‍♂️ Autor

Desenvolvido por **Paulo**  
📧 Contato: phsantos2011@gmail.com

---
