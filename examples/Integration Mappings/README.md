# Integration Mappings (Slack)

This script helps manage the mappings between Slack and Box if using Box as the content store for Slack. It creates a list of current Slack channel and Box
folder mappings and can update mappings based on input csv.

## Setup Pre-Requisites
1. Clone this github repo or download files from the `/examples` directory
   ```bash
   git clone https://github.com/box/boxcli.git
   ```
2. Install PowerShell or .Net core.
   > If you encounter issues make sure you install both dotnet core and PowerShell
	1. For MacOS & Linux, Install the latest version of [PowerShell](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.2).
	2. For Windows, Install the latest version of [dotnet core](https://dotnet.microsoft.com/download).

3. Test PowerShell by running the `pwsh` command in your terminal.
    ```bash
    pwsh
    ```

    ```
    mikechen@mbp Integration Mappings % pwsh
    PowerShell 7.2.1
    Copyright (c) Microsoft Corporation.
	
    https://aka.ms/powershell
    Type 'help' to get help.
	
    PS /Users/mikechen>
    ```
4. Configure and install the Box CLI using the OAuth [CLI Setup Quick Start][oauth-guide]. Make sure the user you use is an admin or co-admin.
5. Configure and [install Box for Slack][install-slack] in the relevant Slack workspaces and orgs
6. Box as the [content layer for Slack][content-layer] in enabled

## Run the script

Change the directory to the folder containing the script. In this example, it is the `Integration Mappings` folder.
```pwsh
rvb@lab:~/box-cli/examples/Integration Mappings$ pwsh
PowerShell 7.2.4
Copyright (c) Microsoft Corporation.

https://aka.ms/powershell
Type 'help' to get help.

PS /home/rvb/box-cli/examples/Integration Mappings>
```

Run the script with EXTRACT to extract current mappings:
```pwsh
./integration-mappings.ps1 -action EXTRACT
```

or

Run the script with APPLY to extract current mappings:
```pwsh
./integration-mappings.ps1 -action APPLY
```

If you don't specify parameters, the script will prompt you to any.

When the script run is completed, you will see the following
output or a similar one.

```
Starting Process
Applying new mappings
Output [...]
All bulk input entries processed successfully.
```

## Logging
Logs are stored in a `logs` folder located in the main folder. You have access to these log files:

* `Integration-mappings_all.txt` that contains all log entries.
* `Integration-mappings_errors.txt` that contains only errors.

## Disclaimer
This project is a collection of open source examples and should not be treated as an officially supported product. Use at your own risk and as a source of example how to use Box CLI.

[oauth-guide]: https://developer.box.com/guides/cli/quick-start/
[install-slack]: https://support.box.com/hc/en-us/articles/360044195313-Installing-and-Using-the-Box-for-Slack-Integration
[content-layer]: https://support.box.com/hc/en-us/articles/4415585987859-Box-as-the-Content-Layer-for-Slack
