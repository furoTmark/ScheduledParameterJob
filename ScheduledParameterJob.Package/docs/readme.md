# Supplying EPiServer scheduled jobs with parameters through Admin Mode
http://blog.mathiaskunto.com/2012/02/13/supplying-episerver-scheduled-jobs-with-parameters-through-admin-mode

Version 1.2.0.0

******************************************************************************************

## Note:

This is an updated version for the ScheduledParameterJob by Mathias Kunto that works with Optimizely version 11.x on .NET Framework.

## Installation:

* Include the ScheduledParameterJob.csproj in your Visual Studio solution.
* Reference it from your web project.
* Make sure all EPiServer references are OK in the ScheduledParameterJob project.
* Add the adapter configuration below to your browser file, or drop the sample SampleAdapterMappings.browser file in your wwwroot App_Browsers directory.

<adapter controlType="EPiServer.UI.Admin.DatabaseJob" adapterType="ScheduledParameterJob.DatabaseJobAdapter" />

## Usage:

* See blog post for usage. https://blog.mathiaskunto.com/2012/02/13/supplying-episerver-scheduled-jobs-with-parameters-through-admin-mode/
* See ExampleJob directory for example job; not included in droppable binary version, nor in the NuGet package.
  - Get it from the blog post or GitHub (https://github.com/furoTmark/ScheduledParameterJob/tree/main/ScheduledParameterJob/ExampleJob)

******************************************************************************************

Release notes:

## Version 1.2.0.0

- Fixed dependencies and references
- Added minor fixes

## Version 1.1.0.0

- Moved core files to separate project.
- Reset button image reset.png is now base64 encoded inside the CSS file JobParameters.css.
- JobParameters.css is now an embedded resource.
- Example scheduled job with parameters is moved to the ExampleJob directory, not included in the droppable binary version nor the NuGet package.


## Version 1.0.0.0

- Initial release.

******************************************************************************************