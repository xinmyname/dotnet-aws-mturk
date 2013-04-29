properties {
    $buildDir = ".\build"
    $outputDir = $buildDir + "\lib\" + $framework
}

task default -depends Compile, Clean

task Compile -depends Clean { 
    $sources = gci ".\CWS.Utility.SharePoint" -r -fi *.cs |% { $_.FullName }
    mkdir $outputDir
    $out = $outputDir + "\CWS.Utility.SharePoint.dll"
    csc /target:library /out:$out $sources 
}

task Clean { 
    if (test-path $outputDir) { ri -r -fo $outputDir }
}