# Using Mass Transit and RabbitMQ in window service base on dotnet framework 4.8.1
This is a minimal Example for a Windows Service hosting a MassTransit Consumer and RabbitMQ in .NET Framework 4.8.1

It uses some extension Methods in XMassTransit.cs to make it easier 
to register all Consumers in a given List of Assemblies. 

Prerequisite:
* install RabbitMq  
* configure the RabbitMQ Queue and virtual Host/Path in appSettings.json [as explained here](https://masstransit-project.com/usage/transports/rabbitmq.html#configuration)

