## CF Workshop Demo

### Introduction

This is a demo app for CF workshops, written in ASP.NET Core.
It is intended to demonstrate some of the day-in-the-life features for developers in CF

 * Push / bind / scale
 * Accessing CF environment variables
 * Accessing CF service variables
 * Scaling, dynamic routing and load balancing
 * Health management and application restart
 * Binding services

### Building, Packaging, and Deploying

#### To get the source code and build the project


    git clone https://github.com/bjimerson-pivotal/CfWorkshopDotNetCore

    dotnet restore

    dotnet build


#### To run the application

You will need a local MySQL server installed; appsettings.json has the credentials and database name.

Run the application locally as an ASP.NET Core app for testing:

    cd CfWorkshopDotNetCore

    dotnet run

Running in CF is as usual too:

    cf create-service p-service-registry standard service-registry
    cf create-service p-mysql 100mb cf-workshop-db
    cf push cf-workshop-dotnet-core
