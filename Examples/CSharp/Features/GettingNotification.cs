
using System.IO;
using Aspose.OCR;
using System;

namespace Aspose.OCR.Examples.CSharp.Features
{
    public class GettingNotification
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExample.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //Initialize an instance of OcrEngine
            OcrEngine ocrEngine = new OcrEngine();

            //Set the Image property by loading the image from file path location or an instance of MemoryStream 
            ocrEngine.Image = ImageStream.FromFile(dataDir+ "Sampleocr.bmp");

            //Get an instance of INotifier
            INotifier processorWord = NotifierFactory.WordNotifier();

            //Write a delegate to handle the Elapsed event
            processorWord.Elapsed += delegate
            {
                //Display the recognized text on screen
                Console.WriteLine(processorWord.Text);
            };

            // Add the word processor to the OcrEngine
            ocrEngine.AddNotifier(processorWord);

            //Process the image
            ocrEngine.Process();
            
            
        }
    }
}