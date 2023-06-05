
# Containerized Microservices Application

This repository contains **Shopping Cart** and **Order** microservices for an e-commerce project.
The services communicate with **RabbitMQ - Event Driven Communication** and use **NoSQL (Redis)** and **Relational (Sql Server)** databases.

## What's Included in This Repository

#### Cart microservice
* **DDD, CQRS, and Clean Architecture** Implementation
* **CQRS with using MediatR, FluentValidation and AutoMapper packages**
* REST APIs, CRUD operations
* **Redis database** connection and containerization
* Publish CartCheckout Queue with using **MassTransit and RabbitMQ**
  
#### Ordering Microservice
* **DDD, CQRS, and Clean Architecture** Implementation
* **CQRS with using MediatR, FluentValidation and AutoMapper packages**
* Consuming **RabbitMQ** CartCheckout event queue with using **MassTransit-RabbitMQ** Configuration
* **SqlServer database** connection and containerization
* Using **Entity Framework Core ORM** and auto migrate to SqlServer when application startup
	
#### Logging
* Centralized Distributed Logging with **Elasticsearch, Kibana and SeriLog** for Microservices

#### Docker Compose establishment with all microservices on docker;
* Containerization of microservices
* Containerization of databases
* Override Environment variables

### Installing
Start the Docker Desktop and follow these steps 
1. Clone the repository
2. At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```
3. **Launch microservices** with the urls below:

* **Cart API -> http://localhost:8002/swagger/index.html**
* **Ordering API -> http://localhost:8004/swagger/index.html**
* **Rabbit Management Dashboard -> http://localhost:15672**   (username: guest, password: guest)
* **Elasticsearch -> http://localhost:9200**
* **Kibana -> http://localhost:5601**


