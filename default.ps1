properties {
    $buildDir = ".\build"
    $outputDir = "$buildDir\lib\$framework"
    $sourceDir = ".\Source\Amazon.WebServices.MechanicalTurk"
    $resourceDir = "$sourceDir\Resources"
    $resourceResponseFile = "$buildDir\resources.res"
}

task default -depends Compile, Clean

task Compile -depends Clean { 
    $sources = gci $sourceDir -r -fi *.cs | select -expand FullName
    gci $resourceDir |% { "/resource:$resourceDir\$_,Amazon.WebServices.MechanicalTurk.Resources.$_" } > $resourceResponseFile
    mkdir $outputDir
    $out = $outputDir + "\Amazon.WebServices.MechanicalTurk.dll"
    csc /target:library /out:$out $sources "@$resourceResponseFile"
    ri $resourceResponseFile
}

task Clean { 
    if (test-path $outputDir) { ri -r -fo $outputDir }
}
