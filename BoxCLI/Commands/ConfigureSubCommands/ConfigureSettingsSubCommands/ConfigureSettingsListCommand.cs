using BoxCLI.BoxHome;
using BoxCLI.BoxHome.BoxHomeFiles;
using Microsoft.Extensions.CommandLineUtils;

namespace BoxCLI.Commands.ConfigureSubCommands.ConfigureSettingsSubCommands
{
    public class ConfigureSettingsListCommand : ConfigureSubCommandBase
    {
        public ConfigureSettingsListCommand(IBoxHome boxHome) : base(boxHome)
        {
        }

        public override void Configure(CommandLineApplication command)
        {
            command.Description = "List all Box settings.";
            command.OnExecute(() =>
            {
                return this.Execute();
            });
            base.Configure(command);
        }

        protected override int Execute()
        {
            this.RunSettingsList();
            return base.Execute();
        }

        private void RunSettingsList()
        {
            var settings = base._settings.GetAllSettings();
            System.Console.WriteLine("Current settings:");
            System.Console.WriteLine($"Path to store Box Reports: {settings.BoxReportsFolderPath}");
            System.Console.WriteLine($"Box Reports folder name: {settings.BoxReportsFolderName}");
            System.Console.WriteLine($"Default file format for Box Reports: {settings.BoxReportsFileFormat}");
        }

    }
}