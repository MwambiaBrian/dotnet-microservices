# An Introduction to Microservices using .NET

Welcome to the repository for the "Microservices using .NET" project! This platform management backend application allows you to add various tech platforms, such as Docker and SQL Server, along with their associated commands, to a database. It's a demonstration of microservices architecture with a focus on .NET technologies.

## Repository

- **Repository URL**: [dotnet-microservices](https://github.com/MwambiaBrian/dotnet-microservices)

## Project Overview

The goal of this project is to provide a real-world example of microservices architecture implemented in .NET. Below are the key components and features of this project:

- Implementation of two .NET Microservices using the REST API pattern
- Utilization of dedicated persistence layers for both services
- Deployment of the services to a Kubernetes cluster for scalability and container orchestration
- Implementation of the API Gateway pattern to efficiently route incoming requests to the respective services
- Establishment of synchronous messaging between services using both HTTP and gRPC for improved performance
- Implementation of asynchronous messaging between services using an Event Bus powered by RabbitMQ, providing flexibility and robust event-driven communication

## Screenshots

### POST a new Platform

![POST a new Platform](image.png)

This screenshot illustrates the process of adding a new tech platform to the database using a POST request.

### GET all platforms

![GET all platforms](image-1.png)

This screenshot shows the response when requesting a list of all available platforms via a GET request.

## Docker Image Repository

To make deployment and scaling easier, Docker images for the services are available on Docker Hub. You can pull these images from the Docker Hub repository hosted at `nelsb`. Here's how you can pull the images:

```shell
docker pull nelsb/platformservice
docker pull nelsb/commandservice
```
