
using System;
using Microsoft.ML;
using Microsoft.ML.Data;

MLContext mlContext = new MLContext();
DataViewSchema modelSchema;
string modelPath = Path.Combine(Environment.CurrentDirectory, "MLModel", "model.zip");
var mlModel = mlContext.Model.Load("C:\\Users\\AAC\\source\\repos\\UseCase\\UseCase\\MLModel\\model.zip", out modelSchema);

var predictionEngine = mlContext.Model.CreatePredictionEngine<Model_Input, Model_Output>(mlModel);

var input = new Model_Input
{
    Temperature = 45,
    Humidity = 30,
    Proximity_to_Industrial_Areas = 1,
    Population_Density = 400,
    Air_Quality = "Hazardous"
};

var result = predictionEngine.Predict(input);
Console.WriteLine($"Predicted Land Usage: {result.land_usage}");

public class Model_Input
{
    [LoadColumn(0)] public float Temperature { get; set; }
    [LoadColumn(1)] public float Humidity { get; set; }
    [LoadColumn(2)] public float Proximity_to_Industrial_Areas { get; set; }
    [LoadColumn(3)] public float Population_Density { get; set; }
    [LoadColumn(4)] public string? Air_Quality { get; set; }

    [LoadColumn(5)] public string? land_usage { get; set; }
}

public class Model_Output
{
    [ColumnName("PredictedLabel")] public string? land_usage { get; set; }
}
