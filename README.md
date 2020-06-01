# OpenWeatherMapSpecFlow

## Running the Tests

To run the tests please open the solution in Visual Studio 2019, compile it and open the **Test Explorer**.

Click **Run All Tests**. In case of running of the first time you will need to setup your SpecFlow account (see https://specflow.org/getting-started/ for details).

In case of problems you might need to set this environment variable in your system to **1**:
```
export MSBUILDSINGLELOADCONTEXT=1
```

## What is good?

* Good separation of responsibilities (feature files, steps, handlers, data models)
* Reusable steps for other scenarios

## What could be done to make this better?

* Getting the tests running in an Azure DevOps Pipeline with results posted in Slack/Teams/etc
* Unit testing the data processing logic (internal test project)
* Scenario context injection so that steps from different step definition classes can use it

## Most interesting trends in test automation

* Using serverless platforms (e.g. Microsoft Azure DevOps, CircleCI with custom Docker images) to run automated suites.
* Building automated deployment/testing pipelines with repeatable environments
* Getting development, QA and project management teams closer by use of BDD and visibility of test results through automated tools and chat systems such as Slack
* Testing REST APIs using Postman/Newman

## Mirek described in JSON

```
{
    name: "Miroslaw Majka",
    nickname: "Mirek",
    other: "TODO"
}
```