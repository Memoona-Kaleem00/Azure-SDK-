#!/bin/sh

set -e
base=`dirname {BASH_SOURCE[0]}`
rootdir="$( cd "$base" && pwd )"
  
dotnet restore
armdir=$rootdir/src/ResourceManagement
for folder in $armdir/*
do
  item=`basename $folder`
  if [ -d $armdir/$item ]
  then
    if [ -d $armdir/$item/$item.Tests ] && [ -f $armdir/$item/$item.Tests/project.json ]
    then
      cd $armdir/$item/$item.Tests
      dotnet restore
      dotnet build --framework netcoreapp1.0
# Skipping tests on CI since they run in live mode only      
#     dotnet test
      cd $armdir 
    fi
  fi
done
