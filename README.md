### Biblio

### **Objetivo do Projeto Biblio 2.0**

O **Biblio 2.0** é uma plataforma digital sem fins lucrativos, desenvolvida para democratizar o acesso à literatura e facilitar a publicação e distribuição de obras literárias. Seu principal objetivo é conectar **autores independentes** a um **público amplo de leitores**, promovendo a divulgação de obras de forma gratuita e incentivando o prazer pela leitura.

---

### **Público-Alvo**

1. **Autores Independentes:**
    - Escritores que buscam uma plataforma acessível para publicar e compartilhar suas obras.
    - Autores que desejam alcançar um público maior sem custos ou intermediários.
2. **Amantes de Livros:**
    - Leitores ávidos em busca de uma variedade de obras, incluindo gêneros populares e nichos literários.
    - Pessoas que valorizam o acesso gratuito a conteúdos literários diversificados.
    - Indivíduos interessados em descobrir novos autores e obras independentes.

## **📌 Principais Funcionalidades do Biblio2.0**

O **Biblio2.0** é um sistema para gerenciamento de livros digitais, permitindo que os usuários interajam com um catálogo de livros e realizem ações como cadastrar, visualizar e favoritar livros.

---

### **📖 Gestão de Livros**

✅ **Cadastro de livros** – Usuários com permissão podem adicionar novos livros a uma tabela de requisição no sistema, informando título, sinopse, autor, gênero e anexando capa, banner e PDF; e deverá ser aceita pelo administrador para realmente ser adicionado a aplicação.

✅ **Exibição de detalhes do livro** – Página dedicada para exibir as informações completas do livro.

✅ **Download de livros** – O sistema permite que os usuários façam o download do PDF dos livros disponíveis.

---

### **👤 Gestão de Usuários**

✅ **Cadastro de usuários** – Permite que novos usuários se registrem no sistem, seja como usuário comum, seja como usuário autor.

✅ **Login e autenticação** – Os usuários precisam realizar login para acessar funcionalidades específicas.

✅ **Edição de perfil** – Os usuários podem alterar nome, email, senha e foto de perfil.

✅ **Exclusão de conta** – Usuários podem excluir permanentemente suas contas.

---

### **⭐ Favoritos**

✅ **Adicionar livros aos favoritos** – Usuários podem marcar livros como favoritos para fácil acesso.

✅ **Remover favoritos** – Os usuários podem remover livros da lista de favoritos.

---

### **🔒 Segurança**

✅ **Confirmação de senha ao alterar informações sensíveis** – Para alterar a senha, o usuário precisa confirmar sua senha atual.

---

### **📂 Outras Funcionalidades**

✅ **Upload de imagens** – O sistema permite que usuários enviem imagens para capa do livro, banner e foto de perfil.

---

### **🛠 Tecnologias Utilizadas**

- **Back-end:** ASP.NET Web Forms (C#)
- **Banco de Dados:** SQL Server
- **Front-end:** HTML, CSS, Bootstrap

---

## **📌 Camadas do Projeto**

### **1️⃣ Data Transfer Objects (DTO) – `Biblio2.DTO`**

📁 **Localização:** `/Biblio2.DTO/`

📌 **Objetivo:** Armazena classes de transferência de dados que representam entidades do sistema.

🔹 **Principais arquivos:**

- `LivroDTO.cs` → Representa um livro no sistema (Título, Autor, Gênero, etc.).
- `UsuarioDTO.cs` → Representa um usuário cadastrado no sistema.
- `GeneroDTO.cs` → Representa um gênero literário.
- `LivroFavoritoDTO.cs` → Representa um relacionamento entre usuário e livros favoritos.

✅ **Resumo:** Essa camada é responsável apenas por armazenar dados, sem regras de negócio ou acesso ao banco.

### **2️⃣ Data Access Layer (DAL) – `Biblio2.DAL`**

📁 **Localização:** `/Biblio2.DAL/`

📌 **Objetivo:** Responsável por acessar e manipular os dados no banco de dados.

🔹 **Principais arquivos:**

- `LivroDAL.cs` → Métodos de CRUD para a tabela de livros.
- `UsuarioDAL.cs` → Métodos para manipulação de usuários.
- `GeneroDAL.cs` → Métodos para consulta de gêneros cadastrados.
- `LivroFavoritoDAL.cs` → Métodos para adicionar/remover favoritos.

✅ **Resumo:** Essa camada executa operações no banco de dados, mas não deve conter regras de negócio.

### **3️⃣ Business Logic Layer (BLL) – `Biblio2.BLL`**

📁 **Localização:** `/Biblio2.BLL/`

📌 **Objetivo:** Contém a lógica de negócio do sistema, garantindo que as regras sejam seguidas antes da persistência dos dados.

🔹 **Principais arquivos:**

- `LivroBLL.cs` → Regras para cadastro, listagem e remoção de livros.
- `UsuarioBLL.cs` → Validação de login, cadastro e edição de perfil.
- `GeneroBLL.cs` → Gestão de gêneros de livros.
- `LivroFavoritoBLL.cs` → Regras para gerenciar favoritos.

✅ **Resumo:** Essa camada processa dados antes de enviá-los para a DAL ou exibi-los na UI.

### **4️⃣ Camada de Apresentação (UI) – `Biblio2.UI`**

📁 **Localização:** `/Biblio2.UI/`

📌 **Objetivo:** Responsável por exibir as informações para o usuário final via ASP.NET Web Forms.

🔹 **Principais pastas:**

📂 **GeralPages/** → Contém páginas compartilhadas, como MasterPages e edição de perfil.

📂 **Author/** → Contém páginas acessíveis apenas a autores, como cadastro de livros.

🔹 **Principais arquivos:**

- `Login.aspx` → Tela de login do sistema.
- `Cadastro.aspx` → Tela de cadastro de usuário do sistema.
- `EditarPerfil.aspx` → Página de edição do perfil do usuário.
- `TemplateLivro.aspx` → Exibe detalhes de um livro.
- `AdicionarNovoLivro.aspx` → Permite o cadastro de um novo livro.

✅ **Resumo:** Essa camada recebe entradas do usuário, envia para a BLL e exibe os resultados.

### **5️⃣ Outros Arquivos e Pastas Importantes**

📂 **/img/** → Armazena imagens de capa de livros e fotos de perfil dos usuários.

📂 **/pdf/** → Armazena os arquivos PDF dos livros cadastrados.

📂 **/css/** → Arquivos de estilo CSS utilizados na interface.

📂 **/GeralPages/ManageUsers.Master** → MasterPage utilizada na navegação do sistema.

## **📌 Fluxo de Comunicação entre as Camadas**

1️⃣ **O usuário interage com a interface (UI).**

## **📌 Resumo da Estrutura do Projeto**

```
Biblio2.0/ # Diretório raiz do projeto
├── Biblio2.BLL # Camada de lógica de negócios (Business Logic Layer)
│   ├── Properties
│   ├── LivroBLL.cs
│   ├── LivroFavoritoBLL.cs
│   ├── LivroRequisicaoBLL.cs
│   ├── Session.cs
│   └── UsuarioBLL.cs
├── Biblio2.DAL # Camada de acesso a dados (Data Access Layer)
│   ├── Properties
│   ├── ScriptDB # Scripts SQL para criação inicial do banco de dados
│   ├── Conexao.cs # Configuração da conexão com o banco de dados
│   ├── LivroDAL.cs
│   ├── LivroFavoritoDAL.cs
│   ├── LivroRequisicaoDAL.cs
│   └── UsuarioDAL.cs
├── Biblio2.DTO # Camada de transferência de dados (Data Transfer Object)
│   ├── Properties
│   ├── GeneroDTO.cs
│   ├── LivroDTO.cs
│   ├── LivroFavoritoDTO.cs
│   ├── LivroRequisicaoDTO.cs
│   ├── TipoUsuarioDTO.cs
│   └── UsuarioDTO.cs
├── Biblio2.UI  # Camada de interface do usuário (User Interface)
│   ├── Properties 
│   ├── GeralPages  # Páginas principais do sistema
│   │   ├── Ajustes.aspx  # Página de configurações
│   │   ├── Catalogo.aspx  # Página do catálogo de livros
│   │   ├── EditarPerfil.aspx  # Página para edição do perfil do usuário
│   │   ├── Inicio.aspx  # Página De recomendação de livros
│   │   ├── ManageUsers.Master  # Página mestra para navegar pela aplicação
│   │   ├── Perfil.aspx  # Página de perfil do usuário
│   │   └── TemplateLivro.aspx  # Modelo para exibição de livros
│   ├── Author  # Páginas relacionadas a autores
│   │   └── AdicionarNovoLivro.aspx  # Página para adicionar um novo livro
│   ├── img  # Diretório de imagens do projeto
│   │   ├── FotoPerfilUsuario  
│   │   └── ImagensLivroRequisicao 
│   ├── pdf  # Diretório para armazenamento de arquivos PDF
│   ├── utilities  # Utilitários gerais do sistema
│   │   └── Clear.cs  # Classe auxiliar para limpeza de dados
│   ├── Cadastro.aspx  # Página de cadastro de usuários
│   ├── Login.aspx  # Página de login
│   ├── packages.config  
│   └── Web.config
```

### **Padrões Utilizados no Projeto Biblio2.0**

**Arquitetura em Camadas**

O projeto é estruturado com múltiplas camadas para separar responsabilidades, seguindo um padrão comum em aplicações **ASP.NET Web Forms**:

- **BLL (Business Logic Layer)** → Contém as regras de negócio.
- **DAL (Data Access Layer)** → Responsável pela comunicação com o banco de dados.
- **DTO (Data Transfer Object)** → Utilizado para transferência de dados entre camadas.
- **UI (User Interface Layer)** → Interface do usuário com as páginas **.aspx**.

Esse modelo melhora a **separação de responsabilidades** e facilita a manutenção do código.

2️⃣ **Os dados são processados na camada BLL, aplicando regras de negócio.**

3️⃣ **A camada DAL acessa o banco de dados para buscar ou salvar informações.**

4️⃣ **Os resultados são retornados para a UI e exibidos ao usuário.**
