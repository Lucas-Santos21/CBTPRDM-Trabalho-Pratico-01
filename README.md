# Trabalho Prático 01: App de Login

Trabalho prático 01 para a disciplina de **Programação para Dispositivos Móveis**, do curso de **Análise e Desenvolvimento de Sistemas (ADS)** no **IFSP – Campus Cubatão**.

Este projeto consiste em um aplicativo móvel construído com **.NET MAUI** e **C#**, simulando uma tela de login com base em um protótipo exigido em sala de aula.

## 📚 Sobre o projeto

O objetivo principal deste trabalho prático (TP 01) foi aplicar os conceitos iniciais de desenvolvimento de interface de usuário (UI) utilizando XAML, gerenciamento de eventos (cliques de botões), manipulação de elementos na tela e navegação básica entre páginas.

### Funcionalidades Implementadas

Atendendo aos requisitos do protótipo, o aplicativo possui as seguintes funcionalidades:

- **Autenticação Simulada (Validação Hardcoded):** Ao clicar no botão **OK**, o sistema verifica se as credenciais inseridas são válidas (ID: `admin` / Pass: `senha@dmin`). 
  - Em caso de sucesso, o usuário é navegado para uma página informando que está logado.
  - Em caso de erro, é exibida uma mensagem (DisplayAlert) de login não autorizado.
- **Limpeza e Foco de Cursor (UX):** O botão **Limpar** apaga os dados preenchidos nos campos de ID e Pass e utiliza o método `.Focus()` para reposicionar automaticamente o cursor no campo de "ID", facilitando uma nova tentativa.
- **Página de Créditos:** O botão **Créditos** direciona para uma nova tela apresentando os nomes dos autores do aplicativo, contendo um botão para retornar à tela inicial.

## 🛠️ Tecnologias

- **C#**
- **.NET MAUI**
- **XAML**
- **.NET 10**

## 💻 Ambiente de desenvolvimento

O projeto foi desenvolvido e testado utilizando o seguinte ambiente:

- **IDE:** Visual Studio 2026
- **Framework:** .NET 10 e .NET MAUI

## 👥 Autores (Dupla)

- **Lucas Santos** - [github/Lucas-Santos21](https://github.com/Lucas-Santos21)
- **Kaueh Farias** - [github/KauehF](https://github.com/KauehF)

---

**Curso:** Análise e Desenvolvimento de Sistemas – ADS  
**Instituição:** Instituto Federal de São Paulo – IFSP  
**Campus:** Cubatão – SP  
**Disciplina:** Programação para Dispositivos Móveis