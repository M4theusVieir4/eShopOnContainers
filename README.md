# E-Shop Application

Esta aplicação foi desenvolvida seguindo as aulas do **José Carlos Macoratti**, com o objetivo de criar uma aplicação de **E-Shop** (loja online) utilizando **microsserviços**. O projeto envolve o uso de **APIs REST** construídas com **.NET 8**, integradas a bancos de dados como **Redis**, **PostgreSQL** e **MongoDB**. Além disso, a comunicação entre microsserviços é feita utilizando o protocolo **gRPC**.

## Tecnologias Utilizadas

- **.NET 8**: Framework principal para construção das APIs REST.
- **Redis**: Banco de dados em memória, utilizado para cache e sessões.
- **PostgreSQL**: Banco de dados relacional utilizado para armazenar dados transacionais.
- **MongoDB**: Banco de dados NoSQL utilizado para armazenar dados não estruturados.
- **gRPC**: Protocolo de comunicação entre microsserviços.
- **Docker Compose**: Utilizado para orquestrar os contêineres dos microsserviços e bancos de dados, facilitando o ambiente de desenvolvimento.

## Funcionalidades

- **Microsserviços Independentes**: Cada microsserviço é responsável por uma parte específica da aplicação, como gerenciamento de produtos, clientes, pedidos, etc.
- **APIs REST**: Todas as interações com o frontend são feitas através de APIs REST, oferecendo flexibilidade e escalabilidade.
- **Comunicação entre Microsserviços**: Microsserviços se comunicam entre si através de chamadas **gRPC**, garantindo comunicação eficiente e de baixo custo.
- **Armazenamento de Dados**: O projeto faz uso de diferentes bancos de dados para otimizar o desempenho e a flexibilidade de armazenamento.
- **Orquestração com Docker Compose**: A aplicação usa o **Docker Compose** para configurar e orquestrar os contêineres dos microsserviços e dos bancos de dados, tornando o ambiente de desenvolvimento simples de configurar e manter.

## Como Rodar a Aplicação

### Pré-requisitos

- .NET 8 SDK
- Docker e Docker Compose
