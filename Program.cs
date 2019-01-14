using System;
using System.Speech.Synthesis;

namespace kebabApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of main variables
            string url;
            string host;

            //Prompting the user to input an URL for parsing
            Console.WriteLine("Input the URL to see its hostname and press [Enter] button:");
            url = Console.ReadLine();

            try
            {
                //Code which parses a user-specified URL and outputs the hostname
                Uri myUri = new Uri(url);
                host = myUri.Host;
                Console.WriteLine($"The hostname of the provided URL is: {host}. ");
            }
            catch
            {
                //if hostname can not be parsed - the programm outputs "kebab" word and say it
                Console.WriteLine("kebab");

                // Initialize a new instance of the SpeechSynthesizer  
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {

                    // Configure the audio output.  
                    synth.SetOutputToDefaultAudioDevice();

                    // Speak a string synchronously
                    synth.Speak("kebab");
                }
            }
            finally
            {
                //Screen closing dialog
                Console.Write("Press any key to close the screen...");
                Console.ReadKey();
            }

        }
    }
}
