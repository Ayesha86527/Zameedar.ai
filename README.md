# Zameendar.ai – Land Usage Classification (ML.NET)

A machine learning console application built with ML.NET that classifies and recommends suitable land usage types—such as **agriculture, housing, commercial or industrial**—based on environmental and demographic parameters.

## Features
- **Multi-class classification** using a custom dataset
- Predicts land type based on:
  - Temperature
  - Humidity
  - Air Quality
  - Proximity to Industrial Zones
  - Population
- Achieved **77% macro-accuracy**
- Built using **ML.NET**, trained and deployed in a lightweight console app

## Files Included
- `Program.cs` — Main console application to load and test the trained model
- `UseCase.csproj` — Project file for building and running the app
- `model.zip` — Trained ML.NET model (you must place this file locally)
- `README.md` — This file

## How to Run
1. Clone or download the repository.
2. Ensure [.NET SDK](https://dotnet.microsoft.com/en-us/download) is installed.
3. Place `model.zip` in the project root directory or modify the path in `Program.cs` accordingly.
4. Open terminal in the project folder and run:
   ```bash
   dotnet run

## Notes
This is a console-based demonstration for showcasing ML.NET capabilities.

The dataset used was custom-built and feature-engineered externally.

Predictions may vary depending on data input; focus is on demonstrating model training and integration.
