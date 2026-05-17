#!/usr/bin/env bash
dotnet new console -o 2-new_project
sed -i 's/Hello, World!/Hello World!/' 2-new_project/Program.cs
dotnet run --project 2-new_project