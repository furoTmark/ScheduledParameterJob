using System;
using System.Globalization;
using EPiServer;
using EPiServer.Core;
using EPiServer.Data.Dynamic;
using EPiServer.DataAbstraction;
using EPiServer.PlugIn;
using ScheduledParameterJob.Extensions;
using ScheduledParameterJob.Parameters;

namespace ScheduledParameterJob.ExampleJob
{
	[ScheduledPlugInWithParameters(
		DisplayName = "Sample parameter job",
		Description = "Sample job with parameters",
		DefinitionsClass = "ScheduledParameterJob.ExampleJob.DefinitionSample",
		DefinitionsAssembly = "ScheduledParameterJob"
	)]
	public class SampleParameterJob : ScheduledJob
	{
		public static string Execute()
		{
			var descriptor = PlugInDescriptor.Load(typeof(SampleParameterJob).FullName, typeof(SampleParameterJob).Assembly.GetName().Name);
			var store = typeof(ScheduledJobParameters).GetStore();
			var parameters = store.LoadPersistedValuesFor(descriptor.ID.ToString(CultureInfo.InvariantCulture));

			var cbChecked = parameters.ContainsKey("CheckBoxSample") && (bool)parameters["CheckBoxSample"] ? "Aye!" : "Nay..";
			var tbText = parameters.TryGetValue("TextBoxSample", out var tbTextValue) ? tbTextValue as string : string.Empty;
			var sampleReference = parameters.TryGetValue("InputPageReferenceSample", out var sampleReferenceValue) ? (PageReference)sampleReferenceValue : PageReference.EmptyReference;
			var samplePageName = sampleReference != null && sampleReference != PageReference.EmptyReference ? DataFactory.Instance.GetPage(sampleReference).PageName : string.Empty;
			var cDateTime = parameters.TryGetValue("CalendarSample", out var cDateTimeValue) ? (DateTime?)cDateTimeValue : null;
			var ddlSelectedValue = parameters.TryGetValue("DropDownListSample", out var ddlValue) ? ddlValue as string : string.Empty;

			var result = string.Empty;
			result += $"CheckBoxSample checked: <b>{cbChecked}</b><br />";
			result += $"TextBoxSample text: <b>{tbText}</b><br />";
			result += $"InputPageReferenceSample page name: <b>{samplePageName}</b> (PageId: <b>{sampleReference}</b>)<br />";
			result += $"CalendarSample date: <b>{cDateTime.ToString()}</b><br />";
			result += $"DropDownListSample selected value: <b>{ddlSelectedValue}</b><br />";
			return result;
		}
	}
}
