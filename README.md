# BullWorth Academy

### ASP.NET 6 MVC web application

---

O projeto é uma aplicação web com operação CRUD para gerenciar estudantes de uma escola fictícia.

Para o desenvolvimento foi utilzado **Bootstrap** para auxiliar no desenvolvimento das interfaces do usuário, **ASP.NET 6** com arquitetura **MVC** e **SQL SERVER** para o back-end.

![image](https://user-images.githubusercontent.com/73973922/178296405-335dbf48-83fa-4671-aaef-819c86ace9ef.png)

### Como funciona

---

Quando a aplicação é executada ela analisa se já existe um banco de dados e/ou migrações pendentes, caso não exista ela inicia uma nova base de dados e popula com alguns registros e também aplica as migrações caso haja alguma.

O sistema tem sistema de paginação, suporte para as operações CRUD e aplicação de filtros baseado no *Grade Level* do estudante, os filtros aparecem conforme os *Grade Levels* existente no banco de dados.

Também é possível pesquisar os registros pela barra de busca.

O app utiliza o **localhost** na porta **5000** para funcionar

**SQLServer express** com **localdb** é utlizado para armazenar os dados