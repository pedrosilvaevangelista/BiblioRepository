# 📚 Biblio 2.0

## **🎯 Objetivo do Projeto**

O **Biblio** é uma plataforma digital sem fins lucrativos, desenvolvida para democratizar o acesso à literatura e facilitar a publicação e distribuição de obras literárias. Seu principal objetivo é conectar **autores independentes** a um **público amplo de leitores**, promovendo a divulgação de obras de forma gratuita e incentivando o prazer pela leitura.

---

## **🎯 Público-Alvo**

### ✍️ Autores Independentes

- Escritores que buscam uma plataforma acessível para publicar e compartilhar suas obras.
- Autores que desejam alcançar um público maior sem custos ou intermediários.

### 📖 Leitores

- Leitores ávidos por uma variedade de gêneros literários, incluindo títulos populares e independentes.
- Pessoas que valorizam o acesso gratuito a conteúdos diversificados.
- Indivíduos interessados em descobrir novos autores e obras alternativas.

---

## **📌 Divisão de Projetos**

O projeto **Biblio** é composto por três subprojetos principais:

### 🏗 Página Estática

- Contém informações sobre a plataforma e um link direto para acessá-la.

### 🌐 Sistema Web Dinâmico

- A parte interativa acessível aos usuários e autores, permitindo acesso e download dos livros.

### 🖥 Sistema Desktop

- Voltado para administradores, permitindo gerenciar usuários, livros e requisições de publicação.

---

## **🌐 SITE ESTÁTICO**

### **📌 Função**

O site estático apresenta a plataforma **Biblio** de forma dinâmica e interativa, oferecendo seções como:

- Sobre
- Catálogo de livros
- Avaliações
- Contato
- Login (redirecionamento para o site dinâmico)

### **🛠 Tecnologias Utilizadas**

- **HTML**
- **CSS**
- **Bootstrap**
- **JavaScript**

**📚 Bibliotecas:**

- Swiper.js
- AOS

---

## **🎨 Fontes e Recursos Visuais**

- **Lora**
- **Playfair Display**
- **Merriweather**
- **Bootstrap**
- **Swiper.js**

---

## **🌍 Sistema Web Dinâmico**

### **📌 Função**

Criado para o gerenciamento de livros digitais, permitindo que os usuários realizem diversas ações.

### **📖 Gestão de Livros**

✅ **Cadastro de livros** – Autores podem adicionar obras (com título, sinopse, autor, gênero, capa, banner e PDF). Publicação sujeita a aprovação.
✅ **Exibição de detalhes do livro** – Cada livro tem uma página dedicada com suas informações completas.
✅ **Download de livros** – Leitores podem baixar os livros em formato PDF.

### **👤 Gestão de Usuários**

✅ **Cadastro de usuários** – Usuários podem se registrar como leitores ou autores.
✅ **Login e autenticação** – Necessário para acessar funcionalidades avançadas.
✅ **Edição de perfil** – Modificação de nome, e-mail, senha e foto de perfil.
✅ **Exclusão de conta** – Usuário pode remover sua conta permanentemente.

### **⭐ Favoritos**

✅ **Adicionar livros aos favoritos** – Para acesso rápido aos livros preferidos.
✅ **Remover favoritos** – Possibilidade de retirar livros da lista.

### **🔍 Pesquisa e Filtros**

✅ **Busca avançada** – Pesquisa por título, autor ou gênero.
✅ **Filtragem de livros** – Busca por categorias específicas.

### **🔒 Segurança**

✅ **Confirmação de senha** – Necessário para alterações de dados sensíveis.
✅ **Criptografia de senha** – Senhas armazenadas de forma segura.

### **📂 Outras Funcionalidades**

✅ **Upload de imagens** – Suporte para capas de livros, banners e fotos de perfil.
✅ **Requisição de livros** – Livros submetidos aguardam aprovação antes da publicação.

---

## **🛠 Tecnologias Utilizadas**

- **Back-end:** [ASP.NET](http://asp.net/) Web Forms (C#)
- **Banco de Dados:** SQL Server
- **Front-end:** HTML, CSS, Bootstrap

---

## **📌 Estrutura do Projeto**

```
Biblio2.0/
├── Biblio2.BLL # Camada de lógica de negócios
├── Biblio2.DAL # Camada de acesso a dados
├── Biblio2.DTO # Camada de transferência de dados
├── Biblio2.UI  # Interface do usuário
│   ├── GeralPages
│   │   ├── Ajustes.aspx
│   │   ├── Catalogo.aspx
│   │   ├── EditarPerfil.aspx
│   │   ├── Inicio.aspx
│   │   ├── Perfil.aspx
│   │   ├── TemplateLivro.aspx
│   ├── Author
│   │   └── AdicionarNovoLivro.aspx
│   ├── img
│   ├── pdf
│   ├── utilities
│   │   └── Clear.cs
│   ├── Cadastro.aspx
│   ├── Index
│   ├── resources
│   ├── Login.aspx
│   ├── Scripts/
│   │   └── Theme.js
│   ├── packages.config
│   └── Web.config

```

---

## **📌 Fluxo de Comunicação entre Camadas**

1️⃣ **Usuário interage com a interface (UI).**
2️⃣ **Dados são processados na camada BLL, aplicando regras de negócio.**
3️⃣ **A camada DAL acessa o banco de dados para busca/persistência de informações.**
4️⃣ **Resultados são retornados para a UI e exibidos ao usuário.**

---

## **📌 Padrões Utilizados**

**Arquitetura em Camadas**

- **BLL (Business Logic Layer)** → Contém regras de negócio.
- **DAL (Data Access Layer)** → Comunicação com o banco de dados.
- **DTO (Data Transfer Object)** → Transferência de dados entre camadas.
- **UI (User Interface Layer)** → Interface do usuário com páginas .aspx.

---

## **🖥 Sistema Desktop**

### **📌 Visão Geral**

A área de Desktop é exclusiva para administradores, permitindo o gerenciamento dos usuários, livros e requisições feitas no **Sistema Web Dinâmico**.

### **📌 Objetivo do Sistema**

Centralizar e controlar o gerenciamento de usuários e dados, impedindo acesso não autorizado.

### **📌 Principais Funcionalidades**

🔐 **Tela de Login**

- Autenticação exclusiva para administradores.
- Validação de credenciais antes do acesso.

👤 **Aba de Usuários**

- Listagem, edição, remoção e cadastro de usuários.

📚 **Aba de Livros**

- Gerenciamento de livros (listar, editar, remover, cadastrar).

📩 **Aba de Requisições**

- Aprovação ou recusa de pedidos de publicação.

✅ **Se aprovado** → Livro é publicado.
❌ **Se recusado** → Livro é removido da lista de requisições.

### **🛠 Tecnologias Utilizadas**

- **Modelo de Projeto:** Windows Forms App (.NET Framework) (C#)
- **Banco de Dados:** SQL Server
