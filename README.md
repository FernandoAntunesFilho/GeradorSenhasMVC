# Gerador de Senhas MVC

## Descrição
Este projeto é uma aplicação ASP.NET Core MVC para gerar senhas seguras com diferentes opções de personalização. O usuário pode escolher se deseja incluir letras maiúsculas, minúsculas, números e caracteres especiais, além de definir o tamanho da senha.

## Tecnologias Utilizadas
- **ASP.NET Core MVC**
- **C#**
- **Razor Views**
- **Bootstrap** (para estilização da interface)

## Estrutura do Projeto

### Controllers
- **HomeController**: Responsável por manipular as requisições HTTP e gerenciar a geração de senhas.

### Models
- **SenhaModel**: Representa as regras para a geração de senhas, incluindo tamanho e tipos de caracteres permitidos.

### Views
- **Index.cshtml**: Formulário para configuração das opções de senha e exibição do resultado gerado.

## Instalação

### Requisitos
- .NET SDK instalado ([Download aqui](https://dotnet.microsoft.com/en-us/download))

### Passos para Execução
1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/gerador-senhas-mvc.git
   ```
2. Navegue até a pasta do projeto:
   ```sh
   cd gerador-senhas-mvc
   ```
3. Restaure os pacotes do projeto:
   ```sh
   dotnet restore
   ```
4. Execute o projeto:
   ```sh
   dotnet run
   ```
5. Abra o navegador e acesse `https://localhost:5001` (ou a porta configurada).

## Uso
1. Marque as opções desejadas para a senha (letras maiúsculas, minúsculas, números e caracteres especiais).
2. Defina o tamanho da senha usando o controle deslizante.
3. Clique no botão "Gerar Senha" para obter a senha segura.

## Contribuição
Contribuições são bem-vindas! Para contribuir:
1. Faça um fork do repositório.
2. Crie um branch para sua feature (`git checkout -b feature-nova`).
3. Faça as alterações e comite (`git commit -m 'Adicionando nova feature'`).
4. Submeta um pull request.

## Licença
Este projeto está sob a licença MIT.

---

Projeto desenvolvido com ❤ por Fernando Antunes

