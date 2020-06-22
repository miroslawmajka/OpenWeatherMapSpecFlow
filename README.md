# OpenWeatherMapSpecFlow

## Running the Tests

To run the tests please open the solution in Visual Studio 2019, compile it and open the **Test Explorer**.

You also need to create a `.env` files at the project level with the following structure:

```
OWA_API_ID=YOUR_OWA_ID
```

You can use the existing `template.env` file but you must change the `YOUR_OWA_ID` to your personal OpenWeather API key. 

Click **Run All Tests**. In case of running of the first time you will need to setup your SpecFlow account (see https://specflow.org/getting-started/ for details).

![Test Explorer](docs/test-explorer.png)

In case of problems you might need to set the `MSBUILDSINGLELOADCONTEXT` environment variable in your system to **1**:
```
# When using Git Bash or any Linux terminal
export MSBUILDSINGLELOADCONTEXT=1
```

You can find the reults for the specific tests from the **Tests Explorer** when you click on "Open additional output for this result":
![Tokyo Test Result](docs/tokyo-test-result.png)

The information we're looking for will be displayed at the bottom of the test run output:
```
 The hottest day and time for Tokyo is Friday (05/06/2020 06:00 UTC) with temperature of 28.4 celsius.
```

## What is good?

* Good separation of responsibilities (feature files, steps, handlers, data models)
* Reusable steps for other test scenarios

## What could be done to make this better?

* Getting the tests running in an Azure DevOps Pipeline with results posted in Slack/Teams/etc
* Unit testing the data processing logic (internal test project)
* Scenario context injection so that steps from different step definition classes can use it
* Display result time in the console for specific Time Zones rather than UTC
