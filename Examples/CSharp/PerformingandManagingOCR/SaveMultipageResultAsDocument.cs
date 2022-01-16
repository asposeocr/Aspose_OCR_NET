using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Aspose.OCR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    public class SaveMultipageResultAsDocument
    {
        public static void Run()
        {
            // ExStart:1   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            List<RecognitionResult> result = api.RecognizeMultipleImages(new List<string> { dataDir + "sample.png", dataDir + "sample_bad.png" }, new RecognitionSettings { }).ToList();

            // Save the result in your preferred format
            AsposeOcr.SaveMultipageDocument(RunExamples.GetDataDir_OCR()+"sample.docx", SaveFormat.Docx, result);
            AsposeOcr.SaveMultipageDocument(RunExamples.GetDataDir_OCR() + "sample.txt", SaveFormat.Text, result);
            AsposeOcr.SaveMultipageDocument(RunExamples.GetDataDir_OCR() + "sample.pdf", SaveFormat.Pdf, result);
            AsposeOcr.SaveMultipageDocument(RunExamples.GetDataDir_OCR() + "sample.xlsx", SaveFormat.Xlsx, result);

            // ExEnd:1
            Console.WriteLine("SaveMultipageResultAsDocument executed successfully");
        }
    }
}
