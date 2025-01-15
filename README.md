# API Base em .NET com Arquitetura MVC

Bem-vindo ao repositório da **API Base em .NET**! Este projeto foi desenvolvido para servir como um ponto de partida para criar APIs REST utilizando o framework ASP.NET Core, aplicando boas práticas de arquitetura com **MVC (Model-View-Controller)**, padrões como **Repository** e **Service**, e injeção de dependências.

---

## ✨ **Funcionalidades Principais**

- Estrutura modular e organizada para fácil manutenção e extensão.
- Implementação de padrões de projeto:
  - Repository Pattern para acesso aos dados.
  - Service Layer para regras de negócio.
- Configuração pronta para Injeção de Dependência (Dependency Injection).
- Documentação da API com Swagger/OpenAPI.
- Configurações de migração do banco de dados com Entity Framework Core.

---

## 📚 **Tecnologias Utilizadas**

- **Linguagem:** C#
- **Framework:** ASP.NET Core 8.0
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQL Server (pode ser substituído por outro, como PostgreSQL ou MySQL)
- **Documentação:** Swagger/OpenAPI
- **Gerenciamento de Dependências:** Injeção de Dependência nativa do ASP.NET Core

---

## 🚀 **Como Executar o Projeto**

### **1. Clone o Repositório**
```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
```

### **2. Configure o Banco de Dados**
No arquivo `appsettings.json`, atualize a string de conexão para o banco de dados:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=seu-servidor;Database=sua-base;User Id=seu-usuario;Password=sua-senha;"
}
```

### **3. Execute as Migrações**
Utilize o **Entity Framework Core** para criar o banco de dados:
```bash
dotnet ef database update
```

### **4. Execute o Projeto**
Inicie a aplicação com o comando:
```bash
dotnet run
```
A API estará disponível em [http://localhost:5000](http://localhost:5000).

---

## 🔄 **Estrutura do Projeto**

```plaintext
MeuProjeto
├── Controllers
│   └── AuthController.cs
├── Models
│   ├── Domain
│   │   ├── AuthRequest.cs
│   │   └── User.cs
│   └── DTOs
├── Repositories
│   ├── Interfaces
│   │   └── IUserRepository.cs
│   └── Implementations
│       └── UserRepository.cs
├── Services
│   ├── Interfaces
│   │   └── IUserService.cs
│   └── Implementations
│       └── UserService.cs
├── Data
│   └── AppDbContext.cs
├── DependencyInjection
│   └── DependencyInjectionConfig.cs
├── appsettings.json
└── Program.cs
```

- **Controllers:** Gerencia as requisições HTTP e interage com os services.
- **Models:** Contém as entidades de domínio e DTOs (Data Transfer Objects).
- **Repositories:** Realiza operações no banco de dados.
- **Services:** Centraliza as regras de negócio e lógica da aplicação.
- **Data:** Configurações do banco de dados.
- **DependencyInjection:** Configuração de DI para controllers, services e repositórios.

---

## 🔧 **Como Personalizar**

1. **Adicionar Novas Entidades:**
   - Crie a classe no diretório `Models/Domain`.
   - Crie os respectivos repositórios, services e controllers.

2. **Adicionar Endpoints:**
   - Crie um método no Controller correspondente.
   - Utilize os services para aplicar as regras de negócio.

3. **Documentação da API:**
   - Os endpoints são automaticamente documentados no Swagger.
   - Acesse [http://localhost:5000/swagger](http://localhost:5000/swagger) para visualizar.

---

## 🔒 **Melhorias Futuras**

- Implementação de autenticação e autorização (JWT).
- Integração com banco de dados NoSQL (MongoDB ou DynamoDB).
- Testes unitários com xUnit.
- Suporte a mensageria com RabbitMQ ou Kafka.

---

## 👤 **Autor**

Projeto desenvolvido por **Ricardo**.

Se gostou do projeto ou deseja colaborar, fique à vontade para abrir uma issue ou criar um pull request!

Conecte-se comigo no [LinkedIn](https://www.linkedin.com/in/ricardo-oliveira-05038123a) ou confira outros projetos no meu [GitHub](https://github.com/ricardodamaceno).

