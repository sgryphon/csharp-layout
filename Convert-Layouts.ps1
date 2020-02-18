Write-Host 'Converting layouts with regions to without'

# Style Cop Layout
$regionFile = 'csharp-layout-stylecop+regions.xml'
$plainFile = 'csharp-layout-stylecop.xml'

$regionPath = Join-Path $PSScriptRoot $regionFile;
$layoutXml = [xml](Get-Content -Path $regionPath);

foreach ($typePattern in $layoutXml.Patterns.TypePattern) {
    foreach ($region in $typePattern.Region) {
        foreach ($entry in $region.Entry) {
            $typePattern.AppendChild($entry);
        }
        $typePattern.RemoveChild($region);
    }
}

$plainPath = Join-Path $PSScriptRoot $plainFile;
$layoutXml.Save($plainPath);

# Documentation Layout
$regionFile = 'csharp-layout-documentation+regions.xml'
$plainFile = 'csharp-layout-documentation.xml'

$regionPath = Join-Path $PSScriptRoot $regionFile;
$layoutXml = [xml](Get-Content -Path $regionPath);

foreach ($typePattern in $layoutXml.Patterns.TypePattern) {
    foreach ($region in $typePattern.Region) {
        foreach ($entry in $region.Entry) {
            $typePattern.AppendChild($entry);
        }
        $typePattern.RemoveChild($region);
    }
}

$plainPath = Join-Path $PSScriptRoot $plainFile;
$layoutXml.Save($plainPath);
