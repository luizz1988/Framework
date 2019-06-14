param($installPath, $toollsPath, $package, $project)

$file = $project.ProjectItems.Item("log4net.config")

$copyToOutput = $file.Properties.Item("CopyToOutputDirectory")
$copyToOutput.Value = 2

