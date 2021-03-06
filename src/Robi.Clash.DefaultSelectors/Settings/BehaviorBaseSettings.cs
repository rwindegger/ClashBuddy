﻿namespace Robi.Clash.DefaultSelectors.Settings
{
    using Common;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    internal class BehaviorBaseSettings : JsonSettings
    {
        internal BehaviorBaseSettings() : base(SettingsPath, "Settings", "BehaviorBaseSettings.json")
        {

        }

	    public string DatabaseFullpath => System.IO.Path.GetFullPath(DatabaseFolder);

	    [DisplayName("Database Folder")]
	    [Description("The folder containing the Nano Databases.")]
	    [DefaultValue("Nano")]
	    public string DatabaseFolder { get; set; }

	    [DisplayName("Logfile Name")]
	    [Description("File name for the logfile, might be removed in the future.")]
	    [DefaultValue("nano.log")]
	    public string LogFileName { get; set; }

	    [DisplayName("Random Deployment Faktor")]
	    [Description("Random deployment factor range to let the bot look more human like")]
	    [Range(0, 10000)]
	    [DefaultValue(200)]
	    public int RandomDeploymentValue { get; set; }
	}
}