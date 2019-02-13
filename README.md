# Inventory Manager

A simple .net core MVC application to keep a track of IT inventory and software subscriptions.



## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

```
git clone https://github.com/raymordy/InventoryManager.git
```

Visual Studio is required for this project and a package restore is necessary which should be done automatically on the second build attempt.



## Solution Structure

The project is split up into 3 separate projects:

###### Inventory.Data

Contains the dbcontext and all models used by Entity Framework

###### Inventory.Service

Contains all the business logic

###### Inventory.Web

Client access MVC project
