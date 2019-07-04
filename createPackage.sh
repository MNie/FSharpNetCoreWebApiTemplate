#!/usr/bin/env bash
rm -r nuget
mkdir nuget
cd nuget
mkdir content
cd content
mkdir Controllers
cd ..
cp ../*.fsproj content/
cp ../*.fs content/
cp ../Controllers/*.fs content/Controllers/
cp ../*.json content/
cp -R ../.template.config content/
cp ../WebApiFSharp.Template.nuspec .
../../nuget.exe pack WebApiFSharp.Template.nuspec