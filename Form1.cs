using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsMLEnterprise
{
    public partial class Form1 : Form
    {
        private readonly MLContext mlContext;
        private IEstimator<ITransformer> dataPrepPipeline;
        private ITransformer trainedModel;

        public Form1()
        {
            InitializeComponent();

            // Create MLContext
            mlContext = new MLContext();

            // Initialize data prep pipeline
            dataPrepPipeline = BuildDataPrepPipeline();

            string modelFileName = "MLModel1.zip"; 
            string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, modelFileName);

            // Load trained model with full pipeline
            if (File.Exists(modelPath))
            {
                // Load trained model with full pipeline
                trainedModel = mlContext.Model.Load(modelPath, out var modelSchema);
                
            }
            else
            {
                MessageBox.Show ("Model file not found at:" + modelPath);
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Show a message box with the current directory
            MessageBox.Show("Current Directory: " + Directory.GetCurrentDirectory());

            // Load sample data
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                Col0 = txtReview.Text,
            };

            // Load model and predict output
            var predictionResult = MLModel1.Predict(sampleData);

            txtGuess.Text = predictionResult.PredictedLabel.ToString();
            txtConfidence.Text = (predictionResult.Score[0] * 100).ToString();
        }


        private IEstimator<ITransformer> BuildDataPrepPipeline()
        {
            return mlContext.Transforms.Conversion.MapValueToKey("Label", "Sentiment")
                .Append(mlContext.Transforms.Text.FeaturizeText("Features", "Comment"))
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("Label"));
        }

        private void btnRetrain_Click(object sender, EventArgs e)
        {
            // Create new data
            Feedback feedbackNewData = new Feedback
            {
                Comment = txtReview.Text
            };

            // Load new data into an IDataView
            IDataView newData = mlContext.Data.LoadFromEnumerable(new[] { feedbackNewData });

            // Apply data prep transforms to new data
            IDataView transformedNewData = dataPrepPipeline.Fit(newData).Transform(newData);

            // Use binary classification trainer for retraining
            var retrainedModel = mlContext.BinaryClassification.Trainers.SdcaLogisticRegression().Fit(transformedNewData);

            // Get predictions from the original model
            //var originalPredictions = trainedModel.Transform(transformedNewData);

            // Get predictions from the retrained model
            var retrainedPredictions = retrainedModel.Transform(transformedNewData);

            // Extract weights from the original model
            //var originalWeights = originalPredictions.GetColumn<float>("Score").ToArray();

            // Extract weights from the retrained model
            var retrainedWeights = retrainedPredictions.GetColumn<float>("Score").ToArray();

            // Display original weight
            //txtOriginalWeight.Text = originalWeights[0].ToString();

            // Display retrained weight
            txtReTrainedWeight.Text = retrainedWeights[0].ToString();

            // Calculate and display weight differences
            //var weightDiff = originalWeights[0] - retrainedWeights[0];
            //txtWeightDiffs.Text = weightDiff.ToString();
        }


        public class Feedback
        {
            [LoadColumn(0)]
            public string Comment { get; set; }

            [LoadColumn(1)]
            [ColumnName("Sentiment")]
            public bool Sentiment { get; set; }
        }
    }
}