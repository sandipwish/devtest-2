# Dev Test 2

## Scenario
You have taken up maintenance on an application created by another developer.  
This application has a function that generates a CSV report based on customer order from a SQL database.  
The users are complaining that the CSV report takes 10 seconds or more to generate.  
They would like report to generate in 2 seconds or less.

## Your Task
In your pull request
* Describe in detail the reason that the CSV report is generating slowly.
* Optimize the code to generate the report in under 2 seconds.

## Constraints
* Do not change the database.
* Do not change or remove the NetworkLatencySimulationDbInterceptor.
* Do not use any additional libraries (no additional nuget packages).

## FYI
The first time you start the app it may take a few seconds to generate the database.
